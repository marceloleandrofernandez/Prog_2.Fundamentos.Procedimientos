Module Ejercicio3_2
    Sub main()
        Dim fecha As Date
        Dim dias As Integer

        Console.WriteLine("Ingrese una fecha")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese dias a sumar")
        dias = Console.ReadLine
        Console.WriteLine("La nueva fecha es: {0}", sumarDias(fecha, dias))
        Console.ReadKey()

    End Sub
    Private Function sumarDias(fecha As Date, dias As Integer) As String
        Return fecha.AddDays(dias).ToShortDateString
    End Function
End Module
