<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UserIdTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(10, 19)
        LogoPictureBox.Margin = New Padding(2)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(110, 142)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(138, 19)
        UsernameLabel.Margin = New Padding(2, 0, 2, 0)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(176, 18)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User Id"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(138, 78)
        PasswordLabel.Margin = New Padding(2, 0, 2, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(176, 18)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UserIdTextBox
        ' 
        UserIdTextBox.Location = New Point(138, 39)
        UserIdTextBox.Margin = New Padding(2)
        UserIdTextBox.Name = "UserIdTextBox"
        UserIdTextBox.Size = New Size(177, 27)
        UserIdTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(139, 98)
        PasswordTextBox.Margin = New Padding(2)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(177, 27)
        PasswordTextBox.TabIndex = 3
        PasswordTextBox.UseSystemPasswordChar = True
        ' 
        ' OK
        ' 
        OK.Location = New Point(139, 147)
        OK.Margin = New Padding(2)
        OK.Name = "OK"
        OK.Size = New Size(75, 32)
        OK.TabIndex = 4
        OK.Text = "&Login"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(241, 147)
        Cancel.Margin = New Padding(2)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(75, 32)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        ' 
        ' Login
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        CancelButton = Cancel
        ClientSize = New Size(381, 190)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UserIdTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

End Class
