Public Class Form5
    Dim time1, time2, time As String
    Dim textA As String
    Dim describe As String
    Dim tableNum As Integer
    Dim row As Integer
    Dim i, n As Integer
    Dim trainingAgency As String
    Dim trainingPlace As String
    Dim trainingClass As String
    Dim diploma As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 4 And textA = "详细描述" Then
                TextBox30.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容").ToString
                TextBox31.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容").ToString
                TextBox32.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容").ToString
                TextBox33.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容").ToString
                TextBox34.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容").ToString
            End If
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 4 And textA = "详细描述" Then
                time1 = DateTimePicker6.Text
                time2 = DateTimePicker7.Text
                time = time1 + "至" + time2
                trainingAgency = TextBox30.Text
                trainingPlace = TextBox31.Text
                trainingClass = TextBox32.Text
                diploma = TextBox33.Text
                describe = TextBox34.Text

                Form1.dsMsg.Tables("MyOffice").Rows(i + 1)("内容") = time
                Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容") = trainingAgency
                Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容") = trainingPlace
                Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容") = trainingClass
                Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容") = diploma
                Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容") = describe
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class