Public Class frmHelloagain
    Private Sub btnSayhello_Click(sender As Object, e As EventArgs) Handles btnSayhello.Click
        lblHello.Text = "Hello, " & txtName.Text
    End Sub
End Class
