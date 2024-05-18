Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        With Delivery
            .TopLevel = False
            Panel2.Controls.Add(Delivery)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With order
            .TopLevel = False
            Panel2.Controls.Add(order)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With sales
            .TopLevel = False
            Panel2.Controls.Add(sales)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class