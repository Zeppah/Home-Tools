<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTracker
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.tbxDescription = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnAddTrackerRecord = New System.Windows.Forms.Button()
        Me.cbxTime = New System.Windows.Forms.CheckBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.gbxCategories = New System.Windows.Forms.GroupBox()
        Me.cbxOther = New System.Windows.Forms.CheckBox()
        Me.cbxBirthday = New System.Windows.Forms.CheckBox()
        Me.cbxBill = New System.Windows.Forms.CheckBox()
        Me.cbxAppointment = New System.Windows.Forms.CheckBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.tbxAmount = New System.Windows.Forms.TextBox()
        Me.gbxCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(411, 229)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(15, 52)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(122, 30)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date: "
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(8, 14)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(129, 30)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description: "
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxDescription
        '
        Me.tbxDescription.Location = New System.Drawing.Point(143, 16)
        Me.tbxDescription.Name = "tbxDescription"
        Me.tbxDescription.Size = New System.Drawing.Size(337, 26)
        Me.tbxDescription.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MM/dd/yyyy hh:mm"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(143, 52)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(150, 26)
        Me.dtpDate.TabIndex = 1
        '
        'btnAddTrackerRecord
        '
        Me.btnAddTrackerRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddTrackerRecord.Location = New System.Drawing.Point(143, 184)
        Me.btnAddTrackerRecord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddTrackerRecord.Name = "btnAddTrackerRecord"
        Me.btnAddTrackerRecord.Size = New System.Drawing.Size(112, 36)
        Me.btnAddTrackerRecord.TabIndex = 4
        Me.btnAddTrackerRecord.Text = "Add"
        Me.btnAddTrackerRecord.UseVisualStyleBackColor = True
        '
        'cbxTime
        '
        Me.cbxTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbxTime.Location = New System.Drawing.Point(80, 92)
        Me.cbxTime.Name = "cbxTime"
        Me.cbxTime.Size = New System.Drawing.Size(80, 26)
        Me.cbxTime.TabIndex = 2
        Me.cbxTime.Text = "Time:          "
        Me.cbxTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbxTime.UseVisualStyleBackColor = True
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(175, 92)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(118, 26)
        Me.dtpTime.TabIndex = 15
        Me.dtpTime.Value = New Date(2020, 6, 16, 12, 0, 0, 0)
        Me.dtpTime.Visible = False
        '
        'gbxCategories
        '
        Me.gbxCategories.BackColor = System.Drawing.Color.Cyan
        Me.gbxCategories.Controls.Add(Me.cbxOther)
        Me.gbxCategories.Controls.Add(Me.cbxBirthday)
        Me.gbxCategories.Controls.Add(Me.cbxBill)
        Me.gbxCategories.Controls.Add(Me.cbxAppointment)
        Me.gbxCategories.Location = New System.Drawing.Point(323, 52)
        Me.gbxCategories.Name = "gbxCategories"
        Me.gbxCategories.Size = New System.Drawing.Size(157, 143)
        Me.gbxCategories.TabIndex = 3
        Me.gbxCategories.TabStop = False
        '
        'cbxOther
        '
        Me.cbxOther.AutoSize = True
        Me.cbxOther.Location = New System.Drawing.Point(21, 106)
        Me.cbxOther.Name = "cbxOther"
        Me.cbxOther.Size = New System.Drawing.Size(68, 24)
        Me.cbxOther.TabIndex = 3
        Me.cbxOther.Text = "Other"
        Me.cbxOther.UseVisualStyleBackColor = True
        '
        'cbxBirthday
        '
        Me.cbxBirthday.AutoSize = True
        Me.cbxBirthday.Location = New System.Drawing.Point(21, 76)
        Me.cbxBirthday.Name = "cbxBirthday"
        Me.cbxBirthday.Size = New System.Drawing.Size(86, 24)
        Me.cbxBirthday.TabIndex = 2
        Me.cbxBirthday.Text = "Birthday"
        Me.cbxBirthday.UseVisualStyleBackColor = True
        '
        'cbxBill
        '
        Me.cbxBill.AutoSize = True
        Me.cbxBill.Location = New System.Drawing.Point(21, 46)
        Me.cbxBill.Name = "cbxBill"
        Me.cbxBill.Size = New System.Drawing.Size(48, 24)
        Me.cbxBill.TabIndex = 1
        Me.cbxBill.Text = "Bill"
        Me.cbxBill.UseVisualStyleBackColor = True
        '
        'cbxAppointment
        '
        Me.cbxAppointment.AutoSize = True
        Me.cbxAppointment.Location = New System.Drawing.Point(21, 16)
        Me.cbxAppointment.Name = "cbxAppointment"
        Me.cbxAppointment.Size = New System.Drawing.Size(119, 24)
        Me.cbxAppointment.TabIndex = 0
        Me.cbxAppointment.Text = "Appointment"
        Me.cbxAppointment.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(21, 134)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(116, 20)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "Enter Amount: "
        Me.lblAmount.Visible = False
        '
        'tbxAmount
        '
        Me.tbxAmount.Location = New System.Drawing.Point(143, 128)
        Me.tbxAmount.Name = "tbxAmount"
        Me.tbxAmount.Size = New System.Drawing.Size(150, 26)
        Me.tbxAmount.TabIndex = 18
        Me.tbxAmount.Text = "0"
        Me.tbxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbxAmount.Visible = False
        '
        'FrmTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(529, 273)
        Me.Controls.Add(Me.tbxAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.gbxCategories)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.cbxTime)
        Me.Controls.Add(Me.btnAddTrackerRecord)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.tbxDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmTracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tracker - Add"
        Me.gbxCategories.ResumeLayout(False)
        Me.gbxCategories.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents tbxDescription As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnAddTrackerRecord As Button
    Friend WithEvents cbxTime As CheckBox
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents gbxCategories As GroupBox
    Friend WithEvents cbxOther As CheckBox
    Friend WithEvents cbxBirthday As CheckBox
    Friend WithEvents cbxBill As CheckBox
    Friend WithEvents cbxAppointment As CheckBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents tbxAmount As TextBox
End Class
