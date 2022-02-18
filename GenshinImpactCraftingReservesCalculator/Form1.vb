Imports System.IO

Public Class Form1

    Private Sub BottonCalc_Click(sender As Object, e As EventArgs) Handles BottonCalc.Click
        Dim CalcResult As String
        If TextBox_Name.Text = "" Then
            MsgBox("名称不能为空", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "错误")
        Else
            If TextBoxLevel4.Text = "" Or IsNumeric(TextBoxLevel4.Text) = False Then
                TextBoxLevel4.Text = 0
            End If
            If TextBoxLevel3.Text = "" Or IsNumeric(TextBoxLevel4.Text) = False Then
                TextBoxLevel3.Text = 0
            End If
            If TextBoxLevel2.Text = "" Or IsNumeric(TextBoxLevel4.Text) = False Then
                TextBoxLevel2.Text = 0
            End If
            If TextBoxLevel1.Text = "" Or IsNumeric(TextBoxLevel4.Text) = False Then
                TextBoxLevel1.Text = 0
            End If
            CalcResult = TextBoxLevel4.Text * 9 + TextBoxLevel3.Text * 6 + TextBoxLevel2.Text * 3 + TextBoxLevel1.Text
            ListBox1.Items.Add(TextBox_Name.Text + "：" + CalcResult)
            TextBox_Name.Text = ""
            TextBoxLevel4.Text = ""
            TextBoxLevel3.Text = ""
            TextBoxLevel2.Text = ""
            TextBoxLevel1.Text = ""
            TextBox_Name.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("请先选择要删除的条目", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "错误")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = ListBox1.Items.Count - 1 To 0 Step -1
            ListBox1.Items.RemoveAt(i)
        Next
    End Sub

    Private Sub TextBox_Name_GotFocus(sender As Object, e As EventArgs) Handles TextBox_Name.GotFocus
        TextBox_Name.SelectionStart = 0
        TextBox_Name.SelectionLength = Len(TextBox_Name.Text)
    End Sub

    Private Sub TextBoxLevel1_GotFocus(sender As Object, e As EventArgs) Handles TextBoxLevel1.GotFocus
        TextBoxLevel1.SelectionStart = 0
        TextBoxLevel1.SelectionLength = Len(TextBoxLevel1.Text)
    End Sub

    Private Sub TextBoxLevel2_GotFocus(sender As Object, e As EventArgs) Handles TextBoxLevel2.GotFocus
        TextBoxLevel2.SelectionStart = 0
        TextBoxLevel2.SelectionLength = Len(TextBoxLevel2.Text)
    End Sub

    Private Sub TextBoxLevel3_GotFocus(sender As Object, e As EventArgs) Handles TextBoxLevel3.GotFocus
        TextBoxLevel3.SelectionStart = 0
        TextBoxLevel3.SelectionLength = Len(TextBoxLevel3.Text)
    End Sub

    Private Sub TextBoxLevel4_GotFocus(sender As Object, e As EventArgs) Handles TextBoxLevel4.GotFocus
        TextBoxLevel4.SelectionStart = 0
        TextBoxLevel4.SelectionLength = Len(TextBoxLevel3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SaveProcess As New System.Text.StringBuilder
        For Each o As Object In ListBox1.Items
            SaveProcess.AppendLine(o)
        Next
        File.WriteAllText("结果.TXT", SaveProcess.ToString)
        MsgBox("文件已保存到程序所在目录下。", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "提示")
        Shell("cmd /c start notepad.exe 结果.TXT")
    End Sub

    Private Sub TextBoxLevel4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLevel4.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            TextBoxLevel4.Text = ""
            TextBoxLevel4.Focus()
        End If
    End Sub

    Private Sub TextBoxLevel3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLevel3.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            TextBoxLevel3.Text = ""
            TextBoxLevel3.Focus()
        End If
    End Sub

    Private Sub TextBoxLevel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLevel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            TextBoxLevel2.Text = ""
            TextBoxLevel2.Focus()
        End If
    End Sub

    Private Sub TextBoxLevel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLevel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            TextBoxLevel1.Text = ""
            TextBoxLevel1.Focus()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedItem <> "" Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class
