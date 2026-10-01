Public Class Conexion

    Public Function Cadena() As String
        Dim cad As String = ""
        'cad = "Data Source=localhost;Initial Catalog=w1361197_FT;Integrated Security=SSPI;"
        cad = "Data Source=localhost\sqlexpress;Initial Catalog=FT;Integrated Security=True"
        Return cad
    End Function

End Class
