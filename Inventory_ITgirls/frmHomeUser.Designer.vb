<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeUser))
        picCorpo = New PictureBox()
        picPEUniform = New PictureBox()
        picSchoolUniform = New PictureBox()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.LightGray
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(768, 40)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(272, 364)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 68
        picCorpo.TabStop = False
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.LightGray
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = CType(resources.GetObject("picPEUniform.Image"), Image)
        picPEUniform.Location = New Point(210, 40)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(275, 364)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 66
        picPEUniform.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(485, 18)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 401)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 67
        picSchoolUniform.TabStop = False
        ' 
        ' frmHomeUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1247, 431)
        Controls.Add(picCorpo)
        Controls.Add(picPEUniform)
        Controls.Add(picSchoolUniform)
        Name = "frmHomeUser"
        Text = "frmHomeUser"
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
End Class
