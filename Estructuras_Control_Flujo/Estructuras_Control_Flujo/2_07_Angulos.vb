Module Angulos
    Sub Main()
        Dim angulo As Integer
        Dim tipoangulo As String

        Console.Write("Ingrese el valor de un angulo: ")
        angulo = Console.ReadLine()

        Select Case angulo
            Case 0 To 89
                tipoangulo = "Agudo."
            Case 90
                tipoangulo = "Recto."
            Case 90 To 179
                tipoangulo = "Obtuso."
            Case 180
                tipoangulo = "LLano."
            Case 181 To 359
                tipoangulo = "Concavo."
            Case Else
                tipoangulo = "Error."
        End Select

        Console.WriteLine("El tipo de angulo ingresado es: " & tipoangulo)
    End Sub
End Module
