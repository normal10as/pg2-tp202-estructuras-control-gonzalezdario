Module NumerosPrimos
    Dim divisores As Integer
    Sub Main()
        Console.WriteLine("Numeros Primos menores a 1000")

        For x = 0 To 1000
            For a = 1 To x
                If x Mod a = 0 Then
                    divisores += 1
                End If
            Next
            If divisores = 2 Then
                Console.Write(x & " - ")
            End If
            divisores = 0
        Next
    End Sub
End Module
