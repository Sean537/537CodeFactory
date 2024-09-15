Imports System.IO
Public Class HTMLControl
    Private Async Sub htmlEditor_Load(sender As Object, e As EventArgs) Handles htmlEditor.Load
        '预加载webview2
        Await htmlWebView.EnsureCoreWebView2Async()
        'htmlWebView.CoreWebView2.Settings.IsScriptEnabled = True '启用webviewnews的js脚本
    End Sub

    Private Sub htmlEditor_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles htmlEditor.TextChanged
        htmlTextChanged()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (FontDialog1.ShowDialog() = DialogResult.OK) Then
            htmlEditor.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        htmlWebView.GoBack()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        htmlWebView.GoForward()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        htmlWebView.Refresh()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        htmlWebView.CoreWebView2.OpenDevToolsWindow()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        htmlWebView.CoreWebView2.OpenTaskManagerWindow()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        htmlEditor.AppendText("<a href=""https://www.bing.com"" >链接🔗</a>")
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        htmlEditor.AppendText("
<script>

</script>")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        htmlEditor.AppendText("<img src=""网页链接""alt=""示例图片"">")
    End Sub
    Private isHorizontal As Boolean = True
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        If isHorizontal Then
            ToolStripStatusLabel1.Image = My.Resources.swap_vertical
            SplitContainer1.Orientation = Orientation.Vertical
            isHorizontal = False
        Else
            ToolStripStatusLabel1.Image = My.Resources.swap_horizontal
            SplitContainer1.Orientation = Orientation.Horizontal
            isHorizontal = True
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        ieform.Show()
        ToolStripButton6.ToolTipText = "IE浏览器内核"
        ieform.Text = ToolStripButton6.ToolTipText
        Try
            Dim lines() As String = File.ReadAllLines("filepatchfile.txt")
            If lines.Length > 0 Then
                Dim filepath As String = lines(0)

                Dim htmltext As String = htmlEditor.Text
                ieform.WebBrowser1.DocumentText = htmltext
                File.WriteAllText(filepath, htmlEditor.Text)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub htmlTextChanged()
        Try
            Dim lines() As String = File.ReadAllLines("filepatchfile.txt")
            If lines.Length > 0 Then
                Dim filepath As String = lines(0)
                htmlWebView.Source = New Uri(filepath)
                Dim htmltext As String = htmlEditor.Text
                ' ieform.WebBrowser1.DocumentText = htmltext
                File.WriteAllText(filepath, htmlEditor.Text)
            End If
            htmlWebView.NavigateToString(htmlEditor.Text)

        Catch ex As Exception

        End Try
        ToolStripStatusLabel2.Text = "字符数：" + htmlEditor.TextLength.ToString()
        Dim currentCharIndex As Integer = htmlEditor.SelectionStart
        Dim lineNumber As Integer = 0
        For Each line As String In htmlEditor.Lines
            Dim lineLength As Integer = line.Length
            If currentCharIndex < lineLength Then
                Exit For
            End If
            currentCharIndex -= lineLength + Environment.NewLine.Length
            lineNumber += 1
        Next
        Dim totalLines As Integer = htmlEditor.Lines.Count()
        ToolStripStatusLabel3.Text = "当前在" + lineNumber.ToString() + "行" + "/总行数：" + totalLines.ToString()
    End Sub
End Class
