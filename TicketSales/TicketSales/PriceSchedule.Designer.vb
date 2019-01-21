<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceSchedule
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
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.PriceScheduleListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(49, 38)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(191, 29)
        Me.PriceLabel.TabIndex = 0
        Me.PriceLabel.Text = "Price Schedule"
        '
        'PriceScheduleListBox
        '
        Me.PriceScheduleListBox.FormattingEnabled = True
        Me.PriceScheduleListBox.Location = New System.Drawing.Point(54, 100)
        Me.PriceScheduleListBox.Name = "PriceScheduleListBox"
        Me.PriceScheduleListBox.Size = New System.Drawing.Size(151, 56)
        Me.PriceScheduleListBox.TabIndex = 1
        '
        'PriceSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.PriceScheduleListBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Name = "PriceSchedule"
        Me.Text = "Ticket Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents PriceScheduleListBox As System.Windows.Forms.ListBox
End Class
