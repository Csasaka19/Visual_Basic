Public Class Form1
    Private Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles cmdcompute.Click
        txtoutput.Text = Len(txtinput.Text)
    End Sub

    Private Sub cmdright_Click(sender As Object, e As EventArgs) Handles cmdright.Click
        Dim text1 As String
        Dim text2 As Integer
        text2 = txtcharacters.Text
        text1 = txtinput.Text
        txtoutput.Text = Microsoft.VisualBasic.Right(text1, text2)

    End Sub

    Private Sub txtcharacters_TextChanged(sender As Object, e As EventArgs) Handles txtcharacters.TextChanged

    End Sub

    Private Sub cmdleft_Click(sender As Object, e As EventArgs) Handles cmdleft.Click
        Dim text1 As String
        Dim text2 As Integer
        text2 = txtcharacters.Text
        text1 = txtinput.Text
        txtoutput.Text = Microsoft.VisualBasic.Left(text1, text2)
    End Sub

    Private Sub cmdmid_Click(sender As Object, e As EventArgs) Handles cmdmid.Click
        Dim text1 As String
        Dim text2 As Integer
        Dim text3 As Integer
        text2 = txtcharacters.Text
        text1 = txtinput.Text
        text3 = txtstart.Text

        txtoutput.Text = Microsoft.VisualBasic.Mid(text1, text2, text3)
    End Sub

    Private Sub cmdupper_Click(sender As Object, e As EventArgs) Handles cmdupper.Click
        Dim text1 As String
        text1 = txtinput.Text
        text1 = StrConv(text1, VbStrConv.Uppercase)
        txtinput.Text = text1

    End Sub

    Private Sub txtinput_TextChanged(sender As Object, e As EventArgs) Handles txtinput.TextChanged

    End Sub

    Private Sub txtinput_LostFocus(sender As Object, e As EventArgs) Handles txtinput.LostFocus
        txtinput.Text = StrConv(txtinput.Text, VbStrConv.ProperCase)

    End Sub
End Class
