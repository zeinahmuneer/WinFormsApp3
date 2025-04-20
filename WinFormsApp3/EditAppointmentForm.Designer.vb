<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAppointmentForm
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
        lblSelect = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtpDate = New DateTimePicker()
        dtpTime = New DateTimePicker()
        btnSave = New Button()
        btnCancel = New Button()
        cmbSelect = New ComboBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Location = New Point(26, 71)
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(55, 20)
        lblSelect.TabIndex = 0
        lblSelect.Text = "Doctor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 1
        Label2.Text = "Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 2
        Label3.Text = "Time"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(26, 190)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(250, 27)
        dtpDate.TabIndex = 3
        ' 
        ' dtpTime
        ' 
        dtpTime.Format = DateTimePickerFormat.Time
        dtpTime.Location = New Point(26, 271)
        dtpTime.Name = "dtpTime"
        dtpTime.Size = New Size(250, 27)
        dtpTime.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(26, 356)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(182, 356)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' cmbSelect
        ' 
        cmbSelect.FormattingEnabled = True
        cmbSelect.Location = New Point(26, 103)
        cmbSelect.Name = "cmbSelect"
        cmbSelect.Size = New Size(174, 28)
        cmbSelect.TabIndex = 7
        cmbSelect.Text = "Doctor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(26, 24)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 28)
        Label4.TabIndex = 8
        Label4.Text = "Edit Appointment"
        ' 
        ' EditAppointmentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 450)
        Controls.Add(Label4)
        Controls.Add(cmbSelect)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(dtpTime)
        Controls.Add(dtpDate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblSelect)
        Name = "EditAppointmentForm"
        Text = "EditAppointmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSelect As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbSelect As ComboBox
    Friend WithEvents Label4 As Label
End Class
