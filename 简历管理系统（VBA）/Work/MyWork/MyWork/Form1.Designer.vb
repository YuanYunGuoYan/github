<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("默认简历")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MyOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeDataSet = New MyWork.officeDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MyOfficeTableAdapter = New MyWork.officeDataSetTableAdapters.MyOfficeTableAdapter()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorTableAdapter = New MyWork.officeDataSetTableAdapters.ColorTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FontSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.FontNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FontSizeTableAdapter = New MyWork.officeDataSetTableAdapters.FontSizeTableAdapter()
        Me.FontNameTableAdapter = New MyWork.officeDataSetTableAdapters.FontNameTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.AlignmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlignmentTableAdapter = New MyWork.officeDataSetTableAdapters.AlignmentTableAdapter()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TitleLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitleLevelTableAdapter = New MyWork.officeDataSetTableAdapters.TitleLevelTableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.PicLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PicLayoutTableAdapter = New MyWork.officeDataSetTableAdapters.PicLayoutTableAdapter()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OfficeDataSet1 = New MyWork.officeDataSet1()
        Me.OfficeDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MyOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FontSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FontNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlignmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyOfficeBindingSource
        '
        Me.MyOfficeBindingSource.DataMember = "MyOffice"
        Me.MyOfficeBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'OfficeDataSetBindingSource
        '
        Me.OfficeDataSetBindingSource.DataSource = Me.OfficeDataSet
        Me.OfficeDataSetBindingSource.Position = 0
        '
        'OfficeDataSet
        '
        Me.OfficeDataSet.DataSetName = "officeDataSet"
        Me.OfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "输出文档"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MyOfficeTableAdapter
        '
        Me.MyOfficeTableAdapter.ClearBeforeFill = True
        '
        'TreeView1
        '
        Me.TreeView1.LineColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(21, 106)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "默认简历"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeView1.Size = New System.Drawing.Size(279, 400)
        Me.TreeView1.TabIndex = 2
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(42, 507)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(63, 25)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "确认"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 22)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 133)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 22)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 133)
        Me.TextBox3.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(387, 249)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(9, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "文字颜色："
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ColorBindingSource
        Me.ComboBox1.DisplayMember = "颜色"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 171)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox1.TabIndex = 21
        Me.ComboBox1.ValueMember = "颜色"
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "Color"
        Me.ColorBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'ColorTableAdapter
        '
        Me.ColorTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.FontSizeBindingSource
        Me.ComboBox2.DisplayMember = "文字大小"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(124, 212)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox2.TabIndex = 22
        Me.ComboBox2.ValueMember = "文字大小"
        '
        'FontSizeBindingSource
        '
        Me.FontSizeBindingSource.DataMember = "FontSize"
        Me.FontSizeBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.FontNameBindingSource
        Me.ComboBox3.DisplayMember = "文字字体"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(124, 250)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox3.TabIndex = 23
        Me.ComboBox3.ValueMember = "文字字体"
        '
        'FontNameBindingSource
        '
        Me.FontNameBindingSource.DataMember = "FontName"
        Me.FontNameBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(9, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "文字大小："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(9, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "文字字体："
        '
        'FontSizeTableAdapter
        '
        Me.FontSizeTableAdapter.ClearBeforeFill = True
        '
        'FontNameTableAdapter
        '
        Me.FontNameTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CheckBox1.Location = New System.Drawing.Point(12, 339)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "加粗"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CheckBox2.Location = New System.Drawing.Point(12, 382)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox2.TabIndex = 27
        Me.CheckBox2.Text = "斜体"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CheckBox3.Location = New System.Drawing.Point(124, 339)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(68, 18)
        Me.CheckBox3.TabIndex = 28
        Me.CheckBox3.Text = "下划线"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CheckBox4.Location = New System.Drawing.Point(124, 382)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(68, 18)
        Me.CheckBox4.TabIndex = 29
        Me.CheckBox4.Text = "删除线"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(9, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 14)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "对齐方式："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(9, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 14)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "首行缩进："
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.AlignmentBindingSource
        Me.ComboBox4.DisplayMember = "对齐方式"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(124, 293)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(67, 21)
        Me.ComboBox4.TabIndex = 32
        Me.ComboBox4.ValueMember = "对齐方式"
        '
        'AlignmentBindingSource
        '
        Me.AlignmentBindingSource.DataMember = "Alignment"
        Me.AlignmentBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'AlignmentTableAdapter
        '
        Me.AlignmentTableAdapter.ClearBeforeFill = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(124, 416)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(68, 23)
        Me.NumericUpDown1.TabIndex = 33
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(124, 450)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(68, 23)
        Me.NumericUpDown2.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(9, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "悬挂缩进："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(9, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 14)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "标题级别:"
        '
        'TitleLevelBindingSource
        '
        Me.TitleLevelBindingSource.DataMember = "TitleLevel"
        Me.TitleLevelBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'TitleLevelTableAdapter
        '
        Me.TitleLevelTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(9, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 14)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "一级标题序号："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(9, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 14)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "二级标题序号："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(9, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 14)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "三级标题序号："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(9, 346)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 14)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "标题颜色："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(9, 389)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 14)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "标题大小："
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(9, 432)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 14)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "标题字体:"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(124, 210)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        Me.NumericUpDown3.Size = New System.Drawing.Size(77, 23)
        Me.NumericUpDown3.TabIndex = 44
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(124, 248)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.ReadOnly = True
        Me.NumericUpDown4.Size = New System.Drawing.Size(77, 23)
        Me.NumericUpDown4.TabIndex = 45
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(124, 291)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.ReadOnly = True
        Me.NumericUpDown5.Size = New System.Drawing.Size(77, 23)
        Me.NumericUpDown5.TabIndex = 46
        '
        'ComboBox6
        '
        Me.ComboBox6.DataSource = Me.ColorBindingSource
        Me.ComboBox6.DisplayMember = "颜色"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(124, 339)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(77, 21)
        Me.ComboBox6.TabIndex = 47
        Me.ComboBox6.ValueMember = "颜色"
        '
        'ComboBox7
        '
        Me.ComboBox7.DataSource = Me.FontSizeBindingSource
        Me.ComboBox7.DisplayMember = "文字大小"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(124, 382)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(77, 21)
        Me.ComboBox7.TabIndex = 48
        Me.ComboBox7.ValueMember = "文字大小"
        '
        'ComboBox8
        '
        Me.ComboBox8.DataSource = Me.FontNameBindingSource
        Me.ComboBox8.DisplayMember = "文字字体"
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(124, 425)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(77, 21)
        Me.ComboBox8.TabIndex = 49
        Me.ComboBox8.ValueMember = "文字字体"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(30, 469)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "确认"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(15, 286)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 14)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "图片路径："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(14, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 14)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "图片布局："
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(15, 356)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 14)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "图片高度："
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(15, 389)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 14)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "图片宽度："
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(14, 425)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 14)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "图片透明度："
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(15, 466)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 14)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "图片对比度："
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(15, 503)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 14)
        Me.Label24.TabIndex = 57
        Me.Label24.Text = "缩放比例："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 277)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 23)
        Me.TextBox1.TabIndex = 58
        '
        'ComboBox9
        '
        Me.ComboBox9.DataSource = Me.PicLayoutBindingSource
        Me.ComboBox9.DisplayMember = "图片布局"
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Location = New System.Drawing.Point(112, 314)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(91, 21)
        Me.ComboBox9.TabIndex = 59
        Me.ComboBox9.ValueMember = "图片布局"
        '
        'PicLayoutBindingSource
        '
        Me.PicLayoutBindingSource.DataMember = "PicLayout"
        Me.PicLayoutBindingSource.DataSource = Me.OfficeDataSetBindingSource
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(112, 347)
        Me.NumericUpDown6.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown6.TabIndex = 60
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(112, 383)
        Me.NumericUpDown7.Maximum = New Decimal(New Integer() {420, 0, 0, 0})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown7.TabIndex = 61
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(112, 419)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown8.TabIndex = 62
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(112, 459)
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown9.TabIndex = 63
        '
        'NumericUpDown10
        '
        Me.NumericUpDown10.Location = New System.Drawing.Point(112, 496)
        Me.NumericUpDown10.Name = "NumericUpDown10"
        Me.NumericUpDown10.Size = New System.Drawing.Size(91, 23)
        Me.NumericUpDown10.TabIndex = 64
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(98, 540)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 65
        Me.Button8.Text = "确认"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PicLayoutTableAdapter
        '
        Me.PicLayoutTableAdapter.ClearBeforeFill = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(21, 524)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 14)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "简历名称："
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(104, 519)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 68
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(225, 519)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(58, 23)
        Me.Button9.TabIndex = 69
        Me.Button9.Text = "修改"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(298, 277)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(60, 23)
        Me.Button11.TabIndex = 70
        Me.Button11.Text = "选择"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 582)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "简历模板模块"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(21, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "后一栏修改简历标题名称并生成简历。"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(21, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "输入你要设置的格式或者内容，完成后在最"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(21, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "象，在对应的标题、文本、图片、表格编辑"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "在下方目录的默认简历中选择你要编辑的对"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Location = New System.Drawing.Point(609, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 582)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "文本编辑框"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(152, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "取消"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.ComboBox8)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.ComboBox7)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ComboBox6)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown5)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(333, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 582)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "标题编辑框"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(124, 169)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(77, 23)
        Me.TextBox5.TabIndex = 47
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown10)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown9)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown8)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown7)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.NumericUpDown6)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.ComboBox9)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Button11)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Location = New System.Drawing.Point(898, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(422, 582)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "图片编辑框"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 540)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "取消"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OfficeDataSet1
        '
        Me.OfficeDataSet1.DataSetName = "officeDataSet1"
        Me.OfficeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfficeDataSetBindingSource1
        '
        Me.OfficeDataSetBindingSource1.DataSource = Me.OfficeDataSet
        Me.OfficeDataSetBindingSource1.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1331, 674)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Name = "Form1"
        Me.Text = "简历管理系统"
        CType(Me.MyOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FontSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FontNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlignmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents OfficeDataSetBindingSource As BindingSource
    Friend WithEvents OfficeDataSet As officeDataSet
    Friend WithEvents MyOfficeBindingSource As BindingSource
    Friend WithEvents MyOfficeTableAdapter As officeDataSetTableAdapters.MyOfficeTableAdapter
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As officeDataSetTableAdapters.ColorTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FontSizeBindingSource As BindingSource
    Friend WithEvents FontSizeTableAdapter As officeDataSetTableAdapters.FontSizeTableAdapter
    Friend WithEvents FontNameBindingSource As BindingSource
    Friend WithEvents FontNameTableAdapter As officeDataSetTableAdapters.FontNameTableAdapter
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents AlignmentBindingSource As BindingSource
    Friend WithEvents AlignmentTableAdapter As officeDataSetTableAdapters.AlignmentTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TitleLevelBindingSource As BindingSource
    Friend WithEvents TitleLevelTableAdapter As officeDataSetTableAdapters.TitleLevelTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents NumericUpDown10 As NumericUpDown
    Friend WithEvents Button8 As Button
    Friend WithEvents PicLayoutBindingSource As BindingSource
    Friend WithEvents PicLayoutTableAdapter As officeDataSetTableAdapters.PicLayoutTableAdapter
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OfficeDataSetBindingSource1 As BindingSource
    Friend WithEvents OfficeDataSet1 As officeDataSet1
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
