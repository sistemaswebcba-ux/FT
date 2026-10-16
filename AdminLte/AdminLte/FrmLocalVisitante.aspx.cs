using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TablaDLL;

namespace AdminLte
{
  public partial class FrmLocalVisitante : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        string Tipo = Request.QueryString["Tipo"].ToString();
        int Categoria = Convert.ToInt16(Request.QueryString["Cat"]);
        string Temporada = Request.QueryString["Temp"].ToString();
        Cargar(Tipo, Categoria, Temporada);
      }
    }

    private void Cargar(string Tipo,int Categoria, string Temporada)
    {
      Tabla tbFianl = new Tabla();
      Torneo tor = new Torneo();
      DataTable tb = tor.GetTorneoxTemporada(Categoria, Temporada);
      int can = tb.Rows.Count;
      int IdTorneo1=0, IdTorneo2=0, IdTorneo3=0, IdTorneo4=0;
      switch (can)
      {
        case 4:
          DataView trdo;
          IdTorneo1 = Convert.ToInt32(tb.Rows[0]["IdTorneo"]);
          IdTorneo2 = Convert.ToInt32(tb.Rows[1]["IdTorneo"]);
          IdTorneo3 = Convert.ToInt32(tb.Rows[2]["IdTorneo"]);
          IdTorneo4 = Convert.ToInt32(tb.Rows[3]["IdTorneo"]);
          if (Tipo =="l")
          {
            lblTabla.Text = "Tabla de Locales ";
            trdo = tbFianl.CargarTablaLocalx4(IdTorneo1, IdTorneo2, IdTorneo3, IdTorneo4);
          }
          else
          {
            lblTabla.Text = "Tabla de Visitantes ";
            trdo = tbFianl.CargarTablaVisitantex4(IdTorneo1, IdTorneo2, IdTorneo3, IdTorneo4);
          }
           
          Gridlla.DataSource = trdo;
          Gridlla.DataBind();
          break;
      }
    }

    protected void Gridlla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
          e.Row.Cells[1].Visible = false;
      }
    }
  }
}
