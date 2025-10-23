<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Panel1 = New Panel()
        picPEUniform = New PictureBox()
        picSchoolUniform = New PictureBox()
        picCorpo = New PictureBox()
        Panel2 = New Panel()
        btnPeUniform = New Button()
        btnSchoolUniform = New Button()
        btnCorporateAttire = New Button()
        Panel1.SuspendLayout()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(btnCorporateAttire)
        Panel1.Controls.Add(btnSchoolUniform)
        Panel1.Controls.Add(btnPeUniform)
        Panel1.Controls.Add(picPEUniform)
        Panel1.Controls.Add(picCorpo)
        Panel1.Controls.Add(picSchoolUniform)
        Panel1.Location = New Point(-2, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1263, 166)
        Panel1.TabIndex = 0
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.CadetBlue
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview__1_
        picPEUniform.Location = New Point(137, 15)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(127, 142)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 42
        picPEUniform.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.CadetBlue
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(308, 15)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(127, 142)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 48
        picSchoolUniform.TabStop = False
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.CadetBlue
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(459, 15)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(125, 142)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 63
        picCorpo.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Location = New Point(-2, 160)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1263, 395)
        Panel2.TabIndex = 1
        ' 
        ' btnPeUniform
        ' 
        btnPeUniform.BackColor = Color.DarkSlateGray
        btnPeUniform.FlatStyle = FlatStyle.Popup
        btnPeUniform.Font = New Font("Arial Rounded MT Bold", 8F)
        btnPeUniform.ForeColor = Color.MintCream
        btnPeUniform.Location = New Point(157, 129)
        btnPeUniform.Name = "btnPeUniform"
        btnPeUniform.Size = New Size(92, 18)
        btnPeUniform.TabIndex = 64
        btnPeUniform.Text = "PE UNIFORM"
        btnPeUniform.UseVisualStyleBackColor = False
        ' 
        ' btnSchoolUniform
        ' 
        btnSchoolUniform.BackColor = Color.DarkSlateGray
        btnSchoolUniform.FlatStyle = FlatStyle.Popup
        btnSchoolUniform.Font = New Font("Arial Rounded MT Bold", 8F)
        btnSchoolUniform.ForeColor = Color.MintCream
        btnSchoolUniform.Location = New Point(313, 129)
        btnSchoolUniform.Name = "btnSchoolUniform"
        btnSchoolUniform.Size = New Size(117, 18)
        btnSchoolUniform.TabIndex = 62
        btnSchoolUniform.Text = "SCHOOL UNIFORM"
        btnSchoolUniform.UseVisualStyleBackColor = False
        ' 
        ' btnCorporateAttire
        ' 
        btnCorporateAttire.BackColor = Color.DarkSlateGray
        btnCorporateAttire.FlatStyle = FlatStyle.Popup
        btnCorporateAttire.Font = New Font("Arial Rounded MT Bold", 7F)
        btnCorporateAttire.ForeColor = Color.MintCream
        btnCorporateAttire.Location = New Point(459, 129)
        btnCorporateAttire.Name = "btnCorporateAttire"
        btnCorporateAttire.Size = New Size(125, 18)
        btnCorporateAttire.TabIndex = 65
        btnCorporateAttire.Text = "CORPORATE ATTIRE"
        btnCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' frmUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1257, 553)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "frmUser"
        Text = "frmUser"
        Panel1.ResumeLayout(False)
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPeUniform As Button
    Friend WithEvents btnSchoolUniform As Button
    Friend WithEvents btnCorporateAttire As Button
End Class
