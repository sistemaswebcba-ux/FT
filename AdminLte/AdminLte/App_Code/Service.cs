using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public DataTable RetornarTabla(string Sql)
    {
        DataTable trdo = GetDatatable(Sql);
        return trdo;
    }

    [WebMethod]
    public void GrabarDatos(string sql)
    {
        Grabar(sql);
    }

    public string GetCadena()
    {
        //string Cadena = "Data Source = DESKTOP-PICJCLR\\SQLEXPRESS; Initial Catalog =PERFUMES; Integrated Security = True";
        string Cadena = "Data Source=sql2016;Initial Catalog=w370361_FT;User ID=w370361_FT;Password=BUra63gine";
        return Cadena;
    }
    public DataTable GetDatatable(string sql)
    {
        SqlConnection con = new SqlConnection(GetCadena());
        SqlCommand comando = new SqlCommand();
        comando.CommandText = sql;
        comando.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comando;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }

    public  void Grabar(string sql)
    {
        SqlConnection con = new SqlConnection(GetCadena());
        SqlCommand comando = new SqlCommand();
        comando.CommandText = sql;
        comando.Connection = con;
        con.Open();
        comando.ExecuteNonQuery();
        con.Close();
    }


}