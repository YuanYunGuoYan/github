<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.WorkingLifeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeDataSet1 = New MyWork.officeDataSet1()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarriageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexTableAdapter = New MyWork.officeDataSet1TableAdapters.SexTableAdapter()
        Me.MarriageTableAdapter = New MyWork.officeDataSet1TableAdapters.MarriageTableAdapter()
        Me.StatusTableAdapter = New MyWork.officeDataSet1TableAdapters.StatusTableAdapter()
        Me.WorkingLifeTableAdapter = New MyWork.officeDataSet1TableAdapters.WorkingLifeTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.WorkingLifeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarriageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorkingLifeBindingSource
        '
        Me.WorkingLifeBindingSource.DataMember = "WorkingLife"
        Me.WorkingLifeBindingSource.DataSource = Me.OfficeDataSet1
        '
        'OfficeDataSet1
        '
        Me.OfficeDataSet1.DataSetName = "officeDataSet1"
        Me.OfficeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me.OfficeDataSet1
        '
        'MarriageBindingSource
        '
        Me.MarriageBindingSource.DataMember = "Marriage"
        Me.MarriageBindingSource.DataSource = Me.OfficeDataSet1
        '
        'SexBindingSource
        '
        Me.SexBindingSource.DataMember = "Sex"
        Me.SexBindingSource.DataSource = Me.OfficeDataSet1
        '
        'SexTableAdapter
        '
        Me.SexTableAdapter.ClearBeforeFill = True
        '
        'MarriageTableAdapter
        '
        Me.MarriageTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'WorkingLifeTableAdapter
        '
        Me.WorkingLifeTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = CType(resources.GetObject("TableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox19, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox18, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox17, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox16, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox15, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox14, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox13, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox12, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox11, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox10, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(228, 344)
        Me.TableLayoutPanel1.TabIndex = 76
        '
        'GroupBox19
        '
        Me.GroupBox19.BackgroundImage = CType(resources.GetObject("GroupBox19.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox19.Controls.Add(Me.TextBox18)
        Me.GroupBox19.Location = New System.Drawing.Point(120, 301)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(93, 40)
        Me.GroupBox19.TabIndex = 77
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "身份证号："
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(6, 15)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(87, 21)
        Me.TextBox18.TabIndex = 0
        '
        'GroupBox18
        '
        Me.GroupBox18.BackgroundImage = CType(resources.GetObject("GroupBox18.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox18.Controls.Add(Me.TextBox17)
        Me.GroupBox18.Location = New System.Drawing.Point(3, 301)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(93, 40)
        Me.GroupBox18.TabIndex = 77
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "籍贯："
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(6, 15)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(87, 21)
        Me.TextBox17.TabIndex = 0
        '
        'GroupBox17
        '
        Me.GroupBox17.BackgroundImage = CType(resources.GetObject("GroupBox17.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox17.Controls.Add(Me.TextBox16)
        Me.GroupBox17.Location = New System.Drawing.Point(120, 253)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(93, 42)
        Me.GroupBox17.TabIndex = 77
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "现居住地："
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(6, 15)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(87, 21)
        Me.TextBox16.TabIndex = 0
        '
        'GroupBox16
        '
        Me.GroupBox16.BackgroundImage = CType(resources.GetObject("GroupBox16.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox16.Controls.Add(Me.TextBox15)
        Me.GroupBox16.Location = New System.Drawing.Point(3, 253)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(93, 42)
        Me.GroupBox16.TabIndex = 77
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "目前薪资："
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(6, 15)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(87, 21)
        Me.TextBox15.TabIndex = 0
        '
        'GroupBox15
        '
        Me.GroupBox15.BackgroundImage = CType(resources.GetObject("GroupBox15.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox15.Controls.Add(Me.ComboBox13)
        Me.GroupBox15.Location = New System.Drawing.Point(120, 204)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox15.TabIndex = 77
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "工作年限："
        '
        'ComboBox13
        '
        Me.ComboBox13.DataSource = Me.WorkingLifeBindingSource
        Me.ComboBox13.DisplayMember = "工作年限"
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Location = New System.Drawing.Point(6, 17)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(87, 20)
        Me.ComboBox13.TabIndex = 0
        Me.ComboBox13.ValueMember = "工作年限"
        '
        'GroupBox14
        '
        Me.GroupBox14.BackgroundImage = CType(resources.GetObject("GroupBox14.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox14.Controls.Add(Me.ComboBox12)
        Me.GroupBox14.Location = New System.Drawing.Point(3, 204)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox14.TabIndex = 1
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "政治面貌："
        '
        'ComboBox12
        '
        Me.ComboBox12.DataSource = Me.StatusBindingSource
        Me.ComboBox12.DisplayMember = "政治面貌"
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(7, 17)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(86, 20)
        Me.ComboBox12.TabIndex = 0
        Me.ComboBox12.ValueMember = "政治面貌"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackgroundImage = CType(resources.GetObject("GroupBox9.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox9.Controls.Add(Me.TextBox8)
        Me.GroupBox9.Location = New System.Drawing.Point(120, 54)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "手机号码："
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(6, 15)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(87, 21)
        Me.TextBox8.TabIndex = 0
        '
        'GroupBox13
        '
        Me.GroupBox13.BackgroundImage = CType(resources.GetObject("GroupBox13.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox13.Controls.Add(Me.ComboBox11)
        Me.GroupBox13.Location = New System.Drawing.Point(120, 156)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(93, 42)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "婚姻状况："
        '
        'ComboBox11
        '
        Me.ComboBox11.DataSource = Me.MarriageBindingSource
        Me.ComboBox11.DisplayMember = "婚姻状况"
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Location = New System.Drawing.Point(6, 15)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(87, 20)
        Me.ComboBox11.TabIndex = 0
        Me.ComboBox11.ValueMember = "婚姻状况"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackgroundImage = CType(resources.GetObject("GroupBox12.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox12.Controls.Add(Me.TextBox11)
        Me.GroupBox12.Location = New System.Drawing.Point(3, 156)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(93, 42)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "身高："
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(6, 15)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(87, 21)
        Me.TextBox11.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.BackgroundImage = CType(resources.GetObject("GroupBox11.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox11.Controls.Add(Me.TextBox10)
        Me.GroupBox11.Location = New System.Drawing.Point(120, 105)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "QQ："
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(6, 15)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(87, 21)
        Me.TextBox10.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = CType(resources.GetObject("GroupBox6.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "姓名："
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 15)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(87, 21)
        Me.TextBox5.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.BackgroundImage = CType(resources.GetObject("GroupBox8.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox8.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(111, 43)
        Me.GroupBox8.TabIndex = 78
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "出生日期："
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 76
        '
        'GroupBox7
        '
        Me.GroupBox7.BackgroundImage = CType(resources.GetObject("GroupBox7.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox7.Controls.Add(Me.ComboBox10)
        Me.GroupBox7.Location = New System.Drawing.Point(120, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox7.TabIndex = 77
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "性别："
        '
        'ComboBox10
        '
        Me.ComboBox10.DataSource = Me.SexBindingSource
        Me.ComboBox10.DisplayMember = "性别"
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(6, 15)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(87, 20)
        Me.ComboBox10.TabIndex = 0
        Me.ComboBox10.ValueMember = "性别"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackgroundImage = CType(resources.GetObject("GroupBox10.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox10.Controls.Add(Me.TextBox9)
        Me.GroupBox10.Location = New System.Drawing.Point(3, 105)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(93, 43)
        Me.GroupBox10.TabIndex = 77
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Email："
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(6, 15)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(87, 21)
        Me.TextBox9.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(49, 389)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "确认"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "取消"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox5.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 449)
        Me.GroupBox5.TabIndex = 76
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "基本信息表编辑框"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 455)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "Form2"
        Me.Text = "基本信息表"
        Me.TopMost = True
        CType(Me.WorkingLifeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarriageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OfficeDataSet1 As officeDataSet1
    Friend WithEvents SexBindingSource As BindingSource
    Friend WithEvents SexTableAdapter As officeDataSet1TableAdapters.SexTableAdapter
    Friend WithEvents MarriageBindingSource As BindingSource
    Friend WithEvents MarriageTableAdapter As officeDataSet1TableAdapters.MarriageTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As officeDataSet1TableAdapters.StatusTableAdapter
    Friend WithEvents WorkingLifeBindingSource As BindingSource
    Friend WithEvents WorkingLifeTableAdapter As officeDataSet1TableAdapters.WorkingLifeTableAdapter
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
