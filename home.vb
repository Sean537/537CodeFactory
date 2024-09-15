Imports System.IO
Imports Microsoft.Web.WebView2.Core
Imports System.Reflection
Public Class home
    Private Async Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebViewNews.EnsureCoreWebView2Async(Nothing) '预加载显示新闻的webview

        WebViewNews.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False  '禁用webviewnews的右键 菜单
        WebViewNews.CoreWebView2.Settings.IsScriptEnabled = True '启用webviewnews的js脚本

        '下面是显示新闻的webview的内容事件
        Me.Text = My.Application.Info.ProductName
        Dim news As String = “<h1>欢迎使用" + My.Application.Info.ProductName + "<h1>
           <h2>版本号：” + My.Application.Info.Version.ToString + “</h2>
           <h2>此页面为 ” + My.Application.Info.ProductName + “ 首页测试界面</h2>
           <h4>开发者：
                <li><a href=""mailto:yilihamujiang365@outlook.com"">yilihamujiang365@outlook.com</a></li>
                <li><a href=""mailto:wushaoquan666@outlook.com"">wushaoquan666@outlook.com</a></li>
            </h4>"
        WebViewNews.NavigateToString(news)

        '按钮标签图标赋值
        Button1.Image = 打开OToolStripMenuItem.Image
        Button3.Image = XinjianToolStripMenuItem.Image
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Text = 打开OToolStripMenuItem.Text
        Button2.Text = 退出XToolStripMenuItem.Text
        Button3.Text = XinjianToolStripMenuItem.Text

        Button3.Image = ResizeImage(Button3.Image, Button1.Image.Size)

    End Sub
    Private Function ResizeImage(image As Image, newSize As Size) As Image
        Dim newImage As New Bitmap(newSize.Width, newSize.Height)
        Using graphics As Graphics = Graphics.FromImage(newImage)
            graphics.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
        End Using
        Return newImage
    End Function


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

        MessageBox.Show("软件名称: " & My.Application.Info.ProductName & vbCrLf & "版本号： " & My.Application.Info.Version.ToString() + vbCrLf + "开发者：" + vbCrLf + "yilihamujiang365@outlook.com" + vbCrLf + "wushaoquan666@outlook.com" + vbCrLf + vbCrLf + "使用的NuGet程序包如下：" + vbCrLf + "Microsoft Edge WebView2 " + "(版本：" & webView2Version + ")" + vbCrLf + "微软公司协议" + vbCrLf + "FastColoredTextBoxNS (版本：" & version.ToString() + ")" + vbCrLf + "GNU 通用公共许可证（GPLv3）", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Newproject()
    End Sub
    Private Sub Newproject()
        ' 获取项目名称
        Dim projectName As String = InputBox("请输入项目名称：")
        If String.IsNullOrEmpty(projectName) Then
            MessageBox.Show("项目名称不能为空。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 显示文件夹选择对话框
        Using fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = DialogResult.OK Then
                Dim selectedPath As String = fbd.SelectedPath

                ' 创建项目文件夹
                Dim projectFolderPath As String = Path.Combine(selectedPath, projectName)
                If Not Directory.Exists(projectFolderPath) Then
                    Directory.CreateDirectory(projectFolderPath)
                End If

                ' 创建 index.html 文件
                Dim htmlFilePath As String = Path.Combine(projectFolderPath, "index.html")
                File.WriteAllText(htmlFilePath, "<h1>hello world</h1>")

                ' 创建 CSS、JS 和 Img 文件夹
                Dim cssFolderPath As String = Path.Combine(projectFolderPath, "CSS")
                Dim jsFolderPath As String = Path.Combine(projectFolderPath, "JS")
                Dim imgFolderPath As String = Path.Combine(projectFolderPath, "Img")
                Directory.CreateDirectory(cssFolderPath)
                Directory.CreateDirectory(jsFolderPath)
                Directory.CreateDirectory(imgFolderPath)

                ' 获取软件根目录
                Dim appRootPath As String = AppDomain.CurrentDomain.BaseDirectory
                ' 确定 filepatchfile.txt 的路径
                Dim patchFilePath As String = Path.Combine(appRootPath, "filepatchfile.txt")
                ' 将选择的路径加上 "\index.html" 后写入文件
                Dim contentToWrite As String = projectFolderPath & "\index.html"

                File.WriteAllText(patchFilePath, contentToWrite)

                ' 移除欢迎页
                TabControl1.TabPages.Clear()

                ' 添加新选项卡
                Dim newTabPage As New TabPage(htmlFilePath)
                TabControl1.TabPages.Add(newTabPage)
                Dim control1 As New HTMLControl
                newTabPage.Controls.Add(control1)
                control1.Dock = DockStyle.Fill

                ' 显示 HTML 文件内容
                Dim htmlContent As String = File.ReadAllText(htmlFilePath)
                control1.htmlEditor.Text = htmlContent
                control1.htmlWebView.Source = New Uri(htmlFilePath)
            End If
        End Using
    End Sub

    Private Sub XinjianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XinjianToolStripMenuItem.Click
        Newproject()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
