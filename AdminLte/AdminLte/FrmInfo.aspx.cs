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
      int Id1 = Convert.ToInt32(Request.QueryString["Id1"]);
      int IdEquipo = Convert.ToInt32(Request.QueryString["IdEquipo"]);
      Equipo eq = new Equipo();
      DataTable trdo = eq.EquipoGetbyId(IdEquipo);
      if (trdo.Rows.Count >0)
      {
        IMG.ImageUrl = "~/Imagen/" + trdo.Rows[0]["Foto"].ToString();     
      }

      Tabla tb = new Tabla();
      DataTable tresul = tb.TablaResumida(Id1, IdEquipo);


    }
  }
}
