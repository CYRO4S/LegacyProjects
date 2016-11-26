<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckbHide = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBDirectory = New System.Windows.Forms.RadioButton()
        Me.RBFile = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.TitlePreview = New System.Windows.Forms.TextBox()
        Me.ContentPreview = New System.Windows.Forms.TextBox()
        Me.picWOK = New System.Windows.Forms.PictureBox()
        Me.picIOK = New System.Windows.Forms.PictureBox()
        Me.picQYN = New System.Windows.Forms.PictureBox()
        Me.picEOK = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RBEOK = New System.Windows.Forms.RadioButton()
        Me.RBWOK = New System.Windows.Forms.RadioButton()
        Me.RBQYN = New System.Windows.Forms.RadioButton()
        Me.RBIOK = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckbMsgbox = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picWOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQYN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(754, 395)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(746, 365)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "备份设置"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ubuntu Light", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 75)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "2"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(294, 45)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(246, 121)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtTime)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ckbHide)
        Me.GroupBox3.Location = New System.Drawing.Point(326, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 85)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "备份选项"
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTime.Location = New System.Drawing.Point(54, 49)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 29)
        Me.txtTime.TabIndex = 3
        Me.txtTime.Text = "600"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(160, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "秒检测一次是否存在源文件(夹)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "每隔"
        '
        'ckbHide
        '
        Me.ckbHide.AutoSize = True
        Me.ckbHide.Checked = True
        Me.ckbHide.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbHide.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ckbHide.Location = New System.Drawing.Point(9, 22)
        Me.ckbHide.Name = "ckbHide"
        Me.ckbHide.Size = New System.Drawing.Size(189, 25)
        Me.ckbHide.TabIndex = 0
        Me.ckbHide.Text = "备份系统及隐藏文件夹"
        Me.ckbHide.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDestination)
        Me.GroupBox2.Controls.Add(Me.txtSource)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(719, 77)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "备份地址"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "目标路径(文件夹)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "源路径(文件或文件夹)"
        '
        'txtDestination
        '
        Me.txtDestination.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestination.Location = New System.Drawing.Point(136, 42)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(577, 23)
        Me.txtDestination.TabIndex = 1
        Me.txtDestination.Text = "E:\"
        '
        'txtSource
        '
        Me.txtSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSource.Location = New System.Drawing.Point(136, 17)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(577, 23)
        Me.txtSource.TabIndex = 0
        Me.txtSource.Text = "G:\"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBDirectory)
        Me.GroupBox1.Controls.Add(Me.RBFile)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "备份内容"
        '
        'RBDirectory
        '
        Me.RBDirectory.AutoSize = True
        Me.RBDirectory.Checked = True
        Me.RBDirectory.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RBDirectory.Location = New System.Drawing.Point(127, 35)
        Me.RBDirectory.Name = "RBDirectory"
        Me.RBDirectory.Size = New System.Drawing.Size(156, 25)
        Me.RBDirectory.TabIndex = 3
        Me.RBDirectory.TabStop = True
        Me.RBDirectory.Text = "文件夹或整个磁盘"
        Me.RBDirectory.UseVisualStyleBackColor = True
        '
        'RBFile
        '
        Me.RBFile.AutoSize = True
        Me.RBFile.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RBFile.Location = New System.Drawing.Point(23, 35)
        Me.RBFile.Name = "RBFile"
        Me.RBFile.Size = New System.Drawing.Size(92, 25)
        Me.RBFile.TabIndex = 2
        Me.RBFile.Text = "单个文件"
        Me.RBFile.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.ckbMsgbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(746, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "提醒设置"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnPreview)
        Me.GroupBox5.Controls.Add(Me.TitlePreview)
        Me.GroupBox5.Controls.Add(Me.ContentPreview)
        Me.GroupBox5.Controls.Add(Me.picWOK)
        Me.GroupBox5.Controls.Add(Me.picIOK)
        Me.GroupBox5.Controls.Add(Me.picQYN)
        Me.GroupBox5.Controls.Add(Me.picEOK)
        Me.GroupBox5.Location = New System.Drawing.Point(354, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(387, 334)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "预览"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(152, 288)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 27)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "查看预览"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'TitlePreview
        '
        Me.TitlePreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TitlePreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TitlePreview.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitlePreview.Location = New System.Drawing.Point(82, 97)
        Me.TitlePreview.Name = "TitlePreview"
        Me.TitlePreview.Size = New System.Drawing.Size(224, 16)
        Me.TitlePreview.TabIndex = 1
        Me.TitlePreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContentPreview
        '
        Me.ContentPreview.BackColor = System.Drawing.Color.White
        Me.ContentPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContentPreview.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ContentPreview.Location = New System.Drawing.Point(84, 153)
        Me.ContentPreview.Name = "ContentPreview"
        Me.ContentPreview.Size = New System.Drawing.Size(266, 16)
        Me.ContentPreview.TabIndex = 0
        Me.ContentPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picWOK
        '
        Me.picWOK.Image = CType(resources.GetObject("picWOK.Image"), System.Drawing.Image)
        Me.picWOK.Location = New System.Drawing.Point(6, 89)
        Me.picWOK.Name = "picWOK"
        Me.picWOK.Size = New System.Drawing.Size(373, 173)
        Me.picWOK.TabIndex = 4
        Me.picWOK.TabStop = False
        '
        'picIOK
        '
        Me.picIOK.Image = CType(resources.GetObject("picIOK.Image"), System.Drawing.Image)
        Me.picIOK.Location = New System.Drawing.Point(6, 89)
        Me.picIOK.Name = "picIOK"
        Me.picIOK.Size = New System.Drawing.Size(373, 173)
        Me.picIOK.TabIndex = 5
        Me.picIOK.TabStop = False
        '
        'picQYN
        '
        Me.picQYN.Image = CType(resources.GetObject("picQYN.Image"), System.Drawing.Image)
        Me.picQYN.Location = New System.Drawing.Point(6, 89)
        Me.picQYN.Name = "picQYN"
        Me.picQYN.Size = New System.Drawing.Size(373, 173)
        Me.picQYN.TabIndex = 3
        Me.picQYN.TabStop = False
        '
        'picEOK
        '
        Me.picEOK.Image = CType(resources.GetObject("picEOK.Image"), System.Drawing.Image)
        Me.picEOK.Location = New System.Drawing.Point(8, 89)
        Me.picEOK.Name = "picEOK"
        Me.picEOK.Size = New System.Drawing.Size(373, 173)
        Me.picEOK.TabIndex = 2
        Me.picEOK.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtContent)
        Me.GroupBox4.Controls.Add(Me.txtTitle)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 90)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(316, 269)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "自定义消息框"
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(9, 95)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(301, 23)
        Me.txtContent.TabIndex = 4
        Me.txtContent.Text = "上次会话意外关闭，是否恢复打开的演示文稿？"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(9, 46)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(301, 23)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "Microsoft PowerPoint"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RBEOK)
        Me.GroupBox6.Controls.Add(Me.RBWOK)
        Me.GroupBox6.Controls.Add(Me.RBQYN)
        Me.GroupBox6.Controls.Add(Me.RBIOK)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(301, 133)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "消息框样式"
        '
        'RBEOK
        '
        Me.RBEOK.AutoSize = True
        Me.RBEOK.Location = New System.Drawing.Point(9, 98)
        Me.RBEOK.Name = "RBEOK"
        Me.RBEOK.Size = New System.Drawing.Size(226, 21)
        Me.RBEOK.TabIndex = 3
        Me.RBEOK.Text = "带有""错误""标志和""确定""按钮的消息框"
        Me.RBEOK.UseVisualStyleBackColor = True
        '
        'RBWOK
        '
        Me.RBWOK.AutoSize = True
        Me.RBWOK.Location = New System.Drawing.Point(9, 73)
        Me.RBWOK.Name = "RBWOK"
        Me.RBWOK.Size = New System.Drawing.Size(226, 21)
        Me.RBWOK.TabIndex = 2
        Me.RBWOK.Text = "带有""警告""标志和""确定""按钮的消息框"
        Me.RBWOK.UseVisualStyleBackColor = True
        '
        'RBQYN
        '
        Me.RBQYN.AutoSize = True
        Me.RBQYN.Checked = True
        Me.RBQYN.Location = New System.Drawing.Point(9, 48)
        Me.RBQYN.Name = "RBQYN"
        Me.RBQYN.Size = New System.Drawing.Size(226, 21)
        Me.RBQYN.TabIndex = 1
        Me.RBQYN.TabStop = True
        Me.RBQYN.Text = "带有""疑问""标志和""是否""按钮的消息框"
        Me.RBQYN.UseVisualStyleBackColor = True
        '
        'RBIOK
        '
        Me.RBIOK.AutoSize = True
        Me.RBIOK.Location = New System.Drawing.Point(9, 22)
        Me.RBIOK.Name = "RBIOK"
        Me.RBIOK.Size = New System.Drawing.Size(226, 21)
        Me.RBIOK.TabIndex = 0
        Me.RBIOK.Text = "带有""信息""标志和""确定""按钮的消息框"
        Me.RBIOK.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "消息框内容："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "消息框标题："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(266, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "如果没有选中，UCopy 2 将在找到目标后退出。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "在找到目标后显示消息框，点按任意按钮退出UCopy 2。"
        '
        'ckbMsgbox
        '
        Me.ckbMsgbox.AutoSize = True
        Me.ckbMsgbox.Checked = True
        Me.ckbMsgbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbMsgbox.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ckbMsgbox.Location = New System.Drawing.Point(20, 25)
        Me.ckbMsgbox.Name = "ckbMsgbox"
        Me.ckbMsgbox.Size = New System.Drawing.Size(157, 25)
        Me.ckbMsgbox.TabIndex = 0
        Me.ckbMsgbox.Text = "完成后显示消息框"
        Me.ckbMsgbox.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(12, 412)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 27)
        Me.btnAbout.TabIndex = 1
        Me.btnAbout.Text = "关于"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Location = New System.Drawing.Point(691, 413)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 27)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStart.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnStart.Location = New System.Drawing.Point(324, 413)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 27)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "开始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(778, 447)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(794, 486)
        Me.MinimumSize = New System.Drawing.Size(794, 486)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UCopy 2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.picWOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQYN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckbHide As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBDirectory As System.Windows.Forms.RadioButton
    Friend WithEvents RBFile As System.Windows.Forms.RadioButton
    Friend WithEvents ckbMsgbox As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RBEOK As System.Windows.Forms.RadioButton
    Friend WithEvents RBWOK As System.Windows.Forms.RadioButton
    Friend WithEvents RBQYN As System.Windows.Forms.RadioButton
    Friend WithEvents RBIOK As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TitlePreview As System.Windows.Forms.TextBox
    Friend WithEvents ContentPreview As System.Windows.Forms.TextBox
    Friend WithEvents picEOK As System.Windows.Forms.PictureBox
    Friend WithEvents picIOK As System.Windows.Forms.PictureBox
    Friend WithEvents picWOK As System.Windows.Forms.PictureBox
    Friend WithEvents picQYN As System.Windows.Forms.PictureBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button

End Class
