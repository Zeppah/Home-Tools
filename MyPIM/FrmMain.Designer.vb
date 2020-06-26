<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txbRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(txbRun))
        Me.mmMain = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTracker = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CoronavirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntertainmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetFlixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboTracker = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.flpTracker = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.cboContact = New System.Windows.Forms.ComboBox()
        Me.BtnAddContact = New System.Windows.Forms.Button()
        Me.flpContact = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnContactSort = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboTrackerTime = New System.Windows.Forms.ComboBox()
        Me.lblMemos = New System.Windows.Forms.Label()
        Me.lblContacts = New System.Windows.Forms.Label()
        Me.lblTrackers = New System.Windows.Forms.Label()
        Me.btnAddMemo = New System.Windows.Forms.Button()
        Me.cboMemos = New System.Windows.Forms.ComboBox()
        Me.mmMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmMain
        '
        Me.mmMain.BackColor = System.Drawing.Color.LightBlue
        Me.mmMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.Form1ToolStripMenuItem, Me.MemosToolStripMenuItem, Me.miTracker})
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
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.Form1ToolStripMenuItem.Text = "Contacts"
        '
        'MemosToolStripMenuItem
        '
        Me.MemosToolStripMenuItem.Name = "MemosToolStripMenuItem"
        Me.MemosToolStripMenuItem.Size = New System.Drawing.Size(86, 29)
        Me.MemosToolStripMenuItem.Text = "Memos"
        '
        'miTracker
        '
        Me.miTracker.Name = "miTracker"
        Me.miTracker.Size = New System.Drawing.Size(84, 29)
        Me.miTracker.Text = "Tracker"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoronavirusToolStripMenuItem, Me.CalendarToolStripMenuItem, Me.MailToolStripMenuItem, Me.NewsToolStripMenuItem, Me.EntertainmentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(921, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(509, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CoronavirusToolStripMenuItem
        '
        Me.CoronavirusToolStripMenuItem.Name = "CoronavirusToolStripMenuItem"
        Me.CoronavirusToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.CoronavirusToolStripMenuItem.Text = "Coronavirus"
        '
        'CalendarToolStripMenuItem
        '
        Me.CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem"
        Me.CalendarToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.CalendarToolStripMenuItem.Text = "Calendar"
        '
        'MailToolStripMenuItem
        '
        Me.MailToolStripMenuItem.Name = "MailToolStripMenuItem"
        Me.MailToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.MailToolStripMenuItem.Text = "Mail"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem1, Me.OnThisDayToolStripMenuItem, Me.WeatherToolStripMenuItem1})
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.NewsToolStripMenuItem.Text = "Current Events"
        '
        'NewsToolStripMenuItem1
        '
        Me.NewsToolStripMenuItem1.Name = "NewsToolStripMenuItem1"
        Me.NewsToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.NewsToolStripMenuItem1.Text = "News"
        '
        'OnThisDayToolStripMenuItem
        '
        Me.OnThisDayToolStripMenuItem.Name = "OnThisDayToolStripMenuItem"
        Me.OnThisDayToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.OnThisDayToolStripMenuItem.Text = "On This Day"
        '
        'WeatherToolStripMenuItem1
        '
        Me.WeatherToolStripMenuItem1.Name = "WeatherToolStripMenuItem1"
        Me.WeatherToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.WeatherToolStripMenuItem1.Text = "Weather"
        '
        'EntertainmentToolStripMenuItem
        '
        Me.EntertainmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MusicToolStripMenuItem1, Me.NetFlixToolStripMenuItem, Me.YoutubeToolStripMenuItem1})
        Me.EntertainmentToolStripMenuItem.Name = "EntertainmentToolStripMenuItem"
        Me.EntertainmentToolStripMenuItem.Size = New System.Drawing.Size(125, 25)
        Me.EntertainmentToolStripMenuItem.Text = "Entertainment"
        '
        'MusicToolStripMenuItem1
        '
        Me.MusicToolStripMenuItem1.Name = "MusicToolStripMenuItem1"
        Me.MusicToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.MusicToolStripMenuItem1.Text = "Music"
        '
        'NetFlixToolStripMenuItem
        '
        Me.NetFlixToolStripMenuItem.Name = "NetFlixToolStripMenuItem"
        Me.NetFlixToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.NetFlixToolStripMenuItem.Text = "NetFlix"
        '
        'YoutubeToolStripMenuItem1
        '
        Me.YoutubeToolStripMenuItem1.Name = "YoutubeToolStripMenuItem1"
        Me.YoutubeToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.YoutubeToolStripMenuItem1.Text = "Youtube"
        '
        'cboTracker
        '
        Me.cboTracker.FormattingEnabled = True
        Me.cboTracker.Items.AddRange(New Object() {"All Lists", "Appointments", "Bills", "Birthdays", "Other", "Starred"})
        Me.cboTracker.Location = New System.Drawing.Point(20, 138)
        Me.cboTracker.Name = "cboTracker"
        Me.cboTracker.Size = New System.Drawing.Size(149, 33)
        Me.cboTracker.TabIndex = 14
        Me.cboTracker.Text = "All Lists"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Bisque
        Me.btnAdd.Location = New System.Drawing.Point(367, 137)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'flpTracker
        '
        Me.flpTracker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpTracker.AutoScroll = True
        Me.flpTracker.Location = New System.Drawing.Point(12, 193)
        Me.flpTracker.Name = "flpTracker"
        Me.flpTracker.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpTracker.Size = New System.Drawing.Size(443, 606)
        Me.flpTracker.TabIndex = 13
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.Bisque
        Me.btnSort.Location = New System.Drawing.Point(286, 137)
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
        Me.cboContact.Location = New System.Drawing.Point(974, 135)
        Me.cboContact.Name = "cboContact"
        Me.cboContact.Size = New System.Drawing.Size(149, 33)
        Me.cboContact.TabIndex = 19
        Me.cboContact.Text = "All Lists"
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddContact.Location = New System.Drawing.Point(1312, 138)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(75, 33)
        Me.BtnAddContact.TabIndex = 16
        Me.BtnAddContact.Text = "Add"
        Me.BtnAddContact.UseVisualStyleBackColor = False
        '
        'flpContact
        '
        Me.flpContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContact.AutoScroll = True
        Me.flpContact.Location = New System.Drawing.Point(953, 193)
        Me.flpContact.Name = "flpContact"
        Me.flpContact.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpContact.Size = New System.Drawing.Size(455, 615)
        Me.flpContact.TabIndex = 18
        '
        'btnContactSort
        '
        Me.btnContactSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContactSort.BackColor = System.Drawing.Color.Bisque
        Me.btnContactSort.Location = New System.Drawing.Point(1231, 138)
        Me.btnContactSort.Name = "btnContactSort"
        Me.btnContactSort.Size = New System.Drawing.Size(75, 33)
        Me.btnContactSort.TabIndex = 17
        Me.btnContactSort.Text = "Sort"
        Me.btnContactSort.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.LightGreen
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 33)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(103, 29)
        Me.MenuStrip2.TabIndex = 20
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'cboTrackerTime
        '
        Me.cboTrackerTime.FormattingEnabled = True
        Me.cboTrackerTime.Items.AddRange(New Object() {"All Time", "Today", "Week", "Month", "Year"})
        Me.cboTrackerTime.Location = New System.Drawing.Point(175, 138)
        Me.cboTrackerTime.Name = "cboTrackerTime"
        Me.cboTrackerTime.Size = New System.Drawing.Size(109, 33)
        Me.cboTrackerTime.TabIndex = 21
        Me.cboTrackerTime.Text = "All Time"
        '
        'lblMemos
        '
        Me.lblMemos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemos.Location = New System.Drawing.Point(478, 91)
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
        Me.lblContacts.Location = New System.Drawing.Point(947, 91)
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
        Me.lblTrackers.Location = New System.Drawing.Point(97, 91)
        Me.lblTrackers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTrackers.Name = "lblTrackers"
        Me.lblTrackers.Size = New System.Drawing.Size(264, 33)
        Me.lblTrackers.TabIndex = 24
        Me.lblTrackers.Text = "Trackers"
        Me.lblTrackers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddMemo
        '
        Me.btnAddMemo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddMemo.BackColor = System.Drawing.Color.Bisque
        Me.btnAddMemo.Location = New System.Drawing.Point(659, 135)
        Me.btnAddMemo.Name = "btnAddMemo"
        Me.btnAddMemo.Size = New System.Drawing.Size(105, 36)
        Me.btnAddMemo.TabIndex = 25
        Me.btnAddMemo.Text = "Add"
        Me.btnAddMemo.UseVisualStyleBackColor = False
        '
        'cboMemos
        '
        Me.cboMemos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cboMemos.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cboMemos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMemos.ForeColor = System.Drawing.Color.White
        Me.cboMemos.FormattingEnabled = True
        Me.cboMemos.Location = New System.Drawing.Point(539, 193)
        Me.cboMemos.Name = "cboMemos"
        Me.cboMemos.Size = New System.Drawing.Size(341, 635)
        Me.cboMemos.TabIndex = 27
        '
        'txbRun
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
        Me.Controls.Add(Me.cboTrackerTime)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.cboContact)
        Me.Controls.Add(Me.BtnAddContact)
        Me.Controls.Add(Me.flpContact)
        Me.Controls.Add(Me.btnContactSort)
        Me.Controls.Add(Me.cboTracker)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.flpTracker)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txbSearch)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.mmMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mmMain
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimumSize = New System.Drawing.Size(1445, 587)
        Me.Name = "txbRun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPIM"
        Me.mmMain.ResumeLayout(False)
        Me.mmMain.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mmMain As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents lblClock As Label
    Friend WithEvents TmrClock As Timer
    Friend WithEvents miTracker As ToolStripMenuItem
    Friend WithEvents Form1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CoronavirusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboTracker As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents flpTracker As FlowLayoutPanel
    Friend WithEvents btnSort As Button
    Friend WithEvents cboContact As ComboBox
    Friend WithEvents BtnAddContact As Button
    Friend WithEvents flpContact As FlowLayoutPanel
    Friend WithEvents btnContactSort As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntertainmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetFlixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cboTrackerTime As ComboBox
    Friend WithEvents lblMemos As Label
    Friend WithEvents lblContacts As Label
    Friend WithEvents lblTrackers As Label
    Friend WithEvents btnAddMemo As Button
    Friend WithEvents MemosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboMemos As ComboBox
    Friend WithEvents NewsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OnThisDayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem1 As ToolStripMenuItem
End Class
