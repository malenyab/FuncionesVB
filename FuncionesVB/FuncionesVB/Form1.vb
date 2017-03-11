Public Class Form1

    Dim func As New funciones()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim resultado As Double

        resultado = suma(5, 15)

        Label1.Text = "El resultado de la función en la misma clase es: " + resultado.ToString

        Dim resultado2 As Double

        resultado2 = func.multiplicacion(5, 15)

        Label2.Text = "El resultado de la función en otra clase es: " + resultado2.ToString


    End Sub

    Public Function suma(valor1 As Double, valor2 As Double)
        Dim sum As Double

        sum = valor1 + valor2

        Return sum
    End Function

End Class
