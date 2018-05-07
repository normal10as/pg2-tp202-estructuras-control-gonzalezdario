Module Meses
    Sub Main()
        Dim mes As Integer

        Console.Write("Ingrese un numero correspondiente a un mes: ")
        mes = Console.ReadLine()

        Select Case mes
            Case 1
                Console.WriteLine("El numero corresponde al mes de Enero")
            Case 2
                Console.WriteLine("El numero corresponde al mes de Febrero")
            Case 3
                Console.WriteLine("El numero corresponde al mes de Marzo")
            Case 4
                Console.WriteLine("El numero corresponde al mes de Abril")
            Case 5
                Console.WriteLine("El numero corresponde al mes de Mayo")
            Case 6
                Console.WriteLine("El numero corresponde al mes de Junio")
            Case 7
                Console.WriteLine("El numero corresponde al mes de Julio")
            Case 8
                Console.WriteLine("El numero corresponde al mes de Agosto")
            Case 9
                Console.WriteLine("El numero corresponde al mes de Septiempre")
            Case 10
                Console.WriteLine("El numero corresponde al mes de Octubre")
            Case 11
                Console.WriteLine("El numero corresponde al mes de Noviembre")
            Case 12
                Console.WriteLine("El numero corresponde al mes de Diciembre")
            Case Else
                Console.WriteLine("No ha ingresado un numero valido.")

        End Select
    End Sub

End Module
