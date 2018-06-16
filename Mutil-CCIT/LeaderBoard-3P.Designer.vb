<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaderBoard_3P
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
        Me.APanel = New System.Windows.Forms.Panel()
        Me.ATim = New System.Windows.Forms.Label()
        Me.ASkorPanel = New System.Windows.Forms.Panel()
        Me.ASkor = New System.Windows.Forms.Label()
        Me.BPanel = New System.Windows.Forms.Panel()
        Me.BTim = New System.Windows.Forms.Label()
        Me.BSkorPanel = New System.Windows.Forms.Panel()
        Me.BSkor = New System.Windows.Forms.Label()
        Me.CPanel = New System.Windows.Forms.Panel()
        Me.CTim = New System.Windows.Forms.Label()
        Me.CSkorPanel = New System.Windows.Forms.Panel()
        Me.CSkor = New System.Windows.Forms.Label()
        Me.Mode = New System.Windows.Forms.Label()
        Me.APanel.SuspendLayout()
        Me.ASkorPanel.SuspendLayout()
        Me.BPanel.SuspendLayout()
        Me.BSkorPanel.SuspendLayout()
        Me.CPanel.SuspendLayout()
        Me.CSkorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'APanel
        '
        Me.APanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.APanel.Controls.Add(Me.ATim)
        Me.APanel.Controls.Add(Me.ASkorPanel)
        Me.APanel.Location = New System.Drawing.Point(12, 119)
        Me.APanel.Name = "APanel"
        Me.APanel.Size = New System.Drawing.Size(349, 266)
        Me.APanel.TabIndex = 3
        '
        'ATim
        '
        Me.ATim.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATim.Location = New System.Drawing.Point(0, 12)
        Me.ATim.Name = "ATim"
        Me.ATim.Size = New System.Drawing.Size(349, 89)
        Me.ATim.TabIndex = 2
        Me.ATim.Text = "<Name>"
        Me.ATim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ASkorPanel
        '
        Me.ASkorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ASkorPanel.Controls.Add(Me.ASkor)
        Me.ASkorPanel.Location = New System.Drawing.Point(0, 119)
        Me.ASkorPanel.Name = "ASkorPanel"
        Me.ASkorPanel.Size = New System.Drawing.Size(349, 143)
        Me.ASkorPanel.TabIndex = 1
        '
        'ASkor
        '
        Me.ASkor.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASkor.Location = New System.Drawing.Point(3, 0)
        Me.ASkor.Name = "ASkor"
        Me.ASkor.Size = New System.Drawing.Size(341, 149)
        Me.ASkor.TabIndex = 0
        Me.ASkor.Text = "0"
        Me.ASkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BPanel
        '
        Me.BPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BPanel.Controls.Add(Me.BTim)
        Me.BPanel.Controls.Add(Me.BSkorPanel)
        Me.BPanel.Location = New System.Drawing.Point(376, 119)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(349, 266)
        Me.BPanel.TabIndex = 4
        '
        'BTim
        '
        Me.BTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTim.Location = New System.Drawing.Point(0, 12)
        Me.BTim.Name = "BTim"
        Me.BTim.Size = New System.Drawing.Size(349, 89)
        Me.BTim.TabIndex = 2
        Me.BTim.Text = "<Name>"
        Me.BTim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BSkorPanel
        '
        Me.BSkorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BSkorPanel.Controls.Add(Me.BSkor)
        Me.BSkorPanel.Location = New System.Drawing.Point(0, 119)
        Me.BSkorPanel.Name = "BSkorPanel"
        Me.BSkorPanel.Size = New System.Drawing.Size(349, 143)
        Me.BSkorPanel.TabIndex = 1
        '
        'BSkor
        '
        Me.BSkor.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSkor.Location = New System.Drawing.Point(4, 0)
        Me.BSkor.Name = "BSkor"
        Me.BSkor.Size = New System.Drawing.Size(341, 149)
        Me.BSkor.TabIndex = 0
        Me.BSkor.Text = "0"
        Me.BSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPanel
        '
        Me.CPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CPanel.Controls.Add(Me.CTim)
        Me.CPanel.Controls.Add(Me.CSkorPanel)
        Me.CPanel.Location = New System.Drawing.Point(743, 119)
        Me.CPanel.Name = "CPanel"
        Me.CPanel.Size = New System.Drawing.Size(349, 266)
        Me.CPanel.TabIndex = 5
        '
        'CTim
        '
        Me.CTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTim.Location = New System.Drawing.Point(0, 12)
        Me.CTim.Name = "CTim"
        Me.CTim.Size = New System.Drawing.Size(349, 89)
        Me.CTim.TabIndex = 2
        Me.CTim.Text = "<Name>"
        Me.CTim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CSkorPanel
        '
        Me.CSkorPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CSkorPanel.Controls.Add(Me.CSkor)
        Me.CSkorPanel.Location = New System.Drawing.Point(0, 119)
        Me.CSkorPanel.Name = "CSkorPanel"
        Me.CSkorPanel.Size = New System.Drawing.Size(349, 143)
        Me.CSkorPanel.TabIndex = 1
        '
        'CSkor
        '
        Me.CSkor.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSkor.Location = New System.Drawing.Point(4, 0)
        Me.CSkor.Name = "CSkor"
        Me.CSkor.Size = New System.Drawing.Size(341, 149)
        Me.CSkor.TabIndex = 0
        Me.CSkor.Text = "0"
        Me.CSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mode
        '
        Me.Mode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mode.Location = New System.Drawing.Point(14, 18)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(1078, 83)
        Me.Mode.TabIndex = 6
        Me.Mode.Text = "<Mode>"
        Me.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeaderBoard_3P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1106, 399)
        Me.Controls.Add(Me.Mode)
        Me.Controls.Add(Me.CPanel)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.APanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LeaderBoard_3P"
        Me.Text = "LeaderBoard_3P"
        Me.APanel.ResumeLayout(False)
        Me.ASkorPanel.ResumeLayout(False)
        Me.BPanel.ResumeLayout(False)
        Me.BSkorPanel.ResumeLayout(False)
        Me.CPanel.ResumeLayout(False)
        Me.CSkorPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents APanel As System.Windows.Forms.Panel
    Friend WithEvents ATim As System.Windows.Forms.Label
    Friend WithEvents ASkorPanel As System.Windows.Forms.Panel
    Friend WithEvents ASkor As System.Windows.Forms.Label
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents BTim As System.Windows.Forms.Label
    Friend WithEvents BSkorPanel As System.Windows.Forms.Panel
    Friend WithEvents BSkor As System.Windows.Forms.Label
    Friend WithEvents CPanel As System.Windows.Forms.Panel
    Friend WithEvents CTim As System.Windows.Forms.Label
    Friend WithEvents CSkorPanel As System.Windows.Forms.Panel
    Friend WithEvents CSkor As System.Windows.Forms.Label
    Friend WithEvents Mode As System.Windows.Forms.Label
End Class
