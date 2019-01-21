<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPriceScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearEnteriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcertLabel = New System.Windows.Forms.Label()
        Me.SectionAndTicketsGroupBox = New System.Windows.Forms.GroupBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.SectionListBox = New System.Windows.Forms.ListBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseInfoLabel = New System.Windows.Forms.Label()
        Me.PrintDocumentOne = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip.SuspendLayout()
        Me.SectionAndTicketsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TicketToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(499, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "&Print Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayPriceScheduleToolStripMenuItem, Me.PurchaseTicketsToolStripMenuItem, Me.ClearEnteriesToolStripMenuItem})
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TicketToolStripMenuItem.Text = "&Ticket"
        '
        'DisplayPriceScheduleToolStripMenuItem
        '
        Me.DisplayPriceScheduleToolStripMenuItem.Name = "DisplayPriceScheduleToolStripMenuItem"
        Me.DisplayPriceScheduleToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DisplayPriceScheduleToolStripMenuItem.Text = "&Display Price Schedule"
        '
        'PurchaseTicketsToolStripMenuItem
        '
        Me.PurchaseTicketsToolStripMenuItem.Name = "PurchaseTicketsToolStripMenuItem"
        Me.PurchaseTicketsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PurchaseTicketsToolStripMenuItem.Text = "&Purchase Tickets"
        '
        'ClearEnteriesToolStripMenuItem
        '
        Me.ClearEnteriesToolStripMenuItem.Name = "ClearEnteriesToolStripMenuItem"
        Me.ClearEnteriesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ClearEnteriesToolStripMenuItem.Text = "&Clear Enteries"
        '
        'ConcertLabel
        '
        Me.ConcertLabel.AutoSize = True
        Me.ConcertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConcertLabel.Location = New System.Drawing.Point(112, 34)
        Me.ConcertLabel.Name = "ConcertLabel"
        Me.ConcertLabel.Size = New System.Drawing.Size(286, 31)
        Me.ConcertLabel.TabIndex = 1
        Me.ConcertLabel.Text = "Concert Ticket Sales"
        '
        'SectionAndTicketsGroupBox
        '
        Me.SectionAndTicketsGroupBox.Controls.Add(Me.NumberTextBox)
        Me.SectionAndTicketsGroupBox.Controls.Add(Me.NumberLabel)
        Me.SectionAndTicketsGroupBox.Controls.Add(Me.SectionLabel)
        Me.SectionAndTicketsGroupBox.Controls.Add(Me.SectionListBox)
        Me.SectionAndTicketsGroupBox.Location = New System.Drawing.Point(12, 96)
        Me.SectionAndTicketsGroupBox.Name = "SectionAndTicketsGroupBox"
        Me.SectionAndTicketsGroupBox.Size = New System.Drawing.Size(257, 153)
        Me.SectionAndTicketsGroupBox.TabIndex = 2
        Me.SectionAndTicketsGroupBox.TabStop = False
        Me.SectionAndTicketsGroupBox.Text = "Select Section and Number of Tickets"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(144, 57)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberTextBox.TabIndex = 3
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(141, 32)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(47, 13)
        Me.NumberLabel.TabIndex = 2
        Me.NumberLabel.Text = "&Number:"
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(17, 32)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(46, 13)
        Me.SectionLabel.TabIndex = 1
        Me.SectionLabel.Text = "&Section:"
        '
        'SectionListBox
        '
        Me.SectionListBox.FormattingEnabled = True
        Me.SectionListBox.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.SectionListBox.Location = New System.Drawing.Point(20, 48)
        Me.SectionListBox.Name = "SectionListBox"
        Me.SectionListBox.Size = New System.Drawing.Size(69, 69)
        Me.SectionListBox.TabIndex = 0
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(340, 177)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(69, 13)
        Me.AmountLabel.TabIndex = 3
        Me.AmountLabel.Text = "Amount Due:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(343, 193)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.ReadOnly = True
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 4
        '
        'PurchaseInfoLabel
        '
        Me.PurchaseInfoLabel.AutoSize = True
        Me.PurchaseInfoLabel.Location = New System.Drawing.Point(318, 128)
        Me.PurchaseInfoLabel.Name = "PurchaseInfoLabel"
        Me.PurchaseInfoLabel.Size = New System.Drawing.Size(0, 13)
        Me.PurchaseInfoLabel.TabIndex = 5
        '
        'PrintDocumentOne
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 284)
        Me.Controls.Add(Me.PurchaseInfoLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.SectionAndTicketsGroupBox)
        Me.Controls.Add(Me.ConcertLabel)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "Ticket Sales"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SectionAndTicketsGroupBox.ResumeLayout(False)
        Me.SectionAndTicketsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayPriceScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseTicketsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearEnteriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcertLabel As System.Windows.Forms.Label
    Friend WithEvents SectionAndTicketsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberLabel As System.Windows.Forms.Label
    Friend WithEvents SectionLabel As System.Windows.Forms.Label
    Friend WithEvents SectionListBox As System.Windows.Forms.ListBox
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurchaseInfoLabel As System.Windows.Forms.Label
    Friend WithEvents PrintDocumentOne As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog

End Class
