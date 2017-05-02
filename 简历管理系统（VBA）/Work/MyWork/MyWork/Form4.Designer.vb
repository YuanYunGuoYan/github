<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.WorkingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeDataSet1 = New MyWork.officeDataSet1()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.ComboBox16 = New System.Windows.Forms.ComboBox()
        Me.CompanyNatureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.CompanySizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.CompanySizeTableAdapter = New MyWork.officeDataSet1TableAdapters.CompanySizeTableAdapter()
        Me.CompanyNatureTableAdapter = New MyWork.officeDataSet1TableAdapters.CompanyNatureTableAdapter()
        Me.WorkingTypeTableAdapter = New MyWork.officeDataSet1TableAdapters.WorkingTypeTableAdapter()
        Me.GroupBox26.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox36.SuspendLayout()
        CType(Me.WorkingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        CType(Me.CompanyNatureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox30.SuspendLayout()
        CType(Me.CompanySizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox26
        '
        Me.GroupBox26.BackgroundImage = CType(resources.GetObject("GroupBox26.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox26.Controls.Add(Me.Button1)
        Me.GroupBox26.Controls.Add(Me.Button12)
        Me.GroupBox26.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox26.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(1194, 211)
        Me.GroupBox26.TabIndex = 78
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "工作经历表编辑框"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(670, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "取消"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(374, 119)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 79
        Me.Button12.Text = "确认"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackgroundImage = CType(resources.GetObject("TableLayoutPanel3.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel3.ColumnCount = 10
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.18156!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.81844!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox27, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox36, 9, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox35, 8, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox34, 7, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox33, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox32, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox31, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox30, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox29, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox28, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 14)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1181, 54)
        Me.TableLayoutPanel3.TabIndex = 78
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.Label2)
        Me.GroupBox27.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox27.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox27.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(241, 41)
        Me.GroupBox27.TabIndex = 79
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "起止时间："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "至"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Location = New System.Drawing.Point(136, 14)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(105, 21)
        Me.DateTimePicker5.TabIndex = 1
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(0, 14)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker4.TabIndex = 0
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.ComboBox14)
        Me.GroupBox36.Location = New System.Drawing.Point(1073, 3)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(99, 41)
        Me.GroupBox36.TabIndex = 80
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "工作性质："
        '
        'ComboBox14
        '
        Me.ComboBox14.DataSource = Me.WorkingTypeBindingSource
        Me.ComboBox14.DisplayMember = "工作类型"
        Me.ComboBox14.FormattingEnabled = True
        Me.ComboBox14.Location = New System.Drawing.Point(11, 20)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(88, 20)
        Me.ComboBox14.TabIndex = 0
        Me.ComboBox14.ValueMember = "工作类型"
        '
        'WorkingTypeBindingSource
        '
        Me.WorkingTypeBindingSource.DataMember = "WorkingType"
        Me.WorkingTypeBindingSource.DataSource = Me.OfficeDataSet1
        '
        'OfficeDataSet1
        '
        Me.OfficeDataSet1.DataSetName = "officeDataSet1"
        Me.OfficeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.TextBox28)
        Me.GroupBox35.Location = New System.Drawing.Point(971, 3)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(96, 41)
        Me.GroupBox35.TabIndex = 80
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "工作描述："
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(6, 18)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(87, 21)
        Me.TextBox28.TabIndex = 0
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.TextBox27)
        Me.GroupBox34.Location = New System.Drawing.Point(866, 3)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(99, 41)
        Me.GroupBox34.TabIndex = 80
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "职位名称："
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(6, 18)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(87, 21)
        Me.TextBox27.TabIndex = 0
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.TextBox26)
        Me.GroupBox33.Location = New System.Drawing.Point(761, 3)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(99, 41)
        Me.GroupBox33.TabIndex = 80
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "职能类别："
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(6, 18)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(87, 21)
        Me.TextBox26.TabIndex = 0
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.TextBox25)
        Me.GroupBox32.Location = New System.Drawing.Point(658, 3)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(97, 41)
        Me.GroupBox32.TabIndex = 80
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "部门："
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(6, 18)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(87, 21)
        Me.TextBox25.TabIndex = 0
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.ComboBox16)
        Me.GroupBox31.Location = New System.Drawing.Point(555, 3)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(97, 41)
        Me.GroupBox31.TabIndex = 80
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "公司性质："
        '
        'ComboBox16
        '
        Me.ComboBox16.DataSource = Me.CompanyNatureBindingSource
        Me.ComboBox16.DisplayMember = "公司性质"
        Me.ComboBox16.FormattingEnabled = True
        Me.ComboBox16.Location = New System.Drawing.Point(7, 16)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(84, 20)
        Me.ComboBox16.TabIndex = 0
        Me.ComboBox16.ValueMember = "公司性质"
        '
        'CompanyNatureBindingSource
        '
        Me.CompanyNatureBindingSource.DataMember = "CompanyNature"
        Me.CompanyNatureBindingSource.DataSource = Me.OfficeDataSet1
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.ComboBox15)
        Me.GroupBox30.Location = New System.Drawing.Point(453, 3)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(96, 41)
        Me.GroupBox30.TabIndex = 80
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "公司规模："
        '
        'ComboBox15
        '
        Me.ComboBox15.DataSource = Me.CompanySizeBindingSource
        Me.ComboBox15.DisplayMember = "公司规模"
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Location = New System.Drawing.Point(8, 18)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(81, 20)
        Me.ComboBox15.TabIndex = 0
        Me.ComboBox15.ValueMember = "公司规模"
        '
        'CompanySizeBindingSource
        '
        Me.CompanySizeBindingSource.DataMember = "CompanySize"
        Me.CompanySizeBindingSource.DataSource = Me.OfficeDataSet1
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.TextBox22)
        Me.GroupBox29.Location = New System.Drawing.Point(350, 3)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(97, 41)
        Me.GroupBox29.TabIndex = 80
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "行业："
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(6, 18)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(87, 21)
        Me.TextBox22.TabIndex = 0
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.TextBox21)
        Me.GroupBox28.Location = New System.Drawing.Point(250, 3)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(94, 41)
        Me.GroupBox28.TabIndex = 80
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "公司："
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(6, 18)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(87, 21)
        Me.TextBox21.TabIndex = 0
        '
        'CompanySizeTableAdapter
        '
        Me.CompanySizeTableAdapter.ClearBeforeFill = True
        '
        'CompanyNatureTableAdapter
        '
        Me.CompanyNatureTableAdapter.ClearBeforeFill = True
        '
        'WorkingTypeTableAdapter
        '
        Me.WorkingTypeTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1215, 238)
        Me.Controls.Add(Me.GroupBox26)
        Me.Name = "Form4"
        Me.Text = "工作经历表"
        Me.TopMost = True
        Me.GroupBox26.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.GroupBox36.ResumeLayout(False)
        CType(Me.WorkingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox34.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox33.PerformLayout()
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.GroupBox31.ResumeLayout(False)
        CType(Me.CompanyNatureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox30.ResumeLayout(False)
        CType(Me.CompanySizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents Button12 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents GroupBox36 As GroupBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents GroupBox35 As GroupBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents GroupBox34 As GroupBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents GroupBox33 As GroupBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents GroupBox32 As GroupBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents ComboBox16 As ComboBox
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents ComboBox15 As ComboBox
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents OfficeDataSet1 As officeDataSet1
    Friend WithEvents CompanySizeBindingSource As BindingSource
    Friend WithEvents CompanySizeTableAdapter As officeDataSet1TableAdapters.CompanySizeTableAdapter
    Friend WithEvents CompanyNatureBindingSource As BindingSource
    Friend WithEvents CompanyNatureTableAdapter As officeDataSet1TableAdapters.CompanyNatureTableAdapter
    Friend WithEvents WorkingTypeBindingSource As BindingSource
    Friend WithEvents WorkingTypeTableAdapter As officeDataSet1TableAdapters.WorkingTypeTableAdapter
    Friend WithEvents Button1 As Button
End Class
