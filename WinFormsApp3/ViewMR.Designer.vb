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
        MedicalRecordsGrid.Size = New Size(883, 329)
        MedicalRecordsGrid.TabIndex = 0
        ' 
        ' ViewMR
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 240)
        Controls.Add(MedicalRecordsGrid)
        Margin = New Padding(2)
        Name = "ViewMR"
        Text = "ViewMR"
        CType(MedicalRecordsGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MedicalRecordsGrid As DataGridView
End Class
