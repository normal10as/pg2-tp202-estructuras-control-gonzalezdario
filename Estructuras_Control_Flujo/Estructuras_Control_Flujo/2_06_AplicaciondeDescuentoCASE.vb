Module AplicaciondeDescuentoCASE
    Dim Cantidad As Integer
    Dim PrecioUnitario As Single
    Dim Descuento As Single = 0
    Sub Main()
        Console.WriteLine("Calculo de Descuento")
        Console.Write("Ingrese la cantidad: ")
        Cantidad = Console.ReadLine()
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

        Dim SubTotal As Single = Cantidad * PrecioUnitario
        Dim MontoDescontado As Single = SubTotal * Descuento
        Console.WriteLine("SubTotal: $" & SubTotal)
        Console.WriteLine("Porcentaje de Descuento: " & Descuento * 100 & "%")
        Console.WriteLine("Monto Descontado: $" & MontoDescontado)
        Console.WriteLine("Total : $" & SubTotal - MontoDescontado)
    End Sub
End Module
