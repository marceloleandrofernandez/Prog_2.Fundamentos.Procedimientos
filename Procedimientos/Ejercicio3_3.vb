Module Ejercicio3_3
    Sub main()
        Dim num As Integer
        Console.WriteLine("Ingrese un Valor:")
        num = Console.ReadLine
        For x = 1 To 5 Step 1
            Console.WriteLine("La potencia de {0} elevado a la {1} es : {2}", num, x + 1, potencias(num, x + 1))
        Next
        Console.ReadKey()
    End Sub
    Private Function potencias(num As Integer, expo As Integer) As Integer

        Return num ^ expo
    End Function

End Module
