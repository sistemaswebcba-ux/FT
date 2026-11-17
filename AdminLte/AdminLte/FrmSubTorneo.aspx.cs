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
  public partial class FrmSubTorneo : System.Web.UI.Page
  {
    private int _grilla2EquipoColIndex = -1;

    protected void Page_Load(object sender, EventArgs e)
    {
       if (!IsPostBack)
      {
        int Id = Convert.ToInt32(Request.QueryString["Id"]);
        CargarEquipos(Id);
      }
    }

    private void CargarEquipos(int IdTorneo)
    {
      Equipo eq = new Equipo();
      DataTable trdo = eq.EquiposGetbyEquiposxTorneo(IdTorneo);
      Grilla.DataSource = trdo;
      Grilla.DataBind();
    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        if (e.Row.Cells.Count > 1)
          e.Row.Cells[1].Visible = false;

        if (e.Row.Cells.Count > 2)
        {
          e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Left;
          e.Row.Cells[2].CssClass = (e.Row.Cells[2].CssClass + " text-start").Trim();
        }
      }
    }

    protected void Grilla2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.Header)
      {
        if (e.Row.Cells.Count > 0)
          e.Row.Cells[0].Visible = false;

        for (int i = 0; i < e.Row.Cells.Count; i++)
        {
          if (string.Equals(e.Row.Cells[i].Text, "Equipo", StringComparison.OrdinalIgnoreCase))
          {
            _grilla2EquipoColIndex = i;
            e.Row.Cells[i].HorizontalAlign = HorizontalAlign.Left;
            e.Row.Cells[i].CssClass = (e.Row.Cells[i].CssClass + " text-start").Trim();
            break;
          }
        }
      }
      else if (e.Row.RowType == DataControlRowType.DataRow)
      {
        if (e.Row.Cells.Count > 0)
          e.Row.Cells[0].Visible = false;

        if (_grilla2EquipoColIndex >= 0 && _grilla2EquipoColIndex < e.Row.Cells.Count)
        {
          e.Row.Cells[_grilla2EquipoColIndex].HorizontalAlign = HorizontalAlign.Left;
          e.Row.Cells[_grilla2EquipoColIndex].CssClass = (e.Row.Cells[_grilla2EquipoColIndex].CssClass + " text-start").Trim();
        }
      }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
      int IdTorneo = 0;
      IdTorneo = Convert.ToInt32(Request.QueryString["Id"]);
      int Can = 0;
      foreach (GridViewRow Fila in Grilla.Rows)
      {
        CheckBox chk = Fila.FindControl("chk") as CheckBox;
        if (chk != null && chk.Checked)
          Can++;
      }

      if (Can == 0)
      {
        ClientScript.RegisterStartupScript(GetType(), "SinSeleccion", "alert('Debe seleccionar un equipo');", true);
        return;
      }

      int[] Vec = new int[Can];
      int i = 0;
      foreach (GridViewRow Fila in Grilla.Rows)
      {
        CheckBox chk = Fila.FindControl("chk") as CheckBox;
        if (chk != null && chk.Checked)
        {
          Vec[i] = Convert.ToInt32(Fila.Cells[1].Text);
          i++;
        }
         
      }

      Tabla obj = new Tabla();
      DataTable tb = obj.MiniTorneos(Vec, Can, IdTorneo);

      if (tb != null)
      {
        for (int j = 0; j < tb.Rows.Count; j++)
        {
          tb.Rows[j]["Pos"] = j + 1;
        }

        _grilla2EquipoColIndex = -1;
        Grilla2.DataSource = tb;
        Grilla2.DataBind();
      }

      string script = "document.addEventListener('DOMContentLoaded', function () { var tabEl = document.getElementById('tab-tabla'); if (tabEl && window.bootstrap) { bootstrap.Tab.getOrCreateInstance(tabEl).show(); } });";
      ClientScript.RegisterStartupScript(GetType(), "MostrarTabTabla", script, true);
    }


  }
}
