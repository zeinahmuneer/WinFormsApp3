<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMRs
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
        PatientId = New TextBox()
        SearchBtn = New Button()
        PatientMr = New DataGridView()
        CType(PatientMr, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 29)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter patient's Id:"
        ' 
        ' PatientId
        ' 
        PatientId.Location = New Point(146, 26)
        PatientId.Margin = New Padding(2)
        PatientId.Name = "PatientId"
        PatientId.Size = New Size(121, 27)
        PatientId.TabIndex = 1
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Location = New Point(290, 26)
        SearchBtn.Margin = New Padding(2)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(90, 27)
        SearchBtn.TabIndex = 2
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' PatientMr
        ' 
        PatientMr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PatientMr.Location = New Point(10, 85)
        PatientMr.Margin = New Padding(2)
        PatientMr.Name = "PatientMr"
        PatientMr.RowHeadersWidth = 62
        PatientMr.Size = New Size(705, 248)
        PatientMr.TabIndex = 3
        ' 
        ' PatientMRs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(726, 344)
        Controls.Add(PatientMr)
        Controls.Add(SearchBtn)
        Controls.Add(PatientId)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "PatientMRs"
        Text = "PatientMRs"
        CType(PatientMr, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PatientId As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents PatientMr As DataGridView
End Class
