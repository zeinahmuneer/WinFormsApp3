Imports Microsoft.Data.SqlClient
Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            conApp.Open()
            Dim com As New SqlCommand("SELECT Role, First_Name FROM Account_Details WHERE User_id=@userid AND Password=@password", conApp)
            com.Parameters.Add("@userid", SqlDbType.NVarChar, 4).Value = UserIdTextBox.Text
            com.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = PasswordTextBox.Text

            Dim reader As SqlDataReader = com.ExecuteReader()
            If reader.Read() Then
                Dim role As Integer = Convert.ToInt32(reader("Role"))
                Dim firstName As String = reader("First_Name").ToString()

                reader.Close()

                If role = 1 Then
                    Doctor.UserFirstName = firstName
                    Doctor.UserId = Convert.ToInt32(UserIdTextBox.Text)
                    Doctor.Show()
                Else
                    Patient.UserFirstName = firstName
                    Patient.UserId = Convert.ToInt32(UserIdTextBox.Text)
                    Patient.Show()
                End If

            Else
                reader.Close()
                MsgBox("Invalid credentials.")
            End If

            UserIdTextBox.Clear()
            PasswordTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message & " Login info is incorrect")
        Finally
            conApp.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class