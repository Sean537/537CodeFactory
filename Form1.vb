Imports System.IO
Imports System.Text
Imports Markdig
Imports ScintillaNET


Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip2.Visible = False


        Await WebViewHTML.EnsureCoreWebView2Async(Nothing)
        OpenFileDialog1.Filter = "HTML文件(*.html)|*.html"
        SaveFileDialog1.Filter = "HTML文件(*.html)|*.html"
        OpenFileDialog2.Filter = "MarkDown文件(*.md)|*.md"
        SaveFileDialog2.Filter = "MarkDown文件(*.md)|*.md"
        Me.Text = My.Application.Info.Title + String.Format("版本 V {0}", My.Application.Info.Version.ToString)


        ConfigureScintillaHTML()
        ConfigureScintillamarkdown()
    End Sub
    Private Sub ConfigureScintillaHTML()

        ' 定义 HTML 标签样式
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Tag).ForeColor = Color.Blue
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Tag).BackColor = Color.White

        ' 定义 HTML 属性样式
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Attribute).ForeColor = Color.Green
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Attribute).BackColor = Color.White

        ' 定义 HTML 字符串样式
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.DoubleString).ForeColor = Color.Gray
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.DoubleString).BackColor = Color.White

        ' 定义 HTML 注释样式
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Comment).ForeColor = Color.LightGray
        ScintillaHTMLL.Styles(ScintillaNET.Style.Html.Comment).BackColor = Color.White

        '行号
        ScintillaHTMLL.Margins(0).Type = MarginType.Number
        ScintillaHTMLL.Margins(0).Width = 40
    End Sub
    Private Sub ConfigureScintillamarkdown()


        ' 定义 Markdown 标签样式
        Scintillamarkdown.Styles(Style.Markdown.Header1).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header1).BackColor = Color.White

        Scintillamarkdown.Styles(Style.Markdown.Header2).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header2).BackColor = Color.White

        Scintillamarkdown.Styles(Style.Markdown.Header3).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header3).BackColor = Color.White

        Scintillamarkdown.Styles(Style.Markdown.Header4).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header4).BackColor = Color.White

        Scintillamarkdown.Styles(Style.Markdown.Header5).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header5).BackColor = Color.White

        Scintillamarkdown.Styles(Style.Markdown.Header6).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Header6).BackColor = Color.White
        ' 定义 Markdown 链接样式
        Scintillamarkdown.Styles(Style.Markdown.Link).ForeColor = Color.Blue
        Scintillamarkdown.Styles(Style.Markdown.Link).Underline = True

        ' 定义 Markdown 代码样式
        Scintillamarkdown.Styles(Style.Markdown.Code).ForeColor = Color.Green
        Scintillamarkdown.Styles(Style.Markdown.Code).BackColor = Color.White

        ' 设置行号
        Scintillamarkdown.Margins(0).Type = MarginType.Number
        Scintillamarkdown.Margins(0).Width = 40

        ' 其他相关设置...
    End Sub












    Private closeConfirmed As Boolean = False

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 如果用户已经确认关闭，则允许关闭
        If closeConfirmed Then
            Return
        End If

        ' 检查RichTextBox1和RichTextBox2是否为空
        If String.IsNullOrWhiteSpace(ScintillaHTMLL.Text) AndAlso String.IsNullOrWhiteSpace(Scintillamarkdown.Text) Then
            ' 如果两个RichTextBox都是空的，允许关闭
            e.Cancel = False
        Else
            ' 如果至少有一个RichTextBox不是空的，显示提醒信息
            Dim result As DialogResult = MessageBox.Show("所有内容未清除，确定要关闭吗?", "确认关闭", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' 如果用户确认关闭，设置标志并再次尝试关闭窗口
                closeConfirmed = True
                Me.Close()
            Else
                ' 如果用户取消关闭，取消关闭事件
                e.Cancel = True
            End If
        End If
    End Sub









    Private Sub 保存HTML文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存HTML文件ToolStripMenuItem.Click
        ' 显示 SaveFileDialog
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' 将Scintillamarkdown 的内容转换为 HTML 并保存到文件
            Saveashtml(ScintillaHTMLL.Text, SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Saveashtml(content As String, filepath As String)
        '将文本内容转换为简单的 html 格式
        Dim htmlcontent As String = "<html><body><pre>" & content.Replace(vbCrLf, "<br>") & "</pre></body></html>"

        '将 html 内容写入到文件
        System.IO.File.WriteAllText(filepath, htmlcontent)
    End Sub







    Private Sub 保存MarkDown文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存Markdown文件ToolStripMenuItem.Click
        If SaveFileDialog2.ShowDialog() = DialogResult.OK Then
            ' 保存Scintillamarkdown2 的内容为 Markdown 文件
            System.IO.File.WriteAllText(SaveFileDialog2.FileName,Scintillamarkdown.Text)
        End If
    End Sub





    Private Sub Scintillamarkdownmarkdown_TextChanged_1(sender As Object, e As EventArgs)


    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
       Scintillamarkdown.AppendText("**" + My.Application.Info.ProductName + "**")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
       Scintillamarkdown.AppendText("*" + My.Application.Info.ProductName + "*")
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
       Scintillamarkdown.AppendText("[" + My.Application.Info.ProductName + "](https://github.com/yilihamujiang365/HTMLandMarkDown-Editor)")
    End Sub


    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

       Scintillamarkdown.AppendText(">" & My.Application.Info.Title)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

       Scintillamarkdown.AppendText("| " + My.Application.Info.ProductName + " | 其他 |
| ------- | ------- |
|       |         |
")
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click

        WebViewHTML.GoForward()

    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click

        WebViewHTML.CoreWebView2.OpenDevToolsWindow()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        If ToolStripTextBox1.Text = "" Then
            MessageBox.Show("请在左边输入链接地址！")
        Else
            WebViewHTML.CoreWebView2.Navigate("https://" & ToolStripTextBox1.Text)
        End If


    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        WebBrowser1.GoBack()

    End Sub









    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click

       Scintillamarkdown.AppendText("![示例图片](http://example.com/example.jpg)")
    End Sub



    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
       Scintillamarkdown.AppendText("``` 
这是代码片段
Console.Writrline(""" + My.Application.Info.Title + """)
```")
    End Sub



    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        ' 检查RichTextBox1和RichTextBox2是否为空
        If String.IsNullOrWhiteSpace(ScintillaHTMLL.Text) AndAlso String.IsNullOrWhiteSpace(Scintillamarkdown.Text) Then
            ' 如果两个RichTextBox都是空的，关闭窗体
            Me.Close()
        Else
            ' 如果至少有一个RichTextBox不是空的，显示提醒信息
            MessageBox.Show("请确认所有内容已清除后再关闭。")
        End If
    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub 反馈或意见ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 反馈或意见ToolStripMenuItem.Click
        Dim linkToOpen As String = "https://forms.office.com/r/ryf0EZnNS0"
        System.Diagnostics.Process.Start(linkToOpen)
    End Sub

    Private Sub 修改HTML编辑器字体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改HTML编辑器字体ToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            ' 如果用户选择了字体，设置RichTextBox的字体
            ScintillaHTMLL.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub 修改Markdown编辑器字体ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改Markdown编辑器字体ToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            ' 如果用户选择了字体，设置RichTextBox的字体
           Scintillamarkdown.Font = FontDialog1.Font
        End If
    End Sub


    Private Sub 新建HTML网页文件ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 新建HTML网页文件ToolStripMenuItem1.Click
        ' 显示 OpenFileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' 尝试以 UTF-8 编码读取文件内容
            Try
                Using reader As New StreamReader(OpenFileDialog1.FileName, Encoding.UTF8)
                    ScintillaHTMLL.Text = reader.ReadToEnd()
                End Using
            Catch ex As Exception
                ' 如果 UTF-8 编码失败，尝试使用系统默认编码
                Using reader As New StreamReader(OpenFileDialog1.FileName)
                    ScintillaHTMLL.Text = reader.ReadToEnd()
                End Using
            End Try
        End If
    End Sub

    Private Sub 新建MarkDown文件ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 新建MarkDown文件ToolStripMenuItem1.Click
        ' 显示 OpenFileDialog
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            ' 尝试以 UTF-8 编码读取文件内容
            Try
                Using reader As New StreamReader(OpenFileDialog2.FileName, Encoding.UTF8)
                   Scintillamarkdown.Text = reader.ReadToEnd()
                End Using
            Catch ex As Exception
                ' 如果 UTF-8 编码失败，尝试使用系统默认编码
                Using reader As New StreamReader(OpenFileDialog2.FileName)
                   Scintillamarkdown.Text = reader.ReadToEnd()
                End Using
            End Try
        End If
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        If ToolStripTextBox2.Text = "" Then
            MessageBox.Show("请在左边输入链接地址！")
        Else
            WebBrowser1.Navigate("https://" & ToolStripTextBox2.Text)
        End If

    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        WebViewHTML.Refresh()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        WebViewHTML.GoBack()
    End Sub

    Private Sub 新建HTML网页文件ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ScintillaHTMLL.Text = ""
    End Sub

    Private Sub 新建MarkDown文件ToolStripMenuItem_Click(sender As Object, e As EventArgs)
       Scintillamarkdown.Text = ""
    End Sub

    Private Sub ScintillaHTMLL_Click(sender As Object, e As EventArgs) Handles ScintillaHTMLL.Click

    End Sub

    Private Sub ScintillaHTMLL_TextChanged(sender As Object, e As EventArgs) Handles ScintillaHTMLL.TextChanged
        ToolStripLabel1.Text = "字数为：" & ScintillaHTMLL.TextLength
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
        Dim HTMLcontent As String = ScintillaHTMLL.Text
        WebViewHTML.NavigateToString(HTMLcontent)
        WebBrowser1.DocumentText = HTMLcontent
    End Sub

    Private Sub Scintillamarkdown_TextChanged(sender As Object, e As EventArgs) Handles Scintillamarkdown.TextChanged
        ToolStripLabel1.Text = "字数为：" & Scintillamarkdown.TextLength
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
        Dim Markdowncontent As String = Scintillamarkdown.Text
        Dim markdownHTMLcontent As String = Markdown.ToHtml(Markdowncontent)
        WebViewHTML.NavigateToString(markdownHTMLcontent)
        WebBrowser1.DocumentText = markdownHTMLcontent

    End Sub

    Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles ToolStripButton17.Click
        If SplitContainer1.Orientation = Orientation.Horizontal Then
            SplitContainer1.Orientation = Orientation.Vertical
            ToolStripButton17.Text = "水平切换"
        Else
            SplitContainer1.Orientation = Orientation.Horizontal
            ToolStripButton17.Text = "垂直切换"
        End If
    End Sub

    Private Sub GithubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GithubToolStripMenuItem.Click
        Dim GitHubadsress As String = "https://github.com/yilihamujiang365/537-Code-Factory"
        Process.Start(GitHubadsress)
    End Sub

    Private Sub GiteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiteeToolStripMenuItem.Click
        Dim Giteeadsress As String = "https://gitee.com/FTS-537Studio/537CodeFactory"
        Process.Start(Giteeadsress)
    End Sub
End Class