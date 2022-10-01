Public Class Form1
    Private Sub CmdShowNames_Click(sender As Object, e As EventArgs) Handles CmdShowNames.Click
        txtFullNames.Text = txtFirstName.Text + " " + txtSecondName.Text
    End Sub

    Private Sub cbo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo1.SelectedIndexChanged
        With cbo1.Items
            .Add("Year 1")
            .Add("Year 2")
            .Add("Year 3")
            .Add("Year 4")
        End With
    End Sub

    Private Sub cbo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo2.SelectedIndexChanged
        With cbo2.Items
            .Add("Year 1")
            .Add("Year 2")
            .Add("Year 3")
            .Add("Year 4")
        End With
    End Sub

    Private Sub optMale_Click(sender As Object, e As EventArgs) Handles optMale.Click
        MsgBox(txtFullNames.Text & " is a male" & " Gender")
    End Sub

    Private Sub optFemale_Click(sender As Object, e As EventArgs) Handles optFemale.Click
        MsgBox(txtFullNames.Text & " is a female" & " Gender")
    End Sub

    Private Sub optOther_Click(sender As Object, e As EventArgs) Handles optOther.Click
        MsgBox(txtFullNames.Text & " is a other" & " Gender")
    End Sub

    Private Sub lstCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourse.SelectedIndexChanged
        With lstCourse.Items
            .Clear()
            .Add("Visual Programming")
            .Add("Structured Programming")
            .Add("Philosophy Studies")
            .Add("Medicine")

        End With
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        lstCourse.Items.Add(txtFullNames)
    End Sub

    Private Sub CmdRemove_Click(sender As Object, e As EventArgs) Handles CmdRemove.Click
        lstCourse.Items.Remove(lstCourse.SelectedItem.ToString)
    End Sub

    Private Sub CmdSort_Click(sender As Object, e As EventArgs) Handles CmdSort.Click
        lstCourse.Sorted = True
    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        lstCourse.Items.Clear()
    End Sub
End Class