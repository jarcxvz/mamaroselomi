Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub lgnbutton_Click(sender As Object, e As EventArgs) Handles lgnbutton.Click
        If Username.Text = "mamarose" And Password.Text = "lomi" Then
            MsgBox("You login successfully!")
            Form2.Show()

        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub
End Class
