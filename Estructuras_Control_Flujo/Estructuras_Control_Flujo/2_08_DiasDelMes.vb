Module DiasDelMes
    Sub Main()
        Dim mes As Integer
        Dim anio As Integer
        Dim dias As Integer
        Dim bisiesto As Boolean

        Console.Write("Ingrese un mes: ")
        mes = Console.ReadLine()
        Console.Write("Ingrese un año: ")
        anio = Console.ReadLine()

        If (anio Mod 4 = 0) And (anio Mod 100 <> 0) Or (anio Mod 400 = 0) Then
            bisiesto = True
        Else
            bisiesto = False
        End If

        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                dias = 31
            Case 2
                If bisiesto = True Then
                    dias = 29
                ElseIf bisiesto = False Then
                    dias = 28
                End If
            Case 4, 6, 9, 11
                dias = 30
        End Select

        Console.WriteLine("El mes tiene " & dias & " dias.")
    End Sub
End Module
