Public Class Form3
    Dim time1, time2, time As String
    Dim textA As String
    Dim school As String
    Dim lesson As String
    Dim degree As String
    Dim describe As String
    Dim i, n As Integer
    Dim row As Integer
    Dim tableNum As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 2 And textA = "专业描述" Then
                TextBox7.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容").ToString
                TextBox12.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容").ToString
                TextBox19.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容").ToString
                TextBox20.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容").ToString
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 2 And textA = "专业描述" Then
                time1 = DateTimePicker2.Text
                time2 = DateTimePicker3.Text
                time = time1 + "至" + time2
                school = TextBox7.Text
                lesson = TextBox12.Text
                degree = TextBox19.Text
                describe = TextBox20.Text

                Form1.dsMsg.Tables("MyOffice").Rows(i + 1)("内容") = time
                Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容") = school
                Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容") = lesson
                Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容") = degree
                Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容") = describe
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class