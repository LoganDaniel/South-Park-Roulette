<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Blinking = New System.Windows.Forms.Timer(Me.components)
        Me.pbMysterion = New System.Windows.Forms.PictureBox()
        Me.pbJoker = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbCheat = New System.Windows.Forms.PictureBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.pbIndicator1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbLaser = New System.Windows.Forms.PictureBox()
        Me.lblChances = New System.Windows.Forms.Label()
        Me.LaserEye = New System.Windows.Forms.Timer(Me.components)
        Me.JokerFaceTransition = New System.Windows.Forms.Timer(Me.components)
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.pbCylinder = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.cbSongSelection = New System.Windows.Forms.ComboBox()
        Me.btnMusic = New System.Windows.Forms.Button()
        CType(Me.pbMysterion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCylinder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tMovement
        '
        Me.tMovement.Interval = 80
        '
        'tAnimation
        '
        Me.tAnimation.Interval = 1
        '
        'Blinking
        '
        Me.Blinking.Interval = 488
        '
        'pbMysterion
        '
        Me.pbMysterion.BackColor = System.Drawing.Color.Transparent
        Me.pbMysterion.Image = CType(resources.GetObject("pbMysterion.Image"), System.Drawing.Image)
        Me.pbMysterion.Location = New System.Drawing.Point(615, 256)
        Me.pbMysterion.Name = "pbMysterion"
        Me.pbMysterion.Size = New System.Drawing.Size(137, 187)
        Me.pbMysterion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMysterion.TabIndex = 2
        Me.pbMysterion.TabStop = False
        '
        'pbJoker
        '
        Me.pbJoker.BackColor = System.Drawing.Color.Transparent
        Me.pbJoker.Image = CType(resources.GetObject("pbJoker.Image"), System.Drawing.Image)
        Me.pbJoker.Location = New System.Drawing.Point(191, 256)
        Me.pbJoker.Name = "pbJoker"
        Me.pbJoker.Size = New System.Drawing.Size(144, 187)
        Me.pbJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbJoker.TabIndex = 1
        Me.pbJoker.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(72, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 74)
        Me.lblTitle.TabIndex = 3
        '
        'pbCheat
        '
        Me.pbCheat.BackColor = System.Drawing.Color.Transparent
        Me.pbCheat.Location = New System.Drawing.Point(57, 228)
        Me.pbCheat.Name = "pbCheat"
        Me.pbCheat.Size = New System.Drawing.Size(100, 101)
        Me.pbCheat.TabIndex = 4
        Me.pbCheat.TabStop = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnswer.Location = New System.Drawing.Point(611, 470)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(62, 20)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "Answer"
        Me.lblAnswer.Visible = False
        '
        'pbIndicator1
        '
        Me.pbIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.pbIndicator1.Image = CType(resources.GetObject("pbIndicator1.Image"), System.Drawing.Image)
        Me.pbIndicator1.Location = New System.Drawing.Point(222, 163)
        Me.pbIndicator1.Name = "pbIndicator1"
        Me.pbIndicator1.Size = New System.Drawing.Size(70, 87)
        Me.pbIndicator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIndicator1.TabIndex = 6
        Me.pbIndicator1.TabStop = False
        Me.pbIndicator1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(652, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pbLaser
        '
        Me.pbLaser.BackColor = System.Drawing.Color.Transparent
        Me.pbLaser.Location = New System.Drawing.Point(615, 342)
        Me.pbLaser.Name = "pbLaser"
        Me.pbLaser.Size = New System.Drawing.Size(61, 16)
        Me.pbLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLaser.TabIndex = 8
        Me.pbLaser.TabStop = False
        Me.pbLaser.Visible = False
        '
        'lblChances
        '
        Me.lblChances.AutoSize = True
        Me.lblChances.BackColor = System.Drawing.Color.Transparent
        Me.lblChances.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChances.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChances.Location = New System.Drawing.Point(757, 470)
        Me.lblChances.Name = "lblChances"
        Me.lblChances.Size = New System.Drawing.Size(89, 20)
        Me.lblChances.TabIndex = 9
        Me.lblChances.Text = "Chances: 2"
        '
        'LaserEye
        '
        Me.LaserEye.Interval = 50
        '
        'JokerFaceTransition
        '
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSpin.Location = New System.Drawing.Point(307, 465)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(133, 31)
        Me.btnSpin.TabIndex = 10
        Me.btnSpin.Text = "Spin Chamber"
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'pbCylinder
        '
        Me.pbCylinder.BackColor = System.Drawing.Color.Transparent
        Me.pbCylinder.Image = CType(resources.GetObject("pbCylinder.Image"), System.Drawing.Image)
        Me.pbCylinder.Location = New System.Drawing.Point(737, 139)
        Me.pbCylinder.Name = "pbCylinder"
        Me.pbCylinder.Size = New System.Drawing.Size(129, 111)
        Me.pbCylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCylinder.TabIndex = 11
        Me.pbCylinder.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(459, 465)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(133, 31)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'cbSongSelection
        '
        Me.cbSongSelection.FormattingEnabled = True
        Me.cbSongSelection.Items.AddRange(New Object() {"SouthPark Intro", "What_Would_Brian_Boitano_Do"})
        Me.cbSongSelection.Location = New System.Drawing.Point(12, 469)
        Me.cbSongSelection.Name = "cbSongSelection"
        Me.cbSongSelection.Size = New System.Drawing.Size(142, 21)
        Me.cbSongSelection.TabIndex = 14
        Me.cbSongSelection.Visible = False
        '
        'btnMusic
        '
        Me.btnMusic.Location = New System.Drawing.Point(170, 469)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.Size = New System.Drawing.Size(75, 23)
        Me.btnMusic.TabIndex = 15
        Me.btnMusic.Text = "Play / Stop"
        Me.btnMusic.UseVisualStyleBackColor = True
        Me.btnMusic.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(869, 501)
        Me.Controls.Add(Me.btnMusic)
        Me.Controls.Add(Me.cbSongSelection)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.pbCylinder)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lblChances)
        Me.Controls.Add(Me.pbLaser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbIndicator1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.pbCheat)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbMysterion)
        Me.Controls.Add(Me.pbJoker)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbMysterion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJoker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCylinder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbJoker As System.Windows.Forms.PictureBox
    Friend WithEvents tMovement As System.Windows.Forms.Timer
    Friend WithEvents tAnimation As System.Windows.Forms.Timer
    Friend WithEvents pbMysterion As System.Windows.Forms.PictureBox
    Friend WithEvents Blinking As System.Windows.Forms.Timer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pbCheat As System.Windows.Forms.PictureBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents pbIndicator1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLaser As System.Windows.Forms.PictureBox
    Friend WithEvents lblChances As System.Windows.Forms.Label
    Friend WithEvents LaserEye As System.Windows.Forms.Timer
    Friend WithEvents JokerFaceTransition As System.Windows.Forms.Timer
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents pbCylinder As System.Windows.Forms.PictureBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents cbSongSelection As ComboBox
    Friend WithEvents btnMusic As Button
End Class
