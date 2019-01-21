Public Class MainForm

    Private PriceDecimal() As Decimal = {40D, 27.5D, 15D, 10D}
    Private SectionString() As String = {"Orchestra", "Mezzanine", "General", "Balcony"}
    Private NumberInteger As Integer
    Private SectionInteger As Integer
    Private TotalTicketsSoldPerSectionInteger As Integer
    Private TotalSalesPerSectionDecimal As Decimal

   

   
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub


    Private Sub ClearEnteriesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearEnteriesToolStripMenuItem.Click

        NumberTextBox.Clear()
        PurchaseInfoLabel.Text = ""
        AmountTextBox.Clear()
        With SectionListBox
            .SelectedIndex = -1
            .Focus()
        End With
    End Sub




    Private Sub DisplayPriceScheduleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayPriceScheduleToolStripMenuItem.Click

        For PriceDisplay = 0 To 1
            PriceSchedule.PriceScheduleListBox.Items.Add(SectionString(PriceDisplay) & vbTab & PriceDecimal(PriceDisplay).ToString("C"))
        Next

        For PriceDisplay = 2 To 3
            PriceSchedule.PriceScheduleListBox.Items.Add(SectionString(PriceDisplay) & vbTab & vbTab & PriceDecimal(PriceDisplay).ToString("C"))
        Next


        PriceSchedule.ShowDialog()

    End Sub



    Private Sub PurchaseTicketsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseTicketsToolStripMenuItem.Click

        If SectionListBox.SelectedIndex <> -1 Then

            SectionInteger = SectionListBox.SelectedIndex

            If NumberTextBox.Text <> "" Then

                Try
                    'Convert text in NumberTextBox to numeric value.
                    NumberInteger = Integer.Parse(NumberTextBox.Text)

                    ' Add to total tickets sold per section.
                    TotalTicketsSoldPerSectionInteger = PriceDecimal(SectionInteger) + NumberInteger

                    'Display the total amount due in the Amount due text box
                    AmountTextBox.Text = (PriceDecimal(SectionInteger) * NumberInteger).ToString("C")


                    PriceDecimal(SectionInteger) += NumberInteger

                    ' Display message reflecting details of ticket purchase.
                    PurchaseInfoLabel.Text = ("You have purchased " & NumberInteger & " tickets at " + vbNewLine +
                                                (PriceDecimal(SectionInteger) - NumberInteger).ToString("C") _
                                                & " per ticket. ")


                    ' Calculate the total amount of ticket sales per section.
                    TotalSalesPerSectionDecimal = TotalTicketsSoldPerSectionInteger * PriceDecimal(SectionInteger)

                Catch NumberException As FormatException
                    MessageBox.Show("Number of tickets must be numeric", "Data Entry Error", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Exclamation)
                    With NumberTextBox
                        .Focus()
                        .SelectAll()
                    End With

                End Try

            Else
                MessageBox.Show("Enter number of tickets you wish to purchase.", "Missing Data", MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)

            End If

        Else
            MessageBox.Show("Make a selection from the Section List.", "Missing Data", MessageBoxButtons.OK, _
                            MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub PrintDocumentOne_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentOne.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        
        Dim FontSizeF As New SizeF



        ' Print page heading.
        Using HeadingFont As New Font("Arial", 16, FontStyle.Bold)
            e.Graphics.DrawString("Summary of Ticket Sales", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

            ' Blank line between heading and data.
            VerticalPrintLocationSingle += LineHeightSingle * 2

        End Using

        ' Print column headings.
        e.Graphics.DrawString("Section", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        HorizontalPrintLocationSingle += 100

        e.Graphics.DrawString("# Tickets", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        HorizontalPrintLocationSingle += 100

        e.Graphics.DrawString("Ticket Price", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        HorizontalPrintLocationSingle += 100

        e.Graphics.DrawString("Sales Amount", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        HorizontalPrintLocationSingle += 100

        VerticalPrintLocationSingle += LineHeightSingle



    End Sub


    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click

        PrintPreviewDialog.Document = PrintDocumentOne
        PrintPreviewDialog.ShowDialog()

    End Sub
End Class

