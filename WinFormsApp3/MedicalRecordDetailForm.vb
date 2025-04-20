Imports Microsoft.Data.SqlClient

Public Class MedicalRecordDetailForm
    Public RecordId As Integer

    Private Sub MedicalRecordDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                MedicationsTextBox.Text = If(reader("Medications") IsNot DBNull.Value, reader("Medications").ToString(), "None")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading record details: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
