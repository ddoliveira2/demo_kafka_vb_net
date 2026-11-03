Public Class FrmPrincipal
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        HelperKafka.SendMessage("mensagens", txtMessage.Text)
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelperKafka.StartListening("mensagens", "001")
    End Sub
End Class
