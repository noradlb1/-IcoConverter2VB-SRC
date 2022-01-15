Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Drawing

Namespace wmgCMS
	Friend Class WaterMarkTextBox
		Inherits RichTextBox

		Private oldFont As Font = Nothing

		Private waterMarkTextEnabled As Boolean = False
		#region "Attributes"
		Private _waterMarkColor As Color = Color.Gray
		Public Property WaterMarkColor() As Color
			Get
				Return _waterMarkColor
			End Get
			Set(ByVal value As Color)
				_waterMarkColor = value
				Invalidate()
			End Set
		End Property

		Private _waterMarkText As String = "Water Mark"
		Public Property WaterMarkText() As String
			Get
				Return _waterMarkText
			End Get
			Set(ByVal value As String)
				_waterMarkText = value
				Invalidate()
			End Set
		End Property

		Private _waterMarkLocked As Boolean = False
		Public Property WaterMarkLocked() As Boolean
			Get
				Return _waterMarkLocked
			End Get
			Set(ByVal value As Boolean)
				_waterMarkLocked = value
			End Set
		End Property
		#End Region

		'Default constructor
		Public Sub New()
			JoinEvents(True)
			Control.CheckForIllegalCrossThreadCalls = False
		End Sub

		'Override OnCreateControl ... 
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			WaterMark_Toggle(Nothing, Nothing)
		End Sub

		'Override OnPaint
		Protected Overrides Sub OnPaint(ByVal args As PaintEventArgs)
			' Use the same font that was defined in base class
			Dim drawFont As New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
			'Create new brush with gray color or 
			Dim drawBrush As New SolidBrush(WaterMarkColor)
			'use Water mark color
			'Draw Text or WaterMark
			args.Graphics.DrawString((If(waterMarkTextEnabled, WaterMarkText, Text)), drawFont, drawBrush, New PointF(1F, 1F))
			MyBase.OnPaint(args)
		End Sub

		Private Sub JoinEvents(ByVal join As Boolean)
			If join Then
				AddHandler Me.TextChanged, AddressOf WaterMark_Toggle
				AddHandler Me.LostFocus, AddressOf WaterMark_Toggle
				'No one of the above events will start immeddiatlly 
				'TextBox control still in constructing, so,
				'Font object (for example) couldn't be catched from within WaterMark_Toggle
				'So, call WaterMark_Toggle through OnCreateControl after TextBox is totally created
				'No doupt, it will be only one time call

				'Old solution uses Timer.Tick event to check Create property
				AddHandler Me.FontChanged, AddressOf WaterMark_FontChanged
			End If
		End Sub

		Public Sub WaterMark_Toggle(ByVal sender As Object, ByVal args As EventArgs)
			If Me.Text.Length <= 0 Then
				EnableWaterMark()
			Else
				DisbaleWaterMark()
			End If
		End Sub

		Public Sub EnableWaterMark()
			If WaterMarkLocked = False Then
				'Save current font until returning the UserPaint style to false (NOTE: It is a try and error advice)
				oldFont = New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
				'Enable OnPaint event handler
				Me.SetStyle(ControlStyles.UserPaint, True)
				Me.waterMarkTextEnabled = True
				'Triger OnPaint immediatly
				Refresh()
			End If
		End Sub

		Public Sub DisbaleWaterMark()
			'Disbale OnPaint event handler
			Me.waterMarkTextEnabled = False
			Me.SetStyle(ControlStyles.UserPaint, False)
			'Return back oldFont if existed
			If oldFont IsNot Nothing Then
				Me.Font = New System.Drawing.Font(oldFont.FontFamily, oldFont.Size, oldFont.Style, oldFont.Unit)
			End If
		End Sub

		Private Sub WaterMark_FontChanged(ByVal sender As Object, ByVal args As EventArgs)
			If waterMarkTextEnabled Then
				oldFont = New System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
				Refresh()
			End If
		End Sub
		Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
			Const WM_CONTEXTMENU As Integer = &H7b

			If m.Msg <> WM_CONTEXTMENU Then
				MyBase.WndProc(m)
			End If
		End Sub
	End Class
End Namespace
