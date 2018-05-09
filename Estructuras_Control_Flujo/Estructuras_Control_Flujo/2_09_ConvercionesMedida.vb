Module ConvercionesMedida
    Dim seleccion As Single
    Dim valor As Single

    Dim cm As Single
    Dim m As Single
    Dim pie As Single
    Dim yarda As Single
    Dim pulgada As Single

    Sub Main()
        Console.WriteLine("Conversor de Unidades...")

        Console.WriteLine("0 - Metros")
        Console.WriteLine("1 - Centimetros")
        Console.WriteLine("2 - Yardas")
        Console.WriteLine("3 - Pies")
        Console.WriteLine("4 - Pulgadas")

        Console.Write("Seleccion: ")
        seleccion = Console.ReadLine()

        Console.Write("Ingrese el valor: ")
        valor = Console.ReadLine()

        Select Case seleccion
            Case 0
                m = valor
                cm = m * 100
                pulgada = cm / 2.54
                pie = pulgada / 12
                yarda = pie / 3
            Case 1
                cm = valor
                m = cm / 100
                pulgada = cm / 2.54
                pie = pulgada / 12
                yarda = pie / 3
            Case 2
                yarda = valor
                pie = yarda * 3
                pulgada = pie * 12
                cm = pulgada * 2.54
                m = cm / 100
            Case 3
                pie = valor
                yarda = pie / 3
                pulgada = pie * 12
                cm = pulgada * 2.54
                m = cm / 100
            Case 4
                pulgada = valor
                cm = pulgada * 2.54
                m = cm / 100
                pie = pulgada / 12
                yarda = pie / 3
        End Select

        Console.WriteLine("Metros: " & m)
        Console.WriteLine("Centimetros: " & cm)
        Console.WriteLine("Pulgadas: " & pulgada)
        Console.WriteLine("Pies: " & pie)
        Console.WriteLine("Yardas:" & yarda)

    End Sub

End Module
