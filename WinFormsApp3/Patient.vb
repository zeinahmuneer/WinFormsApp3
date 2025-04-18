Public Class Patient
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


End Class
