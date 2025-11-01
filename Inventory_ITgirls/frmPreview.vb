Imports Org.BouncyCastle.Asn1.Cmp

Public Class frmPreview
    Private log_id As String
    Private itemName As String
    Private DateTime As String
    Private Action As String
    Private levGenSize As String
    Private changedQuan As String
    Private prevNew As String
    Private admin As String
    Private reason As String

    Public Sub New(log_id As String, name As String, dateTime As String, Action As String, levGenSize As String, changedQuan As String, prevNew As String, admin As String, reason As String)
        InitializeComponent()

        Me.log_id = log_id
        Me.itemName = name
        Me.DateTime = dateTime
        Me.Action = Action
        Me.levGenSize = levGenSize
        Me.changedQuan = changedQuan
        Me.prevNew = prevNew
        Me.admin = admin
        Me.reason = reason

        'txtItemName.Text = Me.itemName
        'txtLevel.Text = Me.level
        'txtGender.Text = Me.gender
        'txtSize.Text = Me.Size
        'txtStock.Text = Me.stockQuantity
        'txtPrice.Text = Me.price
        'lblStatus.Text = Me.status
    End Sub

End Class