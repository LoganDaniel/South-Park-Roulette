<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SomeoneWon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SomeoneWon))
        Me.lblCongratz = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCongratz
        '
        Me.lblCongratz.AutoSize = True
        Me.lblCongratz.BackColor = System.Drawing.Color.Transparent
        Me.lblCongratz.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongratz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCongratz.Location = New System.Drawing.Point(38, 24)
        Me.lblCongratz.Name = "lblCongratz"
        Me.lblCongratz.Size = New System.Drawing.Size(164, 26)
        Me.lblCongratz.TabIndex = 0
        Me.lblCongratz.Text = "Congratulations"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(65, 137)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(127, 42)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Return to Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.BackColor = System.Drawing.Color.Transparent
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWinner.Location = New System.Drawing.Point(75, 64)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(81, 26)
        Me.lblWinner.TabIndex = 3
        Me.lblWinner.Text = "Winner"
        '
        'SomeoneWon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 242)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblCongratz)
        Me.DoubleBuffered = True
        Me.Name = "SomeoneWon"
        Me.Text = "SomeoneWon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCongratz As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lblWinner As System.Windows.Forms.Label
End Class
