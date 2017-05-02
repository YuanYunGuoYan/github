Imports Word = Microsoft.Office.Interop.Word
Public Class Office
    Dim MyWord As Word.Application
    Dim MyDocument As Word.Document
    Dim MyRange As Word.Range
    Dim MyShape As Word.Shape
    Dim Myselect As Word.Selection
    Dim MyTable As Word.Table
    Dim missing = System.Reflection.Missing.Value
    Dim isVisible As Boolean
    Dim isReadOnly As Boolean
    Dim strName As String
    '创建Word Application 对象
    Public Sub New()
        MyWord = CreateObject("Word.Application")
        MyWord.Visible = True
    End Sub
    '创建新文档
    Public Sub NewDocument()
        MyDocument = MyWord.Documents.Add
        MyDocument.Activate()
        MyRange = MyDocument.Range(Start:=0, [End]:=0)
        Myselect = MyWord.Selection
    End Sub
    '使用模板生成新文档
    Public Sub NewDocWithModel(ByVal FileName As String)
        isVisible = False
        strName = FileName
        MyDocument = MyWord.Documents.Add(strName, missing, missing, isVisible)
        MyDocument.Activate()
    End Sub
    '打开已有文档
    Public Sub OpenFile(ByVal FileName As String)
        strName = FileName
        isReadOnly = False
        isVisible = True
        MyDocument = MyWord.Documents.Open(strName, missing, isReadOnly, missing, missing, missing, missing, missing, missing, missing, missing, isVisible, missing, missing, missing, missing)
        MyDocument.Activate()
    End Sub
    Public Sub OpenFile(ByVal FileName As String, ByVal isReadOnly As Boolean)
        strName = FileName
        isVisible = True
        MyDocument = MyWord.Documents.Open(strName, missing, isReadOnly, missing, missing, missing, missing, missing, missing, missing, missing, isVisible, missing, missing, missing, missing)
        MyDocument.Activate()
    End Sub
    '退出Word
    Public Sub Quit()
        MyWord.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(MyWord)
        MyWord = Nothing
    End Sub
    '关闭所有打开的文档
    Public Sub CloseAllDocuments()
        MyWord.Documents.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
    End Sub
    '关闭当前的文档
    Public Sub CloseCurrentDocument()
        MyDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
    End Sub
    '保存当前文档
    Public Sub Save()
        Try
            MyDocument.Save()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    '另存为文档
    Public Sub SaveAs(ByVal FileName As String)
        strName = FileName
        MyDocument.SaveAs(strName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing)
    End Sub
    '打印报告
    Public Sub PrintOut()
        MyDocument.PrintOut()
    End Sub
    'Range选中位置
    Public Sub SetRange(ByVal para As Integer)
        MyRange = MyDocument.Paragraphs(para).Range
        MyRange.Select()
    End Sub
    Public Sub SetRange(ByVal para As Integer, ByVal sent As Integer)
        MyRange = MyDocument.Paragraphs(para).Range.Sentences(sent)
        MyRange.Select()
    End Sub
    Public Sub SetRange(ByVal startpoint As Integer, ByVal endpoint As Integer, ByVal flag As Boolean)
        If flag = True Then
            MyRange = MyDocument.Range(startpoint, endpoint)
            MyRange.Select()
        End If
    End Sub
    '页边距
    Public Sub FormatMargins(ByVal Left As Integer, ByVal Right As Integer, ByVal Top As Integer, ByVal Bottom As Integer)
        With MyDocument.PageSetup
            .LeftMargin = MyWord.InchesToPoints(Left)
            .RightMargin = MyWord.InchesToPoints(Right)
            .TopMargin = MyWord.InchesToPoints(Top）
            .BottomMargin = MyWord.InchesToPoints(Bottom)
        End With
    End Sub
    '标题
    Public Sub Title(ByVal text As String, ByVal FontName As String, ByVal FontSize As Integer)
        With MyRange
            .InsertAfter(text)
            .Font.Name = FontName
            .Font.Size = FontSize
            .Font.Bold = True
            .Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        End With
        MyRange.Start = MyRange.End
    End Sub
    '标题级别
    Public Sub TitleLevel(ByVal level As Integer)
        Select Case (level)
            Case 1
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel1
            Case 2
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel2
            Case 3
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel3
            Case 4
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel4
            Case 5
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel5
            Case 6
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel6
            Case 7
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel7
            Case 8
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel8
            Case 9
                MyRange.ParagraphFormat.OutlineLevel = Word.WdOutlineLevel.wdOutlineLevel9
        End Select
    End Sub
    '换行
    Public Sub NewLine()
        MyRange.Start = MyRange.End
        MyRange.InsertParagraphAfter()
    End Sub
    '段落首行缩进或悬挂
    Public Sub FirstLineIndent(ByVal Indent As Integer)
        MyRange.ParagraphFormat.CharacterUnitFirstLineIndent = Indent
    End Sub
    '段落行距
    Public Sub LineSpacing(ByVal Value As Integer)
        MyRange.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceExactly
        MyRange.ParagraphFormat.LineSpacing = Value
    End Sub
    '插入文本以及其属性设置
    Public Sub InsertText(ByVal text As String)
        MyRange.Start = MyRange.End
        MyRange.InsertAfter(text)
    End Sub
    Public Sub InsertText(ByVal text As String, ByVal FontName As String)
        MyRange.Start = MyRange.End
        With MyRange
            .InsertAfter(text)
            .Font.Name = FontName
        End With
    End Sub
    Public Sub InsertText(ByVal text As String, ByVal FontName As String, ByVal FontSize As Integer)
        MyRange.Start = MyRange.End
        With MyRange
            .InsertAfter(text)
            .Font.Name = FontName
            .Font.Size = FontSize
        End With
    End Sub
    Public Sub InsertText(ByVal text As String, ByVal FontName As String, ByVal FontSize As Integer, ByVal FontBold As Boolean)
        MyRange.Start = MyRange.End
        With MyRange
            .InsertAfter(text)
            .Font.Name = FontName
            .Font.Size = FontSize
            .Font.Bold = FontBold
        End With
    End Sub
    '文本字体大小
    Public Sub FontSize(ByVal FontSize As String)
        Select Case (FontSize)
            Case "初号"
                MyRange.Font.Size = 42
            Case "小初"
                MyRange.Font.Size = 36
            Case "一号"
                MyRange.Font.Size = 26
            Case "小一"
                MyRange.Font.Size = 24
            Case "二号"
                MyRange.Font.Size = 22
            Case "小二"
                MyRange.Font.Size = 18
            Case "三号"
                MyRange.Font.Size = 16
            Case "小三"
                MyRange.Font.Size = 15
            Case "四号"
                MyRange.Font.Size = 14
            Case "小四"
                MyRange.Font.Size = 12
            Case "五号"
                MyRange.Font.Size = 10.5
            Case "小五"
                MyRange.Font.Size = 9
            Case "六号"
                MyRange.Font.Size = 7.5
            Case "小六"
                MyRange.Font.Size = 6.5
            Case "七号"
                MyRange.Font.Size = 5.5
            Case "八号"
                MyRange.Font.Size = 5
            Case Else
                MyRange.Font.Size = FontSize
        End Select
    End Sub
    '文本字体
    Public Sub FontName(ByVal FontName As String)
        MyRange.Font.Name = FontName
    End Sub
    '文本字体加粗
    Public Sub Bold()
        MyRange.Font.Bold = True
    End Sub
    '文本字体颜色
    Public Sub Fontcolor(ByVal ColorIndex As String)
        Select Case (ColorIndex)
            Case "蓝色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdBlue
            Case "红色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdRed
            Case "绿色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdGreen
            Case "白色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdWhite
            Case "粉色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdPink
            Case "黄色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdYellow
            Case "灰色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdGray50
            Case "紫色"
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdViolet
            Case Else
                MyRange.Font.ColorIndex = Word.WdColorIndex.wdBlack
        End Select
    End Sub
    '文字是居中或居左（右）或两端（分散）对齐
    Public Sub Alignment(ByVal position As String)
        Select Case (position)
            Case "居中"
                MyRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Case "居右"
                MyRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            Case "两端对齐"
                MyRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
            Case "分散对齐"
                MyRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphDistribute
            Case Else
                MyRange.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        End Select
    End Sub
    '文字是否斜体
    Public Sub Italic()
        MyRange.Font.Italic = True
    End Sub
    '文字是否标下划线
    Public Sub Underline()
        MyRange.Font.Underline = True
    End Sub
    '文字是否有删除线
    Public Sub Strikethrough()
        MyRange.Font.StrikeThrough = True
    End Sub
    '插入图片
    Public Sub InsertPic(ByVal position As String)
        MyRange.Start = MyRange.End
        MyRange.InsertParagraphAfter()
        MyRange.InlineShapes.AddPicture(position)
    End Sub
    '图片大小
    Public Sub PicSize(ByVal Height As Integer, ByVal width As Integer)
        MyRange.InlineShapes(1).Height = Height
        MyRange.InlineShapes(1).Width = width
    End Sub
    '图片缩放（全体）
    Public Sub PicScale(ByVal value As Integer)
        Dim n '图片个数
        On Error Resume Next '忽略错误
        For n = 1 To MyDocument.InlineShapes.Count 'InlineShapes 类型图片
            MyDocument.InlineShapes(n).Height *= value
            MyDocument.InlineShapes(n).Width *= value
        Next n
    End Sub
    '图片对比度
    Public Sub PicContrast(ByVal value As Double)
        MyRange.InlineShapes(1).PictureFormat.Contrast = value
    End Sub
    '图片透明度
    Public Sub PicBright(ByVal value As Double)
        MyRange.InlineShapes(1).PictureFormat.Brightness = value
    End Sub
    '图片布局
    Public Sub PicLayout(ByVal text As String)
        If text = "嵌入式" Then
            MyRange.ShapeRange(1).WrapFormat.Type = Word.WdWrapType.wdWrapInline
        End If
        If text = "四周型环绕" Then
            MyRange.ShapeRange(1).WrapFormat.Type = Word.WdWrapType.wdWrapSquare
        End If
        If text = "紧密型环绕" Then
            MyRange.ShapeRange(1).WrapFormat.Type = Word.WdWrapType.wdWrapTight
        End If
        If text = "穿越型环绕" Then
            MyRange.ShapeRange(1).WrapFormat.Type = Word.WdWrapType.wdWrapThrough
        End If
        If text = "上下型环绕" Then
            MyRange.ShapeRange(1).WrapFormat.Type = Word.WdWrapType.wdWrapTopBottom
        End If
        If text = "衬于文字下方" Then
            MyRange.ShapeRange(1).WrapFormat.Type = 5
        End If
        If text = "浮于文字上方" Then
            MyRange.ShapeRange(1).WrapFormat.Type = 6
        End If
    End Sub
    '插入表格
    Public Sub InsertTable(ByVal Row As Integer, ByVal Column As Integer)
        MyRange.Tables.Add(MyRange, NumRows:=Row, NumColumns:=Column, DefaultTableBehavior:=Word.WdDefaultTableBehavior.wdWord9TableBehavior, AutoFitBehavior:=Word.WdAutoFitBehavior.wdAutoFitFixed)
    End Sub
    '表格大小
    Public Sub TableSize(ByVal RowHeight As Double, ByVal ColumnWidth As Double)
        MyRange.Tables(1).Rows.Height = RowHeight
        MyRange.Tables(1).Columns.Width = ColumnWidth
    End Sub
    '表格文字
    Public Sub TableText(ByVal RowNum As Integer, ByVal ColumnNum As Integer, ByVal text As String)
        MyRange = MyRange.Tables(1).Cell(Row:=RowNum, Column:=ColumnNum).Range
        MyRange.InsertAfter(text)
    End Sub
    '在下方插入行
    Public Sub TableAddrow()
        MyRange.Rows.Add()
    End Sub
    '在右侧插入列
    Public Sub TableAddcolumn()
        MyRange.Columns.Add()
    End Sub
    '选择表格单元格位置
    Public Sub TableCell(ByVal Row As Integer, ByVal Column As Integer)
        MyTable = MyRange.Tables(1)
        MyRange = MyDocument.Range(MyTable.Cell(Row, Column).Range.Start）
    End Sub
    '合并单元格
    Public Sub TableMerge(ByVal Row1 As Integer, ByVal Column1 As Integer, ByVal Row2 As Integer, ByVal Column2 As Integer)
        MyTable = MyRange.Tables(1)
        MyRange = MyDocument.Range(MyTable.Cell(Row1, Column1).Range.Start, MyTable.Cell(Row2, Column2).Range.End)
        MyRange.Cells.Merge()
    End Sub
    '表格跳出
    Public Sub OutTable()
        MyRange.Start = MyRange.End
        MyRange.InsertParagraphAfter()
    End Sub
    '表格整体文字设置
    Public Sub TableFontName(ByVal FontName As String)
        MyRange.Tables(1).Style.Font.Name = FontName
    End Sub
    Public Sub TableFontSize(ByVal FontSize As Integer)
        MyRange.Tables(1).Style.Font.Size = FontSize
    End Sub
    Public Sub TableFontColor(ByVal ColorIndex As String)
        Select Case (ColorIndex)
            Case "蓝色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdBlue
            Case "红色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdRed
            Case "绿色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdGreen
            Case "白色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdWhite
            Case "粉色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdPink
            Case "黄色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdYellow
            Case "灰色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdGray50
            Case "紫色"
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdViolet
            Case Else
                MyRange.Tables(1).Style.Font.ColorIndex = Word.WdColorIndex.wdBlack
        End Select
    End Sub
    Public Sub TableFontBold(ByVal FontBold As Boolean)
        MyRange.Tables(1).Style.Font.Bold = FontBold
    End Sub
    Public Sub TableFontItalic(ByVal FontItalic As Boolean)
        MyRange.Tables(1).Style.Font.Italic = FontItalic
    End Sub
    Public Sub TableFontUnderline(ByVal FontUnder As Boolean)
        MyRange.Tables(1).Style.Font.Underline = FontUnder
    End Sub
    Public Sub TableAlignment(ByVal position As String)
        Select Case (position)
            Case "居中"
                MyRange.Tables(1).Style.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            Case "居右"
                MyRange.Tables(1).Style.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            Case "两端对齐"
                MyRange.Tables(1).Style.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
            Case "分散对齐"
                MyRange.Tables(1).Style.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphDistribute
            Case Else
                MyRange.Tables(1).Style.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        End Select
    End Sub
End Class

