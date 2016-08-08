Imports System.Threading
Imports Microsoft.Win32
Imports System.Security.AccessControl

Public Class MainForm
    Private Enum RegistryRightsList
        FullControl = RegistryRights.FullControl                      '完全控制
        QueryValues = RegistryRights.QueryValues                '查询数值
        SetValue = RegistryRights.SetValue                              '设置数据
        CreateSubKey = RegistryRights.CreateSubKey            '创建子项
        ObjRegRight = RegistryRights.EnumerateSubKeys    '枚举子项
        Notify = RegistryRights.Notify                                       '枚举子项
        CreateLink = RegistryRights.CreateLink                        '创建链接
        Delete = RegistryRights.Delete                                       '创建链接
        WriteKey = RegistryRights.WriteKey                             '创建链接
        TakeOwnership = RegistryRights.TakeOwnership       '创建链接
        ReadPermissions = RegistryRights.ReadPermissions '读取控制
    End Enum

    '读写*.ini配置文件
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    '鼠标拖动
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False '允许多线访问UI
        lbl_ConnectState.Text = "网络连接状态：" & IIf(My.Computer.Network.IsAvailable, "已连接到网络。", "未连接网络。")
        pnl_AboutMe.Left = 0

        Dim Result As String = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "DontShowAgain", "False", Result, 256, Application.StartupPath & "\Config.ini")
        Result = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)
        If Result = "True" Then
            chk_NotShowAgain.Checked = True
            pnl_AboutMe.Hide()
            pnl_WorkStation.Show()
        End If

        Result = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "PathOfxClient", "请定位xClient.exe!", Result, 256, Application.StartupPath & "\Config.ini")
        PathTextBox.Text = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)

        RefreshNetworkCard()

        Result = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "LastNetworkCard", "尚未配置网卡", Result, 256, Application.StartupPath & "\Config.ini")
        cmb_NetworkCardList.Text = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)
        If cmb_NetworkCardList.Text = "" Then cmb_NetworkCardList.Text = cmb_NetworkCardList.Items(0).ToString()

        Result = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "NetworkReConnect", False, Result, 256, Application.StartupPath & "\Config.ini")
        Result = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)
        chk_NetworkReConnect.Checked = IIf(Result = "True", True, False)

        Result = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "TimeReConnect", False, Result, 256, Application.StartupPath & "\Config.ini")
        Result = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)
        chk_TimeReConnect.Checked = IIf(Result = "True", True, False)

        Result = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "PathOfxClient", "请定位xClient.exe!", Result, 256, Application.StartupPath & "\Config.ini")
        PathTextBox.Text = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)

        MacTextBox.Text = GetNewMac() '随机Mac地址
        lbl_OK.Image = My.Resources.节操拾取器Res.按钮.Clone(New Rectangle(0, 0, 136, 53), Imaging.PixelFormat.Format32bppArgb)
        lbl_StartTask.Image = lbl_OK.Image
        lbl_AboutMe.Image = My.Resources.节操拾取器Res.关于.Clone(New Rectangle(0, 0, 97, 32), Imaging.PixelFormat.Format32bppArgb)
        lbl_Close.Image = My.Resources.节操拾取器Res.关闭.Clone(New Rectangle(0, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
        lbl_Mini.Image = My.Resources.节操拾取器Res.最小化.Clone(New Rectangle(0, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If lbl_StartTask.Enabled = False Then
            lbl_ProgressInfo.Text = "任务正在进行，请稍后退出。"
            lbl_ProgressInfo.ForeColor = Color.Red
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 闪烁提示信息))
            Exit Sub
        End If

        Do Until Me.Opacity = 0
            Me.Opacity -= 0.05
            Threading.Thread.Sleep(10)
        Loop

        End
    End Sub
    Private Sub lbl_Close_Click(sender As Object, e As EventArgs) Handles lbl_Close.Click
        Me.Close()
    End Sub

    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown,
        pnl_AboutMe.MouseDown, pnl_WorkStation.MouseDown, pic_Head.MouseDown, lbl_Info_1.MouseDown,
        lbl_Info_2.MouseDown, lbl_ConnectState.MouseDown, lbl_Step1.MouseDown, lbl_Step1_Info.MouseDown,
        lbl_Step2.MouseDown, lbl_Step2_Info.MouseDown, lbl_Step3.MouseDown, lbl_Step3_Info.MouseDown,
        lbl_ProgressInfo.MouseDown

        ReleaseCapture()
        SendMessageA(Me.Handle, &HA1, 2, 0&)
    End Sub

    Private Sub lbl_Mini_Click(sender As Object, e As EventArgs) Handles lbl_Mini.Click
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.05
            Threading.Thread.Sleep(10)
        Loop
        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 1
    End Sub

#Region "lbl_OK & lbl_StartTask"
    Private Sub lbl_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_OK.MouseDown, lbl_StartTask.MouseDown
        CType(sender, Label).Image = My.Resources.节操拾取器Res.按钮.Clone(New Rectangle(272, 0, 136, 53), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_MouseEnter(sender As Object, e As EventArgs) Handles lbl_OK.MouseEnter, lbl_StartTask.MouseEnter
        CType(sender, Label).Image = My.Resources.节操拾取器Res.按钮.Clone(New Rectangle(136, 0, 136, 53), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_MouseLeave(sender As Object, e As EventArgs) Handles lbl_OK.MouseLeave, lbl_StartTask.MouseLeave
        CType(sender, Label).Image = My.Resources.节操拾取器Res.按钮.Clone(New Rectangle(0, 0, 136, 53), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_OK.MouseUp, lbl_StartTask.MouseUp
        CType(sender, Label).Image = My.Resources.节操拾取器Res.按钮.Clone(New Rectangle(136, 0, 136, 53), Imaging.PixelFormat.Format32bppArgb)
    End Sub
#End Region

#Region "lbl_Close"
    Private Sub lbl_Close_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_Close.MouseDown
        lbl_Close.Image = My.Resources.节操拾取器Res.关闭.Clone(New Rectangle(54, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Close_MouseEnter(sender As Object, e As EventArgs) Handles lbl_Close.MouseEnter
        lbl_Close.Image = My.Resources.节操拾取器Res.关闭.Clone(New Rectangle(27, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Close_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Close.MouseLeave
        lbl_Close.Image = My.Resources.节操拾取器Res.关闭.Clone(New Rectangle(0, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Close_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_Close.MouseUp
        lbl_Close.Image = My.Resources.节操拾取器Res.关闭.Clone(New Rectangle(27, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub
#End Region

#Region "lbl_Minimized"
    Private Sub lbl_Mini_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_Mini.MouseDown
        lbl_Mini.Image = My.Resources.节操拾取器Res.最小化.Clone(New Rectangle(54, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Mini_MouseEnter(sender As Object, e As EventArgs) Handles lbl_Mini.MouseEnter
        lbl_Mini.Image = My.Resources.节操拾取器Res.最小化.Clone(New Rectangle(27, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Mini_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Mini.MouseLeave
        lbl_Mini.Image = My.Resources.节操拾取器Res.最小化.Clone(New Rectangle(0, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_Mini_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_Mini.MouseUp
        lbl_Mini.Image = My.Resources.节操拾取器Res.最小化.Clone(New Rectangle(27, 0, 27, 25), Imaging.PixelFormat.Format32bppArgb)
    End Sub
#End Region

#Region "ReturnAboutMe"
    Private Sub lbl_AboutMe_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_AboutMe.MouseDown
        lbl_AboutMe.Image = My.Resources.节操拾取器Res.关于.Clone(New Rectangle(194, 0, 97, 32), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_AboutMe_MouseEnter(sender As Object, e As EventArgs) Handles lbl_AboutMe.MouseEnter
        lbl_AboutMe.Image = My.Resources.节操拾取器Res.关于.Clone(New Rectangle(97, 0, 97, 32), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_AboutMe_MouseLeave(sender As Object, e As EventArgs) Handles lbl_AboutMe.MouseLeave
        lbl_AboutMe.Image = My.Resources.节操拾取器Res.关于.Clone(New Rectangle(0, 0, 97, 32), Imaging.PixelFormat.Format32bppArgb)
    End Sub

    Private Sub lbl_AboutMe_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_AboutMe.MouseUp
        lbl_AboutMe.Image = My.Resources.节操拾取器Res.关于.Clone(New Rectangle(97, 0, 97, 32), Imaging.PixelFormat.Format32bppArgb)
    End Sub
#End Region

    Private Sub pnl_TextBox_GotFocus(sender As Object, e As EventArgs) Handles pnl_TextBox_1.GotFocus
        MacTextBox.Focus() 'TextBox得到操作焦点
    End Sub
    Private Sub pnl_TextBox_2GotFocus(sender As Object, e As EventArgs) Handles pnl_TextBox_2.GotFocus
        PathTextBox.Focus() 'TextBox得到操作焦点
    End Sub
    Private Sub pnl_ComboBox_GotFocus(sender As Object, e As EventArgs) Handles pnl_ComboBox.GotFocus
        cmb_NetworkCardList.Focus() 'TextBox得到操作焦点
    End Sub

    Private Sub lbl_NewMacAddress_Click(sender As Object, e As EventArgs) Handles lbl_NewMacAddress.Click
        MacTextBox.Text = GetNewMac()
        lbl_ProgressInfo.Text = "已随机生成新的Mac地址。"
    End Sub

    '随机生成Str_MacAdress
    Private Function GetNewMac() As String
        Dim MacAddress As String = vbNullString, TempChars As String = vbNullString
        For i As Integer = 1 To 6
            TempChars = Hex(VBMath.Rnd() * 255).ToString
            If TempChars.Length = 1 Then TempChars = "0" & TempChars
            MacAddress &= TempChars
        Next
        Return MacAddress
    End Function

#Region "lbl_Input"
    Private Sub lbl_AsButton_MouseEnter(sender As Object, e As EventArgs) Handles lbl_NewMacAddress.MouseEnter, lbl_GetPath.MouseEnter, lbl_RefreshList.MouseEnter
        Dim NewFont As New Font(CType(sender, Label).Font.FontFamily.Name, CType(sender, Label).Font.Size, FontStyle.Underline)
        CType(sender, Label).Font = NewFont
    End Sub

    Private Sub lbl_AsButton_MouseLeave(sender As Object, e As EventArgs) Handles lbl_NewMacAddress.MouseLeave, lbl_GetPath.MouseLeave, lbl_RefreshList.MouseLeave
        Dim NewFont As New Font(CType(sender, Label).Font.FontFamily.Name, CType(sender, Label).Font.Size)
        CType(sender, Label).Font = NewFont
    End Sub

#End Region

    Private Sub lbl_GetPath_Click(sender As Object, e As EventArgs) Handles lbl_GetPath.Click
        Dim PathDialog As OpenFileDialog = New OpenFileDialog
        With PathDialog
            .CheckFileExists = True
            .CheckPathExists = True
            .DereferenceLinks = True
            .FileName = "xClient.exe"
            .Filter = "xClient.exe|xClient.exe"
            .Multiselect = False
            .Title = "定位xClient.exe"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                PathTextBox.Text = .FileName
                lbl_ProgressInfo.Text = "已定位xClient.exe程序路径。"
                WritePrivateProfileString("BasicConfig", "PathOfxClient", PathTextBox.Text, Application.StartupPath & "\Config.ini")
            End If
        End With
    End Sub

    Private Sub Progress()
        lbl_ProgressInfo.ForeColor = Color.Black
        lbl_ProgressInfo.Text = "正在执行任务，请稍候..."

        lbl_AboutMe.Enabled = False
        cmb_NetworkCardList.Enabled = False
        MacTextBox.Enabled = False
        PathTextBox.Enabled = False
        lbl_StartTask.Enabled = False
        lbl_NewMacAddress.Enabled = False
        lbl_GetPath.Enabled = False
        lbl_RefreshList.Enabled = False

        For ProgressWidth As Integer = 1 To 416 Step 5
            lbl_Progress.Image = My.Resources.节操拾取器Res.进度条.Clone(New Rectangle(0, 0, ProgressWidth, 15), Imaging.PixelFormat.Format32bppArgb)
            lbl_Progress.Text = Format(ProgressWidth / 416, "00.00%")
            Threading.Thread.Sleep(10)
        Next

        lbl_AboutMe.Enabled = True
        cmb_NetworkCardList.Enabled = True
        MacTextBox.Enabled = True
        PathTextBox.Enabled = True
        lbl_StartTask.Enabled = True
        lbl_NewMacAddress.Enabled = True
        lbl_GetPath.Enabled = True
        lbl_RefreshList.Enabled = True
        lbl_ProgressInfo.Text = "任务执行完毕！节操上限已重置。"
        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 闪烁提示信息))
    End Sub


    Private Sub 闪烁提示信息()
        Beep() '响铃警报

        Dim TempString As String = lbl_ProgressInfo.Text
        For Index As Int16 = 0 To 8
            lbl_ProgressInfo.Text = IIf(Index Mod 2, "", TempString)
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub chk_ShowAgain_CheckedChanged(sender As Object, e As EventArgs) Handles chk_NotShowAgain.CheckedChanged
        WritePrivateProfileString("BasicConfig", "DontShowAgain", chk_NotShowAgain.Checked.ToString, Application.StartupPath & "\Config.ini")
    End Sub

    Private Sub lbl_OK_Click(sender As Object, e As EventArgs) Handles lbl_OK.Click
        pnl_AboutMe.Hide()
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.02
            Threading.Thread.Sleep(5)
        Loop

        pnl_WorkStation.Show()

        Do Until Me.Opacity = 1
            Me.Opacity += 0.02
            Threading.Thread.Sleep(5)
        Loop
    End Sub

    Private Sub lbl_AboutMe_Click(sender As Object, e As EventArgs) Handles lbl_AboutMe.Click
        pnl_WorkStation.Hide()
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.02
            Threading.Thread.Sleep(5)
        Loop

        pnl_AboutMe.Show()

        Do Until Me.Opacity = 1
            Me.Opacity += 0.02
            Threading.Thread.Sleep(5)
        Loop
    End Sub

    Private Sub lbl_RefreshList_Click(sender As Object, e As EventArgs) Handles lbl_RefreshList.Click
        RefreshNetworkCard()
        Dim Result As String = LSet(vbNullChar, 256)
        GetPrivateProfileString("BasicConfig", "LastNetworkCard", "请选择有线网卡!", Result, 256, Application.StartupPath & "\Config.ini")
        cmb_NetworkCardList.Text = Microsoft.VisualBasic.Left(Result, InStr(Result, Chr(0)) - 1)
    End Sub

    Private Sub cmb_NetworkCardList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_NetworkCardList.SelectedIndexChanged
        WritePrivateProfileString("BasicConfig", "LastNetworkCard", cmb_NetworkCardList.SelectedItem.ToString(), Application.StartupPath & "\Config.ini")
    End Sub

    Private Sub chk_NetworkReConnect_CheckedChanged(sender As Object, e As EventArgs) Handles chk_NetworkReConnect.CheckedChanged
        WritePrivateProfileString("BasicConfig", "NetworkReConnect", chk_NetworkReConnect.Checked.ToString, Application.StartupPath & "\Config.ini")
    End Sub

    Private Sub chk_TimeReConnect_CheckedChanged(sender As Object, e As EventArgs) Handles chk_TimeReConnect.CheckedChanged
        WritePrivateProfileString("BasicConfig", "TimeReConnect", chk_TimeReConnect.Checked.ToString, Application.StartupPath & "\Config.ini")
    End Sub

    Private Sub RefreshNetworkCard() '刷新网卡列表
        cmb_NetworkCardList.Items.Clear()

        Dim InfoQuery As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration")
        Dim QueryCollection As System.Management.ManagementObjectCollection = InfoQuery.Get()
        Dim NetworkCard As New System.Management.ManagementObject
        For Each NetworkCard In QueryCollection
            If (IsDBNull(NetworkCard.Item("MacAddress")) = False) And Not (NetworkCard.Item("MacAddress") = vbNullString) Then cmb_NetworkCardList.Items.Add(NetworkCard.Item("Description"))
        Next
    End Sub

    Private Sub lbl_StartTask_Click(sender As Object, e As EventArgs) Handles lbl_StartTask.Click
        If MacTextBox.Text.Length = 12 Then
            If My.Computer.FileSystem.FileExists(PathTextBox.Text) Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf Progress))
            Else
                lbl_ProgressInfo.Text = "xClient.exe文件路径无效，请重置。"
                lbl_ProgressInfo.ForeColor = Color.Red
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 闪烁提示信息))
            End If
        Else
            lbl_ProgressInfo.Text = "Mac地址长度不是12位，请重置。"
            lbl_ProgressInfo.ForeColor = Color.Red
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 闪烁提示信息))
        End If
    End Sub
End Class