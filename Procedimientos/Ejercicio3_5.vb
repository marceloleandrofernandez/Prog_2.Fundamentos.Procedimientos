Module Ejercicio3_5
    Sub main()
        Dim radio As Integer
        Dim altura As Integer

        Console.WriteLine("Ingrese el radio de la base ")
        radio = Console.ReadLine
        Console.WriteLine("Ingrese la altura del cilindro")
        altura = Console.ReadLine
        Console.WriteLine("El volumen del cilindro es :{0}", volumen(radio, altura))
        Console.ReadKey()
    End Sub
    Private Function volumen(rad As Integer, alt As Integer) As Double
        Return Math.PI * rad ^ 2 * alt
    End Function
End Module
