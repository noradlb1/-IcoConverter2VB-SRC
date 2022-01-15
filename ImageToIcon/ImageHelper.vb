Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text

Namespace wmgCMS
	''' <summary>
	''' Provides helper methods for imaging
	''' </summary>
	Public NotInheritable Class ImageHelper

		Private Sub New()
		End Sub

		Private Shared pngiconheader() As Byte = { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 24, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
		Public Shared Function Convert(ByVal img As Image, ByVal s As Size) As Icon
			Using bmp As New Bitmap(img, s)
				Dim png() As Byte
				Using fs As New System.IO.MemoryStream()
					bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
					fs.Position = 0
					png = fs.ToArray()
				End Using

				Using fs As New System.IO.MemoryStream()
					'if (s.Width >= 256 || s.Height >= 256) { s.Width = 256; s.Height = 256; }
					pngiconheader(6) = CByte(s.Width)
					pngiconheader(7) = CByte(s.Height)
					pngiconheader(14) = CByte(png.Length And 255)
					pngiconheader(15) = CByte(png.Length \ 256)
					pngiconheader(18) = CByte(pngiconheader.Length)

					fs.Write(pngiconheader, 0, pngiconheader.Length)
					fs.Write(png, 0, png.Length)
					fs.Position = 0
					Return New Icon(fs)
				End Using
			End Using
		End Function
	End Class
End Namespace
