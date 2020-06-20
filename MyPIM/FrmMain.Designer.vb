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
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoronavirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmMain
        '
        Me.mmMain.BackColor = System.Drawing.Color.Bisque
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
        Me.miExit.Size = New System.Drawing.Size(180, 30)
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
        Me.lblClock.BackColor = System.Drawing.Color.Bisque
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
        Me.lblCalendar.Location = New System.Drawing.Point(584, 33)
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
        Me.MonthCalendar1.Location = New System.Drawing.Point(538, 75)
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
        Me.cbxEventPicker.Location = New System.Drawing.Point(538, 307)
        Me.cbxEventPicker.Name = "cbxEventPicker"
        Me.cbxEventPicker.Size = New System.Drawing.Size(227, 33)
        Me.cbxEventPicker.TabIndex = 5
        Me.cbxEventPicker.Visible = False
        '
        'lblSelectTrackerEvent
        '
        Me.lblSelectTrackerEvent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSelectTrackerEvent.Location = New System.Drawing.Point(533, 247)
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
        Me.txbSearch.Location = New System.Drawing.Point(953, 1)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(353, 33)
        Me.txbSearch.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.Linen
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
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoronavirusToolStripMenuItem, Me.MailToolStripMenuItem, Me.MusicToolStripMenuItem, Me.NewsToolStripMenuItem, Me.WeatherToolStripMenuItem, Me.YouTubeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(951, 37)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(466, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(62, 25)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'CoronavirusToolStripMenuItem
        '
        Me.CoronavirusToolStripMenuItem.Name = "CoronavirusToolStripMenuItem"
        Me.CoronavirusToolStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.CoronavirusToolStripMenuItem.Text = "Coronavirus"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.YouTubeToolStripMenuItem.Text = "YouTube"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'MailToolStripMenuItem
        '
        Me.MailToolStripMenuItem.Name = "MailToolStripMenuItem"
        Me.MailToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.MailToolStripMenuItem.Text = "Mail"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1429, 548)
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
    Friend WithEvents YouTubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailToolStripMenuItem As ToolStripMenuItem
End Class
