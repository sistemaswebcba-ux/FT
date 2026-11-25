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
  public partial class FrmFixture : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        int IdTorneo = Convert.ToInt32(Request.QueryString["IdTorneo"]);
        Fixture fix = new Fixture();
        int Fecha = fix.MaxFecha(IdTorneo);
        CargarFixture(IdTorneo, Fecha);
      }
    }

    private void CargarFixture(int IdTorneo, int Fecha)
    {
      lblFecha.Text = Fecha.ToString();
      Fixture fix = new Fixture();
      DataTable trdo = fix.FixtureGetbyFecha(IdTorneo, Fecha);
      Grilla.DataSource = trdo;
      Grilla.DataBind();
      int TotalFechas = fix.TotalFechas(IdTorneo);
      if (Fecha == TotalFechas)
      {
        btnAtraz.Enabled = false;
      }
      else
      {
        btnAtraz.Enabled = true;
      }

      if (Fecha == 1)
      {
        btnSiguiente.Enabled = false;
      }
      else
      {
        btnSiguiente.Enabled = true;
      }

    }

    protected void btnSiguiente_Click(object sender, ImageClickEventArgs e)
    {
      int Fecha = Convert.ToInt32(lblFecha.Text);
      int IdTorneo = Convert.ToInt32(Request.QueryString["IdTorneo"]);
      Fecha = Fecha - 1;
      CargarFixture(IdTorneo, Fecha);
    }

    protected void btnAtraz_Click(object sender, ImageClickEventArgs e)
    {
      int Fecha = Convert.ToInt32(lblFecha.Text);
      int IdTorneo = Convert.ToInt32(Request.QueryString["IdTorneo"]);
      Fecha = Fecha + 1;
      CargarFixture(IdTorneo, Fecha);

    }
  }
}
