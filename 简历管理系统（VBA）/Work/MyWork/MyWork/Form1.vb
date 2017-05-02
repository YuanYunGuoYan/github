Imports Word = Microsoft.Office.Interop.Word
Imports MyDll
Imports System.Data.OleDb
Imports System.Configuration

Public Class Form1
    Dim word1 As String
    Dim title1, title2, title3, titleA, titleB, titleC As Integer
    Dim titleText, titleText1 As String
    Dim tableTitle As String
    Dim type, nextType, typeText As String
    Dim textA, text1， tableText, parentText As String
    Dim alignment As String
    Dim image As String
    Dim picHeight As Integer
    Dim picWidth As Integer
    Dim titleLevel As String
    Dim color As String
    Dim picLayout As String
    Dim fontSize As String
    Dim fontName As String
    Dim firstLineIndent As Integer
    Dim hangingIndent As Integer
    Dim picContrast As Integer
    Dim picBright As Integer
    Dim picScale As Integer
    Dim picLocation As String
    Public dsMsg As New DataSet()
    Dim i, n As Integer
    Dim row As Integer
    Dim conn As OleDb.OleDbConnection
    Dim connString As String
    Dim filePath As String
    Dim rowNum, colNum, rowNumA, colNumA As Integer
    Dim cellNum As Integer
    Dim tableNum As Integer
    Dim id1, id2, id As Integer
    Dim strSQL As String
    Dim da As New OleDb.OleDbDataAdapter(strSQL, conn)

    Public Sub Data()
        '数据库连接
        Try
            conn = New OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\office.accdb"
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        strSQL = "Select * from MyOffice order by ID"
        Dim da As New OleDb.OleDbDataAdapter(strSQL, conn)
        da.Fill(dsMsg, "MyOffice")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyOffice = New MyDll.Office
        MyOffice.NewDocument()
        Try
            row = dsMsg.Tables("MyOffice").Rows.Count
            For i = 0 To (row - 1)
                title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
                title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
                title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
                type = dsMsg.Tables("MyOffice").Rows(i)("类型").ToString
                textA = dsMsg.Tables（"MyOffice").Rows(i)("内容").ToString
                titleLevel = dsMsg.Tables("MyOffice").Rows(i)("标题级别").ToString
                color = dsMsg.Tables（"MyOffice").Rows(i)("颜色").ToString
                picLayout = dsMsg.Tables（"MyOffice").Rows(i)("图片布局").ToString
                fontSize = dsMsg.Tables（"MyOffice").Rows(i)("文字大小").ToString
                fontName = dsMsg.Tables（"MyOffice").Rows(i)("文字字体").ToString
                firstLineIndent = dsMsg.Tables("MyOffice").Rows(i)("首行缩进")
                hangingIndent = dsMsg.Tables("MyOffice").Rows(i)("悬挂缩进")
                alignment = dsMsg.Tables("MyOffice").Rows(i)("对齐方式").ToString
                image = dsMsg.Tables("MyOffice").Rows(i)("图片路径").ToString
                picHeight = dsMsg.Tables("MyOffice").Rows(i)("图片高度")
                picWidth = dsMsg.Tables("MyOffice").Rows(i)("图片宽度")
                picContrast = dsMsg.Tables("MyOffice").Rows(i)("图片对比度")
                picBright = dsMsg.Tables("MyOffice").Rows(i)("图片透明度")
                picScale = dsMsg.Tables("MyOffice").Rows(i)("图片缩放比例")
                rowNum = dsMsg.Tables("MyOffice").Rows(i)("表行数")
                colNum = dsMsg.Tables("MyOffice").Rows(i)("表列数")
                Select Case (type)
                    Case "文本"
                        MyOffice.InsertText(textA)
                        If fontSize IsNot "" Then
                            MyOffice.FontSize(fontSize)
                        End If
                        If fontName IsNot "" Then
                            MyOffice.FontName(fontName)
                        End If
                        If color IsNot "" Then
                            MyOffice.Fontcolor(color)
                        End If
                        If alignment IsNot "" Then
                            MyOffice.Alignment(alignment)
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("加粗").Equals(True) Then
                            MyOffice.Bold()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("斜体").Equals(True) Then
                            MyOffice.Italic()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("下划线").Equals(True) Then
                            MyOffice.Underline()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("删除线").Equals(True) Then
                            MyOffice.Strikethrough()
                        End If
                        If firstLineIndent > 0 Then
                            MyOffice.FirstLineIndent(firstLineIndent)
                        ElseIf hangingIndent > 0 Then
                            MyOffice.FirstLineIndent(-hangingIndent)
                        ElseIf firstLineIndent = 0 And hangingIndent = 0 Then
                            MyOffice.FirstLineIndent(0)
                        End If
                        MyOffice.NewLine()
                    Case "标题"
                        If title3 > 0 Then
                            MyOffice.InsertText(title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + textA)
                        End If
                        If title2 > 0 And title3 = 0 Then
                            MyOffice.InsertText(title1.ToString + "." + title2.ToString + "." + textA)
                        End If
                        If title1 > 0 And title2 = 0 And title3 = 0 Then
                            MyOffice.InsertText(title1.ToString + "." + textA)
                        End If
                        If fontSize IsNot "" Then
                            MyOffice.FontSize(fontSize)
                        End If
                        If fontName IsNot "" Then
                            MyOffice.FontName(fontName)
                        End If
                        If color IsNot "" Then
                            MyOffice.Fontcolor(color)
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("加粗").Equals(True) Then
                            MyOffice.Bold()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("斜体").Equals(True) Then
                            MyOffice.Italic()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("下划线").Equals(True) Then
                            MyOffice.Underline()
                        End If
                        If dsMsg.Tables("MyOffice").Rows(i)("删除线").Equals(True) Then
                            MyOffice.Strikethrough()
                        End If
                        If alignment IsNot "" Then
                            MyOffice.Alignment(alignment)
                        End If
                        MyOffice.NewLine()
                    Case "图片"
                        MyOffice.InsertPic(image)
                        If picLayout IsNot "" Then
                            MyOffice.PicLayout(picLayout)
                        End If
                        If picHeight > 0 And picWidth > 0 Then
                            MyOffice.PicSize(picHeight, picWidth)
                        End If
                        If picBright > 0 Then
                            MyOffice.PicBright(picBright)
                        End If
                        If picContrast > 0 Then
                            MyOffice.PicContrast(picContrast)
                        End If
                        If picScale > 0 Then
                            MyOffice.PicScale(picScale)
                        End If
                        MyOffice.NewLine()
                    Case "表格"
                        MyOffice.NewLine()
                        MyOffice.InsertTable(rowNum, colNum)
                        cellNum = rowNum * colNum
                        For n = 1 To cellNum
                            tableText = dsMsg.Tables("MyOffice").Rows(i + n)("内容").ToString
                            rowNumA = dsMsg.Tables("MyOffice").Rows(i + n)("表行数")
                            colNumA = dsMsg.Tables("MyOffice").Rows(i + n)("表列数")
                            tableNum = dsMsg.Tables("MyOffice").Rows(i)("表数")
                            If rowNumA = rowNum And colNumA = colNum Then
                                MyOffice.TableText(rowNumA, colNumA, tableText)
                                MyOffice.OutTable()
                            Else
                                MyOffice.TableText(rowNumA, colNumA, tableText)
                            End If
                        Next
                End Select
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        textA = e.Node.Text
        Try
            parentText = e.Node.Parent.Text
        Catch ex As Exception
        End Try
        If textA = "默认简历" Then
            TextBox4.Text = "我的简历"
        End If
        row = dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
            title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
            title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
            titleText = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            Try
                type = dsMsg.Tables("MyOffice").Rows(i + 1)("类型").ToString
            Catch ex As Exception
            End Try
            If textA = title1.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText Then
                TextBox3.Text = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
                TextBox5.Text = dsMsg.Tables("MyOffice").Rows(i)("标题级别").ToString
                ComboBox6.Text = dsMsg.Tables("MyOffice").Rows(i)("颜色").ToString
                ComboBox7.Text = dsMsg.Tables("MyOffice").Rows(i)("文字大小").ToString
                ComboBox8.Text = dsMsg.Tables("MyOffice").Rows(i)("文字字体").ToString
                NumericUpDown3.Value = dsMsg.Tables("MyOffice").Rows(i)("一级标题").ToString
                NumericUpDown4.Value = dsMsg.Tables("MyOffice").Rows(i)("二级标题").ToString
                NumericUpDown5.Value = dsMsg.Tables("MyOffice").Rows(i)("三级标题").ToString
            ElseIf parentText = title1.ToString + "." + titleText Or parentText = title1.ToString + "." + title2.ToString + "." + titleText Or parentText = title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText Then
                Select Case (type)
                    Case "文本"
                        If textA = "1.文本" Then
                            TextBox2.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("内容").ToString
                            ComboBox1.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("颜色").ToString
                            ComboBox2.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("文字大小").ToString
                            ComboBox3.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("文字字体").ToString
                            ComboBox4.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("对齐方式").ToString
                            NumericUpDown1.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("首行缩进")
                            NumericUpDown2.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("悬挂缩进")
                            CheckBox1.Checked = dsMsg.Tables("MyOffice").Rows(i + 1)("加粗")
                            CheckBox2.Checked = dsMsg.Tables("MyOffice").Rows(i + 1)("斜体")
                            CheckBox3.Checked = dsMsg.Tables("MyOffice").Rows(i + 1)("下划线")
                            CheckBox4.Checked = dsMsg.Tables("MyOffice").Rows(i + 1)("删除线")
                        End If
                    Case "表格"
                        tableTitle = dsMsg.Tables("MyOffice").Rows(i + 1)("表标题").ToString
                        Select Case (tableTitle)
                            Case "基本信息表"
                                Form2.Show()
                            Case "教育经历表"
                                Form3.Show()
                            Case "工作经历表"
                                Form4.Show()
                            Case "培训经历表"
                                Form5.Show()
                        End Select
                    Case "图片"
                        image = dsMsg.Tables("MyOffice").Rows(i + 1)("图片路径").ToString
                        PictureBox1.ImageLocation = image
                        TextBox1.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("图片路径").ToString
                        ComboBox9.Text = dsMsg.Tables("MyOffice").Rows(i + 1)("图片布局").ToString
                        NumericUpDown6.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("图片高度")
                        NumericUpDown7.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("图片宽度")
                        NumericUpDown8.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("图片透明度")
                        NumericUpDown9.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("图片对比度")
                        NumericUpDown10.Value = dsMsg.Tables("MyOffice").Rows(i + 1)("图片缩放比例")
                End Select
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“OfficeDataSet.PicLayout”中。您可以根据需要移动或删除它。
        Me.PicLayoutTableAdapter.Fill(Me.OfficeDataSet.PicLayout)
        'TODO: 这行代码将数据加载到表“OfficeDataSet.TitleLevel”中。您可以根据需要移动或删除它。
        Me.TitleLevelTableAdapter.Fill(Me.OfficeDataSet.TitleLevel)
        'TODO: 这行代码将数据加载到表“OfficeDataSet.Alignment”中。您可以根据需要移动或删除它。
        Me.AlignmentTableAdapter.Fill(Me.OfficeDataSet.Alignment)
        'TODO: 这行代码将数据加载到表“OfficeDataSet.FontName”中。您可以根据需要移动或删除它。
        Me.FontNameTableAdapter.Fill(Me.OfficeDataSet.FontName)
        'TODO: 这行代码将数据加载到表“OfficeDataSet.FontSize”中。您可以根据需要移动或删除它。
        Me.FontSizeTableAdapter.Fill(Me.OfficeDataSet.FontSize)
        'TODO: 这行代码将数据加载到表“OfficeDataSet.Color”中。您可以根据需要移动或删除它。
        Me.ColorTableAdapter.Fill(Me.OfficeDataSet.Color)

        Data()

        '封装SQL命令
        Try
            n = 1
            row = dsMsg.Tables("MyOffice").Rows.Count
            For i = 0 To (row - 1)
                title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
                title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
                title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
                titleText = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
                Try
                    titleLevel = dsMsg.Tables("MyOffice").Rows(i)("标题级别")
                Catch ex As Exception
                    titleLevel = 0
                End Try
                type = dsMsg.Tables("MyOffice").Rows(i)("类型").ToString
                Select Case (type)
                    Case "标题"
                        Select Case (titleLevel)
                            Case 1
                                nextType = dsMsg.Tables("MyOffice").Rows(i + n)("类型")
                                Select Case (nextType)
                                    Case "标题"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Add(title1.ToString + "." + titleText)
                                    Case "文本"
                                        typeText = "文本"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Add(title1.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "图片"
                                        typeText = "图片"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Add(title1.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "表格"
                                        typeText = "表格"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Add(title1.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                End Select
                            Case 2
                                nextType = dsMsg.Tables("MyOffice").Rows(i + n)("类型")
                                Select Case (nextType)
                                    Case "标题"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + titleText)
                                    Case "文本"
                                        typeText = "文本"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "图片"
                                        typeText = "图片"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "表格"
                                        typeText = "表格"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                End Select
                            Case 3
                                nextType = dsMsg.Tables("MyOffice").Rows(i + n)("类型")
                                Select Case (nextType)
                                    Case "标题"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText)
                                    Case "文本"
                                        typeText = "文本"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Item(index:=(title3 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "图片"
                                        typeText = "图片"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Item(index:=(title3 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                    Case "表格"
                                        typeText = "表格"
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Add(title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText)
                                        TreeView1.Nodes.Item(index:=0).Nodes.Item(index:=(title1 - 1)).Nodes.Item(index:=(title2 - 1)).Nodes.Item(index:=(title3 - 1)).Nodes.Add(n.ToString + "." + typeText)
                                End Select
                        End Select
                End Select
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "GIF(*.gif)|*.gif|JPEG(*.jpg;*jpeg;*.jpe;*.jfif)|*.jpg|PNG(*.png)|*.png|位图(*.bmp;*.dib)|*.bmp|TIFF(*.tif;*.tiff)|*.tif|所有文件(*.*)|*.*"
        ofd.RestoreDirectory = False
        If ofd.ShowDialog() = DialogResult.OK Then
            filePath = ofd.FileName
            TextBox1.Text = filePath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TreeView1.SelectedNode.Checked = False
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox5.Text = ""
        TextBox3.Text = ""
        NumericUpDown3.Value = 0
        NumericUpDown4.Value = 0
        NumericUpDown5.Value = 0
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TreeView1.SelectedNode.Checked = False
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox2.Text = ""
        ComboBox4.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TreeView1.SelectedNode.Checked = False
        TextBox1.Text = ""
        ComboBox9.Text = ""
        NumericUpDown6.Value = 0
        NumericUpDown7.Value = 0
        NumericUpDown8.Value = 0
        NumericUpDown9.Value = 0
        NumericUpDown10.Value = 0
        image = "C:\Users\Administrator\Pictures\QQ截图20160524102650.png"
        PictureBox1.ImageLocation = image
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        textA = TreeView1.SelectedNode.Parent.Text
        row = dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
            title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
            title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
            titleText = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If textA = title1.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText Then
                color = ComboBox1.Text
                fontSize = ComboBox2.Text
                fontName = ComboBox3.Text
                text1 = TextBox2.Text
                alignment = ComboBox4.Text
                firstLineIndent = NumericUpDown1.Value
                hangingIndent = NumericUpDown2.Value
                dsMsg.Tables("MyOffice").Rows(i + 1)("内容") = text1
                dsMsg.Tables("MyOffice").Rows(i + 1)("颜色") = color
                dsMsg.Tables("MyOffice").Rows(i + 1)("文字大小") = fontSize
                dsMsg.Tables("MyOffice").Rows(i + 1)("文字字体") = fontName
                dsMsg.Tables("MyOffice").Rows(i + 1)("对齐方式") = alignment
                dsMsg.Tables("MyOffice").Rows(i + 1)("首行缩进") = firstLineIndent
                dsMsg.Tables("MyOffice").Rows(i + 1)("悬挂缩进") = hangingIndent
                If CheckBox1.Checked = True Then
                    dsMsg.Tables("MyOffice").Rows(i + 1)("加粗") = True
                End If
                If CheckBox2.Checked = True Then
                    dsMsg.Tables("MyOffice").Rows(i + 1)("斜体") = True
                End If
                If CheckBox3.Checked = True Then
                    dsMsg.Tables("MyOffice").Rows(i + 1)("下划线") = vbYes
                End If
                If CheckBox4.Checked = True Then
                    dsMsg.Tables("MyOffice").Rows(i + 1)("删除线") = vbYes
                End If
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        textA = TreeView1.SelectedNode.Text
        row = dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
            title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
            title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
            titleText = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If textA = title1.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText Then
                color = ComboBox6.Text
                fontSize = ComboBox7.Text
                fontName = ComboBox8.Text
                titleLevel = TextBox5.Text
                text1 = TextBox3.Text
                titleA = NumericUpDown3.Value
                titleB = NumericUpDown4.Value
                titleC = NumericUpDown5.Value
                titleText1 = TextBox3.Text
                dsMsg.Tables("MyOffice").Rows(i)("内容") = text1
                dsMsg.Tables("MyOffice").Rows(i)("颜色") = color
                dsMsg.Tables("MyOffice").Rows(i)("文字大小") = fontSize
                dsMsg.Tables("MyOffice").Rows(i)("文字字体") = fontName
                dsMsg.Tables("MyOffice").Rows(i)("标题级别") = titleLevel
                dsMsg.Tables("MyOffice").Rows(i)("一级标题") = titleA
                dsMsg.Tables("MyOffice").Rows(i)("二级标题") = titleB
                dsMsg.Tables("MyOffice").Rows(i)("三级标题") = titleC
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        textA = TreeView1.SelectedNode.Parent.Text
        row = dsMsg.Tables("MyOffice").Rows.Count
        For i = 0 To (row - 1)
            title1 = dsMsg.Tables("MyOffice").Rows(i)("一级标题")
            title2 = dsMsg.Tables("MyOffice").Rows(i)("二级标题")
            title3 = dsMsg.Tables("MyOffice").Rows(i)("三级标题")
            titleText = dsMsg.Tables("MyOffice").Rows(i)("内容").ToString
            If textA = title1.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + titleText Or textA = title1.ToString + "." + title2.ToString + "." + title3.ToString + "." + titleText Then
                picLocation = TextBox1.Text
                picLayout = ComboBox9.Text
                picHeight = NumericUpDown6.Value
                picWidth = NumericUpDown7.Value
                picBright = NumericUpDown8.Value
                picContrast = NumericUpDown9.Value
                picScale = NumericUpDown10.Value
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片路径") = picLocation
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片布局") = picLayout
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片高度") = picHeight
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片宽度") = picWidth
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片透明度") = picBright
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片对比度") = picContrast
                dsMsg.Tables("MyOffice").Rows(i + 1)("图片缩放比例") = picScale
            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        textA = TextBox4.Text
        dsMsg.Tables("MyOffice").Rows(0)("内容") = textA
        MsgBox("修改成功！")
    End Sub
End Class

