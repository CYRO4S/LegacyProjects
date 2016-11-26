Public Class Form1

    '定义U盘盘符
    Public Drive As String = "G:\"
    '复制到路径
    Public Path As String = "C:\Intel\"


    '声明Ctrl,Alt,Shift键常量
    Public Const WM_HOTKEY = &H312
    Public Const MOD_ALT = &H1
    Public Const MOD_CONTROL = &H2
    Public Const MOD_SHIFT = &H4
    Public Const GWL_WNDPROC = (-4)
    Public Declare Auto Function RegisterHotKey Lib "user32.dll" Alias _
        "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Boolean
    Public Declare Auto Function UnRegisterHotKey Lib "user32.dll" Alias _
        "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        '启动窗体时注册热键，函数说明：
        'RegisterHotKey(Handle, 热键编号, 控制键位, 主键位)
        '控制键位可以是以下之一：
        'MOD_ALT（Alt）、MOD_CONTROL（Ctrl）、MOD_SHIFT（Shift）
        '下面的语句将注册热键0号（Ctrl+0）和热键1号（Ctrl+1）
        RegisterHotKey(Handle, 0, MOD_CONTROL, Asc("0"))
        RegisterHotKey(Handle, 1, MOD_CONTROL, Asc("1"))
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        '关闭窗体时取消注册热键，函数说明：
        'RegisterHotKey(Handle, 热键编号)
        UnRegisterHotKey(Handle, 0)
        UnRegisterHotKey(Handle, 1)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            Select Case m.WParam.ToInt32
                '按下0号热键执行的操作
                Case 0
                    '更改托盘图标
                    icoCopy.Visible = True
                    icoWait.Visible = False
                    '复制文件
                    Shell("xcopy.exe " & Drive & " " & Path & " /S /E /C /H", AppWinStyle.Hide, True)
                    '更改托盘图标
                    icoWait.Visible = True
                    icoWait.Visible = False
                '按下1号热键执行的操作
                Case 1
                    End
            End Select
        End If
        MyBase.WndProc(m)
    End Sub
End Class
