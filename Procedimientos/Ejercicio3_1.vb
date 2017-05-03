Module Ejercicio3_1

    Sub Main()

        fecha_actual()
        Console.WriteLine("La fecha actual es : {0}", fechaActual)
        Console.ReadKey()

    End Sub
    Sub fecha_actual()
        Console.WriteLine("La fecha actual es : {0}", Date.Now.ToShortDateString)
    End Sub
    Private Function fechaActual() As String
        Return Date.Now.ToShortTimeString
    End Function
End Module
