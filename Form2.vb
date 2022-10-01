Public Class Form2
    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        With lsvCourse.Items
            .Add("Visual Programming")
            .Add("Structured Programming")
            .Add("Philosophy Studies")
            .Add("Medicine")
            .Add("Object oriented programming")

        End With
    End Sub


    Private Sub CmdSort_Click(sender As Object, e As EventArgs) Handles CmdSort.Click

    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        lsvCourse.Items.Clear()
    End Sub
End Class