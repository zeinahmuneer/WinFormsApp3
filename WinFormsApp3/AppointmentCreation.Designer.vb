<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentCreation
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
        Specialty = New ComboBox()
        Doctor = New ComboBox()
        DatePicker = New DateTimePicker()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        TimePicker = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 25)
        Label1.TabIndex = 0
        Label1.Text = "Pick a specialty"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 25)
        Label2.TabIndex = 1
        Label2.Text = "Pick the doctor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 2
        Label3.Text = "Pick a date"
        ' 
        ' Specialty
        ' 
        Specialty.FormattingEnabled = True
        Specialty.Location = New Point(57, 112)
        Specialty.Name = "Specialty"
        Specialty.Size = New Size(182, 33)
        Specialty.TabIndex = 3
        Specialty.Text = "Specialty"
        ' 
        ' Doctor
        ' 
        Doctor.FormattingEnabled = True
        Doctor.Location = New Point(57, 196)
        Doctor.Name = "Doctor"
        Doctor.Size = New Size(182, 33)
        Doctor.TabIndex = 4
        Doctor.Text = "Doctor"
        ' 
        ' DatePicker
        ' 
        DatePicker.Location = New Point(57, 290)
        DatePicker.Name = "DatePicker"
        DatePicker.Size = New Size(212, 31)
        DatePicker.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(57, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(312, 32)
        Label4.TabIndex = 6
        Label4.Text = "Create an new appointment"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(57, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 7
        Button1.Text = "&Confirm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(257, 355)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 8
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(350, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 25)
        Label5.TabIndex = 9
        Label5.Text = "Pick a time"
        ' 
        ' TimePicker
        ' 
        TimePicker.Location = New Point(350, 290)
        TimePicker.Name = "TimePicker"
        TimePicker.Size = New Size(212, 31)
        TimePicker.TabIndex = 10
        ' 
        ' AppointmentCreation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(649, 400)
        Controls.Add(TimePicker)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(DatePicker)
        Controls.Add(Doctor)
        Controls.Add(Specialty)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AppointmentCreation"
        Text = "Create An Appointment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Specialty As ComboBox
    Friend WithEvents Doctor As ComboBox
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TimePicker As DateTimePicker
End Class
