using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Tabla
{
    public class cDb
    {
        public static DataTable GetDatatable(string sql)
        {
            SqlConnection con = new SqlConnection(cConexion.GetConexion());
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comando;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
