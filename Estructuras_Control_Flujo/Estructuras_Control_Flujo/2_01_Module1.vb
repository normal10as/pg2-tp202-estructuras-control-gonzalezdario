﻿Module Module1
    Dim a As Integer
    Dim b As Integer
    Sub Main()
        Console.Write("Ingrese un numero: ")
        a = Console.ReadLine()
        Console.Write("Ingrese un numero: ")
        b = Console.ReadLine()

        If a > b Then
            Console.WriteLine("El primer numero es mayor que el segundo.")
        ElseIf a < b Then
            Console.WriteLine("El segundo numero es mayor que el primero.")
        Else
        Console.WriteLine("Los numeros son iguales.")
        End If

    End Sub

End Module
