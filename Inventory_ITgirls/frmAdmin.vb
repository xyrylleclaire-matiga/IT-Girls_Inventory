Imports MySql.Data.MySqlClient
Public Class frmAdmin
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnStockManagement_Click(sender As Object, e As EventArgs) Handles btnStockManagement.Click
        openChildForm(New frmStockManagement)
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        openChildForm(New frmSalesReport)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles picSchoolUniform.Click
        Dim borderColor As Color = Color.Blue
        openChildForm(New frmUniformView)
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPeUniform.Click, Button2.Click
    '    frmPEUniformView.Show()
    '    Hide()
    'End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private currentChild As Form = Nothing
    Public Sub openChildForm(child As Form)
        If currentChild IsNot Nothing Then
            currentChild.Close()
        End If

        currentChild = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        PanelMain.Controls.Clear()
        PanelMain.Controls.Add(child)
        child.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        openChildForm(New frmHomeAdmin)
    End Sub

    Private originalSizes As New Dictionary(Of PictureBox, Size)
    Private originalPositions As New Dictionary(Of PictureBox, Point)

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pic In {picPEUniform, picSchoolUniform, picCorpo}
            originalSizes(pic) = pic.Size
            originalPositions(pic) = pic.Location
            AddHandler pic.MouseEnter, AddressOf PictureHover
            AddHandler pic.MouseLeave, AddressOf PictureLeave
        Next
    End Sub

    Private Sub PictureHover(sender As Object, e As EventArgs)
        Dim pic As PictureBox = CType(sender, PictureBox)
        pic.Size = New Size(originalSizes(pic).Width + 5, originalSizes(pic).Height + 5)
        pic.Location = New Point(originalPositions(pic).X, originalPositions(pic).Y - 5)
        pic.Cursor = Cursors.Hand
        pic.BringToFront()
        pic.BackColor = Color.Teal

        Select Case pic.Name
            Case "picPEUniform"
                AnimateButton(btnPeUniform, True)
            Case "picSchoolUniform"
                AnimateButton(btnSchoolUniform, True)
            Case "picCorpo"
                AnimateButton(btnCorporateAttire, True)
        End Select
    End Sub

    Private Sub PictureLeave(sender As Object, e As EventArgs)
        Dim pic As PictureBox = CType(sender, PictureBox)
        pic.Size = originalSizes(pic)
        pic.Location = originalPositions(pic)
        pic.BackColor = Color.LightGray

        Select Case pic.Name
            Case "picPEUniform"
                AnimateButton(btnPeUniform, False)
            Case "picSchoolUniform"
                AnimateButton(btnSchoolUniform, False)
            Case "picCorpo"
                AnimateButton(btnCorporateAttire, False)
        End Select
    End Sub

    Private Sub AnimateButton(btn As Button, isHover As Boolean)
        If isHover Then
            btn.Font = New Font(btn.Font.FontFamily, CSng(btn.Font.Size + 1.5), FontStyle.Bold)
            btn.ForeColor = Color.Black
            btn.BackColor = Color.LightCyan
            btn.BringToFront()
        Else
            btn.Font = New Font(btn.Font.FontFamily, CSng(btn.Font.Size - 1.5), FontStyle.Bold)
            btn.ForeColor = Color.White
            btn.BackColor = Color.DarkSlateGray
        End If
    End Sub

    Private Sub PanelMain_Paint(sender As Object, e As PaintEventArgs) Handles PanelMain.Paint

    End Sub

    Private Sub btnCorporateAttire_Click(sender As Object, e As EventArgs) Handles btnCorporateAttire.Click
        openChildForm(New frmCorpoAttireView)
    End Sub

    Private Sub picCorpo_Click(sender As Object, e As EventArgs) Handles picCorpo.Click
        openChildForm(New frmCorpoAttireView)
    End Sub

    Private Sub btnPeUniform_Click(sender As Object, e As EventArgs) Handles btnPeUniform.Click
        openChildForm(New frmPEUniformView)
    End Sub

    Private Sub picPEUniform_Click(sender As Object, e As EventArgs) Handles picPEUniform.Click
        openChildForm(New frmPEUniformView)
    End Sub

    Private Sub btnSchoolUniform_Click(sender As Object, e As EventArgs) Handles btnSchoolUniform.Click
        openChildForm(New frmUniformView)
    End Sub

    Private Sub btnPullOut_Click(sender As Object, e As EventArgs) Handles btnPullOut.Click
        openChildForm(New TotalPullouts)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class