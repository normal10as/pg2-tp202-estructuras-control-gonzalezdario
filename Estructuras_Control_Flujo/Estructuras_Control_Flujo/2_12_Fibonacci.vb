Module Fibonacci
    Dim cant As Byte = 0
    Dim a As Integer = 0
    Dim b As Integer = 1

    Sub Main()
        Console.WriteLine("Secuencia Fibonacci---------")
        Do
            Console.WriteLine(a)
            Console.WriteLine(b)
            cant += 1
            a = a + b
            b = b + a
        Loop While cant <= 20
    End Sub
End Module
