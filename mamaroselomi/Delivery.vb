Public Class Delivery


    Private Sub Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim newitem As New ListViewItem(Username.Text)
        newitem.SubItems.Add(Username.Text)

        ListView1.Items.Add(newitem)
    End Sub
End Class
