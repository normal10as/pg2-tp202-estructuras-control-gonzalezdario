Module ParesImpares
    Dim num As Integer
    Dim pares As Integer
    Dim impares As Integer
    Dim cont As Integer

    Sub Main()
        Console.Write("Ingrese un numero: ")
        num = Console.ReadLine()

        Do While num <> 0
            cont = cont + 1
            If num Mod 2 = 0 Then
                pares = pares + 1
            Else
                impares = impares + 1
            End If

            Console.Write("Ingrese un numero: ")
            num = Console.ReadLine()
        Loop

        If pares = cont And cont <> 0 Then
            Console.WriteLine("Todos los numeros son pares.")
        ElseIf impares = cont And cont <> 0 Then
            Console.WriteLine("Todos los numeros son impares.")
        Else
            Console.WriteLine(pares & " numeros son pares.")
            Console.WriteLine(impares & " numeros son impares.")
        End If
    End Sub
End Module
