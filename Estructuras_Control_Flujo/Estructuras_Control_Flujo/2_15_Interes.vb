Module Interes
    Const InteresAnual As Single = 0.36
    Dim capital As Single
    Dim meses As Byte
    Dim interes As Single = 0
    Dim saldo As Single
    Dim TotalInteresGanado As Single = 0

    Sub Main()
        Console.Write("Ingrese un capital inicial: ")
        capital = Console.ReadLine()

        Console.Write("Ingrese la cantidad de meses: ")
        meses = Console.ReadLine()

        Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15}", "Mes", "Capital", "Interes", "Saldo")
        For x = 1 To meses
            capital = capital + interes
            interes = capital * (InteresAnual / 12)
            TotalInteresGanado = TotalInteresGanado + interes
            saldo = capital + interes
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-15}", x, "$" & capital, "$" & interes, "$" & saldo)
        Next
        Console.WriteLine("Total Interes Ganado: " & "$" & TotalInteresGanado)
    End Sub
End Module
