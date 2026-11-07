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
    private int _colEquipo = -1;

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
      if (e.Row.RowType == DataControlRowType.Header)
      {
        string[] destacadas = { "POS", "EQUIPO", "PTS", "PJ" };
        for (int i = 0; i < e.Row.Cells.Count; i++)
        {
          TableCell cell = e.Row.Cells[i];
          string texto = (cell.Text ?? string.Empty).Trim().ToUpperInvariant();
          if (Array.IndexOf(destacadas, texto) >= 0)
          {
            cell.CssClass = (cell.CssClass + " col-destacada").Trim();
          }
          if (texto == "EQUIPO")
          {
            _colEquipo = i;
            cell.CssClass = (cell.CssClass + " col-equipo").Trim();
          }
        }
      }

      if (e.Row.RowType == DataControlRowType.DataRow && _colEquipo >= 0 && _colEquipo < e.Row.Cells.Count)
      {
        e.Row.Cells[_colEquipo].CssClass = (e.Row.Cells[_colEquipo].CssClass + " col-equipo").Trim();
      }

      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        e.Row.Cells[1].Visible = false;
      }
    }
  }
}
