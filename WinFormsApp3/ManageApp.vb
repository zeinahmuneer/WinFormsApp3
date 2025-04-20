Imports Microsoft.Data.SqlClient

Public Class ManageApp
    Public UserId As Integer
    Public Role As Integer
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
                    a.Date,
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

            ' Add Edit button if not added yet
            If Not DoctorApp.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = ""
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                DoctorApp.Columns.Add(editButton)
            End If

            ' Add Cancel button if not added yet
            If Not DoctorApp.Columns.Contains("Cancel") Then
                Dim cancelButton As New DataGridViewButtonColumn()
                cancelButton.Name = "Cancel"
                cancelButton.HeaderText = ""
                cancelButton.Text = "Cancel"
                cancelButton.UseColumnTextForButtonValue = True
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

        If DoctorApp.Columns(e.ColumnIndex).Name = "Edit" Then
            Dim editForm As New EditAppointmentForm(appointmentId)
            editForm.Role = Role
            editForm.ShowDialog()
            LoadDoctorAppointments()

        ElseIf DoctorApp.Columns(e.ColumnIndex).Name = "Cancel" Then
            If MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    If conApp.State <> ConnectionState.Closed Then conApp.Close()
                    conApp.Open()

                    Dim cancelCmd As New SqlCommand("UPDATE Appointment_Details SET Status = 3 WHERE Appointment_id = @AppointmentId", conApp)
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
        End If
    End Sub
End Class
