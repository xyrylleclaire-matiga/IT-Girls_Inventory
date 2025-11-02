Imports System.Data.SqlTypes

Public Class frmPrintPreview
    Private log_id As String
    Private itemName As String
    Private actionDateTime As String
    Private Action As String
    Private levGenSize As String
    Private changedQuan As String
    Private prevNew As String
    Private admin As String
    Private reason As String
    Private adminID As String
    Private uniformID As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(log_id As String, name As String, actionDateTime As String, Action As String, levGenSize As String, changedQuan As String, prevNew As String, admin As String, reason As String, adminID As String, uniformID As String)
        InitializeComponent()

        ' Store values
        Me.log_id = log_id
        Me.itemName = name
        Me.actionDateTime = actionDateTime
        Me.Action = Action
        Me.levGenSize = levGenSize
        Me.changedQuan = changedQuan
        Me.prevNew = prevNew
        Me.admin = admin
        Me.reason = reason
        Me.uniformID = uniformID
        Me.adminID = adminID

        ' === BASIC INFO ===
        lblLogId.Text = log_id
        lblAction.Text = Action
        lblItemName.Text = name
        lblReason.Text = reason
        lblChangeQuan.Text = changedQuan

        Try
            Dim dt As Date = Date.Parse(actionDateTime)
            lblDate.Text = dt.ToString("yyyy-MM-dd")
            lblTime.Text = dt.ToString("HH:mm:ss")
        Catch
            lblDate.Text = actionDateTime
            lblTime.Text = ""
        End Try

        If Not String.IsNullOrEmpty(levGenSize) Then
            Dim parts() As String = levGenSize.Split(New String() {" / "}, StringSplitOptions.None)

            lblLevel.Text = If(parts.Length > 0, parts(0).Trim(), "N/A")
            lblGender.Text = If(parts.Length > 1, parts(1).Trim(), "N/A")
            lblSize.Text = If(parts.Length > 2, parts(2).Trim(), "N/A")
        Else
            lblLevel.Text = "N/A"
            lblGender.Text = "N/A"
            lblSize.Text = "N/A"
        End If

        If Not String.IsNullOrEmpty(prevNew) AndAlso prevNew.Contains("→") Then
            Dim quantities() As String = prevNew.Split("→"c)
            lblPreviousQuan.Text = If(quantities.Length > 0, quantities(0).Trim(), "0")
            lblNewQuan.Text = If(quantities.Length > 1, quantities(1).Trim(), "0")
        Else
            lblPreviousQuan.Text = "0"
            lblNewQuan.Text = "0"
        End If

        lblAdminName.Text = admin
        lblAdminID.Text = adminID

        lblUniformID.Text = uniformID


    End Sub

    Private Sub frmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrintDate.Text = DateTime.Now.ToString("MM-dd-yy HH:mm:ss")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Print error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim labelFont As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim valueFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim sectionFont As New Font("Segoe UI", 11, FontStyle.Bold)

        Dim tealColor As New SolidBrush(Color.FromArgb(0, 150, 136))
        Dim darkTeal As New SolidBrush(Color.FromArgb(0, 105, 92))
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim grayBrush As New SolidBrush(Color.FromArgb(100, 100, 100))
        Dim lightGrayBrush As New SolidBrush(Color.FromArgb(240, 240, 240))
        Dim redBrush As New SolidBrush(Color.Red)

        Dim borderPen As New Pen(Color.FromArgb(0, 105, 92), 2)
        Dim linePen As New Pen(Color.FromArgb(200, 200, 200), 1)

        Dim x As Integer = 50
        Dim y As Integer = 50
        Dim lineHeight As Integer = 25
        Dim sectionSpacing As Integer = 15

        e.Graphics.DrawString("📦 INVENTORY LOG ENTRY DETAILS", titleFont, tealColor, x, y)
        y += 40

        Dim contentRect As New Rectangle(x, y, 700, 600)
        e.Graphics.DrawRectangle(borderPen, contentRect)

        y += 10
        e.Graphics.FillRectangle(tealColor, x + 10, y, 680, 30)
        e.Graphics.DrawString("Paper Area Preview", headerFont, Brushes.White, x + 20, y + 5)
        y += 40

        e.Graphics.DrawString("Log ID:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblLogId.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Date:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblDate.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Time:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblTime.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Action Performed:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblAction.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight + sectionSpacing

        e.Graphics.FillRectangle(darkTeal, x + 10, y, 680, 30)
        e.Graphics.DrawString("Item Information", headerFont, Brushes.White, x + 20, y + 5)
        y += 40

        e.Graphics.DrawString("Uniform ID:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblUniformID.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Item Name:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblItemName.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Level:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblLevel.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Gender:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblGender.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Size:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblSize.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Reason:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblReason.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight + sectionSpacing

        e.Graphics.FillRectangle(darkTeal, x + 10, y, 680, 30)
        e.Graphics.DrawString("Quantity Change", headerFont, Brushes.White, x + 20, y + 5)
        y += 40

        e.Graphics.DrawString("Previous Quantity:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblPreviousQuan.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Change Quantity:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblChangeQuan.Text, valueFont, redBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("New Quantity:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblNewQuan.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight + sectionSpacing

        e.Graphics.FillRectangle(darkTeal, x + 10, y, 680, 30)
        e.Graphics.DrawString("Admin Information", headerFont, Brushes.White, x + 20, y + 5)
        y += 40

        e.Graphics.DrawString("Performed by:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblAdminName.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight

        e.Graphics.DrawString("Admin ID:", labelFont, blackBrush, x + 20, y)
        e.Graphics.DrawString(lblAdminID.Text, valueFont, blackBrush, x + 200, y)
        y += lineHeight + sectionSpacing + 20

        e.Graphics.DrawLine(linePen, x + 10, y, x + 690, y)
        y += 10

        e.Graphics.DrawString("Generated by: Inventory Management System", valueFont, grayBrush, x + 20, y)
        y += lineHeight

        e.Graphics.DrawString("Print Date: " & lblPrintDate.Text, valueFont, redBrush, x + 20, y)

        titleFont.Dispose()
        headerFont.Dispose()
        labelFont.Dispose()
        valueFont.Dispose()
        sectionFont.Dispose()
        tealColor.Dispose()
        darkTeal.Dispose()
        blackBrush.Dispose()
        grayBrush.Dispose()
        redBrush.Dispose()
        borderPen.Dispose()
        linePen.Dispose()
    End Sub
End Class