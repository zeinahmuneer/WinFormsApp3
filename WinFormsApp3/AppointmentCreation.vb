Public Class AppointmentCreation

    Private Sub AppointmentCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimePicker.Format = DateTimePickerFormat.Custom
        TimePicker.CustomFormat = "hh:mm tt"
        TimePicker.ShowUpDown = True
        TimePicker.Value = Date.Today.AddHours(8)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Appointment created successfully!")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class