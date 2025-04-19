Imports Microsoft.Data.SqlClient


Public Class MedicalRecordDetailForm
    Public RecordId As Integer
    Private Sub MedicalRecordDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conApp.Open()
            Dim com As New SqlCommand("SELECT ad.First_Name AS Doctor_Name, 
                                       mr.Visit_notes, mr.Medications
                                       FROM Medical_Records mr 
                                       INNER JOIN Account_Details ad ON mr.Doctor_id = ad.User_id  
                                       WHERE mr.Record_id = @recordId", conApp)
            com.Parameters.AddWithValue("@recordId", RecordId)

            Dim reader As SqlDataReader = com.ExecuteReader()

            If reader.Read() Then
                ' Populate your form controls with the record data
                DoctorNameLabel.Text = "Doctor Name: " + reader("Doctor_Name").ToString()
                VisitNotesTextBox.Text = reader("Visit_notes").ToString()
                MedicationsTextBox.Text = If(reader("Medications") IsNot DBNull.Value, reader("Medications").ToString(), "None")
            End If

            reader.Close()

        Catch ex As Exception
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()

    End Sub
End Class