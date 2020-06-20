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
        Me.BrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.TmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.cbxEventPicker = New System.Windows.Forms.ComboBox()
        Me.lblSelectTrackerEvent = New System.Windows.Forms.Label()
        Me.mmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmMain
        '
        Me.mmMain.BackColor = System.Drawing.Color.Bisque
        Me.mmMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miTracker, Me.Form1ToolStripMenuItem, Me.BrowserToolStripMenuItem})
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
        'BrowserToolStripMenuItem
        '
        Me.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem"
        Me.BrowserToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.BrowserToolStripMenuItem.Text = "Browser"
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
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1429, 548)
        Me.Controls.Add(Me.lblSelectTrackerEvent)
        Me.Controls.Add(Me.cbxEventPicker)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblCalendar)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.mmMain)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mmMain
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimumSize = New System.Drawing.Size(1445, 587)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyPIM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents miTracker As ToolStripMenuItem
    Friend WithEvents Form1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCalendar As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents cbxEventPicker As ComboBox
    Friend WithEvents lblSelectTrackerEvent As Label
    Friend WithEvents BrowserToolStripMenuItem As ToolStripMenuItem
End Class
