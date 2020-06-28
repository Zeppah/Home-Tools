<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEvents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnAddEventRecord = New System.Windows.Forms.Button()
        Me.ChkTime = New System.Windows.Forms.CheckBox()
        Me.DtpTime = New System.Windows.Forms.DateTimePicker()
        Me.GrpCategories = New System.Windows.Forms.GroupBox()
        Me.ChkStarred = New System.Windows.Forms.CheckBox()
        Me.ChkOther = New System.Windows.Forms.CheckBox()
        Me.ChkBirthday = New System.Windows.Forms.CheckBox()
        Me.ChkBill = New System.Windows.Forms.CheckBox()
        Me.ChkAppointment = New System.Windows.Forms.CheckBox()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Bisque
        Me.BtnExit.Location = New System.Drawing.Point(371, 364)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(105, 30)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblDate
        '
        Me.LblDate.Location = New System.Drawing.Point(25, 131)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(69, 30)
        Me.LblDate.TabIndex = 1
        Me.LblDate.Text = "Date: "
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTitle
        '
        Me.LblTitle.Location = New System.Drawing.Point(25, 93)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(69, 30)
        Me.LblTitle.TabIndex = 4
        Me.LblTitle.Text = "Title: "
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(100, 95)
        Me.TxtTitle.MaxLength = 30
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(337, 26)
        Me.TxtTitle.TabIndex = 0
        '
        'DtpDate
        '
        Me.DtpDate.CustomFormat = "MM/dd/yyyy hh:mm"
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(100, 131)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(150, 26)
        Me.DtpDate.TabIndex = 1
        '
        'BtnAddEventRecord
        '
        Me.BtnAddEventRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddEventRecord.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddEventRecord.Location = New System.Drawing.Point(100, 264)
        Me.BtnAddEventRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddEventRecord.Name = "BtnAddEventRecord"
        Me.BtnAddEventRecord.Size = New System.Drawing.Size(112, 36)
        Me.BtnAddEventRecord.TabIndex = 4
        Me.BtnAddEventRecord.Text = "Add"
        Me.BtnAddEventRecord.UseVisualStyleBackColor = False
        '
        'ChkTime
        '
        Me.ChkTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkTime.Location = New System.Drawing.Point(37, 171)
        Me.ChkTime.Name = "ChkTime"
        Me.ChkTime.Size = New System.Drawing.Size(80, 26)
        Me.ChkTime.TabIndex = 2
        Me.ChkTime.Text = "Time:          "
        Me.ChkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkTime.UseVisualStyleBackColor = True
        '
        'DtpTime
        '
        Me.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpTime.Location = New System.Drawing.Point(132, 171)
        Me.DtpTime.Name = "DtpTime"
        Me.DtpTime.ShowUpDown = True
        Me.DtpTime.Size = New System.Drawing.Size(118, 26)
        Me.DtpTime.TabIndex = 15
        Me.DtpTime.Value = New Date(2020, 6, 16, 12, 0, 0, 0)
        Me.DtpTime.Visible = False
        '
        'GrpCategories
        '
        Me.GrpCategories.BackColor = System.Drawing.Color.Cyan
        Me.GrpCategories.Controls.Add(Me.ChkStarred)
        Me.GrpCategories.Controls.Add(Me.ChkOther)
        Me.GrpCategories.Controls.Add(Me.ChkBirthday)
        Me.GrpCategories.Controls.Add(Me.ChkBill)
        Me.GrpCategories.Controls.Add(Me.ChkAppointment)
        Me.GrpCategories.Location = New System.Drawing.Point(280, 131)
        Me.GrpCategories.Name = "GrpCategories"
        Me.GrpCategories.Size = New System.Drawing.Size(157, 169)
        Me.GrpCategories.TabIndex = 3
        Me.GrpCategories.TabStop = False
        '
        'ChkStarred
        '
        Me.ChkStarred.AutoSize = True
        Me.ChkStarred.Location = New System.Drawing.Point(21, 132)
        Me.ChkStarred.Name = "ChkStarred"
        Me.ChkStarred.Size = New System.Drawing.Size(81, 24)
        Me.ChkStarred.TabIndex = 4
        Me.ChkStarred.Text = "Starred"
        Me.ChkStarred.UseVisualStyleBackColor = True
        '
        'ChkOther
        '
        Me.ChkOther.AutoSize = True
        Me.ChkOther.Location = New System.Drawing.Point(21, 106)
        Me.ChkOther.Name = "ChkOther"
        Me.ChkOther.Size = New System.Drawing.Size(68, 24)
        Me.ChkOther.TabIndex = 3
        Me.ChkOther.Text = "Other"
        Me.ChkOther.UseVisualStyleBackColor = True
        '
        'ChkBirthday
        '
        Me.ChkBirthday.AutoSize = True
        Me.ChkBirthday.Location = New System.Drawing.Point(21, 76)
        Me.ChkBirthday.Name = "ChkBirthday"
        Me.ChkBirthday.Size = New System.Drawing.Size(86, 24)
        Me.ChkBirthday.TabIndex = 2
        Me.ChkBirthday.Text = "Birthday"
        Me.ChkBirthday.UseVisualStyleBackColor = True
        '
        'ChkBill
        '
        Me.ChkBill.AutoSize = True
        Me.ChkBill.Location = New System.Drawing.Point(21, 46)
        Me.ChkBill.Name = "ChkBill"
        Me.ChkBill.Size = New System.Drawing.Size(48, 24)
        Me.ChkBill.TabIndex = 1
        Me.ChkBill.Text = "Bill"
        Me.ChkBill.UseVisualStyleBackColor = True
        '
        'ChkAppointment
        '
        Me.ChkAppointment.AutoSize = True
        Me.ChkAppointment.Location = New System.Drawing.Point(21, 16)
        Me.ChkAppointment.Name = "ChkAppointment"
        Me.ChkAppointment.Size = New System.Drawing.Size(119, 24)
        Me.ChkAppointment.TabIndex = 0
        Me.ChkAppointment.Text = "Appointment"
        Me.ChkAppointment.UseVisualStyleBackColor = True
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Location = New System.Drawing.Point(21, 213)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(73, 20)
        Me.LblAmount.TabIndex = 17
        Me.LblAmount.Text = "Amount: "
        Me.LblAmount.Visible = False
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(100, 207)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(150, 26)
        Me.TxtAmount.TabIndex = 18
        Me.TxtAmount.Text = "0"
        Me.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtAmount.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 35)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Events"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(489, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAmount)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.GrpCategories)
        Me.Controls.Add(Me.DtpTime)
        Me.Controls.Add(Me.ChkTime)
        Me.Controls.Add(Me.BtnAddEventRecord)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormEvents"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GrpCategories.ResumeLayout(False)
        Me.GrpCategories.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnAddEventRecord As Button
    Friend WithEvents ChkTime As CheckBox
    Friend WithEvents DtpTime As DateTimePicker
    Friend WithEvents GrpCategories As GroupBox
    Friend WithEvents ChkOther As CheckBox
    Friend WithEvents ChkBirthday As CheckBox
    Friend WithEvents ChkBill As CheckBox
    Friend WithEvents ChkAppointment As CheckBox
    Friend WithEvents LblAmount As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents ChkStarred As CheckBox
    Friend WithEvents Label1 As Label
End Class
