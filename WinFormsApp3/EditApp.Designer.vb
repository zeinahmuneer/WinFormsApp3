<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditApp
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
        AppInfo = New DataGridView()
        Edit = New Button()
        CType(AppInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AppInfo
        ' 
        AppInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AppInfo.Location = New Point(-1, 1)
        AppInfo.Name = "AppInfo"
        AppInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        AppInfo.Size = New Size(716, 264)
        AppInfo.TabIndex = 0
        ' 
        ' Edit
        ' 
        Edit.Location = New Point(12, 285)
        Edit.Name = "Edit"
        Edit.Size = New Size(112, 34)
        Edit.TabIndex = 1
        Edit.Text = "&Edit"
        Edit.UseVisualStyleBackColor = True
        ' 
        ' EditApp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(715, 344)
        Controls.Add(Edit)
        Controls.Add(AppInfo)
        Name = "EditApp"
        Text = "View or Edit Appointments"
        CType(AppInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AppInfo As DataGridView
    Friend WithEvents Edit As Button
End Class
