<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MnuMain = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoronavirusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentEventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisDayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntertainmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetflixToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CboEventList = New System.Windows.Forms.ComboBox()
        Me.BtnAddEvent = New System.Windows.Forms.Button()
        Me.FlpEvents = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnSortEvent = New System.Windows.Forms.Button()
        Me.CboContactList = New System.Windows.Forms.ComboBox()
        Me.BtnAddContact = New System.Windows.Forms.Button()
        Me.FlpContacts = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnContactSort = New System.Windows.Forms.Button()
        Me.CboEventTime = New System.Windows.Forms.ComboBox()
        Me.LblMemos = New System.Windows.Forms.Label()
        Me.LblContacts = New System.Windows.Forms.Label()
        Me.LblEvents = New System.Windows.Forms.Label()
        Me.BtnAddMemo = New System.Windows.Forms.Button()
        Me.LstMemos = New System.Windows.Forms.ListBox()
        Me.MnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMain
        '
        Me.MnuMain.BackColor = System.Drawing.Color.LightBlue
        Me.MnuMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.BrowserToolStripMenuItem, Me.CalculatorToolStripMenuItem1})
        Me.MnuMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuMain.Name = "MnuMain"
        Me.MnuMain.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MnuMain.Size = New System.Drawing.Size(1429, 33)
        Me.MnuMain.TabIndex = 0
        Me.MnuMain.Text = "MenuStrip1"
        '
        'miFile
        '
        Me.miFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExit})
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(53, 29)
        Me.miFile.Text = "File"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(114, 30)
        Me.miExit.Text = "Exit"
        '
        'BrowserToolStripMenuItem
        '
        Me.BrowserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalendarToolStripMenuItem1, Me.CoronavirusToolStripMenuItem1, Me.CurrentEventsToolStripMenuItem, Me.EntertainmentToolStripMenuItem1, Me.MailToolStripMenuItem1})
        Me.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem"
        Me.BrowserToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.BrowserToolStripMenuItem.Text = "Browser"
        '
        'CalendarToolStripMenuItem1
        '
        Me.CalendarToolStripMenuItem1.Name = "CalendarToolStripMenuItem1"
        Me.CalendarToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.CalendarToolStripMenuItem1.Text = "Calendar"
        '
        'CoronavirusToolStripMenuItem1
        '
        Me.CoronavirusToolStripMenuItem1.Name = "CoronavirusToolStripMenuItem1"
        Me.CoronavirusToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.CoronavirusToolStripMenuItem1.Text = "Coronavirus"
        '
        'CurrentEventsToolStripMenuItem
        '
        Me.CurrentEventsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem2, Me.OnThisDayToolStripMenuItem1, Me.WeatherToolStripMenuItem})
        Me.CurrentEventsToolStripMenuItem.Name = "CurrentEventsToolStripMenuItem"
        Me.CurrentEventsToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.CurrentEventsToolStripMenuItem.Text = "Current Events"
        '
        'NewsToolStripMenuItem2
        '
        Me.NewsToolStripMenuItem2.Name = "NewsToolStripMenuItem2"
        Me.NewsToolStripMenuItem2.Size = New System.Drawing.Size(185, 30)
        Me.NewsToolStripMenuItem2.Text = "News"
        '
        'OnThisDayToolStripMenuItem1
        '
        Me.OnThisDayToolStripMenuItem1.Name = "OnThisDayToolStripMenuItem1"
        Me.OnThisDayToolStripMenuItem1.Size = New System.Drawing.Size(185, 30)
        Me.OnThisDayToolStripMenuItem1.Text = "On This Day"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'EntertainmentToolStripMenuItem1
        '
        Me.EntertainmentToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MusicToolStripMenuItem, Me.NetflixToolStripMenuItem1, Me.YouTubeToolStripMenuItem})
        Me.EntertainmentToolStripMenuItem1.Name = "EntertainmentToolStripMenuItem1"
        Me.EntertainmentToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.EntertainmentToolStripMenuItem1.Text = "Entertainment"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(157, 30)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'NetflixToolStripMenuItem1
        '
        Me.NetflixToolStripMenuItem1.Name = "NetflixToolStripMenuItem1"
        Me.NetflixToolStripMenuItem1.Size = New System.Drawing.Size(157, 30)
        Me.NetflixToolStripMenuItem1.Text = "Netflix"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(157, 30)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'MailToolStripMenuItem1
        '
        Me.MailToolStripMenuItem1.Name = "MailToolStripMenuItem1"
        Me.MailToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.MailToolStripMenuItem1.Text = "Mail"
        '
        'CalculatorToolStripMenuItem1
        '
        Me.CalculatorToolStripMenuItem1.Name = "CalculatorToolStripMenuItem1"
        Me.CalculatorToolStripMenuItem1.Size = New System.Drawing.Size(110, 29)
        Me.CalculatorToolStripMenuItem1.Text = "Calculator"
        '
        'LblClock
        '
        Me.LblClock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblClock.BackColor = System.Drawing.Color.LightBlue
        Me.LblClock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.Location = New System.Drawing.Point(463, 0)
        Me.LblClock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(417, 33)
        Me.LblClock.TabIndex = 1
        Me.LblClock.Text = "Date and Time Display"
        Me.LblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrClock
        '
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(924, 1)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(382, 33)
        Me.TxtSearch.TabIndex = 7
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackColor = System.Drawing.Color.Bisque
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(1326, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(91, 33)
        Me.BtnSearch.TabIndex = 8
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'CboEventList
        '
        Me.CboEventList.FormattingEnabled = True
        Me.CboEventList.Items.AddRange(New Object() {"All Lists", "Appointments", "Bills", "Birthdays", "Other", "Starred"})
        Me.CboEventList.Location = New System.Drawing.Point(32, 154)
        Me.CboEventList.Name = "CboEventList"
        Me.CboEventList.Size = New System.Drawing.Size(149, 33)
        Me.CboEventList.TabIndex = 14
        Me.CboEventList.Text = "All Lists"
        '
        'BtnAddEvent
        '
        Me.BtnAddEvent.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddEvent.Location = New System.Drawing.Point(157, 100)
        Me.BtnAddEvent.Name = "BtnAddEvent"
        Me.BtnAddEvent.Size = New System.Drawing.Size(139, 35)
        Me.BtnAddEvent.TabIndex = 11
        Me.BtnAddEvent.Text = "Add Event"
        Me.BtnAddEvent.UseVisualStyleBackColor = False
        '
        'FlpEvents
        '
        Me.FlpEvents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlpEvents.AutoScroll = True
        Me.FlpEvents.Location = New System.Drawing.Point(14, 194)
        Me.FlpEvents.Name = "FlpEvents"
        Me.FlpEvents.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.FlpEvents.Size = New System.Drawing.Size(443, 606)
        Me.FlpEvents.TabIndex = 13
        '
        'BtnSortEvent
        '
        Me.BtnSortEvent.BackColor = System.Drawing.Color.Bisque
        Me.BtnSortEvent.Location = New System.Drawing.Point(355, 153)
        Me.BtnSortEvent.Name = "BtnSortEvent"
        Me.BtnSortEvent.Size = New System.Drawing.Size(75, 35)
        Me.BtnSortEvent.TabIndex = 12
        Me.BtnSortEvent.Text = "Sort"
        Me.BtnSortEvent.UseVisualStyleBackColor = False
        '
        'CboContactList
        '
        Me.CboContactList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboContactList.FormattingEnabled = True
        Me.CboContactList.Items.AddRange(New Object() {"All Lists", "Acquaintance", "Business", "Family", "Friend", "Other", "Starred"})
        Me.CboContactList.Location = New System.Drawing.Point(981, 155)
        Me.CboContactList.Name = "CboContactList"
        Me.CboContactList.Size = New System.Drawing.Size(149, 33)
        Me.CboContactList.TabIndex = 19
        Me.CboContactList.Text = "All Lists"
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddContact.Location = New System.Drawing.Point(1123, 98)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(127, 35)
        Me.BtnAddContact.TabIndex = 16
        Me.BtnAddContact.Text = "Add Contact"
        Me.BtnAddContact.UseVisualStyleBackColor = False
        '
        'FlpContacts
        '
        Me.FlpContacts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlpContacts.AutoScroll = True
        Me.FlpContacts.Location = New System.Drawing.Point(964, 194)
        Me.FlpContacts.Name = "FlpContacts"
        Me.FlpContacts.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.FlpContacts.Size = New System.Drawing.Size(455, 606)
        Me.FlpContacts.TabIndex = 18
        '
        'BtnContactSort
        '
        Me.BtnContactSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnContactSort.BackColor = System.Drawing.Color.Bisque
        Me.BtnContactSort.Location = New System.Drawing.Point(1306, 153)
        Me.BtnContactSort.Name = "BtnContactSort"
        Me.BtnContactSort.Size = New System.Drawing.Size(75, 35)
        Me.BtnContactSort.TabIndex = 17
        Me.BtnContactSort.Text = "Sort"
        Me.BtnContactSort.UseVisualStyleBackColor = False
        '
        'CboEventTime
        '
        Me.CboEventTime.FormattingEnabled = True
        Me.CboEventTime.Items.AddRange(New Object() {"All Time", "Today", "Week", "Month", "Year"})
        Me.CboEventTime.Location = New System.Drawing.Point(187, 154)
        Me.CboEventTime.Name = "CboEventTime"
        Me.CboEventTime.Size = New System.Drawing.Size(109, 33)
        Me.CboEventTime.TabIndex = 21
        Me.CboEventTime.Text = "All Time"
        '
        'LblMemos
        '
        Me.LblMemos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblMemos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMemos.Location = New System.Drawing.Point(469, 195)
        Me.LblMemos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMemos.Name = "LblMemos"
        Me.LblMemos.Size = New System.Drawing.Size(468, 33)
        Me.LblMemos.TabIndex = 22
        Me.LblMemos.Text = "Memos"
        Me.LblMemos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblContacts
        '
        Me.LblContacts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblContacts.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContacts.Location = New System.Drawing.Point(956, 64)
        Me.LblContacts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContacts.Name = "LblContacts"
        Me.LblContacts.Size = New System.Drawing.Size(461, 33)
        Me.LblContacts.TabIndex = 23
        Me.LblContacts.Text = "Contacts"
        Me.LblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEvents
        '
        Me.LblEvents.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEvents.Location = New System.Drawing.Point(97, 64)
        Me.LblEvents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEvents.Name = "LblEvents"
        Me.LblEvents.Size = New System.Drawing.Size(264, 33)
        Me.LblEvents.TabIndex = 24
        Me.LblEvents.Text = "Events"
        Me.LblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddMemo
        '
        Me.BtnAddMemo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAddMemo.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddMemo.Location = New System.Drawing.Point(609, 416)
        Me.BtnAddMemo.Name = "BtnAddMemo"
        Me.BtnAddMemo.Size = New System.Drawing.Size(171, 36)
        Me.BtnAddMemo.TabIndex = 25
        Me.BtnAddMemo.Text = "Add Memo"
        Me.BtnAddMemo.UseVisualStyleBackColor = False
        '
        'LstMemos
        '
        Me.LstMemos.BackColor = System.Drawing.SystemColors.Window
        Me.LstMemos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LstMemos.FormattingEnabled = True
        Me.LstMemos.ItemHeight = 25
        Me.LstMemos.Location = New System.Drawing.Point(530, 231)
        Me.LstMemos.Name = "LstMemos"
        Me.LstMemos.Size = New System.Drawing.Size(341, 179)
        Me.LstMemos.TabIndex = 28
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1429, 831)
        Me.Controls.Add(Me.LstMemos)
        Me.Controls.Add(Me.BtnAddMemo)
        Me.Controls.Add(Me.LblEvents)
        Me.Controls.Add(Me.LblContacts)
        Me.Controls.Add(Me.LblMemos)
        Me.Controls.Add(Me.CboEventTime)
        Me.Controls.Add(Me.CboContactList)
        Me.Controls.Add(Me.BtnAddContact)
        Me.Controls.Add(Me.FlpContacts)
        Me.Controls.Add(Me.BtnContactSort)
        Me.Controls.Add(Me.CboEventList)
        Me.Controls.Add(Me.BtnAddEvent)
        Me.Controls.Add(Me.FlpEvents)
        Me.Controls.Add(Me.BtnSortEvent)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.LblClock)
        Me.Controls.Add(Me.MnuMain)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnuMain
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimumSize = New System.Drawing.Size(1445, 587)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPIM"
        Me.MnuMain.ResumeLayout(False)
        Me.MnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuMain As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents LblClock As Label
    Friend WithEvents TmrClock As Timer
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CboEventList As ComboBox
    Friend WithEvents BtnAddEvent As Button
    Friend WithEvents FlpEvents As FlowLayoutPanel
    Friend WithEvents BtnSortEvent As Button
    Friend WithEvents CboContactList As ComboBox
    Friend WithEvents BtnAddContact As Button
    Friend WithEvents FlpContacts As FlowLayoutPanel
    Friend WithEvents BtnContactSort As Button
    Friend WithEvents CboEventTime As ComboBox
    Friend WithEvents LblMemos As Label
    Friend WithEvents LblContacts As Label
    Friend WithEvents LblEvents As Label
    Friend WithEvents BtnAddMemo As Button
    Friend WithEvents BrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalendarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoronavirusToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CurrentEventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents OnThisDayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntertainmentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NetflixToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LstMemos As ListBox
End Class
