<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiPlayer))
        Me.btnMusic = New System.Windows.Forms.Button()
        Me.cbSongSelection = New System.Windows.Forms.ComboBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.pbCylinder = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbIndicator1 = New System.Windows.Forms.PictureBox()
        Me.pbJoker = New System.Windows.Forms.PictureBox()
        Me.pbSecondPlayer = New System.Windows.Forms.PictureBox()
        Me.tMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.JokerFaceTransition = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblWhosTurn = New System.Windows.Forms.Label()
        Me.pbCheat = New System.Windows.Forms.PictureBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbCylinder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSecondPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCheat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMusic
        '
        Me.btnMusic.Location = New System.Drawing.Point(165, 471)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.Size = New System.Drawing.Size(75, 23)
        Me.btnMusic.TabIndex = 29
        Me.btnMusic.Text = "Play / Stop"
        Me.btnMusic.UseVisualStyleBackColor = True
        '
        'cbSongSelection
        '
        Me.cbSongSelection.FormattingEnabled = True
        Me.cbSongSelection.Items.AddRange(New Object() {"SouthPark Intro", "What_Would_Brian_Boitano_Do"})
        Me.cbSongSelection.Location = New System.Drawing.Point(7, 471)
        Me.cbSongSelection.Name = "cbSongSelection"
        Me.cbSongSelection.Size = New System.Drawing.Size(142, 21)
        Me.cbSongSelection.TabIndex = 28
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuit.Location = New System.Drawing.Point(454, 467)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(133, 31)
        Me.btnQuit.TabIndex = 27
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'pbCylinder
        '
        Me.pbCylinder.BackColor = System.Drawing.Color.Transparent
        Me.pbCylinder.Image = CType(resources.GetObject("pbCylinder.Image"), System.Drawing.Image)
        Me.pbCylinder.Location = New System.Drawing.Point(728, 5)
        Me.pbCylinder.Name = "pbCylinder"
        Me.pbCylinder.Size = New System.Drawing.Size(129, 111)
        Me.pbCylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCylinder.TabIndex = 26
        Me.pbCylinder.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSpin.Location = New System.Drawing.Point(302, 467)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(133, 31)
        Me.btnSpin.TabIndex = 25
        Me.btnSpin.Text = "Spin Chamber"
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(647, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pbIndicator1
        '
        Me.pbIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.pbIndicator1.Image = CType(resources.GetObject("pbIndicator1.Image"), System.Drawing.Image)
        Me.pbIndicator1.Location = New System.Drawing.Point(217, 150)
        Me.pbIndicator1.Name = "pbIndicator1"
        Me.pbIndicator1.Size = New System.Drawing.Size(70, 87)
        Me.pbIndicator1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbIndicator1.TabIndex = 21
        Me.pbIndicator1.TabStop = False
        Me.pbIndicator1.Visible = False
        '
        'pbJoker
        '
        Me.pbJoker.BackColor = System.Drawing.Color.Transparent
        Me.pbJoker.Image = CType(resources.GetObject("pbJoker.Image"), System.Drawing.Image)
        Me.pbJoker.Location = New System.Drawing.Point(186, 242)
        Me.pbJoker.Name = "pbJoker"
        Me.pbJoker.Size = New System.Drawing.Size(144, 187)
        Me.pbJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbJoker.TabIndex = 16
        Me.pbJoker.TabStop = False
        '
        'pbSecondPlayer
        '
        Me.pbSecondPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pbSecondPlayer.Image = Global.SouthPark_Roulette.My.Resources.Resources.mMovement1
        Me.pbSecondPlayer.Location = New System.Drawing.Point(611, 242)
        Me.pbSecondPlayer.Name = "pbSecondPlayer"
        Me.pbSecondPlayer.Size = New System.Drawing.Size(144, 187)
        Me.pbSecondPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSecondPlayer.TabIndex = 30
        Me.pbSecondPlayer.TabStop = False
        '
        'tMovement
        '
        '
        'tAnimation
        '
        '
        'JokerFaceTransition
        '
        '
        'btnPlayer1
        '
        Me.btnPlayer1.BackColor = System.Drawing.Color.Orange
        Me.btnPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnPlayer1.Image = Global.SouthPark_Roulette.My.Resources.Resources.ImageOne
        Me.btnPlayer1.Location = New System.Drawing.Point(7, 23)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(290, 406)
        Me.btnPlayer1.TabIndex = 31
        Me.btnPlayer1.Text = "Player 1 Starts"
        Me.btnPlayer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlayer1.UseVisualStyleBackColor = False
        '
        'btnPlayer2
        '
        Me.btnPlayer2.BackColor = System.Drawing.Color.Orange
        Me.btnPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnPlayer2.Image = Global.SouthPark_Roulette.My.Resources.Resources.ImageTwo
        Me.btnPlayer2.Location = New System.Drawing.Point(578, 23)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(279, 406)
        Me.btnPlayer2.TabIndex = 32
        Me.btnPlayer2.Text = "Player 2 Starts"
        Me.btnPlayer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPlayer2.UseVisualStyleBackColor = False
        '
        'btnRandom
        '
        Me.btnRandom.BackColor = System.Drawing.Color.Orange
        Me.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnRandom.Image = Global.SouthPark_Roulette.My.Resources.Resources.ImageUnknown
        Me.btnRandom.Location = New System.Drawing.Point(293, 23)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(291, 406)
        Me.btnRandom.TabIndex = 33
        Me.btnRandom.Text = "Random"
        Me.btnRandom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRandom.UseVisualStyleBackColor = False
        '
        'lblWhosTurn
        '
        Me.lblWhosTurn.AutoSize = True
        Me.lblWhosTurn.BackColor = System.Drawing.Color.Transparent
        Me.lblWhosTurn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWhosTurn.Location = New System.Drawing.Point(608, 476)
        Me.lblWhosTurn.Name = "lblWhosTurn"
        Me.lblWhosTurn.Size = New System.Drawing.Size(93, 13)
        Me.lblWhosTurn.TabIndex = 34
        Me.lblWhosTurn.Text = "Select Who Starts"
        '
        'pbCheat
        '
        Me.pbCheat.BackColor = System.Drawing.Color.Transparent
        Me.pbCheat.Location = New System.Drawing.Point(59, 225)
        Me.pbCheat.Name = "pbCheat"
        Me.pbCheat.Size = New System.Drawing.Size(100, 101)
        Me.pbCheat.TabIndex = 35
        Me.pbCheat.TabStop = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnswer.Location = New System.Drawing.Point(800, 469)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(62, 20)
        Me.lblAnswer.TabIndex = 36
        Me.lblAnswer.Text = "Answer"
        Me.lblAnswer.Visible = False
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblSubHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeader.Location = New System.Drawing.Point(21, 77)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(696, 17)
        Me.lblSubHeader.TabIndex = 37
        Me.lblSubHeader.Text = "Be careful not to miss when shooting the opponent or else you have to wait until " & _
    "they miss to regain your shot"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 39.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(715, 72)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Click a Character to Shoot"
        '
        'MultiPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SouthPark_Roulette.My.Resources.Resources.SouthParkBusStop
        Me.ClientSize = New System.Drawing.Size(869, 501)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnPlayer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSubHeader)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.pbCheat)
        Me.Controls.Add(Me.lblWhosTurn)
        Me.Controls.Add(Me.pbSecondPlayer)
        Me.Controls.Add(Me.btnMusic)
        Me.Controls.Add(Me.cbSongSelection)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.pbCylinder)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbIndicator1)
        Me.Controls.Add(Me.pbJoker)
        Me.Name = "MultiPlayer"
        Me.Text = "MultiPlayer"
        CType(Me.pbCylinder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJoker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSecondPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCheat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMusic As System.Windows.Forms.Button
    Friend WithEvents cbSongSelection As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents pbCylinder As System.Windows.Forms.PictureBox
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbIndicator1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbJoker As System.Windows.Forms.PictureBox
    Friend WithEvents pbSecondPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents tMovement As System.Windows.Forms.Timer
    Friend WithEvents tAnimation As System.Windows.Forms.Timer
    Friend WithEvents JokerFaceTransition As System.Windows.Forms.Timer
    Friend WithEvents btnPlayer1 As System.Windows.Forms.Button
    Friend WithEvents btnPlayer2 As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents lblWhosTurn As System.Windows.Forms.Label
    Friend WithEvents pbCheat As System.Windows.Forms.PictureBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSubHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
