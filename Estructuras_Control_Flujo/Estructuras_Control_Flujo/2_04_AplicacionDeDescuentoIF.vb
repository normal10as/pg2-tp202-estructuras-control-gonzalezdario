Module AplicacionDeDescuentoIF
    Dim Cantidad As Integer
    Dim PrecioUnitario As Single
    Dim Descuento As Single
    Sub Main()
        Console.WriteLine("Calculo de Descuento")
        Console.Write("Ingrese la cantidad: ")
        Cantidad = Console.ReadLine()
        Console.Write("Ingrese el precio unitario: ")
        PrecioUnitario = Console.ReadLine()

        If Cantidad >= 10 And Cantidad <= 50 Then
            Descuento = 0.05
        ElseIf Cantidad > 50 And Cantidad <= 250 Then
            Descuento = 0.1
        ElseIf Cantidad > 250 Then
            Descuento = 0.2
        End If

        Dim SubTotal As Single = Cantidad * PrecioUnitario
        Dim MontoDescontado As Single = SubTotal * Descuento
        Console.WriteLine("SubTotal: $" & SubTotal)
        Console.WriteLine("Porcentaje de Descuento: " & Descuento * 100 & "%")
        Console.WriteLine("Monto Descontado: $" & MontoDescontado)
        Console.WriteLine("Total : $" & SubTotal - MontoDescontado)
    End Sub
End Module
