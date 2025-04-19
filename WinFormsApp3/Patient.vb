Public Class Patient
    Public UserId As Integer
    Public UserFirstName As String


    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserName.Text = "Patient Name: " + UserFirstName

    End Sub
    Private Sub MakeAnAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeAnAppointmentToolStripMenuItem.Click
        AppointmentCreation.MdiParent = Me
        AppointmentCreation.Show()
    End Sub

    Private Sub EditAnAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAnAppointmentToolStripMenuItem.Click
        EditApp.MdiParent = Me
        EditApp.Show()
    End Sub

    Private Sub ViewMedicalReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMedicalReportsToolStripMenuItem.Click
        ViewMR.MdiParent = Me
        ViewMR.UserId = UserId
        ViewMR.Show()
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.MdiParent = Me
        ChangePassword.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

End Class
