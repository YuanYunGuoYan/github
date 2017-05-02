<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox20.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox20
        '
        Me.GroupBox20.BackgroundImage = CType(resources.GetObject("GroupBox20.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox20.Controls.Add(Me.Button1)
        Me.GroupBox20.Controls.Add(Me.Button6)
        Me.GroupBox20.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox20.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(742, 145)
        Me.GroupBox20.TabIndex = 77
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "教育经历表编辑框"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "取消"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(257, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "确认"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImage = CType(resources.GetObject("TableLayoutPanel2.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.10811!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.89189!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox25, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox24, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox23, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox21, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox22, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(731, 51)
        Me.TableLayoutPanel2.TabIndex = 77
        '
        'GroupBox25
        '
        Me.GroupBox25.BackgroundImage = CType(resources.GetObject("GroupBox25.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox25.Controls.Add(Me.TextBox20)
        Me.GroupBox25.Location = New System.Drawing.Point(604, 3)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(116, 44)
        Me.GroupBox25.TabIndex = 79
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "专业描述："
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(6, 15)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 21)
        Me.TextBox20.TabIndex = 0
        '
        'GroupBox24
        '
        Me.GroupBox24.BackgroundImage = CType(resources.GetObject("GroupBox24.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox24.Controls.Add(Me.TextBox19)
        Me.GroupBox24.Location = New System.Drawing.Point(486, 3)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(112, 44)
        Me.GroupBox24.TabIndex = 79
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "学历："
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(6, 15)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 21)
        Me.TextBox19.TabIndex = 0
        '
        'GroupBox23
        '
        Me.GroupBox23.BackgroundImage = CType(resources.GetObject("GroupBox23.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox23.Controls.Add(Me.TextBox12)
        Me.GroupBox23.Location = New System.Drawing.Point(367, 3)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(113, 44)
        Me.GroupBox23.TabIndex = 79
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "专业："
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(6, 15)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 21)
        Me.TextBox12.TabIndex = 0
        '
        'GroupBox21
        '
        Me.GroupBox21.BackgroundImage = CType(resources.GetObject("GroupBox21.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox21.Controls.Add(Me.Label1)
        Me.GroupBox21.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox21.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox21.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(242, 44)
        Me.GroupBox21.TabIndex = 78
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "起止时间："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "至"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(136, 15)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(105, 21)
        Me.DateTimePicker3.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(0, 15)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePicker2.TabIndex = 0
        '
        'GroupBox22
        '
        Me.GroupBox22.BackgroundImage = CType(resources.GetObject("GroupBox22.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox22.Controls.Add(Me.TextBox7)
        Me.GroupBox22.Location = New System.Drawing.Point(251, 3)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(110, 44)
        Me.GroupBox22.TabIndex = 79
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "学校："
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(6, 15)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 21)
        Me.TextBox7.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(765, 207)
        Me.Controls.Add(Me.GroupBox20)
        Me.Name = "Form3"
        Me.Text = "教育经历表"
        Me.TopMost = True
        Me.GroupBox20.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
End Class
