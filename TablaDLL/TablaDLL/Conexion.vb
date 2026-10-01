Public Class Conexion

    Public Function Cadena() As String
        Dim cad As String = "" '
        ' string Cadena = "Data Source=sql2016;Initial Catalog=w370361_FT;User ID=w370361_FT;Password=BUra63gine";

        'Initial Catalog=DGAUTOS;User ID=sa;Password=123
        'cad = "Data Source=localhost;Initial Catalog=w1361197_FT;Integrated Security=SSPI;"
        ' servidor Web 2 don weebb la que funciona
        cad = "Data Source=sql2016;Initial Catalog=w370361_FT;User ID=w370361_FT;Password=BUra63gine"
        ' servidor web
        '  cad = "Data Source=localhost;Initial Catalog=w370361_FT;User ID=w370361_FT;Password=BUra63gine"
        '  ' local sql 2014
        'cad = "Data Source=DESKTOP-PICJCLR\SQLEXPRESS;Initial Catalog=ft;Integrated Security=True"

        '   local sql 2022
        'cad = "Data Source=DESKTOP-PICJCLR\SQLEXPRESS01;Initial Catalog=CopiaFt;Integrated Security=True"
        Return cad
    End Function

End Class
