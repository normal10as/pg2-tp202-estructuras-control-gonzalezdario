Module MultiplosDeCinco
    Dim x As Integer
    Dim cont As Integer

    Sub Main()
        Console.Write("Ingrese un numero: ")
        Dim a As Integer = Console.ReadLine()

        Console.Write("Ingrese un numero mayor al anterior: ")
        Dim b As Integer = Console.ReadLine()
        Console.Write(vbCrLf)

        'For ------------------------------------------------------------------
        Console.WriteLine("Multiplos de Cinco Encontrados: [For]")
        For x = a To b

            If x Mod 5 = 0 Then
                cont = cont + 1
                Console.Write(x & " - ")
            End If
        Next
        If cont <> 0 Then
            Console.WriteLine("Encontrados: " & cont & " multiplos." & vbCrLf)
        Else
            Console.WriteLine("No se encontraron multiplos de 5." & vbCrLf)
        End If

        'Do While Loop --------------------------------------------------------
        x = a
        cont = 0

        Console.WriteLine("Multiplos de Cinco Encontrados: [Do While... Loop]")
        Do While x <= b
            If x Mod 5 = 0 Then
                cont = cont + 1
                Console.Write(x & " - ")
            End If
            x += 1
        Loop

        If cont <> 0 Then
            Console.WriteLine("Encontrados: " & cont & " multiplos." & vbCrLf)
        Else
            Console.WriteLine("No se encontraron multiplos de 5." & vbCrLf)
        End If


        'Do Loop While --------------------------------------------------------
        x = a
        cont = 0

        Console.WriteLine("Multiplos de Cinco Encontrados: [Do... Loop While]")
        Do
            If x Mod 5 = 0 Then
                cont = cont + 1
                Console.Write(x & " - ")
            End If
            x += 1
        Loop While x <= b

        If cont <> 0 Then
            Console.WriteLine("Encontrados: " & cont & " multiplos." & vbCrLf)
        Else
            Console.WriteLine("No se encontraron multiplos de 5." & vbCrLf)
        End If

        'Do Until Loop --------------------------------------------------------
        x = a
        cont = 0

        Console.WriteLine("Multiplos de Cinco Encontrados: [Do Until... Loop]")
        Do Until x > b
            If x Mod 5 = 0 Then
                cont = cont + 1
                Console.Write(x & " - ")
            End If
            x += 1
        Loop

        If cont <> 0 Then
            Console.WriteLine("Encontrados: " & cont & " multiplos." & vbCrLf)
        Else
            Console.WriteLine("No se encontraron multiplos de 5." & vbCrLf)
        End If


        'Do Loop Until --------------------------------------------------------
        x = a
        cont = 0

        Console.WriteLine("Multiplos de Cinco Encontrados: [Do... Loop Until]")
        Do
            If x Mod 5 = 0 Then
                cont = cont + 1
                Console.Write(x & " - ")
            End If
            x += 1
        Loop Until x > b

        If cont <> 0 Then
            Console.WriteLine("Encontrados: " & cont & " multiplos." & vbCrLf)
        Else
            Console.WriteLine("No se encontraron multiplos de 5." & vbCrLf)
        End If

    End Sub
End Module
