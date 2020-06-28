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
        Me.mmMain = New System.Windows.Forms.MenuStrip()
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
        Me.lblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboEventList = New System.Windows.Forms.ComboBox()
        Me.btnTrackerAdd = New System.Windows.Forms.Button()
        Me.flpTracker = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.cboContact = New System.Windows.Forms.ComboBox()
        Me.BtnAddContact = New System.Windows.Forms.Button()
        Me.flpContact = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnContactSort = New System.Windows.Forms.Button()
        Me.cboEventTime = New System.Windows.Forms.ComboBox()
        Me.lblMemos = New System.Windows.Forms.Label()
        Me.lblContacts = New System.Windows.Forms.Label()
        Me.lblTrackers = New System.Windows.Forms.Label()
        Me.btnAddMemo = New System.Windows.Forms.Button()
        Me.cboMemos = New System.Windows.Forms.ComboBox()
        Me.mmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmMain
        '
        Me.mmMain.BackColor = System.Drawing.Color.LightBlue
        Me.mmMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.BrowserToolStripMenuItem, Me.CalculatorToolStripMenuItem1})
        Me.mmMain.Location = New System.Drawing.Point(0, 0)
        Me.mmMain.Name = "mmMain"
        Me.mmMain.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mmMain.Size = New System.Drawing.Size(1429, 33)
        Me.mmMain.TabIndex = 0
        Me.mmMain.Text = "MenuStrip1"
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
        'lblClock
        '
        Me.lblClock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblClock.BackColor = System.Drawing.Color.LightBlue
        Me.lblClock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(463, 0)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(417, 33)
        Me.lblClock.TabIndex = 1
        Me.lblClock.Text = "Date and Time Display"
        Me.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrClock
        '
        '
        'txbSearch
        '
        Me.txbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbSearch.Location = New System.Drawing.Point(924, 1)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(382, 33)
        Me.txbSearch.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.Bisque
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1326, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 33)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboEventList
        '
        Me.cboEventList.FormattingEnabled = True
        Me.cboEventList.Items.AddRange(New Object() {"All Lists", "Appointments", "Bills", "Birthdays", "Other", "Starred"})
        Me.cboEventList.Location = New System.Drawing.Point(32, 154)
        Me.cboEventList.Name = "cboEventList"
        Me.cboEventList.Size = New System.Drawing.Size(149, 33)
        Me.cboEventList.TabIndex = 14
        Me.cboEventList.Text = "All Lists"
        '
        'btnTrackerAdd
        '
        Me.btnTrackerAdd.BackColor = System.Drawing.Color.Bisque
        Me.btnTrackerAdd.Location = New System.Drawing.Point(157, 100)
        Me.btnTrackerAdd.Name = "btnTrackerAdd"
        Me.btnTrackerAdd.Size = New System.Drawing.Size(139, 35)
        Me.btnTrackerAdd.TabIndex = 11
        Me.btnTrackerAdd.Text = "Add Event"
        Me.btnTrackerAdd.UseVisualStyleBackColor = False
        '
        'flpTracker
        '
        Me.flpTracker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpTracker.AutoScroll = True
        Me.flpTracker.Location = New System.Drawing.Point(14, 194)
        Me.flpTracker.Name = "flpTracker"
        Me.flpTracker.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpTracker.Size = New System.Drawing.Size(443, 606)
        Me.flpTracker.TabIndex = 13
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.Bisque
        Me.btnSort.Location = New System.Drawing.Point(355, 153)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 35)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'cboContact
        '
        Me.cboContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContact.FormattingEnabled = True
        Me.cboContact.Items.AddRange(New Object() {"All Lists", "Acquaintance", "Business", "Family", "Friend", "Other", "Starred"})
        Me.cboContact.Location = New System.Drawing.Point(972, 155)
        Me.cboContact.Name = "cboContact"
        Me.cboContact.Size = New System.Drawing.Size(149, 33)
        Me.cboContact.TabIndex = 19
        Me.cboContact.Text = "All Lists"
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddContact.Location = New System.Drawing.Point(1114, 98)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(127, 35)
        Me.BtnAddContact.TabIndex = 16
        Me.BtnAddContact.Text = "Add Contact"
        Me.BtnAddContact.UseVisualStyleBackColor = False
        '
        'flpContact
        '
        Me.flpContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContact.AutoScroll = True
        Me.flpContact.Location = New System.Drawing.Point(955, 194)
        Me.flpContact.Name = "flpContact"
        Me.flpContact.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpContact.Size = New System.Drawing.Size(455, 615)
        Me.flpContact.TabIndex = 18
        '
        'btnContactSort
        '
        Me.btnContactSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContactSort.BackColor = System.Drawing.Color.Bisque
        Me.btnContactSort.Location = New System.Drawing.Point(1297, 153)
        Me.btnContactSort.Name = "btnContactSort"
        Me.btnContactSort.Size = New System.Drawing.Size(75, 35)
        Me.btnContactSort.TabIndex = 17
        Me.btnContactSort.Text = "Sort"
        Me.btnContactSort.UseVisualStyleBackColor = False
        '
        'cboEventTime
        '
        Me.cboEventTime.FormattingEnabled = True
        Me.cboEventTime.Items.AddRange(New Object() {"All Time", "Today", "Week", "Month", "Year"})
        Me.cboEventTime.Location = New System.Drawing.Point(187, 154)
        Me.cboEventTime.Name = "cboEventTime"
        Me.cboEventTime.Size = New System.Drawing.Size(109, 33)
        Me.cboEventTime.TabIndex = 21
        Me.cboEventTime.Text = "All Time"
        '
        'lblMemos
        '
        Me.lblMemos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemos.Location = New System.Drawing.Point(478, 64)
        Me.lblMemos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemos.Name = "lblMemos"
        Me.lblMemos.Size = New System.Drawing.Size(468, 33)
        Me.lblMemos.TabIndex = 22
        Me.lblMemos.Text = "Memos"
        Me.lblMemos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContacts
        '
        Me.lblContacts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContacts.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacts.Location = New System.Drawing.Point(947, 64)
        Me.lblContacts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(461, 33)
        Me.lblContacts.TabIndex = 23
        Me.lblContacts.Text = "Contacts"
        Me.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrackers
        '
        Me.lblTrackers.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrackers.Location = New System.Drawing.Point(97, 64)
        Me.lblTrackers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTrackers.Name = "lblTrackers"
        Me.lblTrackers.Size = New System.Drawing.Size(264, 33)
        Me.lblTrackers.TabIndex = 24
        Me.lblTrackers.Text = "Events"
        Me.lblTrackers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddMemo
        '
        Me.btnAddMemo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddMemo.BackColor = System.Drawing.Color.Bisque
        Me.btnAddMemo.Location = New System.Drawing.Point(616, 100)
        Me.btnAddMemo.Name = "btnAddMemo"
        Me.btnAddMemo.Size = New System.Drawing.Size(171, 36)
        Me.btnAddMemo.TabIndex = 25
        Me.btnAddMemo.Text = "Add Memo"
        Me.btnAddMemo.UseVisualStyleBackColor = False
        '
        'cboMemos
        '
        Me.cboMemos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMemos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cboMemos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMemos.ForeColor = System.Drawing.Color.White
        Me.cboMemos.FormattingEnabled = True
        Me.cboMemos.Location = New System.Drawing.Point(539, 194)
        Me.cboMemos.Name = "cboMemos"
        Me.cboMemos.Size = New System.Drawing.Size(341, 635)
        Me.cboMemos.TabIndex = 27
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1429, 831)
        Me.Controls.Add(Me.cboMemos)
        Me.Controls.Add(Me.btnAddMemo)
        Me.Controls.Add(Me.lblTrackers)
        Me.Controls.Add(Me.lblContacts)
        Me.Controls.Add(Me.lblMemos)
        Me.Controls.Add(Me.cboEventTime)
        Me.Controls.Add(Me.cboContact)
        Me.Controls.Add(Me.BtnAddContact)
        Me.Controls.Add(Me.flpContact)
        Me.Controls.Add(Me.btnContactSort)
        Me.Controls.Add(Me.cboEventList)
        Me.Controls.Add(Me.btnTrackerAdd)
        Me.Controls.Add(Me.flpTracker)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txbSearch)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.mmMain)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mmMain
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimumSize = New System.Drawing.Size(1445, 587)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPIM"
        Me.mmMain.ResumeLayout(False)
        Me.mmMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mmMain As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents lblClock As Label
    Friend WithEvents TmrClock As Timer
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cboEventList As ComboBox
    Friend WithEvents btnTrackerAdd As Button
    Friend WithEvents flpTracker As FlowLayoutPanel
    Friend WithEvents btnSort As Button
    Friend WithEvents cboContact As ComboBox
    Friend WithEvents BtnAddContact As Button
    Friend WithEvents flpContact As FlowLayoutPanel
    Friend WithEvents btnContactSort As Button
    Friend WithEvents cboEventTime As ComboBox
    Friend WithEvents lblMemos As Label
    Friend WithEvents lblContacts As Label
    Friend WithEvents lblTrackers As Label
    Friend WithEvents btnAddMemo As Button
    Friend WithEvents cboMemos As ComboBox
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
End Class
