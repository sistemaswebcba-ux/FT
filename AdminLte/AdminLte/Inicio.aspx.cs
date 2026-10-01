using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TablaDLL;
using System.Data;

namespace AdminLte
{
  public partial class Inicio : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string Id = Request.QueryString["Id"].ToString();
      if (Id !="")
      {
        Cargar(Convert.ToInt32(Id));
      }
      
    }

    public void Cargar(int IdTorneo)
    {
      TablaDLL.Tabla objTabla = new TablaDLL.Tabla();
      DataView tb = objTabla.TablaGral(IdTorneo);

      Gridlla.DataSource = tb;
      Gridlla.DataBind();
    }

    protected void Gridlla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        e.Row.Cells[1].Visible = false;
        // Validamos que el índice exista en la fila actual para evitar errores
      /*
       * if (e.Row.Cells.Count > indiceColumna)
        {
         
        }
      */
      }
    }
  }
}
