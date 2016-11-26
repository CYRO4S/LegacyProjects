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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.icoWait = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.icoCopy = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'icoWait
        '
        Me.icoWait.Icon = CType(resources.GetObject("icoWait.Icon"), System.Drawing.Icon)
        Me.icoWait.Text = "REALTEK音频控制面板"
        Me.icoWait.Visible = True
        '
        'icoCopy
        '
        Me.icoCopy.Icon = CType(resources.GetObject("icoCopy.Icon"), System.Drawing.Icon)
        Me.icoCopy.Text = "NVIDIA控制面板"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(0, 0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "Windows 资源管理器"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icoWait As NotifyIcon
    Friend WithEvents icoCopy As NotifyIcon
End Class
