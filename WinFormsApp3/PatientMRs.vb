Imports Microsoft.Data.SqlClient

Public Class PatientMRs
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If String.IsNullOrWhiteSpace(PatientId.Text) Then
            MessageBox.Show("Please enter a Patient ID.")
            Return
        End If

        Try
            If conApp.State <> ConnectionState.Closed Then conApp.Close()
            conApp.Open()

            Dim query As String = "
                SELECT 
                    mr.Record_id,
                    ad1.First_Name + ' ' + ad1.Last_Name AS Patient_Name,
                    ad2.First_Name + ' ' + ad2.Last_Name AS Doctor_Name,
                    mr.Visit_notes,
                    mr.Medications,
                    'View Details' AS ViewLink
                FROM Medical_Records mr
                INNER JOIN Account_Details ad1 ON mr.Patient_id = ad1.User_id
                INNER JOIN Account_Details ad2 ON mr.Doctor_id = ad2.User_id
                WHERE mr.Patient_id = @PatientId
            "

            Dim cmd As New SqlCommand(query, conApp)
            cmd.Parameters.AddWithValue("@PatientId", PatientId.Text.Trim())

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            PatientMr.DataSource = dt
            PatientMr.Columns("Record_id").Visible = False

            ' Style the "View Details" column like a link
            If PatientMr.Columns.Contains("ViewLink") Then
                PatientMr.Columns("ViewLink").DefaultCellStyle.ForeColor = Color.Blue
                PatientMr.Columns("ViewLink").DefaultCellStyle.Font =
                    New Font(PatientMr.DefaultCellStyle.Font, FontStyle.Underline)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving medical records: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub PatientMr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientMr.CellContentClick
        If e.RowIndex >= 0 AndAlso PatientMr.Columns(e.ColumnIndex).Name = "ViewLink" Then
            Dim recordId As Integer = CInt(PatientMr.Rows(e.RowIndex).Cells("Record_id").Value)
            ShowMedicalRecordDetails(recordId)
        End If
    End Sub

    Private Sub ShowMedicalRecordDetails(recordId As Integer)
        Dim detailsForm As New MedicalRecordDetailForm()
        detailsForm.RecordId = recordId
        detailsForm.ShowDialog()
    End Sub
End Class
