﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox1
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label_ProductName As System.Windows.Forms.Label
    Friend WithEvents Label_DeveloperName As System.Windows.Forms.Label
    Friend WithEvents TextBox_Description As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Label_CopyrightInfo As System.Windows.Forms.Label

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_ProductName = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_CopyrightInfo = New System.Windows.Forms.Label()
        Me.Label_DeveloperName = New System.Windows.Forms.Label()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Controls.Add(Me.Label_ProductName, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label_Version, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Label_CopyrightInfo, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.Label_DeveloperName, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBox_Description, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 0, 6)
        Me.TableLayoutPanel.Controls.Add(Me.LinkLabel1, 0, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 7
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12397!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12397!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12397!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12397!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5041!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.Size = New System.Drawing.Size(863, 426)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'Label_ProductName
        '
        Me.Label_ProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_ProductName.Location = New System.Drawing.Point(6, 0)
        Me.Label_ProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label_ProductName.MaximumSize = New System.Drawing.Size(0, 16)
        Me.Label_ProductName.Name = "Label_ProductName"
        Me.Label_ProductName.Size = New System.Drawing.Size(854, 16)
        Me.Label_ProductName.TabIndex = 0
        Me.Label_ProductName.Text = "产品名称"
        Me.Label_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Version
        '
        Me.Label_Version.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Version.Location = New System.Drawing.Point(6, 41)
        Me.Label_Version.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label_Version.MaximumSize = New System.Drawing.Size(0, 16)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(854, 16)
        Me.Label_Version.TabIndex = 0
        Me.Label_Version.Text = "版本"
        Me.Label_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        AddHandler Me.Label_Version.Click, AddressOf Me.LabelVersion_Click
        '
        'Label_CopyrightInfo
        '
        Me.Label_CopyrightInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_CopyrightInfo.Location = New System.Drawing.Point(6, 82)
        Me.Label_CopyrightInfo.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label_CopyrightInfo.MaximumSize = New System.Drawing.Size(0, 16)
        Me.Label_CopyrightInfo.Name = "Label_CopyrightInfo"
        Me.Label_CopyrightInfo.Size = New System.Drawing.Size(854, 16)
        Me.Label_CopyrightInfo.TabIndex = 0
        Me.Label_CopyrightInfo.Text = "版权信息"
        Me.Label_CopyrightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_DeveloperName
        '
        Me.Label_DeveloperName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_DeveloperName.Location = New System.Drawing.Point(6, 123)
        Me.Label_DeveloperName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label_DeveloperName.MaximumSize = New System.Drawing.Size(0, 16)
        Me.Label_DeveloperName.Name = "Label_DeveloperName"
        Me.Label_DeveloperName.Size = New System.Drawing.Size(854, 16)
        Me.Label_DeveloperName.TabIndex = 0
        Me.Label_DeveloperName.Text = "开发者名称"
        Me.Label_DeveloperName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Description.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TextBox_Description.Location = New System.Drawing.Point(6, 167)
        Me.TextBox_Description.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ReadOnly = True
        Me.TextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Description.Size = New System.Drawing.Size(854, 171)
        Me.TextBox_Description.TabIndex = 0
        Me.TextBox_Description.TabStop = False
        Me.TextBox_Description.Text = resources.GetString("TextBox_Description.Text")
        AddHandler Me.TextBox_Description.TextChanged, AddressOf Me.TextBoxDescription_TextChanged_1
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(777, 394)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(83, 29)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "好(&O)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel1.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(775, 341)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 46)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "官方网站"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(869, 590)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 435)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(863, 152)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "开发者列表：" & Global.Microsoft.VisualBasic.ChrW(10) & "1.ئىلھامجان （E-mail:yilihamujiang365@outlook.com）" & Global.Microsoft.VisualBasic.ChrW(10) & "Home(https://github.com/" &
    "yilihamujiang365/)"
        '
        'AboutBox1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(887, 606)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AboutBox1"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label_Version As Label
End Class
