<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContacts
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
        Me.BtnExitContact = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblCity = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblBirthday = New System.Windows.Forms.Label()
        Me.LblNotes = New System.Windows.Forms.Label()
        Me.LblZipcode = New System.Windows.Forms.Label()
        Me.CboState = New System.Windows.Forms.ComboBox()
        Me.LblState = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtBirthdate = New System.Windows.Forms.MaskedTextBox()
        Me.TxtZipcode = New System.Windows.Forms.MaskedTextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxTMiddleName = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.CboGroups = New System.Windows.Forms.ComboBox()
        Me.LblGroups = New System.Windows.Forms.Label()
        Me.BtnAddContact = New System.Windows.Forms.Button()
        Me.TxtCompany = New System.Windows.Forms.TextBox()
        Me.LblCompany = New System.Windows.Forms.Label()
        Me.ChkStarred = New System.Windows.Forms.CheckBox()
        Me.LblContacts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExitContact
        '
        Me.BtnExitContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExitContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnExitContact.Location = New System.Drawing.Point(568, 562)
        Me.BtnExitContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExitContact.Name = "BtnExitContact"
        Me.BtnExitContact.Size = New System.Drawing.Size(107, 38)
        Me.BtnExitContact.TabIndex = 15
        Me.BtnExitContact.Text = "Exit"
        Me.BtnExitContact.UseVisualStyleBackColor = False
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(31, 89)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(59, 21)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name: "
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(19, 154)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(73, 21)
        Me.LblAddress.TabIndex = 2
        Me.LblAddress.Text = "Address: "
        Me.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.Location = New System.Drawing.Point(48, 221)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(44, 21)
        Me.LblCity.TabIndex = 3
        Me.LblCity.Text = "City: "
        Me.LblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Location = New System.Drawing.Point(33, 255)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(61, 21)
        Me.LblPhone.TabIndex = 4
        Me.LblPhone.Text = "Phone: "
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(267, 255)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(55, 21)
        Me.LblEmail.TabIndex = 5
        Me.LblEmail.Text = "Email: "
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblBirthday
        '
        Me.LblBirthday.AutoSize = True
        Me.LblBirthday.Location = New System.Drawing.Point(14, 284)
        Me.LblBirthday.Name = "LblBirthday"
        Me.LblBirthday.Size = New System.Drawing.Size(80, 21)
        Me.LblBirthday.TabIndex = 6
        Me.LblBirthday.Text = "Birthdate: "
        Me.LblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNotes
        '
        Me.LblNotes.AutoSize = True
        Me.LblNotes.Location = New System.Drawing.Point(31, 317)
        Me.LblNotes.Name = "LblNotes"
        Me.LblNotes.Size = New System.Drawing.Size(58, 21)
        Me.LblNotes.TabIndex = 7
        Me.LblNotes.Text = "Notes: "
        Me.LblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblZipcode
        '
        Me.LblZipcode.AutoSize = True
        Me.LblZipcode.Location = New System.Drawing.Point(446, 221)
        Me.LblZipcode.Name = "LblZipcode"
        Me.LblZipcode.Size = New System.Drawing.Size(72, 21)
        Me.LblZipcode.TabIndex = 8
        Me.LblZipcode.Text = "Zipcode: "
        Me.LblZipcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboState
        '
        Me.CboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboState.FormattingEnabled = True
        Me.CboState.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WI", "WV", "WY", "AS", "FM", "GU", "MH", "MP", "PR", "PW", "VI"})
        Me.CboState.Location = New System.Drawing.Point(385, 220)
        Me.CboState.Name = "CboState"
        Me.CboState.Size = New System.Drawing.Size(55, 29)
        Me.CboState.TabIndex = 7
        '
        'LblState
        '
        Me.LblState.AutoSize = True
        Me.LblState.Location = New System.Drawing.Point(332, 221)
        Me.LblState.Name = "LblState"
        Me.LblState.Size = New System.Drawing.Size(51, 21)
        Me.LblState.TabIndex = 10
        Me.LblState.Text = "State: "
        Me.LblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNotes
        '
        Me.TxtNotes.AcceptsReturn = True
        Me.TxtNotes.Location = New System.Drawing.Point(100, 317)
        Me.TxtNotes.MaxLength = 30
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(507, 162)
        Me.TxtNotes.TabIndex = 13
        '
        'TxtBirthdate
        '
        Me.TxtBirthdate.Location = New System.Drawing.Point(100, 284)
        Me.TxtBirthdate.Mask = "00/00/0000 90:00"
        Me.TxtBirthdate.Name = "TxtBirthdate"
        Me.TxtBirthdate.Size = New System.Drawing.Size(150, 29)
        Me.TxtBirthdate.TabIndex = 11
        Me.TxtBirthdate.ValidatingType = GetType(Date)
        '
        'TxtZipcode
        '
        Me.TxtZipcode.Location = New System.Drawing.Point(524, 218)
        Me.TxtZipcode.Mask = "00000-9999"
        Me.TxtZipcode.Name = "TxtZipcode"
        Me.TxtZipcode.Size = New System.Drawing.Size(83, 29)
        Me.TxtZipcode.TabIndex = 8
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(100, 86)
        Me.TxtFirstName.MaxLength = 10
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(165, 29)
        Me.TxtFirstName.TabIndex = 0
        '
        'TxTMiddleName
        '
        Me.TxTMiddleName.Location = New System.Drawing.Point(271, 86)
        Me.TxTMiddleName.MaxLength = 10
        Me.TxTMiddleName.Name = "TxTMiddleName"
        Me.TxTMiddleName.Size = New System.Drawing.Size(165, 29)
        Me.TxTMiddleName.TabIndex = 1
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(442, 86)
        Me.TxtLastName.MaxLength = 10
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(165, 29)
        Me.TxtLastName.TabIndex = 2
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(100, 152)
        Me.TxtAddress1.MaxLength = 30
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(507, 29)
        Me.TxtAddress1.TabIndex = 4
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(100, 185)
        Me.TxtAddress2.MaxLength = 30
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(507, 29)
        Me.TxtAddress2.TabIndex = 5
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(100, 251)
        Me.TxtPhone.Mask = "(999) 000-0000"
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(150, 29)
        Me.TxtPhone.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(328, 251)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(279, 29)
        Me.TxtEmail.TabIndex = 10
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(100, 218)
        Me.TxtCity.MaxLength = 15
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(226, 29)
        Me.TxtCity.TabIndex = 6
        '
        'CboGroups
        '
        Me.CboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGroups.FormattingEnabled = True
        Me.CboGroups.Items.AddRange(New Object() {"Acquaintance", "Business", "Family", "Friend", "Other"})
        Me.CboGroups.Location = New System.Drawing.Point(328, 284)
        Me.CboGroups.MaxDropDownItems = 25
        Me.CboGroups.Name = "CboGroups"
        Me.CboGroups.Size = New System.Drawing.Size(279, 29)
        Me.CboGroups.Sorted = True
        Me.CboGroups.TabIndex = 12
        '
        'LblGroups
        '
        Me.LblGroups.AutoSize = True
        Me.LblGroups.Location = New System.Drawing.Point(254, 287)
        Me.LblGroups.Name = "LblGroups"
        Me.LblGroups.Size = New System.Drawing.Size(68, 21)
        Me.LblGroups.TabIndex = 14
        Me.LblGroups.Text = "Groups: "
        Me.LblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddContact.Location = New System.Drawing.Point(100, 485)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(127, 38)
        Me.BtnAddContact.TabIndex = 14
        Me.BtnAddContact.Text = "Add"
        Me.BtnAddContact.UseVisualStyleBackColor = False
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(100, 119)
        Me.TxtCompany.MaxLength = 30
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(507, 29)
        Me.TxtCompany.TabIndex = 3
        '
        'LblCompany
        '
        Me.LblCompany.AutoSize = True
        Me.LblCompany.Location = New System.Drawing.Point(10, 121)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(84, 21)
        Me.LblCompany.TabIndex = 16
        Me.LblCompany.Text = "Company: "
        Me.LblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkStarred
        '
        Me.ChkStarred.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkStarred.BackColor = System.Drawing.Color.OldLace
        Me.ChkStarred.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ChkStarred.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkStarred.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkStarred.Location = New System.Drawing.Point(233, 484)
        Me.ChkStarred.Name = "ChkStarred"
        Me.ChkStarred.Size = New System.Drawing.Size(108, 38)
        Me.ChkStarred.TabIndex = 17
        Me.ChkStarred.Text = "Starred"
        Me.ChkStarred.UseVisualStyleBackColor = False
        '
        'LblContacts
        '
        Me.LblContacts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblContacts.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContacts.Location = New System.Drawing.Point(100, 14)
        Me.LblContacts.Name = "LblContacts"
        Me.LblContacts.Size = New System.Drawing.Size(485, 38)
        Me.LblContacts.TabIndex = 18
        Me.LblContacts.Text = "Contacts"
        Me.LblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(688, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblContacts)
        Me.Controls.Add(Me.ChkStarred)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.LblCompany)
        Me.Controls.Add(Me.BtnAddContact)
        Me.Controls.Add(Me.LblGroups)
        Me.Controls.Add(Me.CboGroups)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtAddress2)
        Me.Controls.Add(Me.TxtAddress1)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.TxTMiddleName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.TxtZipcode)
        Me.Controls.Add(Me.TxtBirthdate)
        Me.Controls.Add(Me.TxtNotes)
        Me.Controls.Add(Me.LblState)
        Me.Controls.Add(Me.CboState)
        Me.Controls.Add(Me.LblZipcode)
        Me.Controls.Add(Me.LblNotes)
        Me.Controls.Add(Me.LblBirthday)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.LblCity)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnExitContact)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormContacts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExitContact As Button
    Friend WithEvents LblName As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblCity As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblBirthday As Label
    Friend WithEvents LblNotes As Label
    Friend WithEvents LblZipcode As Label
    Friend WithEvents CboState As ComboBox
    Friend WithEvents LblState As Label
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TxtBirthdate As MaskedTextBox
    Friend WithEvents TxtZipcode As MaskedTextBox
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents TxTMiddleName As TextBox
    Friend WithEvents TxtLastName As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtPhone As MaskedTextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents CboGroups As ComboBox
    Friend WithEvents LblGroups As Label
    Friend WithEvents BtnAddContact As Button
    Friend WithEvents TxtCompany As TextBox
    Friend WithEvents LblCompany As Label
    Friend WithEvents ChkStarred As CheckBox
    Friend WithEvents LblContacts As Label
End Class
