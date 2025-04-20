Imports Microsoft.Data.SqlClient

Public Class ChangePassword
    Public UserId As String ' Assuming UserId is passed or available
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If OldPass.Text = String.Empty Or NewPass.Text = String.Empty Or ConfirmPass.Text = String.Empty Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        If NewPass.Text <> ConfirmPass.Text Then
            MessageBox.Show("New password and confirm password do not match.")
            Return
        End If

        Try
            If conApp.State <> ConnectionState.Closed Then conApp.Close()
            conApp.Open()

            Dim checkPasswordCmd As New SqlCommand("SELECT Password FROM Account_Details WHERE User_id = @UserId", conApp)
            checkPasswordCmd.Parameters.AddWithValue("@UserId", UserId)

            Dim currentPassword As String = Convert.ToString(checkPasswordCmd.ExecuteScalar())

            If currentPassword.Trim() <> OldPass.Text.Trim() Then
                MessageBox.Show("The old password is incorrect.")
                Return
            End If

            Dim updatePasswordCmd As New SqlCommand("UPDATE Account_Details SET Password = @NewPassword WHERE User_id = @UserId", conApp)
            updatePasswordCmd.Parameters.AddWithValue("@NewPassword", NewPass.Text)
            updatePasswordCmd.Parameters.AddWithValue("@UserId", UserId)

            updatePasswordCmd.ExecuteNonQuery()

            MessageBox.Show("Password changed successfully!")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error changing password: " & ex.Message)
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class
