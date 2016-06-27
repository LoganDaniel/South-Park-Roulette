<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuitForm
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnJoke = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Location = New System.Drawing.Point(24, 25)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(186, 13)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Are you sure you want to quit, Buddy?"
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnYes.Location = New System.Drawing.Point(92, 279)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNo.Location = New System.Drawing.Point(173, 279)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnJoke
        '
        Me.btnJoke.BackColor = System.Drawing.Color.DarkOrange
        Me.btnJoke.Location = New System.Drawing.Point(254, 279)
        Me.btnJoke.Name = "btnJoke"
        Me.btnJoke.Size = New System.Drawing.Size(164, 23)
        Me.btnJoke.TabIndex = 3
        Me.btnJoke.Text = "I'm not your Buddy, Guy"
        Me.btnJoke.UseVisualStyleBackColor = False
        '
        'QuitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.SouthPark_Roulette.My.Resources.Resources.TerranceAndPhillip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 314)
        Me.Controls.Add(Me.btnJoke)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "QuitForm"
        Me.Text = "QuitForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnJoke As System.Windows.Forms.Button
End Class
