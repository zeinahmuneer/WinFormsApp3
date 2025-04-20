<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageApp
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
        DoctorApp = New DataGridView()
        CType(DoctorApp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DoctorApp
        ' 
        DoctorApp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DoctorApp.Location = New Point(-4, 1)
        DoctorApp.Margin = New Padding(2)
        DoctorApp.Name = "DoctorApp"
        DoctorApp.RowHeadersWidth = 62
        DoctorApp.Size = New Size(821, 362)
        DoctorApp.TabIndex = 0
        ' 
        ' ManageApp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 362)
        Controls.Add(DoctorApp)
        Margin = New Padding(2)
        Name = "ManageApp"
        Text = "ManageApp"
        CType(DoctorApp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DoctorApp As DataGridView
End Class
