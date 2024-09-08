Imports System.IO
Imports System.Security.Policy
Imports System.Web.UI.Design.WebControls
Imports System.Windows.Forms.Design
Imports FastColoredTextBoxNS
Imports Microsoft.Web.WebView2.WinForms
Imports System.InvalidOperationException
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.Web.WebView2.Core
Imports System.Reflection

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebViewNews.EnsureCoreWebView2Async(Nothing) '预加载显示新闻的webview

        WebViewNews.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False  '禁用webviewnews的右键 菜单
        WebViewNews.CoreWebView2.Settings.IsScriptEnabled = True '启用webviewnews的js脚本

        '下面是显示新闻的webview的内容事件
        Me.Text = My.Application.Info.ProductName + " " + String.Format("版本 {0}", My.Application.Info.Version.ToString)
        Dim news As String = “<h1>欢迎使用" + My.Application.Info.ProductName + "<h1>
           <h2>目前版本号：” + My.Application.Info.Version.ToString + “</h2>
           <h2>此页面为” + My.Application.Info.ProductName + “新闻界面，用来显示更新消息，最新内容，最新内容，后续会更新成在线网页
           <h4>开发者：<a href=""mailto:yilihamujiang365@outlook.com"">yilihamujiang365@outlook.com</a></h4>"
        WebViewNews.NavigateToString(news)

        '按钮标签图标赋值
        Button1.Image = 打开OToolStripMenuItem.Image
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Text = 打开OToolStripMenuItem.Text
        Button2.Text = 退出XToolStripMenuItem.Text
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenProject()
        '打开文件事件
    End Sub
    Private Sub 打开OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开OToolStripMenuItem.Click
        OpenProject()
        '打开文件事件
    End Sub

    '打开文件事件
    Private Sub OpenProject()
        '选择文件的时候把文件路径保存到txt文件里面
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "HTML Files (*.html;*.htm)|*.html;*.htm"
        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog.FileName
            Dim fileContent As String = File.ReadAllText(filePath)

            ' 将 filePath 的内容保存到 filepatchfile.txt
            File.WriteAllText("filepatchfile.txt", filePath)

            '移除欢迎页
            TabControl1.TabPages.Clear()

            ' 添加新选项卡
            Dim newTabPage As New TabPage(filePath)
            TabControl1.TabPages.Add(newTabPage)
            Dim Control1 As New HTMLControl
            newTabPage.Controls.Add(Control1)
            Control1.Dock = DockStyle.Fill

            '打开后展示工作
            Control1.htmlEditor.Text = fileContent
            Control1.htmlWebView.Source = New Uri(filePath)
            'Control1.HTMLWebBrowser.Url = New Uri(filePath)
        End If
    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click
        Dim webView2Version As String = CoreWebView2Environment.GetAvailableBrowserVersionString()
        Dim fctbAssembly As Assembly = Assembly.Load("FastColoredTextBox") '假设程序集名称是 FastColoredTextBox，如果不正确请调整
        Dim version As Version = fctbAssembly.GetName().Version

        MessageBox.Show("软件名称: " & My.Application.Info.ProductName & vbCrLf & "目前版本号： " & My.Application.Info.Version.ToString() + vbCrLf + "开发者:yilihamujiang365@outlook.com" + vbCrLf + vbCrLf + "使用的NuGet程序包如下：" + vbCrLf + "Microsoft Edge WebView2 " + "(版本：" & webView2Version + ")" + vbCrLf + "微软公司协议" + vbCrLf + "FastColoredTextBoxNS (版本：" & version.ToString() + ")" + vbCrLf + "GNU 宽通用公共许可证（LGPLv3）", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class
