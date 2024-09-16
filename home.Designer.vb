<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XinjianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl_Home = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Home = New System.Windows.Forms.GroupBox()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_Open = New System.Windows.Forms.Button()
        Me.WebViewNews = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl_Home.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Home.SuspendLayout()
        CType(Me.WebViewNews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XinjianToolStripMenuItem, Me.打开OToolStripMenuItem, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        'XinjianToolStripMenuItem
        '
        Me.XinjianToolStripMenuItem.Image = CType(resources.GetObject("XinjianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XinjianToolStripMenuItem.Name = "XinjianToolStripMenuItem"
        Me.XinjianToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.XinjianToolStripMenuItem.Text = "新建项目(&N)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Image = CType(resources.GetObject("打开OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Image = CType(resources.GetObject("退出XToolStripMenuItem.Image"), System.Drawing.Image)
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Image = CType(resources.GetObject("关于AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.关于AToolStripMenuItem.Text = "关于(&A)..."
        '
        'TabControl_Home
        '
        Me.TabControl_Home.Controls.Add(Me.TabPage1)
        Me.TabControl_Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Home.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl_Home.HotTrack = True
        Me.TabControl_Home.Location = New System.Drawing.Point(0, 25)
        Me.TabControl_Home.Name = "TabControl_Home"
        Me.TabControl_Home.SelectedIndex = 0
        Me.TabControl_Home.Size = New System.Drawing.Size(1016, 595)
        Me.TabControl_Home.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox_Home)
        Me.TabPage1.Controls.Add(Me.WebViewNews)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "首页"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox_Home
        '
        Me.GroupBox_Home.Controls.Add(Me.Button_New)
        Me.GroupBox_Home.Controls.Add(Me.Button_Exit)
        Me.GroupBox_Home.Controls.Add(Me.Button_Open)
        Me.GroupBox_Home.Location = New System.Drawing.Point(25, 211)
        Me.GroupBox_Home.Name = "GroupBox_Home"
        Me.GroupBox_Home.Size = New System.Drawing.Size(224, 228)
        Me.GroupBox_Home.TabIndex = 2
        Me.GroupBox_Home.TabStop = False
        Me.GroupBox_Home.Text = "您可以"
        '
        'Button_New
        '
        Me.Button_New.Font = New System.Drawing.Font("宋体", 16.0!)
        Me.Button_New.Image = CType(resources.GetObject("Button_New.Image"), System.Drawing.Image)
        Me.Button_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_New.Location = New System.Drawing.Point(13, 22)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(193, 60)
        Me.Button_New.TabIndex = 2
        Me.Button_New.Text = "Button_New"
        Me.Button_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Exit.Image = CType(resources.GetObject("Button_Exit.Image"), System.Drawing.Image)
        Me.Button_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Exit.Location = New System.Drawing.Point(13, 154)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(193, 60)
        Me.Button_Exit.TabIndex = 1
        Me.Button_Exit.Text = "Button_Exit"
        Me.Button_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Button_Open
        '
        Me.Button_Open.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button_Open.Image = CType(resources.GetObject("Button_Open.Image"), System.Drawing.Image)
        Me.Button_Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Open.Location = New System.Drawing.Point(13, 88)
        Me.Button_Open.Name = "Button_Open"
        Me.Button_Open.Size = New System.Drawing.Size(193, 60)
        Me.Button_Open.TabIndex = 1
        Me.Button_Open.Text = "Button_Open"
        Me.Button_Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Open.UseVisualStyleBackColor = True
        '
        'WebViewNews
        '
        Me.WebViewNews.AllowExternalDrop = True
        Me.WebViewNews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebViewNews.CreationProperties = Nothing
        Me.WebViewNews.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebViewNews.Location = New System.Drawing.Point(289, 40)
        Me.WebViewNews.Name = "WebViewNews"
        Me.WebViewNews.Size = New System.Drawing.Size(690, 497)
        Me.WebViewNews.TabIndex = 0
        Me.WebViewNews.ZoomFactor = 1.0R
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 620)
        Me.Controls.Add(Me.TabControl_Home)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(960, 570)
        Me.Name = "home"
        Me.Text = "home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl_Home.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Home.ResumeLayout(False)
        CType(Me.WebViewNews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl_Home As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Button_Open As Button
    Friend WithEvents WebViewNews As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents GroupBox_Home As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_New As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents XinjianToolStripMenuItem As ToolStripMenuItem
End Class
