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
        ConfirmButton = New Button()
        CancelButton = New Button()
        Label5 = New Label()
        TimePicker = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 56)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 0
        Label1.Text = "Pick a specialty"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 128)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 1
        Label2.Text = "Pick the doctor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 201)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 2
        Label3.Text = "Pick a date"
        ' 
        ' Specialty
        ' 
        Specialty.FormattingEnabled = True
        Specialty.Location = New Point(46, 90)
        Specialty.Margin = New Padding(2)
        Specialty.Name = "Specialty"
        Specialty.Size = New Size(146, 28)
        Specialty.TabIndex = 3
        Specialty.Text = "Specialty"
        ' 
        ' Doctor
        ' 
        Doctor.FormattingEnabled = True
        Doctor.Location = New Point(46, 157)
        Doctor.Margin = New Padding(2)
        Doctor.Name = "Doctor"
        Doctor.Size = New Size(146, 28)
        Doctor.TabIndex = 4
        Doctor.Text = "Doctor"
        ' 
        ' DatePicker
        ' 
        DatePicker.Location = New Point(46, 232)
        DatePicker.Margin = New Padding(2)
        DatePicker.Name = "DatePicker"
        DatePicker.Size = New Size(170, 27)
        DatePicker.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(46, 19)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(253, 28)
        Label4.TabIndex = 6
        Label4.Text = "Create an new appointment"
        ' 
        ' ConfirmButton
        ' 
        ConfirmButton.Location = New Point(46, 284)
        ConfirmButton.Margin = New Padding(2)
        ConfirmButton.Name = "ConfirmButton"
        ConfirmButton.Size = New Size(90, 27)
        ConfirmButton.TabIndex = 7
        ConfirmButton.Text = "&Confirm"
        ConfirmButton.TextImageRelation = TextImageRelation.ImageBeforeText
        ConfirmButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(206, 284)
        CancelButton.Margin = New Padding(2)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(90, 27)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(280, 201)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 9
        Label5.Text = "Pick a time"
        ' 
        ' TimePicker
        ' 
        TimePicker.Format = DateTimePickerFormat.Time
        TimePicker.Location = New Point(280, 232)
        TimePicker.Margin = New Padding(2)
        TimePicker.Name = "TimePicker"
        TimePicker.Size = New Size(170, 27)
        TimePicker.TabIndex = 10
        ' 
        ' AppointmentCreation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 346)
        Controls.Add(TimePicker)
        Controls.Add(Label5)
        Controls.Add(CancelButton)
        Controls.Add(ConfirmButton)
        Controls.Add(Label4)
        Controls.Add(DatePicker)
        Controls.Add(Doctor)
        Controls.Add(Specialty)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
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
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TimePicker As DateTimePicker
End Class
