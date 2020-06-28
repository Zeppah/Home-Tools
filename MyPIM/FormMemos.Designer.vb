<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMemos
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
        Me.LblMemo = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.BtnExitMemo = New System.Windows.Forms.Button()
        Me.BtnAddMemo = New System.Windows.Forms.Button()
        Me.BtnDeleteMemo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblMemo
        '
        Me.LblMemo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMemo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMemo.Location = New System.Drawing.Point(31, 23)
        Me.LblMemo.Name = "LblMemo"
        Me.LblMemo.Size = New System.Drawing.Size(336, 55)
        Me.LblMemo.TabIndex = 0
        Me.LblMemo.Text = "Memo"
        Me.LblMemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTitle
        '
        Me.TxtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtTitle.ForeColor = System.Drawing.Color.White
        Me.TxtTitle.Location = New System.Drawing.Point(31, 92)
        Me.TxtTitle.MaxLength = 45
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(338, 29)
        Me.TxtTitle.TabIndex = 3
        '
        'TxtMemo
        '
        Me.TxtMemo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtMemo.ForeColor = System.Drawing.Color.White
        Me.TxtMemo.Location = New System.Drawing.Point(31, 128)
        Me.TxtMemo.MaxLength = 0
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.Size = New System.Drawing.Size(338, 202)
        Me.TxtMemo.TabIndex = 4
        '
        'BtnExitMemo
        '
        Me.BtnExitMemo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExitMemo.BackColor = System.Drawing.Color.Bisque
        Me.BtnExitMemo.Location = New System.Drawing.Point(289, 416)
        Me.BtnExitMemo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExitMemo.Name = "BtnExitMemo"
        Me.BtnExitMemo.Size = New System.Drawing.Size(105, 30)
        Me.BtnExitMemo.TabIndex = 6
        Me.BtnExitMemo.Text = "Exit"
        Me.BtnExitMemo.UseVisualStyleBackColor = False
        '
        'BtnAddMemo
        '
        Me.BtnAddMemo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddMemo.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddMemo.Location = New System.Drawing.Point(31, 338)
        Me.BtnAddMemo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddMemo.Name = "BtnAddMemo"
        Me.BtnAddMemo.Size = New System.Drawing.Size(112, 36)
        Me.BtnAddMemo.TabIndex = 7
        Me.BtnAddMemo.Text = "Add"
        Me.BtnAddMemo.UseVisualStyleBackColor = False
        '
        'BtnDeleteMemo
        '
        Me.BtnDeleteMemo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteMemo.BackColor = System.Drawing.Color.Bisque
        Me.BtnDeleteMemo.Location = New System.Drawing.Point(257, 338)
        Me.BtnDeleteMemo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeleteMemo.Name = "BtnDeleteMemo"
        Me.BtnDeleteMemo.Size = New System.Drawing.Size(112, 36)
        Me.BtnDeleteMemo.TabIndex = 8
        Me.BtnDeleteMemo.Text = "Delete"
        Me.BtnDeleteMemo.UseVisualStyleBackColor = False
        Me.BtnDeleteMemo.Visible = False
        '
        'FormMemos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(407, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnDeleteMemo)
        Me.Controls.Add(Me.BtnAddMemo)
        Me.Controls.Add(Me.BtnExitMemo)
        Me.Controls.Add(Me.TxtMemo)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblMemo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMemos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMemo As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents TxtMemo As TextBox
    Friend WithEvents BtnExitMemo As Button
    Friend WithEvents BtnAddMemo As Button
    Friend WithEvents BtnDeleteMemo As Button
End Class
