<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        AppointmentsToolStripMenuItem = New ToolStripMenuItem()
        MakeAnAppointmentToolStripMenuItem = New ToolStripMenuItem()
        EditAnAppointmentToolStripMenuItem = New ToolStripMenuItem()
        MedicalRecordsToolStripMenuItem = New ToolStripMenuItem()
        ViewMedicalReportsToolStripMenuItem = New ToolStripMenuItem()
        ManageAccountToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AppointmentsToolStripMenuItem, MedicalRecordsToolStripMenuItem, ManageAccountToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AppointmentsToolStripMenuItem
        ' 
        AppointmentsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MakeAnAppointmentToolStripMenuItem, EditAnAppointmentToolStripMenuItem})
        AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem"
        AppointmentsToolStripMenuItem.Size = New Size(142, 29)
        AppointmentsToolStripMenuItem.Text = "Appointments"
        ' 
        ' MakeAnAppointmentToolStripMenuItem
        ' 
        MakeAnAppointmentToolStripMenuItem.Name = "MakeAnAppointmentToolStripMenuItem"
        MakeAnAppointmentToolStripMenuItem.Size = New Size(289, 34)
        MakeAnAppointmentToolStripMenuItem.Text = "Make an appointment"
        ' 
        ' EditAnAppointmentToolStripMenuItem
        ' 
        EditAnAppointmentToolStripMenuItem.Name = "EditAnAppointmentToolStripMenuItem"
        EditAnAppointmentToolStripMenuItem.Size = New Size(289, 34)
        EditAnAppointmentToolStripMenuItem.Text = "Edit an appointment"
        ' 
        ' MedicalRecordsToolStripMenuItem
        ' 
        MedicalRecordsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewMedicalReportsToolStripMenuItem})
        MedicalRecordsToolStripMenuItem.Name = "MedicalRecordsToolStripMenuItem"
        MedicalRecordsToolStripMenuItem.Size = New Size(157, 29)
        MedicalRecordsToolStripMenuItem.Text = "Medical Records"
        ' 
        ' ViewMedicalReportsToolStripMenuItem
        ' 
        ViewMedicalReportsToolStripMenuItem.Name = "ViewMedicalReportsToolStripMenuItem"
        ViewMedicalReportsToolStripMenuItem.Size = New Size(283, 34)
        ViewMedicalReportsToolStripMenuItem.Text = "View Medical Reports"
        ' 
        ' ManageAccountToolStripMenuItem
        ' 
        ManageAccountToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem, LogoutToolStripMenuItem})
        ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem"
        ManageAccountToolStripMenuItem.Size = New Size(162, 29)
        ManageAccountToolStripMenuItem.Text = "Manage Account"
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(270, 34)
        ChangePasswordToolStripMenuItem.Text = "Change password"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(270, 34)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' Patient
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Patient"
        Text = "Patient"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AppointmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeAnAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAnAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMedicalReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem

End Class
