<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeAdmin))
        PanelMain = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        btnCorporateAttire = New Button()
        picCorpo = New PictureBox()
        btnSchoolUniform = New Button()
        btnPeUniform = New Button()
        picPEUniform = New PictureBox()
        picSchoolUniform = New PictureBox()
        PanelMain.SuspendLayout()
        CType(picCorpo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.LightCyan
        PanelMain.Controls.Add(Label3)
        PanelMain.Controls.Add(Label4)
        PanelMain.Controls.Add(btnCorporateAttire)
        PanelMain.Controls.Add(picCorpo)
        PanelMain.Controls.Add(btnSchoolUniform)
        PanelMain.Controls.Add(btnPeUniform)
        PanelMain.Controls.Add(picPEUniform)
        PanelMain.Controls.Add(picSchoolUniform)
        PanelMain.Location = New Point(-7, -10)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1054, 590)
        PanelMain.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkSlateGray
        Label3.Location = New Point(697, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 24)
        Label3.TabIndex = 69
        Label3.Text = "ADMIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkSlateGray
        Label4.Location = New Point(310, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(400, 43)
        Label4.TabIndex = 68
        Label4.Text = "INVENTORY SYSTEM"
        ' 
        ' btnCorporateAttire
        ' 
        btnCorporateAttire.BackColor = Color.DarkSlateGray
        btnCorporateAttire.FlatStyle = FlatStyle.Popup
        btnCorporateAttire.Font = New Font("Arial Rounded MT Bold", 16F)
        btnCorporateAttire.ForeColor = Color.MintCream
        btnCorporateAttire.Location = New Point(686, 404)
        btnCorporateAttire.Name = "btnCorporateAttire"
        btnCorporateAttire.Size = New Size(254, 38)
        btnCorporateAttire.TabIndex = 63
        btnCorporateAttire.Text = "CORPORATE ATTIRE"
        btnCorporateAttire.UseVisualStyleBackColor = False
        ' 
        ' picCorpo
        ' 
        picCorpo.BackColor = Color.LightGray
        picCorpo.BorderStyle = BorderStyle.Fixed3D
        picCorpo.Image = CType(resources.GetObject("picCorpo.Image"), Image)
        picCorpo.Location = New Point(677, 123)
        picCorpo.Name = "picCorpo"
        picCorpo.Size = New Size(272, 364)
        picCorpo.SizeMode = PictureBoxSizeMode.StretchImage
        picCorpo.TabIndex = 62
        picCorpo.TabStop = False
        ' 
        ' btnSchoolUniform
        ' 
        btnSchoolUniform.BackColor = Color.DarkSlateGray
        btnSchoolUniform.FlatStyle = FlatStyle.Popup
        btnSchoolUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnSchoolUniform.ForeColor = Color.MintCream
        btnSchoolUniform.Location = New Point(405, 415)
        btnSchoolUniform.Name = "btnSchoolUniform"
        btnSchoolUniform.Size = New Size(264, 38)
        btnSchoolUniform.TabIndex = 61
        btnSchoolUniform.Text = "SCHOOL UNIFORM"
        btnSchoolUniform.UseVisualStyleBackColor = False
        ' 
        ' btnPeUniform
        ' 
        btnPeUniform.BackColor = Color.DarkSlateGray
        btnPeUniform.FlatStyle = FlatStyle.Popup
        btnPeUniform.Font = New Font("Arial Rounded MT Bold", 16F)
        btnPeUniform.ForeColor = Color.MintCream
        btnPeUniform.Location = New Point(136, 404)
        btnPeUniform.Name = "btnPeUniform"
        btnPeUniform.Size = New Size(246, 38)
        btnPeUniform.TabIndex = 60
        btnPeUniform.Text = "PE UNIFORM"
        btnPeUniform.UseVisualStyleBackColor = False
        ' 
        ' picPEUniform
        ' 
        picPEUniform.BackColor = Color.LightGray
        picPEUniform.BorderStyle = BorderStyle.Fixed3D
        picPEUniform.Image = CType(resources.GetObject("picPEUniform.Image"), Image)
        picPEUniform.Location = New Point(122, 123)
        picPEUniform.Name = "picPEUniform"
        picPEUniform.Size = New Size(275, 364)
        picPEUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picPEUniform.TabIndex = 41
        picPEUniform.TabStop = False
        ' 
        ' picSchoolUniform
        ' 
        picSchoolUniform.BackColor = Color.LightGray
        picSchoolUniform.BorderStyle = BorderStyle.Fixed3D
        picSchoolUniform.Image = My.Resources.Resources.Copy_of_Cenardo_application_removebg_preview
        picSchoolUniform.Location = New Point(397, 101)
        picSchoolUniform.Name = "picSchoolUniform"
        picSchoolUniform.Size = New Size(283, 401)
        picSchoolUniform.SizeMode = PictureBoxSizeMode.StretchImage
        picSchoolUniform.TabIndex = 47
        picSchoolUniform.TabStop = False
        ' 
        ' frmHomeAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 551)
        Controls.Add(PanelMain)
        Name = "frmHomeAdmin"
        Text = "frmHomeAdmin"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        CType(picCorpo, ComponentModel.ISupportInitialize).EndInit()
        CType(picPEUniform, ComponentModel.ISupportInitialize).EndInit()
        CType(picSchoolUniform, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents picPEUniform As PictureBox
    Friend WithEvents picSchoolUniform As PictureBox
    Friend WithEvents btnPeUniform As Button
    Friend WithEvents btnSchoolUniform As Button
    Friend WithEvents picCorpo As PictureBox
    Friend WithEvents btnCorporateAttire As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
