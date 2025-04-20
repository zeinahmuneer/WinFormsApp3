Imports Microsoft.Data.SqlClient

Public Class EditAppointmentForm
    Private AppointmentId As Integer
    Public Role As Integer

    Public Sub New(appId As Integer)
        InitializeComponent()
        AppointmentId = appId
    End Sub

    Private Sub EditAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "dd/MM/yyyy"
        dtpDate.MinDate = Date.Today

        dtpTime.Format = DateTimePickerFormat.Custom
        dtpTime.CustomFormat = "hh:mm tt"
        dtpTime.ShowUpDown = True
        dtpTime.Value = Date.Today.AddHours(8)

        LoadAppointmentDetails()
    End Sub

    Private Sub LoadAppointmentDetails()
        Dim apptDate As Date = Date.Today
        Dim apptTime As TimeSpan = New TimeSpan(8, 0, 0)
        Dim specialtyId As Integer = 0
        Dim doctorId As String = ""
        Dim statusId As Integer = 1

        Try
            If conApp.State <> ConnectionState.Open Then conApp.Open()

            Dim query As String = "
                SELECT a.Date, a.Time, a.Doctor_id, a.Status, d.Specialty AS SpecialtyId
                FROM Appointment_Details a
                JOIN Doctor d ON a.Doctor_id = d.Doctor_id
                WHERE a.Appointment_id = @AppointmentId
            "

            Using cmd As New SqlCommand(query, conApp)
                cmd.Parameters.AddWithValue("@AppointmentId", AppointmentId)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        apptDate = Convert.ToDateTime(reader("Date"))
                        apptTime = reader.GetTimeSpan(reader.GetOrdinal("Time"))
                        doctorId = reader("Doctor_id").ToString()
                        specialtyId = Convert.ToInt32(reader("SpecialtyId"))
                        statusId = Convert.ToInt32(reader("Status"))
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading appointment: " & ex.Message)
            Return
        Finally
            conApp.Close()
        End Try

        dtpDate.Value = apptDate
        dtpTime.Value = Date.Today.Add(apptTime)
        If Role = 1 Then
            lblSelect.Text = "Status:"
            LoadStatuses()
            cmbSelect.SelectedValue = statusId
        Else
            lblSelect.Text = "Doctor:"
            LoadDoctors(specialtyId)
            cmbSelect.SelectedValue = doctorId
        End If
    End Sub

    Private Sub LoadDoctors(specialtyId As Integer)
        Try
            If conApp.State <> ConnectionState.Open Then conApp.Open()

            Dim query As String = "
                SELECT d.Doctor_id,
                       ad.First_Name + ' ' + ad.Last_Name AS FullName
                FROM Doctor d
                JOIN Account_Details ad ON d.Doctor_id = ad.User_id
                WHERE d.Specialty = @SpecialtyId
            "

            Using cmd As New SqlCommand(query, conApp)
                cmd.Parameters.AddWithValue("@SpecialtyId", specialtyId)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                cmbSelect.DataSource = dt
                cmbSelect.DisplayMember = "FullName"
                cmbSelect.ValueMember = "Doctor_id"
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading doctors: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub LoadStatuses()
        Try
            If conApp.State <> ConnectionState.Open Then conApp.Open()

            Dim query As String = "SELECT Status_id, Status FROM Appointment_Status"

            Using cmd As New SqlCommand(query, conApp)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                cmbSelect.DataSource = dt
                cmbSelect.DisplayMember = "Status"
                cmbSelect.ValueMember = "Status_id"
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading statuses: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        Dim selectedTime As TimeSpan = dtpTime.Value.TimeOfDay
        Dim selectedDate As Date = dtpTime.Value.Date
        Dim startTime As New TimeSpan(8, 0, 0)
        Dim endTime As New TimeSpan(14, 0, 0)

        If selectedTime < startTime Then
            dtpTime.Value = selectedDate.Add(startTime)
            MessageBox.Show("Appointments are available between 8:00 AM and 2:00 PM.")
        ElseIf selectedTime > endTime Then
            dtpTime.Value = selectedDate.Add(endTime)
            MessageBox.Show("Appointments are available between 8:00 AM and 2:00 PM.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If conApp.State <> ConnectionState.Open Then conApp.Open()

            Dim query As String

            If Role = 1 Then
                query = "
                    UPDATE Appointment_Details
                    SET Date = @Date,
                        Time = @Time,
                        Status = @Status
                    WHERE Appointment_id = @AppointmentId
                "
            Else
                query = "
                    UPDATE Appointment_Details
                    SET Date = @Date,
                        Time = @Time,
                        Doctor_id = @DoctorId
                    WHERE Appointment_id = @AppointmentId
                "
            End If

            Using cmd As New SqlCommand(query, conApp)
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date)
                cmd.Parameters.AddWithValue("@Time", dtpTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@AppointmentId", AppointmentId)

                If Role = 1 Then
                    cmd.Parameters.AddWithValue("@Status", cmbSelect.SelectedValue)
                Else
                    cmd.Parameters.AddWithValue("@DoctorId", cmbSelect.SelectedValue)
                End If

                cmd.ExecuteNonQuery()
                MessageBox.Show("Appointment updated successfully.")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating appointment: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
