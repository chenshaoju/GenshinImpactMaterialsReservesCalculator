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
            CalcResult = TextBoxLevel4.Text * 4 + TextBoxLevel3.Text * 3 + TextBoxLevel2.Text * 2 + TextBoxLevel1.Text
            ListBox1.Items.Add(TextBox_Name.Text + "：" + CalcResult)
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
End Class
