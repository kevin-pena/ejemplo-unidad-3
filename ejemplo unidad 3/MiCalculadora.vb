Public Class MiCalculadora
    Public Sub MostrarMensaje(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Public Function Suma(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Public Function Resta(a As Integer, b As Integer) As Integer
        Return a - b
    End Function

    Public Function Multiplicacion(a As Integer, b As Integer) As Integer
        Return a * b
    End Function

    Public Function Division(a As Integer, b As Integer) As Double
        If b <> 0 Then
            Return CDbl(a) / CDbl(b)
        Else
            Throw New DivideByZeroException("Error: división entre cero no permitida")
        End If
    End Function
End Class




