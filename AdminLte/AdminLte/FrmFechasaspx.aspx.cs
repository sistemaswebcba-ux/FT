using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TablaDLL;

namespace AdminLte
{
  public partial class FrmFechasaspx : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        int Id = Convert.ToInt32(Request.QueryString["Id"]);
        CargarFechas(Id);
      }
    }

    private void CargarFechas(int Id)
    {
      Torneo tor = new Torneo();
      int MaximaFecha = tor.GetMaxFecha(Id);
    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
  }
}
