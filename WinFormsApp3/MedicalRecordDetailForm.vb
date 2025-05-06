Imports Microsoft.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class MedicalRecordDetailForm
    Public RecordId As Integer

    '––– Printing fields
    Private WithEvents PrintDocument1 As New PrintDocument()
    Private PrintPreviewDialog1 As New PrintPreviewDialog()

    Private Sub MedicalRecordDetailForm_Load(sender As Object, e As EventArgs) _
            Handles MyBase.Load

        Try
            conApp.Open()
            Dim com As New SqlCommand("
                SELECT 
                    doc.First_Name AS Doctor_Name, 
                    pat.First_Name + ' ' + pat.Last_Name AS Patient_Name,
                    mr.Visit_notes, 
                    mr.Medications
                FROM Medical_Records mr 
                INNER JOIN Account_Details doc ON mr.Doctor_id = doc.User_id  
                INNER JOIN Account_Details pat ON mr.Patient_id = pat.User_id
                WHERE mr.Record_id = @recordId", conApp)

            com.Parameters.AddWithValue("@recordId", RecordId)
            Dim reader As SqlDataReader = com.ExecuteReader()

            If reader.Read() Then
                DoctorNameLabel.Text = "Doctor Name: " & reader("Doctor_Name").ToString()
                PatientName.Text = "Patient Name: " & reader("Patient_Name").ToString()
                VisitNotesTextBox.Text = reader("Visit_notes").ToString()
                MedicationsTextBox.Text = If(reader("Medications") IsNot DBNull.Value,
                                            reader("Medications").ToString(), "None")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading record details: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub MedicalRBtn_Click(sender As Object, e As EventArgs) _
            Handles MedicalRBtn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 800
        PrintPreviewDialog1.Height = 600
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterParent
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' No state to reset for a single record, but handler must exist
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) _
            Handles PrintDocument1.BeginPrint
        ' nothing needed
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) _
            Handles PrintDocument1.PrintPage

        Dim left As Integer = e.MarginBounds.Left
        Dim top As Integer = e.MarginBounds.Top
        Dim lineSpace As Integer = 6
        Dim fontLabel As New Font("Arial", 10, FontStyle.Bold)
        Dim fontText As New Font("Arial", 10)

        Dim y = top

        ' 1) Doctor Name
        e.Graphics.DrawString(DoctorNameLabel.Text, fontLabel, Brushes.Black, left, y)
        y += fontLabel.Height + lineSpace

        ' 2) Patient Name
        e.Graphics.DrawString(PatientName.Text, fontLabel, Brushes.Black, left, y)
        y += fontLabel.Height + lineSpace

        ' 3) Visit Notes header
        e.Graphics.DrawString("Visit Notes:", fontLabel, Brushes.Black, left, y)
        y += fontLabel.Height + lineSpace

        ' Draw Visit Notes wrapped
        Dim notesRect As New RectangleF(
            left,
            y,
            e.MarginBounds.Width,
            e.MarginBounds.Height - y)
        e.Graphics.DrawString(
            VisitNotesTextBox.Text,
            fontText,
            Brushes.Black,
            notesRect)
        ' measure height using integer width
        Dim notesSize As SizeF = e.Graphics.MeasureString(
            VisitNotesTextBox.Text,
            fontText,
            CInt(notesRect.Width))
        y += CInt(notesSize.Height) + lineSpace

        ' 4) Medications header
        e.Graphics.DrawString("Medications:", fontLabel, Brushes.Black, left, y)
        y += fontLabel.Height + lineSpace

        ' Draw Medications wrapped
        Dim medRect As New RectangleF(
            left,
            y,
            e.MarginBounds.Width,
            e.MarginBounds.Bottom - y)
        e.Graphics.DrawString(
            MedicationsTextBox.Text,
            fontText,
            Brushes.Black,
            medRect)

        e.HasMorePages = False
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) _
            Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
