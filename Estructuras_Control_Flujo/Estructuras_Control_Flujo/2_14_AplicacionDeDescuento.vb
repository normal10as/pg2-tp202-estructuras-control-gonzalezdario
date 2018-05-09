Module AplicacionDeDescuento
    Dim Cantidad As Integer
    Dim PrecioUnitario As Single
    Dim Descuento As Single = 0
    Dim SubTotal As Single
    Dim MontoDescontado As Single
    Dim Total As Single
    Dim TotalDescontado As Single
    Dim TotalPagar As Single

    Sub Main()
        Console.WriteLine("Calculo de Descuento")
        Console.WriteLine("------------------------------------")
        Console.Write("Ingrese la cantidad: ")
        Cantidad = Console.ReadLine()

        Do While Cantidad <> 0
            Console.Write("Ingrese el precio unitario: ")
            PrecioUnitario = Console.ReadLine()

            Select Case Cantidad
                Case 10 To 50
                    Descuento = 0.05
                Case 51 To 250
                    Descuento = 0.1
                Case Is > 250
                    Descuento = 0.2
            End Select

            SubTotal = Cantidad * PrecioUnitario
            MontoDescontado = SubTotal * Descuento
            Total = SubTotal - MontoDescontado
            TotalDescontado = TotalDescontado + MontoDescontado
            TotalPagar = TotalPagar + Total

            Console.WriteLine("SubTotal: $" & SubTotal)
            Console.WriteLine("Porcentaje de Descuento: " & Descuento * 100 & "%")
            Console.WriteLine("Monto Descontado: $" & MontoDescontado)
            Console.WriteLine("Total : $" & Total)

            Console.WriteLine("------------------------------------")
            Console.Write("Ingrese una cantidad: ")
            Cantidad = Console.ReadLine()
        Loop
        Console.WriteLine("------------------------------------")
        Console.WriteLine("Total Descontado: $" & TotalDescontado)
        Console.WriteLine("Total a Pagar : $" & TotalPagar)
        Console.WriteLine("------------------------------------")

    End Sub
End Module
