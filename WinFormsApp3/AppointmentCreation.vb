Imports Microsoft.Data.SqlClient

Public Class AppointmentCreation
    Public UserId As Integer
    Private Sub AppointmentCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimePicker.Format = DateTimePickerFormat.Custom
        TimePicker.CustomFormat = "hh:mm tt"
        TimePicker.ShowUpDown = True
        TimePicker.Value = Date.Today.AddHours(8)
        DatePicker.Format = DateTimePickerFormat.Custom
        DatePicker.CustomFormat = "dd/MM/yyyy"
        DatePicker.Value = Date.Today
        DatePicker.MinDate = Date.Today

        LoadSpecialties()
    End Sub

    Private Sub TimePicker_ValueChanged(sender As Object, e As EventArgs) Handles TimePicker.ValueChanged
        Dim selectedTime As TimeSpan = TimePicker.Value.TimeOfDay
        Dim selectedDate As Date = TimePicker.Value.Date

        Dim startTime As New TimeSpan(8, 0, 0)
        Dim endTime As New TimeSpan(14, 0, 0)

        If selectedTime < startTime Then
            TimePicker.Value = selectedDate.Add(startTime)
            MessageBox.Show("Appointments are available between 8:00 AM and 2:00 PM.")
        ElseIf selectedTime > endTime Then
            TimePicker.Value = selectedDate.Add(endTime)
            MessageBox.Show("Appointments are available between 8:00 AM and 2:00 PM.")
        End If
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        ' Validate fields
        If Specialty.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a specialty.")
            Return
        End If

        If Doctor.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a doctor.")
            Return
        End If

        Dim appointmentDate As Date = DatePicker.Value.Date
        Dim appointmentTime As TimeSpan = TimePicker.Value.TimeOfDay
        Dim doctorId As String = Doctor.SelectedValue.ToString()
        Dim patientId As String = UserId
        Dim statusId As Integer = 1

        Try
            If conApp.State <> ConnectionState.Closed Then
                conApp.Close()
            End If
            conApp.Open()



            ' Insert the appointment
            Dim insertQuery As String = "
            INSERT INTO Appointment_Details (Patient_id, Doctor_id, Date, Time, Status)
            VALUES (@PatientId, @DoctorId, @Date, @Time, @Status)
        "

            Using insertCmd As New SqlCommand(insertQuery, conApp)
                insertCmd.Parameters.AddWithValue("@PatientId", patientId)
                insertCmd.Parameters.AddWithValue("@DoctorId", doctorId)
                insertCmd.Parameters.AddWithValue("@Date", appointmentDate)
                insertCmd.Parameters.AddWithValue("@Time", appointmentTime)
                insertCmd.Parameters.AddWithValue("@Status", statusId)

                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Appointment created successfully!")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error creating appointment: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Specialty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Specialty.SelectedIndexChanged
        If Specialty.SelectedValue IsNot Nothing Then
            Dim specialtyId As Integer = Convert.ToInt32(Specialty.SelectedValue)
            LoadDoctors(specialtyId)
        End If
    End Sub

    Private Sub LoadSpecialties()
        Try
            If conApp.State <> ConnectionState.Closed Then
                conApp.Close()
            End If
            conApp.Open()
            Using cmd As New SqlCommand("SELECT Specialty_id, Specialty FROM dbo.Specialty", conApp)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                Specialty.DisplayMember = "Specialty"
                Specialty.ValueMember = "Specialty_id"
                Specialty.DataSource = dt
            End Using

        Catch ex As Exception
        Finally
            conApp.Close()
        End Try

    End Sub

    Private Sub LoadDoctors(specialtyId As Integer)
        Try
            If conApp.State <> ConnectionState.Closed Then
                conApp.Close()
            End If
            conApp.Open()
            Dim query As String = "
            SELECT d.Doctor_id, 
                   (a.First_Name + ' ' + a.Last_Name) AS DoctorName
            FROM Doctor d
            INNER JOIN Account_Details a ON d.Doctor_id = a.User_id
            WHERE d.Specialty = @SpecialtyId"

            Using cmd As New SqlCommand(query, conApp)
                cmd.Parameters.AddWithValue("@SpecialtyId", specialtyId)

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                Doctor.DisplayMember = "DoctorName"
                Doctor.ValueMember = "Doctor_id"
                Doctor.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading doctors: " & ex.Message)
        Finally
            conApp.Close()
        End Try
        Doctor.SelectedIndex = -1
        Doctor.Text = "Doctor"
    End Sub
End Class