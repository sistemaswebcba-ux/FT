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
        CargarFixture(IdTorneo);
      }
    }

    private void CargarFixture(int IdTorneo)
    {
      Fixture fix = new Fixture();
      int Fecha = fix.MaxFecha(IdTorneo);
      DataTable trdo = fix.FixtureGetbyFecha(IdTorneo, Fecha);
      Grilla.DataSource = trdo;
      Grilla.DataBind();

    }
  }
}
