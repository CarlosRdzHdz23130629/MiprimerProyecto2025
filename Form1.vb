Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Este código se ejecuta al abrir el formulario
        Me.Text = "Mi primer programa en Visual Studio"
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Código que se ejecuta al dar clic en el botón
        MessageBox.Show("¡Hola, mundo desde Visual Studio!")
    End Sub
End Class
