Imports Microsoft.Data.SqlClient

Public Class AppointmentCreation

    Private Sub AppointmentCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimePicker.Format = DateTimePickerFormat.Custom
        TimePicker.CustomFormat = "hh:mm tt"
        TimePicker.ShowUpDown = True
        TimePicker.Value = Date.Today.AddHours(8)

        LoadSpecialties()
    End Sub

    Private Sub TimePicker_ValueChanged(sender As Object, e As EventArgs) Handles TimePicker.ValueChanged
        Dim selectedTime As TimeSpan = TimePicker.Value.TimeOfDay
        Dim startTime As TimeSpan = New TimeSpan(8, 0, 0)
        Dim endTime As TimeSpan = New TimeSpan(14, 0, 0)

        If selectedTime < startTime Or selectedTime > endTime Then
            MessageBox.Show("Appointments are available between 8:00 AM and 2:00 PM.")
        End If
    End Sub

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged
        DatePicker.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        MsgBox("Appointment created successfully!")
        Me.Close()
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

    Private Sub Doctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Doctor.SelectedIndexChanged

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
    End Sub
End Class