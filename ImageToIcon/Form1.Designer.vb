Namespace wmgCMS
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.tbHeight = New wmgCMS.WaterMarkTextBox()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.tbWidth = New wmgCMS.WaterMarkTextBox()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(248, Byte), Integer))
            Me.panel1.BackgroundImage = Global.My.Resources.Resources.white
            Me.panel1.Controls.Add(Me.button2)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 430)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(627, 37)
            Me.panel1.TabIndex = 0
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button2.FlatAppearance.BorderSize = 0
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(538, 1)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(90, 36)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Convert"
            Me.button2.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.FlatAppearance.BorderSize = 0
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(442, 1)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(90, 36)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Browse..."
            Me.button1.UseVisualStyleBackColor = True
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.panel2.Controls.Add(Me.pictureBox1)
            Me.panel2.Controls.Add(Me.panel4)
            Me.panel2.Controls.Add(Me.tbHeight)
            Me.panel2.Controls.Add(Me.panel3)
            Me.panel2.Controls.Add(Me.tbWidth)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(627, 119)
            Me.panel2.TabIndex = 5
            '
            'pictureBox1
            '
            Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pictureBox1.Location = New System.Drawing.Point(520, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(95, 95)
            Me.pictureBox1.TabIndex = 6
            Me.pictureBox1.TabStop = False
            '
            'panel4
            '
            Me.panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel4.BackColor = System.Drawing.Color.DarkGray
            Me.panel4.Location = New System.Drawing.Point(12, 100)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(486, 1)
            Me.panel4.TabIndex = 9
            '
            'tbHeight
            '
            Me.tbHeight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tbHeight.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(90, Byte), Integer))
            Me.tbHeight.Location = New System.Drawing.Point(12, 67)
            Me.tbHeight.Multiline = False
            Me.tbHeight.Name = "tbHeight"
            Me.tbHeight.Size = New System.Drawing.Size(486, 28)
            Me.tbHeight.TabIndex = 8
            Me.tbHeight.Text = ""
            Me.tbHeight.WaterMarkColor = System.Drawing.Color.Gray
            Me.tbHeight.WaterMarkLocked = False
            Me.tbHeight.WaterMarkText = "Height (px)"
            '
            'panel3
            '
            Me.panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel3.BackColor = System.Drawing.Color.DarkGray
            Me.panel3.Location = New System.Drawing.Point(12, 51)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(486, 1)
            Me.panel3.TabIndex = 7
            '
            'tbWidth
            '
            Me.tbWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tbWidth.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.tbWidth.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tbWidth.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tbWidth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(90, Byte), Integer))
            Me.tbWidth.Location = New System.Drawing.Point(12, 18)
            Me.tbWidth.Multiline = False
            Me.tbWidth.Name = "tbWidth"
            Me.tbWidth.Size = New System.Drawing.Size(486, 28)
            Me.tbWidth.TabIndex = 6
            Me.tbWidth.Text = ""
            Me.tbWidth.WaterMarkColor = System.Drawing.Color.Gray
            Me.tbWidth.WaterMarkLocked = False
            Me.tbWidth.WaterMarkText = "Width (px)"
            '
            'panel5
            '
            Me.panel5.AllowDrop = True
            Me.panel5.BackColor = System.Drawing.Color.White
            Me.panel5.BackgroundImage = Global.My.Resources.Resources.drag
            Me.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel5.Location = New System.Drawing.Point(0, 119)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(627, 311)
            Me.panel5.TabIndex = 6
            '
            'Form1
            '
            Me.AllowDrop = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(627, 467)
            Me.Controls.Add(Me.panel5)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.DoubleBuffered = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(643, 506)
            Me.Name = "Form1"
            Me.Text = "Iconify"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panel1 As System.Windows.Forms.Panel
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button1 As System.Windows.Forms.Button
		Private panel2 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private WithEvents tbHeight As WaterMarkTextBox
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents tbWidth As WaterMarkTextBox
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents panel5 As System.Windows.Forms.Panel
	End Class
End Namespace

