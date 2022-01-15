Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace wmgCMS
	Partial Public Class Form1
		Inherits Form

		Private imageToConvertPath() As String

		Public Sub New()
			InitializeComponent()
			Me.AllowDrop = True
		End Sub

		Public Sub convert()
			If imageToConvertPath IsNot Nothing Then
				Dim thumb As Bitmap = CType(Image.FromFile(imageToConvertPath(0)), Bitmap)
				Dim w As Integer
				Dim h As Integer
				If tbHeight.Text <> "" AndAlso tbWidth.Text <> "" Then
					w = Int32.Parse(tbWidth.Text)
					h = Int32.Parse(tbHeight.Text)
					thumb = ResizeImage(thumb, w, h)

				Else
					w = thumb.Width
					h = thumb.Height
				End If
				thumb.MakeTransparent()

				Dim g As Graphics = Graphics.FromImage(thumb) ' allow drawing to it
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic ' make the image shrink nicely by using HighQualityBicubic mode
				g.DrawImage(thumb, 0, 0, w, h)
				g.Flush()

				'Generate save file dialog
				Dim sfd As New SaveFileDialog()
				'Set dialog filter
				sfd.Filter = "Icon (*.ico)|*.ico|All files (*.*)|*.*"
				If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Dim IconStream As Stream = System.IO.File.Create(sfd.FileName)

					'DEPRECATED DUE TO LOW QUALITY ICON
'                    Icon icon = Icon.FromHandle(thumb.GetHicon());
'                    icon.Save(IconStream);
'                    IconStream.Close();

'INSTANT VB NOTE: The variable icon was renamed since Visual Basic does not handle local variables named the same as class members well:
					Dim icon_Renamed As Icon = ImageHelper.Convert(thumb, New Size(w, h))
					Me.Icon = icon_Renamed
					Me.Icon.Save(IconStream)
					IconStream.Close()
				End If
			Else
				MessageBox.Show("Please select an image by dragging it into the window or by clicking 'Browse...'")
			End If
		End Sub

		'Handles cursor effects when dragging over data
		Private Sub panel5_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles panel5.DragEnter
			If e.Data.GetDataPresent(DataFormats.FileDrop) Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		'Handles what to do when data is dropped. Bitmap var is assigned the image.
		Private Sub panel5_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles panel5.DragDrop
			imageToConvertPath = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
			'MessageBox.Show(imageToConvertPath[0]);
			pictureBox1.BackgroundImage = Image.FromFile(imageToConvertPath(0))
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			convert()
		End Sub

		''' <summary>
		''' Resize the image to the specified width and height.
		''' </summary>
		''' <param name="image">The image to resize.</param>
		''' <param name="width">The width to resize to.</param>
		''' <param name="height">The height to resize to.</param>
		''' <returns>The resized image.</returns>
		Public Shared Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Bitmap
			Dim destRect = New Rectangle(0, 0, width, height)
			Dim destImage = New Bitmap(width, height)

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution)

			Using graphics = System.Drawing.Graphics.FromImage(destImage)
				graphics.CompositingMode = CompositingMode.SourceCopy
				graphics.CompositingQuality = CompositingQuality.HighQuality
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
				graphics.SmoothingMode = SmoothingMode.HighQuality
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

				Using wrapMode = New ImageAttributes()
					wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY)
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode)
				End Using
			End Using

			Return destImage
		End Function

		Private Sub tbWidth_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbWidth.Enter
			panel3.BackColor = ColorTranslator.FromHtml("#3E7EF8")
			panel4.BackColor = Color.DarkGray
		End Sub

		Private Sub tbHeight_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbHeight.Enter
			panel3.BackColor = Color.DarkGray
			panel4.BackColor = ColorTranslator.FromHtml("#3E7EF8")
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim ofd As New OpenFileDialog()
			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName)
				Catch i As Exception
					MessageBox.Show("Invalid image file. Please select a valid file. Exception: " & i.Message)
				End Try


				imageToConvertPath = New String(0){} 'Must instantiate array to prevent null reference exception
				imageToConvertPath(0) = ofd.FileName
			End If
		End Sub

		Private Sub panel5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel5.Click
			'Allow user to click on upload area to select file
			button1_Click(Me, New EventArgs())
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
