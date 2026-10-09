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
  public partial class FrmInfo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        Cargar();
      }
    }

    private void Cargar()
    {
      int IdTorneo  = 0;
      string NombreTorneo = "";
      Tabla objTabla = new Tabla();
      int IdEquipo = Convert.ToInt32(Request.QueryString["IdEquipo"]);
      string Temp = Request.QueryString["Temp"].ToString();
      Equipo eq = new Equipo();
      DataTable trdo = eq.EquipoGetbyId(IdEquipo);
      if (trdo.Rows.Count >0)
      {
        lblEquipo.Text = trdo.Rows[0]["Equipo"].ToString(); 
        IMG.ImageUrl = "~/Imagen/" + trdo.Rows[0]["Foto"].ToString();     
      }

      //Debo usar este meotdo GetTorneoxEquipoyTemporada
      //trae los torneos por equipo y temporada
      Torneo tor = new Torneo();
      DataTable tbTorneo = tor.GetTorneoxEquipoyTemporada(IdEquipo, Temp);
      if (tbTorneo.Rows.Count >0)
      {
        int can = tbTorneo.Rows.Count;
        switch(can)
        {
          case 1:
            IdTorneo = Convert.ToInt32(tbTorneo.Rows[0]["IdEquipo"]);
            NombreTorneo = tbTorneo.Rows[0]["Torneo"].ToString();
            DataTable tbTabla = objTabla.TablaResumida(IdTorneo, IdEquipo);
            Grilla1.DataSource = tbTabla;
            Grilla1.DataBind();
            break;
          case 2:
            IdTorneo = Convert.ToInt32(tbTorneo.Rows[0]["IdTorneo"]);
            NombreTorneo = tbTorneo.Rows[0]["Torneo"].ToString();
            lblTorneo1.Text = NombreTorneo;
            DataTable tbTabla2 = objTabla.TablaResumida(IdTorneo, IdEquipo);
            Grilla1.DataSource = tbTabla2;
            Grilla1.DataBind();
            //Cargo la 2 grilla
            IdTorneo = Convert.ToInt32(tbTorneo.Rows[1]["IdTorneo"]);
            NombreTorneo = tbTorneo.Rows[1]["Torneo"].ToString();
            lblTorneo2.Text = NombreTorneo;
            DataTable tbTabla3 = objTabla.TablaResumida(IdTorneo, IdEquipo);
            Grilla2.DataSource = tbTabla3;
            Grilla2.DataBind();
            break;
        }
      }
      /*
      Tabla tb = new Tabla();
      DataTable tresul = tb.TablaResumida(Id1, IdEquipo);
      if (tresul.Rows.Count >0 )
      {
        Grilla1.DataSource = tresul;
        Grilla1.DataBind();
      }
      */


    }

    protected void Grilla1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        e.Row.Cells[1].Visible = false;
      }
    }

    protected void Grilla2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        e.Row.Cells[1].Visible = false;
      }
    }
  }
}
