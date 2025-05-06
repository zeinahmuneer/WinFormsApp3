<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalRecordDetailForm
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
        VisitNotesTextBox = New TextBox()
        MedicationsTextBox = New TextBox()
        DoctorNameLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CloseButton = New Button()
        PatientName = New Label()
        MedicalRBtn = New Button()
        SuspendLayout()
        ' 
        ' VisitNotesTextBox
        ' 
        VisitNotesTextBox.Location = New Point(12, 113)
        VisitNotesTextBox.Multiline = True
        VisitNotesTextBox.Name = "VisitNotesTextBox"
        VisitNotesTextBox.ReadOnly = True
        VisitNotesTextBox.Size = New Size(284, 158)
        VisitNotesTextBox.TabIndex = 0
        ' 
        ' MedicationsTextBox
        ' 
        MedicationsTextBox.Location = New Point(325, 113)
        MedicationsTextBox.Multiline = True
        MedicationsTextBox.Name = "MedicationsTextBox"
        MedicationsTextBox.ReadOnly = True
        MedicationsTextBox.Size = New Size(284, 158)
        MedicationsTextBox.TabIndex = 1
        ' 
        ' DoctorNameLabel
        ' 
        DoctorNameLabel.AutoSize = True
        DoctorNameLabel.Location = New Point(12, 42)
        DoctorNameLabel.Name = "DoctorNameLabel"
        DoctorNameLabel.Size = New Size(106, 20)
        DoctorNameLabel.TabIndex = 2
        DoctorNameLabel.Text = "Doctor Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 3
        Label2.Text = "VisitNotes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(325, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 4
        Label3.Text = "Medications"
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(12, 292)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(94, 29)
        CloseButton.TabIndex = 5
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' PatientName
        ' 
        PatientName.AutoSize = True
        PatientName.Location = New Point(12, 9)
        PatientName.Name = "PatientName"
        PatientName.Size = New Size(105, 20)
        PatientName.TabIndex = 6
        PatientName.Text = "Patient Name: "
        ' 
        ' MedicalRBtn
        ' 
        MedicalRBtn.Location = New Point(130, 292)
        MedicalRBtn.Name = "MedicalRBtn"
        MedicalRBtn.Size = New Size(166, 29)
        MedicalRBtn.TabIndex = 7
        MedicalRBtn.Text = "Print Medical Record"
        MedicalRBtn.UseVisualStyleBackColor = True
        ' 
        ' MedicalRecordDetailForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 333)
        Controls.Add(MedicalRBtn)
        Controls.Add(PatientName)
        Controls.Add(CloseButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DoctorNameLabel)
        Controls.Add(MedicationsTextBox)
        Controls.Add(VisitNotesTextBox)
        Name = "MedicalRecordDetailForm"
        Text = "MedicalRecordDetailForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents VisitNotesTextBox As TextBox
    Friend WithEvents MedicationsTextBox As TextBox
    Friend WithEvents DoctorNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents PatientName As Label
    Friend WithEvents MedicalRBtn As Button
End Class
