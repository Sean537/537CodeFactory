Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置此窗体的标题。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        Me.Label_ProductName.Text = My.Application.Info.ProductName
        Me.Label_Version.Text = String.Format("版本 {0}", My.Application.Info.Version.ToString)
        Me.Label_CopyrightInfo.Text = My.Application.Info.Copyright
        Me.Label_DeveloperName.Text = My.Application.Info.CompanyName

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim mywebadress As String = "https://www.537studio.com"
        Process.Start(mywebadress)
    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Description.TextChanged

    End Sub

    Private Sub TextBoxDescription_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelVersion_Click(sender As Object, e As EventArgs)

    End Sub
End Class
