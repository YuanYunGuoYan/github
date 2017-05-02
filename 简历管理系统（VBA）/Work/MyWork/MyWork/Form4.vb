Public Class Form4
    Dim time1, time2, time As String
    Dim textA As String
    Dim describe As String
    Dim tableNum As Integer
    Dim row As Integer
    Dim i, n As Integer
    Dim company As String
    Dim industry As String
    Dim companySize As String
    Dim companyNature As String
    Dim department As String
    Dim roleType As String
    Dim jobName As String
    Dim jobType As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.WorkingType”中。您可以根据需要移动或删除它。
        Me.WorkingTypeTableAdapter.Fill(Me.OfficeDataSet1.WorkingType)
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.CompanyNature”中。您可以根据需要移动或删除它。
        Me.CompanyNatureTableAdapter.Fill(Me.OfficeDataSet1.CompanyNature)
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.CompanySize”中。您可以根据需要移动或删除它。
        Me.CompanySizeTableAdapter.Fill(Me.OfficeDataSet1.CompanySize)

        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 3 And textA = "工作性质" Then
                TextBox21.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容").ToString
                TextBox22.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容").ToString
                ComboBox15.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容").ToString
                ComboBox16.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容").ToString
                TextBox25.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容").ToString
                TextBox26.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 7)("内容").ToString
                TextBox27.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 8)("内容").ToString
                TextBox28.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 9)("内容").ToString
                ComboBox14.Text = Form1.dsMsg.Tables("MyOffice").Rows(i + 10)("内容").ToString
            End If
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            textA = Form1.dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If tableNum = 3 And textA = "工作性质" Then
                time1 = DateTimePicker4.Text
                time2 = DateTimePicker5.Text
                time = time1 + "至" + time2
                company = TextBox21.Text
                industry = TextBox22.Text
                companySize = ComboBox15.Text
                companyNature = ComboBox16.Text
                department = TextBox25.Text
                roleType = TextBox26.Text
                jobName = TextBox27.Text
                describe = TextBox28.Text
                jobType = ComboBox14.Text

                Form1.dsMsg.Tables("MyOffice").Rows(i + 1)("内容") = time
                Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容") = company
                Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容") = industry
                Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容") = companySize
                Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容") = companyNature
                Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容") = department
                Form1.dsMsg.Tables("MyOffice").Rows(i + 7)("内容") = roleType
                Form1.dsMsg.Tables("MyOffice").Rows(i + 8)("内容") = jobName
                Form1.dsMsg.Tables("MyOffice").Rows(i + 9)("内容") = describe
                Form1.dsMsg.Tables("MyOffice").Rows(i + 10)("内容") = jobType
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class