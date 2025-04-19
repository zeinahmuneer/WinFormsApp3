Public Class Doctor
    Public UserId As Integer
    Public UserFirstName As String

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserName.Text = "Doctor Name: " + UserFirstName
    End Sub
    Private Sub ManageAppointmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAppointmentsToolStripMenuItem.Click
        ManageApp.MdiParent = Me
        ManageApp.Show()
    End Sub
    Private Sub ChangepasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.MdiParent = Me
        ChangePassword.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ViewPatientsMRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPatientsMRToolStripMenuItem.Click
        PatientMRs.MdiParent = Me
        PatientMRs.Show()
    End Sub

End Class