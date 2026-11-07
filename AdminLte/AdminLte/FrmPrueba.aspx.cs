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
  public partial class FrmPrueba : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        Cargar(2, 3, 4, 5);
      }
    }

    private void Cargar(int IdTroneo1, int IdTorneo2, int IdTorneo3, int IdTorneto4)
    {
      TablaDLL.Tabla objTabla = new TablaDLL.Tabla();
      DataView tb = objTabla.TablaAnualx4(IdTroneo1, IdTorneo2, IdTorneo3, IdTorneto4);
      
      Grilla.DataSource = tb;
      Grilla.DataBind();
    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        e.Row.Cells[1].Visible = false;
      }
    }
  }
}
