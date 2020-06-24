<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContacts
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lblZipcode = New System.Windows.Forms.Label()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.tbxNotes = New System.Windows.Forms.TextBox()
        Me.mtbBirthdate = New System.Windows.Forms.MaskedTextBox()
        Me.mtbZipcode = New System.Windows.Forms.MaskedTextBox()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.tbxMiddleName = New System.Windows.Forms.TextBox()
        Me.tbxLastName = New System.Windows.Forms.TextBox()
        Me.tbxAddress1 = New System.Windows.Forms.TextBox()
        Me.tbxAddress2 = New System.Windows.Forms.TextBox()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.tbxCity = New System.Windows.Forms.TextBox()
        Me.cbxGroups = New System.Windows.Forms.ComboBox()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.btnSaveContactRecord = New System.Windows.Forms.Button()
        Me.tbxCompany = New System.Windows.Forms.TextBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Bisque
        Me.btnExit.Location = New System.Drawing.Point(614, 374)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 38)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(48, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 21)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name: "
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(36, 105)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(73, 21)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address: "
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(65, 172)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(44, 21)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City: "
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(50, 206)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(61, 21)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone: "
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(284, 206)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 21)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email: "
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(31, 235)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(80, 21)
        Me.lblBirthday.TabIndex = 6
        Me.lblBirthday.Text = "Birthdate: "
        Me.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(25, 271)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(86, 21)
        Me.lblNotes.TabIndex = 7
        Me.lblNotes.Text = "Comment: "
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblZipcode
        '
        Me.lblZipcode.AutoSize = True
        Me.lblZipcode.Location = New System.Drawing.Point(463, 172)
        Me.lblZipcode.Name = "lblZipcode"
        Me.lblZipcode.Size = New System.Drawing.Size(72, 21)
        Me.lblZipcode.TabIndex = 8
        Me.lblZipcode.Text = "Zipcode: "
        Me.lblZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxState
        '
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WI", "WV", "WY", "AS", "FM", "GU", "MH", "MP", "PR", "PW", "VI"})
        Me.cbxState.Location = New System.Drawing.Point(402, 171)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(55, 29)
        Me.cbxState.TabIndex = 7
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(349, 172)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(51, 21)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State: "
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxNotes
        '
        Me.tbxNotes.Location = New System.Drawing.Point(117, 268)
        Me.tbxNotes.MaxLength = 30
        Me.tbxNotes.Name = "tbxNotes"
        Me.tbxNotes.Size = New System.Drawing.Size(507, 29)
        Me.tbxNotes.TabIndex = 13
        '
        'mtbBirthdate
        '
        Me.mtbBirthdate.Location = New System.Drawing.Point(117, 235)
        Me.mtbBirthdate.Mask = "00/00/0000 90:00"
        Me.mtbBirthdate.Name = "mtbBirthdate"
        Me.mtbBirthdate.Size = New System.Drawing.Size(150, 29)
        Me.mtbBirthdate.TabIndex = 11
        Me.mtbBirthdate.ValidatingType = GetType(Date)
        '
        'mtbZipcode
        '
        Me.mtbZipcode.Location = New System.Drawing.Point(541, 169)
        Me.mtbZipcode.Mask = "00000-9999"
        Me.mtbZipcode.Name = "mtbZipcode"
        Me.mtbZipcode.Size = New System.Drawing.Size(83, 29)
        Me.mtbZipcode.TabIndex = 8
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Location = New System.Drawing.Point(117, 37)
        Me.tbxFirstName.MaxLength = 10
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(165, 29)
        Me.tbxFirstName.TabIndex = 0
        '
        'tbxMiddleName
        '
        Me.tbxMiddleName.Location = New System.Drawing.Point(288, 37)
        Me.tbxMiddleName.MaxLength = 10
        Me.tbxMiddleName.Name = "tbxMiddleName"
        Me.tbxMiddleName.Size = New System.Drawing.Size(165, 29)
        Me.tbxMiddleName.TabIndex = 1
        '
        'tbxLastName
        '
        Me.tbxLastName.Location = New System.Drawing.Point(459, 37)
        Me.tbxLastName.MaxLength = 10
        Me.tbxLastName.Name = "tbxLastName"
        Me.tbxLastName.Size = New System.Drawing.Size(165, 29)
        Me.tbxLastName.TabIndex = 2
        '
        'tbxAddress1
        '
        Me.tbxAddress1.Location = New System.Drawing.Point(117, 103)
        Me.tbxAddress1.MaxLength = 30
        Me.tbxAddress1.Name = "tbxAddress1"
        Me.tbxAddress1.Size = New System.Drawing.Size(507, 29)
        Me.tbxAddress1.TabIndex = 4
        '
        'tbxAddress2
        '
        Me.tbxAddress2.Location = New System.Drawing.Point(117, 136)
        Me.tbxAddress2.MaxLength = 30
        Me.tbxAddress2.Name = "tbxAddress2"
        Me.tbxAddress2.Size = New System.Drawing.Size(507, 29)
        Me.tbxAddress2.TabIndex = 5
        '
        'mtbPhone
        '
        Me.mtbPhone.Location = New System.Drawing.Point(117, 202)
        Me.mtbPhone.Mask = "(999) 000-0000"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(150, 29)
        Me.mtbPhone.TabIndex = 9
        '
        'tbxEmail
        '
        Me.tbxEmail.Location = New System.Drawing.Point(345, 202)
        Me.tbxEmail.MaxLength = 30
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(279, 29)
        Me.tbxEmail.TabIndex = 10
        '
        'tbxCity
        '
        Me.tbxCity.Location = New System.Drawing.Point(117, 169)
        Me.tbxCity.MaxLength = 10
        Me.tbxCity.Name = "tbxCity"
        Me.tbxCity.Size = New System.Drawing.Size(226, 29)
        Me.tbxCity.TabIndex = 6
        '
        'cbxGroups
        '
        Me.cbxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGroups.FormattingEnabled = True
        Me.cbxGroups.Items.AddRange(New Object() {"Acquaintance", "Business", "Family", "Friend", "Other"})
        Me.cbxGroups.Location = New System.Drawing.Point(345, 235)
        Me.cbxGroups.MaxDropDownItems = 25
        Me.cbxGroups.Name = "cbxGroups"
        Me.cbxGroups.Size = New System.Drawing.Size(279, 29)
        Me.cbxGroups.Sorted = True
        Me.cbxGroups.TabIndex = 12
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.Location = New System.Drawing.Point(271, 238)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(68, 21)
        Me.lblGroups.TabIndex = 14
        Me.lblGroups.Text = "Groups: "
        Me.lblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSaveContactRecord
        '
        Me.btnSaveContactRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveContactRecord.BackColor = System.Drawing.Color.Bisque
        Me.btnSaveContactRecord.Location = New System.Drawing.Point(117, 314)
        Me.btnSaveContactRecord.Name = "btnSaveContactRecord"
        Me.btnSaveContactRecord.Size = New System.Drawing.Size(127, 38)
        Me.btnSaveContactRecord.TabIndex = 14
        Me.btnSaveContactRecord.Text = "Add"
        Me.btnSaveContactRecord.UseVisualStyleBackColor = False
        '
        'tbxCompany
        '
        Me.tbxCompany.Location = New System.Drawing.Point(117, 70)
        Me.tbxCompany.MaxLength = 30
        Me.tbxCompany.Name = "tbxCompany"
        Me.tbxCompany.Size = New System.Drawing.Size(507, 29)
        Me.tbxCompany.TabIndex = 3
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(27, 72)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(84, 21)
        Me.lblCompany.TabIndex = 16
        Me.lblCompany.Text = "Company: "
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(734, 426)
        Me.Controls.Add(Me.tbxCompany)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.btnSaveContactRecord)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.cbxGroups)
        Me.Controls.Add(Me.tbxCity)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.mtbPhone)
        Me.Controls.Add(Me.tbxAddress2)
        Me.Controls.Add(Me.tbxAddress1)
        Me.Controls.Add(Me.tbxLastName)
        Me.Controls.Add(Me.tbxMiddleName)
        Me.Controls.Add(Me.tbxFirstName)
        Me.Controls.Add(Me.mtbZipcode)
        Me.Controls.Add(Me.mtbBirthdate)
        Me.Controls.Add(Me.tbxNotes)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.cbxState)
        Me.Controls.Add(Me.lblZipcode)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblNotes As Label
    Friend WithEvents lblZipcode As Label
    Friend WithEvents cbxState As ComboBox
    Friend WithEvents lblState As Label
    Friend WithEvents tbxNotes As TextBox
    Friend WithEvents mtbBirthdate As MaskedTextBox
    Friend WithEvents mtbZipcode As MaskedTextBox
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents tbxMiddleName As TextBox
    Friend WithEvents tbxLastName As TextBox
    Friend WithEvents tbxAddress1 As TextBox
    Friend WithEvents tbxAddress2 As TextBox
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxCity As TextBox
    Friend WithEvents cbxGroups As ComboBox
    Friend WithEvents lblGroups As Label
    Friend WithEvents btnSaveContactRecord As Button
    Friend WithEvents tbxCompany As TextBox
    Friend WithEvents lblCompany As Label
End Class
