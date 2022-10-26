
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Form1


    Private Sub cbo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo1.SelectedIndexChanged
        With cbo1.Items
            .Add("2016")
            .Add("2017")
            .Add("2018")
            .Add("2019")
            .Add("2020")
            .Add("2021")
            .Add("2022")
            .Add("2023")
        End With
    End Sub

    Private Sub ListBoxHobbies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxHobbies.SelectedIndexChanged
        ListBoxHobbies.Sorted = True
        With ListBoxHobbies.Items
            .Clear()
            .Add("Swimming")
            .Add("Hockey")
            .Add("Chess")
            .Add("Football")
            .Add("Basketball")
            .Add("Netball")
            .Add("Student Leadership")
            .Add("Volleyball")
            .Add("Scrabble")
            .Add("Gaming")
            .Add("Handball")

        End With
    End Sub
    Private Sub txtMobileNumber_TextChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.TextChanged
        Dim mobile As Integer
        mobile = Integer.Parse(txtMobileNumber.Text)
        txtMobileNumber.MaxLength = 10

    End Sub

    Private Sub txtRegistrationNumber_Validating(sender As Object, e As CancelEventArgs) Handles txtRegistrationNumber.Validating
        If String.IsNullOrEmpty(txtRegistrationNumber.Text.Trim) Then
            MessageBox.Show("Warning! Please input your registration number")
        End If
    End Sub
    Private Sub txtRegistrationNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRegistrationNumber.TextChanged
        txtRegistrationNumber.MaxLength = 7

    End Sub
    Private Sub txtFullNames_TextChanged(sender As Object, e As EventArgs) Handles txtFullNames.TextChanged
        txtFullNames.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtemailaddress_TextChanged(sender As Object, e As EventArgs) Handles txtemailaddress.TextChanged

    End Sub

    Private Sub cbo1_LostFocus(sender As Object, e As EventArgs) Handles cbo1.LostFocus
        cbo1.BackColor = BackColor.Blue
    End Sub

    Private Sub cbo1_GotFocus(sender As Object, e As EventArgs) Handles cbo1.GotFocus
        cbo1.BackColor = BackColor.White
    End Sub

    Private Sub ListBoxHobbies_LostFocus(sender As Object, e As EventArgs) Handles ListBoxHobbies.LostFocus
        ListBoxHobbies.BackColor = BackColor.White
    End Sub

    Private Sub ListBoxHobbies_GotFocus(sender As Object, e As EventArgs) Handles ListBoxHobbies.GotFocus
        ListBoxHobbies.BackColor = BackColor.Blue
    End Sub

    Private Sub txtMobileNumber_LostFocus(sender As Object, e As EventArgs) Handles txtMobileNumber.LostFocus
        txtMobileNumber.BackColor = BackColor.White
    End Sub

    Private Sub txtMobileNumber_GotFocus(sender As Object, e As EventArgs) Handles txtMobileNumber.GotFocus
        txtMobileNumber.BackColor = BackColor.Blue
    End Sub

    Private Sub txtRegistrationNumber_LostFocus(sender As Object, e As EventArgs) Handles txtRegistrationNumber.LostFocus
        txtRegistrationNumber.BackColor = BackColor.White
    End Sub

    Private Sub txtRegistrationNumber_GotFocus(sender As Object, e As EventArgs) Handles txtRegistrationNumber.GotFocus
        txtRegistrationNumber.BackColor = BackColor.Blue
    End Sub

    Private Sub txtemailaddress_LostFocus(sender As Object, e As EventArgs) Handles txtemailaddress.LostFocus
        txtemailaddress.BackColor = BackColor.White
    End Sub

    Private Sub txtemailaddress_GotFocus(sender As Object, e As EventArgs) Handles txtemailaddress.GotFocus
        txtemailaddress.BackColor = BackColor.Blue
    End Sub

    Private Sub txtFullNames_LostFocus(sender As Object, e As EventArgs) Handles txtFullNames.LostFocus
        txtFullNames.BackColor = BackColor.White
    End Sub

    Private Sub txtFullNames_GotFocus(sender As Object, e As EventArgs) Handles txtFullNames.GotFocus
        txtFullNames.BackColor = BackColor.Blue
    End Sub

    Private Sub RadiobtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadiobtnMale.CheckedChanged

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtemailaddress.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.Please try again")
        End If

        Dim Fullname As String
        Fullname = txtFullNames.Text.Trim

        If Fullname.Contains(" ") Then
            Dim parts As String() = Fullname.Split(" ")

            txtoutput1.Text = parts(0)
            txtoutput2.Text = parts(1)
        Else
            txtoutput1.Text = Fullname
            txtoutput2.Text = ""
        End If


    End Sub
End Class
