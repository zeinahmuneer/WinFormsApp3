Imports Microsoft.Data.SqlClient

Public Class ViewMR
    Public UserId As Integer
    Private Sub ViewMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conApp.Open()
            Dim com As New SqlCommand("SELECT mr.Record_id, ad.First_Name AS Doctor_Name, 
                                      mr.Visit_notes, mr.Medications, 
                                      'View Details' AS ViewLink 
                                      FROM Medical_Records mr 
                                      INNER JOIN Account_Details ad ON mr.Doctor_id = ad.User_id 
                                      WHERE mr.Patient_id = @userid", conApp)
            com.Parameters.AddWithValue("@userid", UserId)

            Dim adapter As New SqlDataAdapter(com)
            Dim ds As New DataSet()
            adapter.Fill(ds, "MedicalRecords")

            MedicalRecordsGrid.DataSource = ds.Tables("MedicalRecords")
            MedicalRecordsGrid.Columns("Record_id").Visible = False

            MedicalRecordsGrid.Columns("ViewLink").DefaultCellStyle.ForeColor = Color.Blue
            MedicalRecordsGrid.Columns("ViewLink").DefaultCellStyle.Font = New Font(MedicalRecordsGrid.DefaultCellStyle.Font, FontStyle.Underline)
        Catch ex As Exception
        Finally
            conApp.Close()
        End Try
    End Sub
    Private Sub MedicalRecordsGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedicalRecordsGrid.CellContentClick
        ' Check if clicked on "View Details" link
        If e.RowIndex >= 0 AndAlso MedicalRecordsGrid.Columns(e.ColumnIndex).Name = "ViewLink" Then
            Dim recordId As Integer = CInt(MedicalRecordsGrid.Rows(e.RowIndex).Cells("Record_id").Value)
            ShowMedicalRecordDetails(recordId)
        End If
    End Sub

    Private Sub ShowMedicalRecordDetails(recordId As Integer)
        Dim detailsForm As New MedicalRecordDetailForm()
        detailsForm.RecordId = recordId
        detailsForm.ShowDialog()
    End Sub
End Class