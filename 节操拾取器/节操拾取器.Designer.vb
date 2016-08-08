<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lbl_Close = New System.Windows.Forms.Label()
        Me.pnl_AboutMe = New System.Windows.Forms.Panel()
        Me.lbl_OK = New System.Windows.Forms.Label()
        Me.chk_NotShowAgain = New System.Windows.Forms.CheckBox()
        Me.lbl_Info_2 = New System.Windows.Forms.Label()
        Me.lbl_Info_1 = New System.Windows.Forms.Label()
        Me.pic_Head = New System.Windows.Forms.PictureBox()
        Me.lbl_Mini = New System.Windows.Forms.Label()
        Me.pnl_WorkStation = New System.Windows.Forms.Panel()
        Me.chk_TimeReConnect = New System.Windows.Forms.CheckBox()
        Me.chk_NetworkReConnect = New System.Windows.Forms.CheckBox()
        Me.lbl_Progress = New System.Windows.Forms.Label()
        Me.lbl_ConnectState = New System.Windows.Forms.Label()
        Me.pnl_ComboBox = New System.Windows.Forms.Panel()
        Me.cmb_NetworkCardList = New System.Windows.Forms.ComboBox()
        Me.lbl_RefreshList = New System.Windows.Forms.Label()
        Me.lbl_Step1_Info = New System.Windows.Forms.Label()
        Me.lbl_Step1 = New System.Windows.Forms.Label()
        Me.lbl_AboutMe = New System.Windows.Forms.Label()
        Me.lbl_ProgressInfo = New System.Windows.Forms.Label()
        Me.lbl_GetPath = New System.Windows.Forms.Label()
        Me.lbl_NewMacAddress = New System.Windows.Forms.Label()
        Me.pnl_TextBox_2 = New System.Windows.Forms.Panel()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.lbl_Step3_Info = New System.Windows.Forms.Label()
        Me.lbl_Step3 = New System.Windows.Forms.Label()
        Me.lbl_Step2_Info = New System.Windows.Forms.Label()
        Me.lbl_Step2 = New System.Windows.Forms.Label()
        Me.pnl_TextBox_1 = New System.Windows.Forms.Panel()
        Me.MacTextBox = New System.Windows.Forms.TextBox()
        Me.lbl_StartTask = New System.Windows.Forms.Label()
        Me.pnl_AboutMe.SuspendLayout()
        CType(Me.pic_Head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_WorkStation.SuspendLayout()
        Me.pnl_ComboBox.SuspendLayout()
        Me.pnl_TextBox_2.SuspendLayout()
        Me.pnl_TextBox_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Close
        '
        Me.lbl_Close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Close.Image = Global.节操拾取器.My.Resources.节操拾取器Res.关闭
        Me.lbl_Close.Location = New System.Drawing.Point(1, 5)
        Me.lbl_Close.Name = "lbl_Close"
        Me.lbl_Close.Size = New System.Drawing.Size(27, 25)
        Me.lbl_Close.TabIndex = 7
        '
        'pnl_AboutMe
        '
        Me.pnl_AboutMe.BackColor = System.Drawing.Color.Transparent
        Me.pnl_AboutMe.Controls.Add(Me.lbl_OK)
        Me.pnl_AboutMe.Controls.Add(Me.chk_NotShowAgain)
        Me.pnl_AboutMe.Controls.Add(Me.lbl_Info_2)
        Me.pnl_AboutMe.Controls.Add(Me.lbl_Info_1)
        Me.pnl_AboutMe.Controls.Add(Me.pic_Head)
        Me.pnl_AboutMe.Location = New System.Drawing.Point(540, 5)
        Me.pnl_AboutMe.Name = "pnl_AboutMe"
        Me.pnl_AboutMe.Size = New System.Drawing.Size(540, 355)
        Me.pnl_AboutMe.TabIndex = 8
        '
        'lbl_OK
        '
        Me.lbl_OK.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OK.ForeColor = System.Drawing.Color.Red
        Me.lbl_OK.Image = Global.节操拾取器.My.Resources.节操拾取器Res.按钮
        Me.lbl_OK.Location = New System.Drawing.Point(307, 254)
        Me.lbl_OK.Name = "lbl_OK"
        Me.lbl_OK.Size = New System.Drawing.Size(136, 53)
        Me.lbl_OK.TabIndex = 10
        Me.lbl_OK.Text = "同意并继续"
        Me.lbl_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_NotShowAgain
        '
        Me.chk_NotShowAgain.AutoSize = True
        Me.chk_NotShowAgain.BackColor = System.Drawing.Color.Transparent
        Me.chk_NotShowAgain.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.chk_NotShowAgain.ForeColor = System.Drawing.Color.Black
        Me.chk_NotShowAgain.Location = New System.Drawing.Point(320, 231)
        Me.chk_NotShowAgain.Name = "chk_NotShowAgain"
        Me.chk_NotShowAgain.Size = New System.Drawing.Size(115, 20)
        Me.chk_NotShowAgain.TabIndex = 9
        Me.chk_NotShowAgain.Text = "下次启动不再显示"
        Me.chk_NotShowAgain.UseVisualStyleBackColor = False
        '
        'lbl_Info_2
        '
        Me.lbl_Info_2.AutoSize = True
        Me.lbl_Info_2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info_2.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.lbl_Info_2.ForeColor = System.Drawing.Color.Gray
        Me.lbl_Info_2.Location = New System.Drawing.Point(230, 330)
        Me.lbl_Info_2.Name = "lbl_Info_2"
        Me.lbl_Info_2.Size = New System.Drawing.Size(298, 16)
        Me.lbl_Info_2.TabIndex = 8
        Me.lbl_Info_2.Text = "——如果你继续操作本程序，则表示已默认以上声明。——"
        '
        'lbl_Info_1
        '
        Me.lbl_Info_1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Info_1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Info_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_Info_1.Location = New System.Drawing.Point(228, 34)
        Me.lbl_Info_1.Name = "lbl_Info_1"
        Me.lbl_Info_1.Size = New System.Drawing.Size(300, 182)
        Me.lbl_Info_1.TabIndex = 7
        Me.lbl_Info_1.Text = "免责声明:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    本程序只是一个单纯善良、人畜无害的""节操拾取器""，不具有任何实际能力(呵呵…)，如果你意外发现该程序在某大学校园网环境内不仅能拾取节操还能拾" & _
    "取校园网流量…那么，鄙人表示对该情况毫不知情(呵呵…)。用户请勿将本程序用于非法用途(呵呵…)，由本程序对任何组织或机构造成的任何损失由程序使用者承担，程序作者" & _
    "不承担任何责任！"
        '
        'pic_Head
        '
        Me.pic_Head.BackColor = System.Drawing.Color.Transparent
        Me.pic_Head.BackgroundImage = Global.节操拾取器.My.Resources.节操拾取器Res.暴走表情
        Me.pic_Head.Location = New System.Drawing.Point(63, 237)
        Me.pic_Head.Name = "pic_Head"
        Me.pic_Head.Size = New System.Drawing.Size(120, 120)
        Me.pic_Head.TabIndex = 6
        Me.pic_Head.TabStop = False
        '
        'lbl_Mini
        '
        Me.lbl_Mini.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mini.Image = Global.节操拾取器.My.Resources.节操拾取器Res.最小化
        Me.lbl_Mini.Location = New System.Drawing.Point(28, 5)
        Me.lbl_Mini.Name = "lbl_Mini"
        Me.lbl_Mini.Size = New System.Drawing.Size(27, 25)
        Me.lbl_Mini.TabIndex = 13
        '
        'pnl_WorkStation
        '
        Me.pnl_WorkStation.BackColor = System.Drawing.Color.Transparent
        Me.pnl_WorkStation.Controls.Add(Me.chk_TimeReConnect)
        Me.pnl_WorkStation.Controls.Add(Me.chk_NetworkReConnect)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Progress)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_ConnectState)
        Me.pnl_WorkStation.Controls.Add(Me.pnl_ComboBox)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_RefreshList)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step1_Info)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step1)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_AboutMe)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_ProgressInfo)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_GetPath)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_NewMacAddress)
        Me.pnl_WorkStation.Controls.Add(Me.pnl_TextBox_2)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step3_Info)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step3)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step2_Info)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_Step2)
        Me.pnl_WorkStation.Controls.Add(Me.pnl_TextBox_1)
        Me.pnl_WorkStation.Controls.Add(Me.lbl_StartTask)
        Me.pnl_WorkStation.Location = New System.Drawing.Point(0, 5)
        Me.pnl_WorkStation.Name = "pnl_WorkStation"
        Me.pnl_WorkStation.Size = New System.Drawing.Size(540, 355)
        Me.pnl_WorkStation.TabIndex = 14
        Me.pnl_WorkStation.Visible = False
        '
        'chk_TimeReConnect
        '
        Me.chk_TimeReConnect.AutoSize = True
        Me.chk_TimeReConnect.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chk_TimeReConnect.ForeColor = System.Drawing.Color.Black
        Me.chk_TimeReConnect.Location = New System.Drawing.Point(292, 268)
        Me.chk_TimeReConnect.Name = "chk_TimeReConnect"
        Me.chk_TimeReConnect.Size = New System.Drawing.Size(159, 21)
        Me.chk_TimeReConnect.TabIndex = 29
        Me.chk_TimeReConnect.Text = "间隔半小时自动拾取节操"
        Me.chk_TimeReConnect.UseVisualStyleBackColor = True
        '
        'chk_NetworkReConnect
        '
        Me.chk_NetworkReConnect.AutoSize = True
        Me.chk_NetworkReConnect.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chk_NetworkReConnect.ForeColor = System.Drawing.Color.Black
        Me.chk_NetworkReConnect.Location = New System.Drawing.Point(292, 245)
        Me.chk_NetworkReConnect.Name = "chk_NetworkReConnect"
        Me.chk_NetworkReConnect.Size = New System.Drawing.Size(147, 21)
        Me.chk_NetworkReConnect.TabIndex = 28
        Me.chk_NetworkReConnect.Text = "断网自动重新拾取节操"
        Me.chk_NetworkReConnect.UseVisualStyleBackColor = True
        '
        'lbl_Progress
        '
        Me.lbl_Progress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Progress.Location = New System.Drawing.Point(119, 337)
        Me.lbl_Progress.Name = "lbl_Progress"
        Me.lbl_Progress.Size = New System.Drawing.Size(418, 15)
        Me.lbl_Progress.TabIndex = 27
        Me.lbl_Progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ConnectState
        '
        Me.lbl_ConnectState.AutoSize = True
        Me.lbl_ConnectState.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_ConnectState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_ConnectState.Location = New System.Drawing.Point(262, 2)
        Me.lbl_ConnectState.Name = "lbl_ConnectState"
        Me.lbl_ConnectState.Size = New System.Drawing.Size(92, 17)
        Me.lbl_ConnectState.TabIndex = 26
        Me.lbl_ConnectState.Text = "网络连接状态："
        '
        'pnl_ComboBox
        '
        Me.pnl_ComboBox.BackgroundImage = Global.节操拾取器.My.Resources.节操拾取器Res.输入框
        Me.pnl_ComboBox.Controls.Add(Me.cmb_NetworkCardList)
        Me.pnl_ComboBox.Location = New System.Drawing.Point(292, 58)
        Me.pnl_ComboBox.Name = "pnl_ComboBox"
        Me.pnl_ComboBox.Size = New System.Drawing.Size(160, 32)
        Me.pnl_ComboBox.TabIndex = 0
        '
        'cmb_NetworkCardList
        '
        Me.cmb_NetworkCardList.BackColor = System.Drawing.Color.White
        Me.cmb_NetworkCardList.DropDownHeight = 200
        Me.cmb_NetworkCardList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NetworkCardList.DropDownWidth = 450
        Me.cmb_NetworkCardList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_NetworkCardList.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmb_NetworkCardList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_NetworkCardList.FormattingEnabled = True
        Me.cmb_NetworkCardList.IntegralHeight = False
        Me.cmb_NetworkCardList.Location = New System.Drawing.Point(4, 5)
        Me.cmb_NetworkCardList.MaxDropDownItems = 16
        Me.cmb_NetworkCardList.Name = "cmb_NetworkCardList"
        Me.cmb_NetworkCardList.Size = New System.Drawing.Size(153, 20)
        Me.cmb_NetworkCardList.Sorted = True
        Me.cmb_NetworkCardList.TabIndex = 24
        '
        'lbl_RefreshList
        '
        Me.lbl_RefreshList.AutoSize = True
        Me.lbl_RefreshList.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_RefreshList.ForeColor = System.Drawing.Color.Blue
        Me.lbl_RefreshList.Location = New System.Drawing.Point(458, 66)
        Me.lbl_RefreshList.Name = "lbl_RefreshList"
        Me.lbl_RefreshList.Size = New System.Drawing.Size(53, 12)
        Me.lbl_RefreshList.TabIndex = 25
        Me.lbl_RefreshList.Text = "刷新列表"
        '
        'lbl_Step1_Info
        '
        Me.lbl_Step1_Info.AutoSize = True
        Me.lbl_Step1_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step1_Info.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step1_Info.ForeColor = System.Drawing.Color.Black
        Me.lbl_Step1_Info.Location = New System.Drawing.Point(324, 33)
        Me.lbl_Step1_Info.Name = "lbl_Step1_Info"
        Me.lbl_Step1_Info.Size = New System.Drawing.Size(93, 20)
        Me.lbl_Step1_Info.TabIndex = 23
        Me.lbl_Step1_Info.Text = "选择有线网卡"
        '
        'lbl_Step1
        '
        Me.lbl_Step1.AutoSize = True
        Me.lbl_Step1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step1.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Step1.Location = New System.Drawing.Point(261, 32)
        Me.lbl_Step1.Name = "lbl_Step1"
        Me.lbl_Step1.Size = New System.Drawing.Size(57, 21)
        Me.lbl_Step1.TabIndex = 22
        Me.lbl_Step1.Text = "Step1:"
        '
        'lbl_AboutMe
        '
        Me.lbl_AboutMe.Image = Global.节操拾取器.My.Resources.节操拾取器Res.关于
        Me.lbl_AboutMe.Location = New System.Drawing.Point(1, 322)
        Me.lbl_AboutMe.Name = "lbl_AboutMe"
        Me.lbl_AboutMe.Size = New System.Drawing.Size(97, 32)
        Me.lbl_AboutMe.TabIndex = 20
        '
        'lbl_ProgressInfo
        '
        Me.lbl_ProgressInfo.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_ProgressInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_ProgressInfo.Location = New System.Drawing.Point(292, 222)
        Me.lbl_ProgressInfo.Name = "lbl_ProgressInfo"
        Me.lbl_ProgressInfo.Size = New System.Drawing.Size(216, 17)
        Me.lbl_ProgressInfo.TabIndex = 19
        Me.lbl_ProgressInfo.Text = "已随机生成新的Mac地址。"
        '
        'lbl_GetPath
        '
        Me.lbl_GetPath.AutoSize = True
        Me.lbl_GetPath.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_GetPath.ForeColor = System.Drawing.Color.Blue
        Me.lbl_GetPath.Location = New System.Drawing.Point(458, 192)
        Me.lbl_GetPath.Name = "lbl_GetPath"
        Me.lbl_GetPath.Size = New System.Drawing.Size(53, 12)
        Me.lbl_GetPath.TabIndex = 18
        Me.lbl_GetPath.Text = "选取路径"
        '
        'lbl_NewMacAddress
        '
        Me.lbl_NewMacAddress.AutoSize = True
        Me.lbl_NewMacAddress.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_NewMacAddress.ForeColor = System.Drawing.Color.Blue
        Me.lbl_NewMacAddress.Location = New System.Drawing.Point(458, 133)
        Me.lbl_NewMacAddress.Name = "lbl_NewMacAddress"
        Me.lbl_NewMacAddress.Size = New System.Drawing.Size(53, 12)
        Me.lbl_NewMacAddress.TabIndex = 17
        Me.lbl_NewMacAddress.Text = "重新生成"
        '
        'pnl_TextBox_2
        '
        Me.pnl_TextBox_2.BackgroundImage = Global.节操拾取器.My.Resources.节操拾取器Res.输入框
        Me.pnl_TextBox_2.Controls.Add(Me.PathTextBox)
        Me.pnl_TextBox_2.Location = New System.Drawing.Point(292, 180)
        Me.pnl_TextBox_2.Name = "pnl_TextBox_2"
        Me.pnl_TextBox_2.Size = New System.Drawing.Size(160, 32)
        Me.pnl_TextBox_2.TabIndex = 14
        '
        'PathTextBox
        '
        Me.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PathTextBox.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PathTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PathTextBox.Location = New System.Drawing.Point(4, 5)
        Me.PathTextBox.MaxLength = 12
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(152, 22)
        Me.PathTextBox.TabIndex = 13
        Me.PathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Step3_Info
        '
        Me.lbl_Step3_Info.AutoSize = True
        Me.lbl_Step3_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step3_Info.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step3_Info.ForeColor = System.Drawing.Color.Black
        Me.lbl_Step3_Info.Location = New System.Drawing.Point(324, 156)
        Me.lbl_Step3_Info.Name = "lbl_Step3_Info"
        Me.lbl_Step3_Info.Size = New System.Drawing.Size(137, 20)
        Me.lbl_Step3_Info.TabIndex = 16
        Me.lbl_Step3_Info.Text = "定位xClient.exe路径"
        '
        'lbl_Step3
        '
        Me.lbl_Step3.AutoSize = True
        Me.lbl_Step3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step3.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Step3.Location = New System.Drawing.Point(261, 155)
        Me.lbl_Step3.Name = "lbl_Step3"
        Me.lbl_Step3.Size = New System.Drawing.Size(57, 21)
        Me.lbl_Step3.TabIndex = 15
        Me.lbl_Step3.Text = "Step3:"
        '
        'lbl_Step2_Info
        '
        Me.lbl_Step2_Info.AutoSize = True
        Me.lbl_Step2_Info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step2_Info.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step2_Info.ForeColor = System.Drawing.Color.Black
        Me.lbl_Step2_Info.Location = New System.Drawing.Point(324, 96)
        Me.lbl_Step2_Info.Name = "lbl_Step2_Info"
        Me.lbl_Step2_Info.Size = New System.Drawing.Size(122, 20)
        Me.lbl_Step2_Info.TabIndex = 14
        Me.lbl_Step2_Info.Text = "选择新的Mac地址"
        '
        'lbl_Step2
        '
        Me.lbl_Step2.AutoSize = True
        Me.lbl_Step2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Step2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Step2.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Step2.Location = New System.Drawing.Point(261, 95)
        Me.lbl_Step2.Name = "lbl_Step2"
        Me.lbl_Step2.Size = New System.Drawing.Size(57, 21)
        Me.lbl_Step2.TabIndex = 13
        Me.lbl_Step2.Text = "Step2:"
        '
        'pnl_TextBox_1
        '
        Me.pnl_TextBox_1.BackgroundImage = Global.节操拾取器.My.Resources.节操拾取器Res.输入框
        Me.pnl_TextBox_1.Controls.Add(Me.MacTextBox)
        Me.pnl_TextBox_1.Location = New System.Drawing.Point(292, 120)
        Me.pnl_TextBox_1.Name = "pnl_TextBox_1"
        Me.pnl_TextBox_1.Size = New System.Drawing.Size(160, 32)
        Me.pnl_TextBox_1.TabIndex = 12
        '
        'MacTextBox
        '
        Me.MacTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MacTextBox.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MacTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MacTextBox.Location = New System.Drawing.Point(4, 3)
        Me.MacTextBox.MaxLength = 12
        Me.MacTextBox.Name = "MacTextBox"
        Me.MacTextBox.Size = New System.Drawing.Size(152, 26)
        Me.MacTextBox.TabIndex = 13
        Me.MacTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_StartTask
        '
        Me.lbl_StartTask.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StartTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_StartTask.Image = Global.节操拾取器.My.Resources.节操拾取器Res.按钮
        Me.lbl_StartTask.Location = New System.Drawing.Point(299, 285)
        Me.lbl_StartTask.Name = "lbl_StartTask"
        Me.lbl_StartTask.Size = New System.Drawing.Size(136, 53)
        Me.lbl_StartTask.TabIndex = 0
        Me.lbl_StartTask.Text = "< 拾取节操 >"
        Me.lbl_StartTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = Global.节操拾取器.My.Resources.节操拾取器Res.Background
        Me.ClientSize = New System.Drawing.Size(540, 360)
        Me.Controls.Add(Me.lbl_Mini)
        Me.Controls.Add(Me.lbl_Close)
        Me.Controls.Add(Me.pnl_AboutMe)
        Me.Controls.Add(Me.pnl_WorkStation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "节操拾取器"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Yellow
        Me.pnl_AboutMe.ResumeLayout(False)
        Me.pnl_AboutMe.PerformLayout()
        CType(Me.pic_Head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_WorkStation.ResumeLayout(False)
        Me.pnl_WorkStation.PerformLayout()
        Me.pnl_ComboBox.ResumeLayout(False)
        Me.pnl_TextBox_2.ResumeLayout(False)
        Me.pnl_TextBox_2.PerformLayout()
        Me.pnl_TextBox_1.ResumeLayout(False)
        Me.pnl_TextBox_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Close As System.Windows.Forms.Label
    Friend WithEvents pnl_AboutMe As System.Windows.Forms.Panel
    Friend WithEvents lbl_OK As System.Windows.Forms.Label
    Friend WithEvents chk_NotShowAgain As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Info_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Info_1 As System.Windows.Forms.Label
    Friend WithEvents pic_Head As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Mini As System.Windows.Forms.Label
    Friend WithEvents pnl_WorkStation As System.Windows.Forms.Panel
    Friend WithEvents lbl_StartTask As System.Windows.Forms.Label
    Friend WithEvents pnl_TextBox_1 As System.Windows.Forms.Panel
    Friend WithEvents MacTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Step2_Info As System.Windows.Forms.Label
    Friend WithEvents lbl_Step2 As System.Windows.Forms.Label
    Friend WithEvents pnl_TextBox_2 As System.Windows.Forms.Panel
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Step3_Info As System.Windows.Forms.Label
    Friend WithEvents lbl_Step3 As System.Windows.Forms.Label
    Friend WithEvents lbl_NewMacAddress As System.Windows.Forms.Label
    Friend WithEvents lbl_GetPath As System.Windows.Forms.Label
    Friend WithEvents lbl_ProgressInfo As System.Windows.Forms.Label
    Friend WithEvents lbl_AboutMe As System.Windows.Forms.Label
    Friend WithEvents lbl_Step1_Info As System.Windows.Forms.Label
    Friend WithEvents lbl_Step1 As System.Windows.Forms.Label
    Friend WithEvents cmb_NetworkCardList As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_RefreshList As System.Windows.Forms.Label
    Friend WithEvents pnl_ComboBox As System.Windows.Forms.Panel
    Friend WithEvents lbl_ConnectState As System.Windows.Forms.Label
    Friend WithEvents lbl_Progress As System.Windows.Forms.Label
    Friend WithEvents chk_NetworkReConnect As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TimeReConnect As System.Windows.Forms.CheckBox

End Class
