Module Ejercicio3_4
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Do
            Console.WriteLine("Ingrese Lado A: ")
            a = Console.ReadLine
        Loop Until valido(a)
        Do
            Console.WriteLine("Ingrese Lado B: ")
            b = Console.ReadLine
        Loop Until valido(b)
        Console.WriteLine("El cuadrado de la hipotenusa es {0}", hipotenusa(a, b))

        Console.ReadKey()

    End Sub
    Private Function valido(N As Integer) As Boolean
        If N > 0 and N == int(N) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function hipotenusa(A As Integer, B As Integer) As Integer

        Return (A ^ 2) + (B ^ 2)
    End Function
End Module
