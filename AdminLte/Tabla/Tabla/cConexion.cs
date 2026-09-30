using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabla
{
    public class cConexion
    {
        public static string GetConexion()
        {
            //SISTEMA PERFUMES DESKTOP-TRC4UMG
            // string cadena = "Data Source=DESKTOP-TRC4UMG;Initial Catalog=SISTEMA;Integrated Security=True;TrustServerCertificate=True;";
            //  string cadena = "Data Source=DESKTOP-TRC4UMG;Initial Catalog=PERFUMES;Integrated Security=True;TrustServerCertificate=True;";
            //cad = "Data Source=localhost;Initial Catalog=w1361197_FT;Integrated Security=SSPI;"
         //   string cadena = "Data Source=sql2016;Initial Catalog=w370361_FT;User ID=w370361_FT;Password=BUra63gine";
            //nueva cadena de conexion   
              string cadena = "Data Source=DESKTOP-PICJCLR\\SQLEXPRESS;Initial Catalog=ft;Integrated Security=True";

            return cadena;
        }
    }
}
