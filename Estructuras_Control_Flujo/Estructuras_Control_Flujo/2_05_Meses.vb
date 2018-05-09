Module Meses
    Dim resultado As String
    Sub Main()
        Dim mes As Integer

        Console.Write("Ingrese un numero correspondiente a un mes: ")
        mes = Console.ReadLine()

        Select Case mes
            Case 1
                resultado = "Enero"
            Case 2
                resultado = "Febrero"
            Case 3
                resultado = "Marzo"
            Case 4
                resultado = "Abril"
            Case 5
                resultado = "Mayo"
            Case 6
                resultado = "Junio"
            Case 7
                resultado = "Julio"
            Case 8
                resultado = "Agosto"
            Case 9
                resultado = "Septiempre"
            Case 10
                resultado = "Octubre"
            Case 11
                resultado = "Noviembre"
            Case 12
                resultado = "Diciembre"
            Case Else
                resultado = "Error"
        End Select

        If resultado <> "Error" Then
            Console.WriteLine("El numero corresponde al mes de " + resultado + ".")
        Else
            Console.WriteLine("No ha ingresado un numero valido.")
        End If
    End Sub

End Module
