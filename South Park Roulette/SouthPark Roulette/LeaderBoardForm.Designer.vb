<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaderBoardForm
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgLeaderBoard = New System.Windows.Forms.DataGridView()
        Me.CName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnLose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgLeaderBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Orange
        Me.btnLoad.Location = New System.Drawing.Point(270, 237)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(202, 54)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Orange
        Me.btnBack.Location = New System.Drawing.Point(31, 237)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(202, 54)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgLeaderBoard
        '
        Me.dgLeaderBoard.BackgroundColor = System.Drawing.Color.Orange
        Me.dgLeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLeaderBoard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CName, Me.Wins, Me.columnLose, Me.cTotal})
        Me.dgLeaderBoard.Location = New System.Drawing.Point(31, 12)
        Me.dgLeaderBoard.Name = "dgLeaderBoard"
        Me.dgLeaderBoard.Size = New System.Drawing.Size(441, 219)
        Me.dgLeaderBoard.TabIndex = 3
        '
        'CName
        '
        Me.CName.HeaderText = "Name"
        Me.CName.Name = "CName"
        Me.CName.ReadOnly = True
        '
        'Wins
        '
        Me.Wins.HeaderText = "cWins"
        Me.Wins.Name = "Wins"
        Me.Wins.ReadOnly = True
        '
        'columnLose
        '
        Me.columnLose.HeaderText = "Losses"
        Me.columnLose.Name = "columnLose"
        Me.columnLose.ReadOnly = True
        '
        'cTotal
        '
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LeaderBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(489, 304)
        Me.Controls.Add(Me.dgLeaderBoard)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "LeaderBoardForm"
        Me.Text = "LeaderBoardForm"
        CType(Me.dgLeaderBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgLeaderBoard As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Wins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnLose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
