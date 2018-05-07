Module NumeroMayor
    Sub Main()
        Dim mayor As Integer
        Dim mayorpos As String
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer

        Console.WriteLine("Mayor de Cinco Numeros")
        Console.Write("Ingrese un valor :  ")
        a = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        b = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        c = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        d = Console.ReadLine()
        Console.Write("Ingrese un valor :  ")
        e = Console.ReadLine()

        mayor = a
        mayorpos = "primer"

        If b > mayor Then
            mayor = b
            mayorpos = "segundo"
        End If

        If c > mayor Then
            mayor = c
            mayorpos = "tercer"
        End If

        If d > mayor Then
            mayor = d
            mayorpos = "cuarto"
        End If

        If e > mayor Then
            mayor = e
            mayorpos = "quinto"
        End If

        Console.WriteLine("El " + mayorpos + " numero es el mayor.")
    End Sub
End Module
