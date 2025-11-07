Imports MySql.Data.MySqlClient
Public Class frmAdmin

    'FOR DESIGNNNN
    Private Sub PanelLowStock_Paint(sender As Object, e As PaintEventArgs) Handles PanelLowStock.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim radius As Integer = 10
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        pnl.Region = New Region(path)
    End Sub

    Private Sub PanelTotalPullouts_Paint(sender As Object, e As PaintEventArgs) Handles PanelTotalPullouts.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim radius As Integer = 10
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        pnl.Region = New Region(path)
    End Sub

    Private Sub PanelTotalStocks_Paint(sender As Object, e As PaintEventArgs) Handles PanelTotalStocks.Paint
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim radius As Integer = 10
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        pnl.Region = New Region(path)
    End Sub

    Private Sub PanelPendingRequests_Paint(sender As Object, e As PaintEventArgs) Handles PanelPendingRequests.Paint
        Dim pnl = DirectCast(sender, Panel)
        Dim radius = 10
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim path As New Drawing2D.GraphicsPath
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        pnl.Region = New Region(path)
    End Sub


    Private activeButton As Button = Nothing
    Private Sub SetActiveButton(btn As Button)
        If activeButton IsNot Nothing Then
            ResetButtonStyle(activeButton)
        End If

        activeButton = btn
        HighlightButton(activeButton)
    End Sub

    Private Sub HighlightButton(btn As Button)
        btn.BackColor = Color.LightCyan
        btn.ForeColor = Color.Black
        btn.Font = New Font(btn.Font.FontFamily, CSng(btn.Font.Size + 1.5), FontStyle.Bold)
    End Sub

    Private Sub ResetButtonStyle(btn As Button)
        btn.BackColor = Color.DarkSlateGray
        btn.ForeColor = Color.White
        btn.Font = New Font(btn.Font.FontFamily, CSng(btn.Font.Size - 1.5), FontStyle.Bold)
    End Sub



    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnStockStorage_Click(sender As Object, e As EventArgs) Handles btnStockStorage.Click
        openChildForm(New frmStockStorage)
        SetActiveButton(btnStockStorage)
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        openChildForm(New frmAdminReports)
        SetActiveButton(btnSalesReport)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Dim borderColor = Color.Blue
        openChildForm(New frmUniformView)
    End Sub
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

    Private Sub btnAdminDashboard_Click_1(sender As Object, e As EventArgs) Handles btnAdminDashboard.Click
        openChildForm(New frmAdminDashboard)
        SetActiveButton(btnAdminDashboard)
    End Sub

    Private originalSizes As New Dictionary(Of PictureBox, Size)
    Private originalPositions As New Dictionary(Of PictureBox, Point)


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

    Private Sub btnCorporateAttire_Click(sender As Object, e As EventArgs)
        openChildForm(New frmCorpoAttireView)
    End Sub

    Private Sub picCorpo_Click(sender As Object, e As EventArgs)
        openChildForm(New frmCorpoAttireView)
    End Sub

    Private Sub btnPeUniform_Click(sender As Object, e As EventArgs)
        openChildForm(New frmPEUniformView)
    End Sub

    Private Sub picPEUniform_Click(sender As Object, e As EventArgs)
        openChildForm(New frmPEUniformView)
    End Sub

    Private Sub btnSchoolUniform_Click(sender As Object, e As EventArgs)
        openChildForm(New frmUniformView)
    End Sub

    Private Sub btnReturnedItems_Click(sender As Object, e As EventArgs) Handles btnReturnedItems.Click
        openChildForm(New frmAdminReturnedItems)
        SetActiveButton(btnReturnedItems)
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnStockMonitoring.Click
        openChildForm(New frmAdminStockMonitoring)
        SetActiveButton(btnStockMonitoring)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class