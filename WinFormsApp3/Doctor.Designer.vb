<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ManageAppointmentToolStripMenuItem = New ToolStripMenuItem()
        ManageAppointmentsToolStripMenuItem = New ToolStripMenuItem()
        MedicalRecordsToolStripMenuItem = New ToolStripMenuItem()
        ViewPatientsMRToolStripMenuItem = New ToolStripMenuItem()
        AccountManagementToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManageAppointmentToolStripMenuItem, MedicalRecordsToolStripMenuItem, AccountManagementToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(657, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ManageAppointmentToolStripMenuItem
        ' 
        ManageAppointmentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManageAppointmentsToolStripMenuItem})
        ManageAppointmentToolStripMenuItem.Name = "ManageAppointmentToolStripMenuItem"
        ManageAppointmentToolStripMenuItem.Size = New Size(134, 29)
        ManageAppointmentToolStripMenuItem.Text = "Appointment"
        ' 
        ' ManageAppointmentsToolStripMenuItem
        ' 
        ManageAppointmentsToolStripMenuItem.Name = "ManageAppointmentsToolStripMenuItem"
        ManageAppointmentsToolStripMenuItem.Size = New Size(294, 34)
        ManageAppointmentsToolStripMenuItem.Text = "Manage appointments"
        ' 
        ' MedicalRecordsToolStripMenuItem
        ' 
        MedicalRecordsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewPatientsMRToolStripMenuItem})
        MedicalRecordsToolStripMenuItem.Name = "MedicalRecordsToolStripMenuItem"
        MedicalRecordsToolStripMenuItem.Size = New Size(157, 29)
        MedicalRecordsToolStripMenuItem.Text = "Medical Records"
        ' 
        ' ViewPatientsMRToolStripMenuItem
        ' 
        ViewPatientsMRToolStripMenuItem.Name = "ViewPatientsMRToolStripMenuItem"
        ViewPatientsMRToolStripMenuItem.Size = New Size(255, 34)
        ViewPatientsMRToolStripMenuItem.Text = "View patient's MR"
        ' 
        ' AccountManagementToolStripMenuItem
        ' 
        AccountManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem, LogoutToolStripMenuItem})
        AccountManagementToolStripMenuItem.Name = "AccountManagementToolStripMenuItem"
        AccountManagementToolStripMenuItem.Size = New Size(167, 29)
        AccountManagementToolStripMenuItem.Text = "Manage Account "
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(256, 34)
        ChangePasswordToolStripMenuItem.Text = "Change password"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(256, 34)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' Doctor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 449)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Doctor"
        Text = "Doctor"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAppointmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPatientsMRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
