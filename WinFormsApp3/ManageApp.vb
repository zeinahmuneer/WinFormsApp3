Imports Microsoft.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class ManageApp
    Public UserId As Integer
    Public Role As Integer

    '––– Printing fields
    Private WithEvents PrintDocument1 As New PrintDocument()
    Private PrintPreviewDialog1 As New PrintPreviewDialog()
    Private printData As DataTable
    Private currentRow As Integer = 0

    Private Sub ManageApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctorAppointments()
    End Sub

    Private Sub LoadDoctorAppointments()
        Try
            If conApp.State <> ConnectionState.Closed Then conApp.Close()
            conApp.Open()

            Dim query As String = "
                SELECT
                    a.Appointment_id,
                    ad.First_Name + ' ' + ad.Last_Name AS PatientName,
                    CAST(a.Date AS date)    AS Date,
                    a.Time,
                    s.Status
                FROM Appointment_Details a
                JOIN Account_Details ad ON a.Patient_id = ad.User_id
                JOIN Appointment_Status s ON a.Status = s.Status_id
                WHERE a.Doctor_id = @UserId
            "

            Using cmd As New SqlCommand(query, conApp)
                cmd.Parameters.AddWithValue("@UserId", UserId)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                DoctorApp.DataSource = dt
                DoctorApp.Columns("Appointment_id").Visible = False
            End Using

            ' Add Edit button if not present
            If Not DoctorApp.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn() With {
                    .Name = "Edit",
                    .HeaderText = "",
                    .Text = "Edit",
                    .UseColumnTextForButtonValue = True
                }
                DoctorApp.Columns.Add(editButton)
            End If

            ' Add Cancel button if not present
            If Not DoctorApp.Columns.Contains("Cancel") Then
                Dim cancelButton As New DataGridViewButtonColumn() With {
                    .Name = "Cancel",
                    .HeaderText = "",
                    .Text = "Cancel",
                    .UseColumnTextForButtonValue = True
                }
                DoctorApp.Columns.Add(cancelButton)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading appointments: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub DoctorApp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DoctorApp.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim appointmentId As Integer = Convert.ToInt32(DoctorApp.Rows(e.RowIndex).Cells("Appointment_id").Value)

        Select Case DoctorApp.Columns(e.ColumnIndex).Name
            Case "Edit"
                Dim editForm As New EditAppointmentForm(appointmentId)
                editForm.Role = Role
                editForm.ShowDialog()
                LoadDoctorAppointments()

            Case "Cancel"
                If MessageBox.Show("Are you sure you want to cancel this appointment?",
                                   "Confirm Cancel", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Try
                        If conApp.State <> ConnectionState.Closed Then conApp.Close()
                        conApp.Open()
                        Dim cancelCmd As New SqlCommand(
                            "UPDATE Appointment_Details SET Status = 3 WHERE Appointment_id = @AppointmentId",
                            conApp)
                        cancelCmd.Parameters.AddWithValue("@AppointmentId", appointmentId)
                        cancelCmd.ExecuteNonQuery()
                        MessageBox.Show("Appointment canceled.")
                    Catch ex As Exception
                        MessageBox.Show("Error canceling appointment: " & ex.Message)
                    Finally
                        conApp.Close()
                    End Try
                    LoadDoctorAppointments()
                End If
        End Select
    End Sub

    Private Sub PrintAppBtn_Click(sender As Object, e As EventArgs) Handles PrintAppBtn.Click
        ' Build a DataTable of today’s appointments, excluding ID/Edit/Cancel
        Dim all As DataTable = CType(DoctorApp.DataSource, DataTable)
        Dim today = DateTime.Today

        Dim dt As New DataTable()
        ' Add only the printable columns
        For Each col As DataColumn In all.Columns
            If col.ColumnName <> "Appointment_id" Then
                dt.Columns.Add(col.ColumnName, GetType(String))
            End If
        Next

        ' Filter rows where Date = today
        For Each row As DataRow In all.Rows
            If Convert.ToDateTime(row("Date")).Date = today Then
                Dim newRow = dt.NewRow()
                Dim i As Integer = 0
                For Each col As DataColumn In all.Columns
                    If col.ColumnName <> "Appointment_id" Then
                        newRow(i) = row(col.ColumnName).ToString()
                        i += 1
                    End If
                Next
                dt.Rows.Add(newRow)
            End If
        Next

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No appointments for today.")
            Return
        End If

        printData = dt
        currentRow = 0

        ' Preview & print
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 900
        PrintPreviewDialog1.Height = 700
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterParent
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Reset before each print/preview
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

        ' columns to print
        Dim cols = printData.Columns.Cast(Of DataColumn).ToList()
        Dim colCount = cols.Count

        ' first column fixed, others share remaining width
        Dim totalW = e.MarginBounds.Width
        Dim firstW = 100
        Dim otherW = CInt((totalW - firstW) / (colCount - 1))
        Dim colW = New List(Of Integer) From {firstW}
        For i As Integer = 2 To colCount
            colW.Add(otherW)
        Next

        ' x positions
        Dim xPos(colCount - 1) As Integer
        xPos(0) = left
        For i As Integer = 1 To colCount - 1
            xPos(i) = xPos(i - 1) + colW(i - 1)
        Next

        ' draw headers
        Dim hH = fontHeader.Height + 8
        For i As Integer = 0 To colCount - 1
            Dim r = New RectangleF(xPos(i), rowY, colW(i), hH)
            e.Graphics.FillRectangle(Brushes.LightGray, r)
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(r))
            e.Graphics.DrawString(cols(i).ColumnName, fontHeader, Brushes.Black, r)
        Next
        rowY += hH

        ' draw rows
        While currentRow < printData.Rows.Count
            Dim thisRow = printData.Rows(currentRow)
            ' measure needed height
            Dim maxH As Integer = 0
            For i As Integer = 0 To colCount - 1
                Dim txt = thisRow(i).ToString()
                Dim sz = e.Graphics.MeasureString(txt, fontCell, colW(i))
                maxH = Math.Max(maxH, CInt(sz.Height) + 6)
            Next

            ' new page?
            If rowY + maxH > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If

            ' draw each cell
            For i As Integer = 0 To colCount - 1
                Dim txt = thisRow(i).ToString()
                Dim r = New RectangleF(xPos(i), rowY, colW(i), maxH)
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(r))
                e.Graphics.DrawString(txt, fontCell, Brushes.Black, r)
            Next

            rowY += maxH
            currentRow += 1
        End While

        e.HasMorePages = False
    End Sub
End Class
