<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMR
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
        MedicalRecordsGrid = New DataGridView()
        PrintMRBtn = New Button()
        CType(MedicalRecordsGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MedicalRecordsGrid
        ' 
        MedicalRecordsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MedicalRecordsGrid.Location = New Point(2, -2)
        MedicalRecordsGrid.Margin = New Padding(2)
        MedicalRecordsGrid.Name = "MedicalRecordsGrid"
        MedicalRecordsGrid.RowHeadersWidth = 62
        MedicalRecordsGrid.Size = New Size(726, 265)
        MedicalRecordsGrid.TabIndex = 0
        ' 
        ' PrintMRBtn
        ' 
        PrintMRBtn.Location = New Point(12, 268)
        PrintMRBtn.Name = "PrintMRBtn"
        PrintMRBtn.Size = New Size(226, 29)
        PrintMRBtn.TabIndex = 1
        PrintMRBtn.Text = "Print Medical Records"
        PrintMRBtn.UseVisualStyleBackColor = True
        ' 
        ' ViewMR
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(725, 308)
        Controls.Add(PrintMRBtn)
        Controls.Add(MedicalRecordsGrid)
        Margin = New Padding(2)
        Name = "ViewMR"
        Text = "ViewMR"
        CType(MedicalRecordsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MedicalRecordsGrid As DataGridView
    Friend WithEvents PrintMRBtn As Button
End Class
