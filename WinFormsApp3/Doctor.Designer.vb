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
        UserName = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ManageAppointmentToolStripMenuItem, MedicalRecordsToolStripMenuItem, AccountManagementToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(526, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ManageAppointmentToolStripMenuItem
        ' 
        ManageAppointmentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManageAppointmentsToolStripMenuItem})
        ManageAppointmentToolStripMenuItem.Name = "ManageAppointmentToolStripMenuItem"
        ManageAppointmentToolStripMenuItem.Size = New Size(111, 24)
        ManageAppointmentToolStripMenuItem.Text = "Appointment"
        ' 
        ' ManageAppointmentsToolStripMenuItem
        ' 
        ManageAppointmentsToolStripMenuItem.Name = "ManageAppointmentsToolStripMenuItem"
        ManageAppointmentsToolStripMenuItem.Size = New Size(242, 26)
        ManageAppointmentsToolStripMenuItem.Text = "Manage appointments"
        ' 
        ' MedicalRecordsToolStripMenuItem
        ' 
        MedicalRecordsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewPatientsMRToolStripMenuItem})
        MedicalRecordsToolStripMenuItem.Name = "MedicalRecordsToolStripMenuItem"
        MedicalRecordsToolStripMenuItem.Size = New Size(133, 24)
        MedicalRecordsToolStripMenuItem.Text = "Medical Records"
        ' 
        ' ViewPatientsMRToolStripMenuItem
        ' 
        ViewPatientsMRToolStripMenuItem.Name = "ViewPatientsMRToolStripMenuItem"
        ViewPatientsMRToolStripMenuItem.Size = New Size(210, 26)
        ViewPatientsMRToolStripMenuItem.Text = "View patient's MR"
        ' 
        ' AccountManagementToolStripMenuItem
        ' 
        AccountManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem, LogoutToolStripMenuItem})
        AccountManagementToolStripMenuItem.Name = "AccountManagementToolStripMenuItem"
        AccountManagementToolStripMenuItem.Size = New Size(139, 24)
        AccountManagementToolStripMenuItem.Text = "Manage Account "
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(209, 26)
        ChangePasswordToolStripMenuItem.Text = "Change password"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(209, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' UserName
        ' 
        UserName.AutoSize = True
        UserName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserName.Location = New Point(0, 28)
        UserName.Name = "UserName"
        UserName.Padding = New Padding(11, 0, 0, 0)
        UserName.Size = New Size(117, 20)
        UserName.TabIndex = 3
        UserName.Text = "Doctor Name: "
        ' 
        ' Doctor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(526, 359)
        Controls.Add(UserName)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
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
    Friend WithEvents UserName As Label
End Class
