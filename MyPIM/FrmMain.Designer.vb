<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.mmMain = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTracker = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.cbxEventPicker = New System.Windows.Forms.ComboBox()
        Me.lblSelectTrackerEvent = New System.Windows.Forms.Label()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CoronavirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntertainmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.FileExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmMain
        '
        Me.mmMain.BackColor = System.Drawing.Color.LightBlue
        Me.mmMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miTracker, Me.Form1ToolStripMenuItem})
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
        'miTracker
        '
        Me.miTracker.Name = "miTracker"
        Me.miTracker.Size = New System.Drawing.Size(84, 29)
        Me.miTracker.Text = "Tracker"
        '
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(97, 29)
        Me.Form1ToolStripMenuItem.Text = "Contacts"
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
        'lblCalendar
        '
        Me.lblCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCalendar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalendar.Location = New System.Drawing.Point(646, 44)
        Me.lblCalendar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(154, 33)
        Me.lblCalendar.TabIndex = 2
        Me.lblCalendar.Text = "Calendar"
        Me.lblCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MonthCalendar1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(600, 86)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(10)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'cbxEventPicker
        '
        Me.cbxEventPicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxEventPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEventPicker.FormattingEnabled = True
        Me.cbxEventPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxEventPicker.Items.AddRange(New Object() {"Appointment", "Bill", "Birthday", "Other"})
        Me.cbxEventPicker.Location = New System.Drawing.Point(600, 318)
        Me.cbxEventPicker.Name = "cbxEventPicker"
        Me.cbxEventPicker.Size = New System.Drawing.Size(227, 33)
        Me.cbxEventPicker.TabIndex = 5
        Me.cbxEventPicker.Visible = False
        '
        'lblSelectTrackerEvent
        '
        Me.lblSelectTrackerEvent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSelectTrackerEvent.Location = New System.Drawing.Point(595, 258)
        Me.lblSelectTrackerEvent.Name = "lblSelectTrackerEvent"
        Me.lblSelectTrackerEvent.Size = New System.Drawing.Size(232, 57)
        Me.lblSelectTrackerEvent.TabIndex = 6
        Me.lblSelectTrackerEvent.Text = "Select Tracker Event" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Schedule"
        Me.lblSelectTrackerEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblSelectTrackerEvent.Visible = False
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoronavirusToolStripMenuItem, Me.MailToolStripMenuItem, Me.MusicToolStripMenuItem, Me.NewsToolStripMenuItem, Me.WeatherToolStripMenuItem, Me.EntertainmentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(924, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CoronavirusToolStripMenuItem
        '
        Me.CoronavirusToolStripMenuItem.Name = "CoronavirusToolStripMenuItem"
        Me.CoronavirusToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.CoronavirusToolStripMenuItem.Text = "Coronavirus"
        '
        'MailToolStripMenuItem
        '
        Me.MailToolStripMenuItem.Name = "MailToolStripMenuItem"
        Me.MailToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.MailToolStripMenuItem.Text = "Mail"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'EntertainmentToolStripMenuItem
        '
        Me.EntertainmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetFlixToolStripMenuItem, Me.YoutubeToolStripMenuItem1})
        Me.EntertainmentToolStripMenuItem.Name = "EntertainmentToolStripMenuItem"
        Me.EntertainmentToolStripMenuItem.Size = New System.Drawing.Size(125, 25)
        Me.EntertainmentToolStripMenuItem.Text = "Entertainment"
        '
        'NetFlixToolStripMenuItem
        '
        Me.NetFlixToolStripMenuItem.Name = "NetFlixToolStripMenuItem"
        Me.NetFlixToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.NetFlixToolStripMenuItem.Text = "NetFlix"
        '
        'YoutubeToolStripMenuItem1
        '
        Me.YoutubeToolStripMenuItem1.Name = "YoutubeToolStripMenuItem1"
        Me.YoutubeToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.YoutubeToolStripMenuItem1.Text = "Youtube"
        '
        'cboTracker
        '
        Me.cboTracker.FormattingEnabled = True
        Me.cboTracker.Items.AddRange(New Object() {"All", "Appointments", "Bills", "Birthdays", "Other"})
        Me.cboTracker.Location = New System.Drawing.Point(32, 87)
        Me.cboTracker.Name = "cboTracker"
        Me.cboTracker.Size = New System.Drawing.Size(149, 33)
        Me.cboTracker.TabIndex = 14
        Me.cboTracker.Text = "All"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Bisque
        Me.btnAdd.Location = New System.Drawing.Point(362, 88)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 32)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'flpTracker
        '
        Me.flpTracker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flpTracker.AutoScroll = True
        Me.flpTracker.Location = New System.Drawing.Point(12, 129)
        Me.flpTracker.Name = "flpTracker"
        Me.flpTracker.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpTracker.Size = New System.Drawing.Size(443, 860)
        Me.flpTracker.TabIndex = 13
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.Color.Bisque
        Me.btnSort.Location = New System.Drawing.Point(281, 88)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 32)
        Me.btnSort.TabIndex = 12
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'cboContact
        '
        Me.cboContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContact.FormattingEnabled = True
        Me.cboContact.Items.AddRange(New Object() {"All", "Acquaintance", "Business", "Family", "Friend", "Other"})
        Me.cboContact.Location = New System.Drawing.Point(980, 86)
        Me.cboContact.Name = "cboContact"
        Me.cboContact.Size = New System.Drawing.Size(149, 33)
        Me.cboContact.TabIndex = 19
        Me.cboContact.Text = "All"
        '
        'BtnAddContact
        '
        Me.BtnAddContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddContact.BackColor = System.Drawing.Color.Bisque
        Me.BtnAddContact.Location = New System.Drawing.Point(1318, 88)
        Me.BtnAddContact.Name = "BtnAddContact"
        Me.BtnAddContact.Size = New System.Drawing.Size(75, 32)
        Me.BtnAddContact.TabIndex = 16
        Me.BtnAddContact.Text = "Add"
        Me.BtnAddContact.UseVisualStyleBackColor = False
        '
        'flpContact
        '
        Me.flpContact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContact.AutoScroll = True
        Me.flpContact.Location = New System.Drawing.Point(953, 129)
        Me.flpContact.Name = "flpContact"
        Me.flpContact.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpContact.Size = New System.Drawing.Size(455, 860)
        Me.flpContact.TabIndex = 18
        '
        'btnContactSort
        '
        Me.btnContactSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContactSort.BackColor = System.Drawing.Color.Bisque
        Me.btnContactSort.Location = New System.Drawing.Point(1237, 87)
        Me.btnContactSort.Name = "btnContactSort"
        Me.btnContactSort.Size = New System.Drawing.Size(75, 32)
        Me.btnContactSort.TabIndex = 17
        Me.btnContactSort.Text = "Sort"
        Me.btnContactSort.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.LightGreen
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FileExplorerToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 33)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(324, 29)
        Me.MenuStrip2.TabIndex = 20
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'FileExplorerToolStripMenuItem
        '
        Me.FileExplorerToolStripMenuItem.Name = "FileExplorerToolStripMenuItem"
        Me.FileExplorerToolStripMenuItem.Size = New System.Drawing.Size(112, 25)
        Me.FileExplorerToolStripMenuItem.Text = "File Explorer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 25)
        Me.ToolStripMenuItem1.Text = "Notepad++"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1429, 990)
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
        Me.Controls.Add(Me.lblSelectTrackerEvent)
        Me.Controls.Add(Me.cbxEventPicker)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblCalendar)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.mmMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mmMain
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimumSize = New System.Drawing.Size(1445, 587)
        Me.Name = "FrmMain"
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
    Friend WithEvents lblCalendar As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents cbxEventPicker As ComboBox
    Friend WithEvents lblSelectTrackerEvent As Label
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CoronavirusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntertainmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetFlixToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem1 As ToolStripMenuItem
End Class
