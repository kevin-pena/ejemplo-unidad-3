Public Class Form1

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim calculadora As New MiCalculadora()

        calculadora.MostrarMensaje("¡Hola, soy una calculadora!")

        Dim resultadoSuma As Integer = calculadora.Suma(5, 3)
        MessageBox.Show("Suma: " & resultadoSuma.ToString())

        Dim resultadoResta As Integer = calculadora.Resta(10, 7)
        MessageBox.Show("Resta: " & resultadoResta.ToString())

        Dim resultadoMultiplicacion As Integer = calculadora.Multiplicacion(4, 6)
        MessageBox.Show("Multiplicación: " & resultadoMultiplicacion.ToString())

        Try
            Dim resultadoDivision As Double = calculadora.Division(10, 2)
            MessageBox.Show("División: " & resultadoDivision.ToString())
        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

