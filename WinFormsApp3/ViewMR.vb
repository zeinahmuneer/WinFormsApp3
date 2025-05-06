Imports Microsoft.Data.SqlClient
Imports System.Drawing.Printing

Public Class ViewMR
    Public UserId As Integer

    '––– Printing fields
    Private WithEvents PrintDocument1 As New PrintDocument()
    Private PrintPreviewDialog1 As New PrintPreviewDialog()
    Private printData As DataTable
    Private currentRow As Integer = 0

    Private Sub ViewMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conApp.Open()
            Dim com As New SqlCommand(
                "SELECT mr.Record_id,
                        ad.First_Name AS Doctor_Name,
                        mr.Visit_notes,
                        mr.Medications,
                        'View Details' AS ViewLink
                   FROM Medical_Records mr
                   INNER JOIN Account_Details ad
                     ON mr.Doctor_id = ad.User_id
                  WHERE mr.Patient_id = @userid",
                conApp)
            com.Parameters.AddWithValue("@userid", UserId)

            Dim adapter As New SqlDataAdapter(com)
            Dim ds As New DataSet()
            adapter.Fill(ds, "MedicalRecords")

            MedicalRecordsGrid.DataSource = ds.Tables("MedicalRecords")
            MedicalRecordsGrid.Columns("Record_id").Visible = False

            ' Style the ViewLink column
            MedicalRecordsGrid.Columns("ViewLink").DefaultCellStyle.ForeColor = Color.Blue
            MedicalRecordsGrid.Columns("ViewLink").DefaultCellStyle.Font =
                New Font(MedicalRecordsGrid.DefaultCellStyle.Font, FontStyle.Underline)
        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub MedicalRecordsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
            Handles MedicalRecordsGrid.CellContentClick
        If e.RowIndex >= 0 AndAlso MedicalRecordsGrid.Columns(e.ColumnIndex).Name = "ViewLink" Then
            Dim recordId As Integer =
                CInt(MedicalRecordsGrid.Rows(e.RowIndex).Cells("Record_id").Value)
            ShowMedicalRecordDetails(recordId)
        End If
    End Sub

    Private Sub ShowMedicalRecordDetails(recordId As Integer)
        Dim detailsForm As New MedicalRecordDetailForm()
        detailsForm.RecordId = recordId
        detailsForm.ShowDialog()
    End Sub

    Private Sub PrintMRBtn_Click(sender As Object, e As EventArgs) Handles PrintMRBtn.Click
        If MedicalRecordsGrid.Rows.Count = 0 Then
            MessageBox.Show("No data to print.")
            Return
        End If

        ' Build a DataTable with only the visible, printable columns (exclude ViewLink)
        Dim dt As New DataTable()
        For Each col As DataGridViewColumn In MedicalRecordsGrid.Columns
            If col.Visible AndAlso col.Name <> "ViewLink" Then
                dt.Columns.Add(col.HeaderText, GetType(String))
            End If
        Next

        For Each row As DataGridViewRow In MedicalRecordsGrid.Rows
            If Not row.IsNewRow Then
                Dim newRow = dt.NewRow()
                Dim i As Integer = 0
                For Each col As DataGridViewColumn In MedicalRecordsGrid.Columns
                    If col.Visible AndAlso col.Name <> "ViewLink" Then
                        newRow(i) = row.Cells(col.Index).Value?.ToString()
                        i += 1
                    End If
                Next
                dt.Rows.Add(newRow)
            End If
        Next

        printData = dt

        ' Show Print Preview (BeginPrint resets currentRow)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 900
        PrintPreviewDialog1.Height = 700
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterParent
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Reset the row counter at the start of each Print or Preview
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) _
            Handles PrintDocument1.BeginPrint
        currentRow = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) _
            Handles PrintDocument1.PrintPage

        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontCell As New Font("Arial", 10)
        Dim left = e.MarginBounds.Left
        Dim top = e.MarginBounds.Top
        Dim rowY = top

        ' Determine which columns we're printing
        Dim cols = printData.Columns.Cast(Of DataColumn)().ToList()
        Dim colCount = cols.Count

        ' Compute column widths: first col 100px, rest share remaining
        Dim totalWidth = e.MarginBounds.Width
        Dim firstColW = 100
        Dim otherW = CInt((totalWidth - firstColW) / (colCount - 1))
        Dim colWidths = New List(Of Integer) From {firstColW}
        For i As Integer = 2 To colCount
            colWidths.Add(otherW)
        Next

        ' Precompute X positions
        Dim xPos(colCount - 1) As Integer
        xPos(0) = left
        For i As Integer = 1 To colCount - 1
            xPos(i) = xPos(i - 1) + colWidths(i - 1)
        Next

        ' — Draw header row —
        Dim headerH = fontHeader.Height + 8
        For i As Integer = 0 To colCount - 1
            Dim r = New RectangleF(xPos(i), rowY, colWidths(i), headerH)
            e.Graphics.FillRectangle(Brushes.LightGray, r)
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(r))
            e.Graphics.DrawString(cols(i).ColumnName, fontHeader, Brushes.Black, r)
        Next
        rowY += headerH

        ' — Draw data rows —
        While currentRow < printData.Rows.Count
            Dim thisRow = printData.Rows(currentRow)
            ' Measure required row height
            Dim maxH As Integer = 0
            For i As Integer = 0 To colCount - 1
                Dim txt = thisRow(i).ToString()
                Dim sz = e.Graphics.MeasureString(txt, fontCell, colWidths(i))
                maxH = Math.Max(maxH, CInt(sz.Height) + 6)
            Next

            ' New page if not enough space
            If rowY + maxH > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If

            ' Draw each cell
            For i As Integer = 0 To colCount - 1
                Dim txt = thisRow(i).ToString()
                Dim r = New RectangleF(xPos(i), rowY, colWidths(i), maxH)
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(r))
                e.Graphics.DrawString(txt, fontCell, Brushes.Black, r)
            Next

            rowY += maxH
            currentRow += 1
        End While

        e.HasMorePages = False
    End Sub
End Class
