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
  public partial class FrmTablaAnual : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      int IdTorneo1 = Convert.ToInt32(Request.QueryString["Id1"].ToString());
      int IdTorneo2 = Convert.ToInt32(Request.QueryString["Id2"].ToString());
      int IdTorneo3 = Convert.ToInt32(Request.QueryString["Id3"].ToString());
      int IdTorneo4 = Convert.ToInt32(Request.QueryString["Id4"].ToString());
      Cargar(IdTorneo1, IdTorneo2, IdTorneo3, IdTorneo4);
    }

    private void Cargar (int IdTroneo1, int IdTorneo2, int IdTorneo3, int IdTorneto4)
    {
      TablaDLL.Tabla objTabla = new TablaDLL.Tabla();
      DataView tb = objTabla.TablaAnualx4(IdTroneo1, IdTorneo2, IdTorneo3, IdTorneto4);

      Gridlla.DataSource = tb;
      Gridlla.DataBind();
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
