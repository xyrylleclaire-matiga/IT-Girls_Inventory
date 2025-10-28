<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Panel1 = New Panel()
        btnHome = New Button()
        btnBack = New Button()
        btnCorporateAttire = New Button()
        btnSchoolUniform = New Button()
        btnPeUniform = New Button()
        PanelUser = New Panel()
        picCorpo = New PictureBox()
        picPEUniform = New PictureBox()
        picSchoolUniform = New PictureBox()
        Panel1.SuspendLayout()
        PanelUser.SuspendLayout()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSlateGray
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnCorporateAttire)
        Panel1.Controls.Add(btnSchoolUniform)
        Panel1.Controls.Add(btnPeUniform)
        Panel1.Location = New Point(-2, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1263, 91)
        Panel1.TabIndex = 0
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.MediumTurquoise
        btnHome.FlatStyle = FlatStyle.Popup
        btnHome.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.Black
        btnHome.Location = New Point(32, 25)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(215, 46)
        btnHome.TabIndex = 67
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Teal
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Arial Rounded MT Bold", 10.0F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(1035, 23)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(180, 45)
        btnBack.TabIndex = 66
        btnBack.Text = "LOGOUT"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnCorporateAttire
        ' 
        btnCorporateAttire.BackColor = Color.MediumTurquoise
        btnCorporateAttire.FlatStyle = FlatStyle.Popup
        btnCorporateAttire.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCorporateAttire.ForeColor = Color.Black
        btnCorporateAttire.Location = New Point(776, 24)
        btnCorporateAttire.Name = "btnCorporateAttire"
        btnCorporateAttire.Size = New Size(215, 45)
        btnCorporateAttire.TabIndex = 65
        btnCorporateAttire.Text = "CORPORATE ATTIRE"
        btnCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' btnSchoolUniform
        ' 
        btnSchoolUniform.BackColor = Color.MediumTurquoise
        btnSchoolUniform.FlatStyle = FlatStyle.Popup
        btnSchoolUniform.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSchoolUniform.ForeColor = Color.Black
        btnSchoolUniform.Location = New Point(528, 24)
        btnSchoolUniform.Name = "btnSchoolUniform"
        btnSchoolUniform.Size = New Size(215, 46)
        btnSchoolUniform.TabIndex = 62
        btnSchoolUniform.Text = "SCHOOL UNIFORM"
        btnSchoolUniform.UseVisualStyleBackColor = False
        ' 
        ' btnPeUniform
        ' 
        btnPeUniform.BackColor = Color.MediumTurquoise
        btnPeUniform.FlatStyle = FlatStyle.Popup
        btnPeUniform.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPeUniform.ForeColor = Color.Black
        btnPeUniform.Location = New Point(280, 25)
        btnPeUniform.Name = "btnPeUniform"
        btnPeUniform.Size = New Size(215, 45)
        btnPeUniform.TabIndex = 64
        btnPeUniform.Text = "PE UNIFORM"
        btnPeUniform.UseVisualStyleBackColor = False
        ' 
        ' PanelUser
        ' 
        PanelUser.BackColor = Color.LightCyan
        PanelUser.Controls.Add(picCorpo)
        PanelUser.Controls.Add(picPEUniform)
        PanelUser.Controls.Add(picSchoolUniform)
        PanelUser.Location = New Point(-2, 85)
        PanelUser.Name = "PanelUser"
        PanelUser.Size = New Size(1263, 470)
        PanelUser.TabIndex = 1
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.LightGray
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(773, 57)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(272, 364)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 65
        picCorpo.TabStop = False
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.LightGray
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = CType(resources.GetObject("picPEUniform.Image"), Image)
        picPEUniform.Location = New Point(218, 57)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(275, 364)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 63
        picPEUniform.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(493, 35)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 401)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 64
        picSchoolUniform.TabStop = False
        ' 
        ' frmUser
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1257, 553)
        Controls.Add(Panel1)
        Controls.Add(PanelUser)
        Name = "frmUser"
        Text = "frmUser"
        Panel1.ResumeLayout(False)
        PanelUser.ResumeLayout(False)
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelUser As Panel
    Friend WithEvents btnPeUniform As Button
    Friend WithEvents btnSchoolUniform As Button
    Friend WithEvents btnCorporateAttire As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents btnHome As Button
End Class