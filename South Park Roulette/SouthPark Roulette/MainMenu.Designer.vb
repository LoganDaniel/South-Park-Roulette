<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnSingle = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnLeader = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.cbSongSelection = New System.Windows.Forms.ComboBox()
        Me.btnMusic = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHowtoPlay = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SouthPark_Roulette.My.Resources.Resources.mJokerWins
        Me.PictureBox1.Location = New System.Drawing.Point(172, 290)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.SouthPark_Roulette.My.Resources.Resources.MysterionWin
        Me.PictureBox4.Location = New System.Drawing.Point(641, 290)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(137, 153)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'BtnSingle
        '
        Me.BtnSingle.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnSingle.Location = New System.Drawing.Point(348, 92)
        Me.BtnSingle.Name = "BtnSingle"
        Me.BtnSingle.Size = New System.Drawing.Size(197, 70)
        Me.BtnSingle.TabIndex = 4
        Me.BtnSingle.Text = "Single Player"
        Me.BtnSingle.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.Color.DarkOrange
        Me.btnMulti.Location = New System.Drawing.Point(348, 168)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(197, 70)
        Me.btnMulti.TabIndex = 5
        Me.btnMulti.Text = "Multi-Player"
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'btnLeader
        '
        Me.btnLeader.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLeader.Location = New System.Drawing.Point(348, 244)
        Me.btnLeader.Name = "btnLeader"
        Me.btnLeader.Size = New System.Drawing.Size(197, 70)
        Me.btnLeader.TabIndex = 6
        Me.btnLeader.Text = "LeaderBoards"
        Me.btnLeader.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnExit.Location = New System.Drawing.Point(348, 396)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(197, 70)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Quit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'cbSongSelection
        '
        Me.cbSongSelection.FormattingEnabled = True
        Me.cbSongSelection.Items.AddRange(New Object() {"SouthPark Intro", "What_Would_Brian_Boitano_Do"})
        Me.cbSongSelection.Location = New System.Drawing.Point(14, 478)
        Me.cbSongSelection.Name = "cbSongSelection"
        Me.cbSongSelection.Size = New System.Drawing.Size(142, 21)
        Me.cbSongSelection.TabIndex = 12
        '
        'btnMusic
        '
        Me.btnMusic.Location = New System.Drawing.Point(172, 478)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.Size = New System.Drawing.Size(75, 23)
        Me.btnMusic.TabIndex = 13
        Me.btnMusic.Text = "Play / Stop"
        Me.btnMusic.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(57, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(744, 55)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Russian Roulette - SouthPark Edition"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(105, 64)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(649, 25)
        Me.lblSubTitle.TabIndex = 16
        Me.lblSubTitle.Text = "If We're Still Alive In The Morning, Then We'll Know We're Not Dead"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "- Randy Marsh, 2006"
        '
        'btnHowtoPlay
        '
        Me.btnHowtoPlay.BackColor = System.Drawing.Color.DarkOrange
        Me.btnHowtoPlay.Location = New System.Drawing.Point(348, 320)
        Me.btnHowtoPlay.Name = "btnHowtoPlay"
        Me.btnHowtoPlay.Size = New System.Drawing.Size(197, 70)
        Me.btnHowtoPlay.TabIndex = 18
        Me.btnHowtoPlay.Text = "How to Play"
        Me.btnHowtoPlay.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SouthPark_Roulette.My.Resources.Resources.SouthParkBusStop
        Me.ClientSize = New System.Drawing.Size(862, 513)
        Me.Controls.Add(Me.btnHowtoPlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMusic)
        Me.Controls.Add(Me.cbSongSelection)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnLeader)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.BtnSingle)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSingle As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnLeader As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents cbSongSelection As System.Windows.Forms.ComboBox
    Friend WithEvents btnMusic As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHowtoPlay As System.Windows.Forms.Button
End Class
