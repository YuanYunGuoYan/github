Public Class Form2
    Dim name1, nameA As String
    Dim sex, sexA As String
    Dim birthDate, birthDateA As String
    Dim phoneNumber, phoneNumberA As String
    Dim email, emailA As String
    Dim qq, qqA As String
    Dim heightA, heightB As String
    Dim marriage, marriageA As String
    Dim status, statusA As String
    Dim workingLife, workingLifeA As String
    Dim salary, salaryA As String
    Dim address, addressA As String
    Dim birthPlace, birthPlaceA As String
    Dim idNum, idNumA As String
    Dim i, n As Integer
    Dim row As Integer
    Dim tableNum As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            If tableNum = 1 Then
                name1 = TextBox5.Text
                nameA = "姓名：" + name1
                sex = ComboBox10.Text
                sexA = "性别：" + sex
                birthDate = DateTimePicker1.Text
                birthDateA = "出生日期：" + birthDate
                phoneNumber = TextBox8.Text
                phoneNumberA = "手机号码：" + phoneNumber
                email = TextBox9.Text
                emailA = "Email：" + email
                qq = TextBox10.Text
                qqA = "QQ：" + qq
                heightA = TextBox11.Text
                heightB = "身高：" + heightA
                marriage = ComboBox11.Text
                marriageA = "婚姻状况：" + marriage
                status = ComboBox12.Text
                statusA = "政治面貌：" + status
                workingLife = ComboBox13.Text
                workingLifeA = "工作年限：" + workingLife
                salary = TextBox15.Text
                salaryA = "目前薪资：" + salary
                address = TextBox16.Text
                addressA = "现居住地：" + address
                birthPlace = TextBox17.Text
                birthPlaceA = "籍贯：" + birthPlace
                idNum = TextBox18.Text
                idNumA = "身份证号：" + idNum

                Form1.dsMsg.Tables("MyOffice").Rows(i + 1)("内容") = nameA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容") = sexA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容") = birthDateA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容") = phoneNumberA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容") = emailA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容") = qqA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 7)("内容") = heightB
                Form1.dsMsg.Tables("MyOffice").Rows(i + 8)("内容") = marriageA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 9)("内容") = statusA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 10)("内容") = workingLifeA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 11)("内容") = salaryA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 12)("内容") = addressA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 13)("内容") = birthPlaceA
                Form1.dsMsg.Tables("MyOffice").Rows(i + 14)("内容") = idNumA
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.WorkingLife”中。您可以根据需要移动或删除它。
        Me.WorkingLifeTableAdapter.Fill(Me.OfficeDataSet1.WorkingLife)
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.Status”中。您可以根据需要移动或删除它。
        Me.StatusTableAdapter.Fill(Me.OfficeDataSet1.Status)
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.Marriage”中。您可以根据需要移动或删除它。
        Me.MarriageTableAdapter.Fill(Me.OfficeDataSet1.Marriage)
        'TODO: 这行代码将数据加载到表“OfficeDataSet1.Sex”中。您可以根据需要移动或删除它。
        Me.SexTableAdapter.Fill(Me.OfficeDataSet1.Sex)

        row = Form1.dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            tableNum = Form1.dsMsg.Tables("MyOffice").Rows(i)("表数")
            If tableNum = 1 Then
                name1 = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 1)("内容").ToString, "姓名：", "")
                TextBox5.Text = name1
                sex = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 2)("内容").ToString, "性别：", "")
                ComboBox10.Text = sex
                birthDate = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 3)("内容").ToString, "出生日期：", "")
                DateTimePicker1.Text = birthDate
                phoneNumber = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 4)("内容").ToString, "手机号码：", "")
                TextBox8.Text = phoneNumber
                email = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 5)("内容").ToString, "Email：", "")
                TextBox9.Text = email
                qq = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 6)("内容").ToString, "QQ：", "")
                TextBox10.Text = qq
                heightA = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 7)("内容").ToString, "身高：", "")
                TextBox11.Text = heightA
                marriage = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 8)("内容").ToString, "婚姻状况：", "")
                ComboBox11.Text = marriage
                status = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 9)("内容").ToString, "政治面貌：", "")
                ComboBox12.Text = status
                workingLife = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 10)("内容").ToString, "工作年限：", "")
                ComboBox13.Text = workingLife
                salary = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 11)("内容").ToString, "目前薪资：", "")
                TextBox15.Text = salary
                address = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 12)("内容").ToString, "现居住地：", "")
                TextBox16.Text = address
                birthPlace = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 13)("内容").ToString, "籍贯：", "")
                TextBox17.Text = birthPlace
                idNum = Replace(Form1.dsMsg.Tables("MyOffice").Rows(i + 14)("内容").ToString, "身份证号：", "")
                TextBox18.Text = idNum
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class