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
        Me.lblMemos = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxHeading = New System.Windows.Forms.TextBox()
        Me.tbxMemo = New System.Windows.Forms.TextBox()
        Me.btnMemoExit = New System.Windows.Forms.Button()
        Me.btnAddMemoRecord = New System.Windows.Forms.Button()
        Me.btnDeleteMemo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMemos
        '
        Me.lblMemos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemos.Location = New System.Drawing.Point(2, 18)
        Me.lblMemos.Name = "lblMemos"
        Me.lblMemos.Size = New System.Drawing.Size(525, 55)
        Me.lblMemos.TabIndex = 0
        Me.lblMemos.Text = "Memo"
        Me.lblMemos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(13, 90)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(80, 21)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Heading: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Memo: "
        '
        'tbxHeading
        '
        Me.tbxHeading.Location = New System.Drawing.Point(99, 87)
        Me.tbxHeading.MaxLength = 45
        Me.tbxHeading.Name = "tbxHeading"
        Me.tbxHeading.Size = New System.Drawing.Size(338, 29)
        Me.tbxHeading.TabIndex = 3
        '
        'tbxMemo
        '
        Me.tbxMemo.Location = New System.Drawing.Point(99, 123)
        Me.tbxMemo.MaxLength = 0
        Me.tbxMemo.Multiline = True
        Me.tbxMemo.Name = "tbxMemo"
        Me.tbxMemo.Size = New System.Drawing.Size(338, 202)
        Me.tbxMemo.TabIndex = 4
        '
        'btnMemoExit
        '
        Me.btnMemoExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMemoExit.BackColor = System.Drawing.Color.Bisque
        Me.btnMemoExit.Location = New System.Drawing.Point(410, 380)
        Me.btnMemoExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMemoExit.Name = "btnMemoExit"
        Me.btnMemoExit.Size = New System.Drawing.Size(105, 30)
        Me.btnMemoExit.TabIndex = 6
        Me.btnMemoExit.Text = "Exit"
        Me.btnMemoExit.UseVisualStyleBackColor = False
        '
        'btnAddMemoRecord
        '
        Me.btnAddMemoRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddMemoRecord.BackColor = System.Drawing.Color.Bisque
        Me.btnAddMemoRecord.Location = New System.Drawing.Point(99, 333)
        Me.btnAddMemoRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddMemoRecord.Name = "btnAddMemoRecord"
        Me.btnAddMemoRecord.Size = New System.Drawing.Size(112, 36)
        Me.btnAddMemoRecord.TabIndex = 7
        Me.btnAddMemoRecord.Text = "Add"
        Me.btnAddMemoRecord.UseVisualStyleBackColor = False
        '
        'btnDeleteMemo
        '
        Me.btnDeleteMemo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteMemo.BackColor = System.Drawing.Color.Bisque
        Me.btnDeleteMemo.Location = New System.Drawing.Point(219, 333)
        Me.btnDeleteMemo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteMemo.Name = "btnDeleteMemo"
        Me.btnDeleteMemo.Size = New System.Drawing.Size(112, 36)
        Me.btnDeleteMemo.TabIndex = 8
        Me.btnDeleteMemo.Text = "Delete"
        Me.btnDeleteMemo.UseVisualStyleBackColor = False
        Me.btnDeleteMemo.Visible = False
        '
        'FrmMemos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(528, 424)
        Me.Controls.Add(Me.btnDeleteMemo)
        Me.Controls.Add(Me.btnAddMemoRecord)
        Me.Controls.Add(Me.btnMemoExit)
        Me.Controls.Add(Me.tbxMemo)
        Me.Controls.Add(Me.tbxHeading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblMemos)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMemos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMemos As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxHeading As TextBox
    Friend WithEvents tbxMemo As TextBox
    Friend WithEvents btnMemoExit As Button
    Friend WithEvents btnAddMemoRecord As Button
    Friend WithEvents btnDeleteMemo As Button
End Class
