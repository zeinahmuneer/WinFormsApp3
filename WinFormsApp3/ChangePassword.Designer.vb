<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        OldPass = New TextBox()
        NewPass = New TextBox()
        ConfirmPass = New TextBox()
        SaveBtn = New Button()
        CancelBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 23)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter your old password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 111)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter the new password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 196)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 20)
        Label3.TabIndex = 2
        Label3.Text = "Confirm new password"
        ' 
        ' OldPass
        ' 
        OldPass.Location = New Point(32, 59)
        OldPass.Margin = New Padding(2)
        OldPass.Name = "OldPass"
        OldPass.Size = New Size(157, 27)
        OldPass.TabIndex = 3
        ' 
        ' NewPass
        ' 
        NewPass.Location = New Point(32, 144)
        NewPass.Margin = New Padding(2)
        NewPass.Name = "NewPass"
        NewPass.Size = New Size(157, 27)
        NewPass.TabIndex = 4
        NewPass.UseSystemPasswordChar = True
        ' 
        ' ConfirmPass
        ' 
        ConfirmPass.Location = New Point(32, 232)
        ConfirmPass.Margin = New Padding(2)
        ConfirmPass.Name = "ConfirmPass"
        ConfirmPass.Size = New Size(157, 27)
        ConfirmPass.TabIndex = 5
        ConfirmPass.UseSystemPasswordChar = True
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Location = New Point(32, 300)
        SaveBtn.Margin = New Padding(2)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(90, 27)
        SaveBtn.TabIndex = 6
        SaveBtn.Text = "&Save"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' CancelBtn
        ' 
        CancelBtn.Location = New Point(168, 300)
        CancelBtn.Margin = New Padding(2)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(90, 27)
        CancelBtn.TabIndex = 7
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 357)
        Controls.Add(CancelBtn)
        Controls.Add(SaveBtn)
        Controls.Add(ConfirmPass)
        Controls.Add(NewPass)
        Controls.Add(OldPass)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "ChangePassword"
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OldPass As TextBox
    Friend WithEvents NewPass As TextBox
    Friend WithEvents ConfirmPass As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
