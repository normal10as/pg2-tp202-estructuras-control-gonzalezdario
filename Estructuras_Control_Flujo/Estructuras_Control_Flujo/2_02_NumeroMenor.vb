Module NumeroMenor
    Sub Main()
        Dim menor As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        Console.Write("Ingrese un valor :  ")
        a = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        b = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        c = Console.ReadLine()

        menor = a

        If b < menor Then
            menor = b
        ElseIf c < menor Then
            menor = c
        End If

        Console.WriteLine("El numero menor es: " & menor)
    End Sub
End Module
