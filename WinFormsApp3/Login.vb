Imports Microsoft.Data.SqlClient
Public Class Login


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            conApp.Open()

            Dim com As New SqlCommand("select Role from Account_Details where User_id=@userid and Password=@password", conApp)

            com.Parameters.Add("@userid", SqlDbType.NVarChar, 4).Value = UsernameTextBox.Text
            com.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = PasswordTextBox.Text

            Dim Role As Object = com.ExecuteScalar

            If Role IsNot Nothing Then
                If CInt(Role) = 1 Then
                    Patient.Show()
                Else
                    Doctor.Show()
                End If
            Else
                MsgBox("Invalid credentials.")
            End If
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message & "Login info is incorrect")
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
