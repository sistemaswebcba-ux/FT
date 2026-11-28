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
  public partial class FrmPartido : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        CargarTorneo();
      }
    }

    private void CargarTorneo ()
    {
      Torneo obj = new Torneo();
      DataTable trdo = obj.TorneoAll();
      CmbTorneo.DataSource = trdo;
      CmbTorneo.DataValueField = "IdTorneo";
      CmbTorneo.DataTextField = "Torneo";
      CmbTorneo.DataBind();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {

      CargarPartido();
    }

    private void CargarPartido()
    {
      int IdTorneo = 0;
      int Fecha = 0;
      IdTorneo = Convert.ToInt32(CmbTorneo.SelectedValue);
      Fixture Fix = new Fixture();
      Fecha = Convert.ToInt32(txtFecha.Text);
      DataTable trdo = Fix.FixtureGetbyFecha(IdTorneo, Fecha);
      Grilla.DataSource = trdo;
      Grilla.DataBind();
      int Jugo = 0;
      foreach (GridViewRow row in Grilla.Rows)
      {

        TextBox txtGl = row.FindControl("txtgl") as TextBox;
        TextBox txtGv = row.FindControl("txtgv") as TextBox;
        Label lblgl = row.FindControl("lblgl") as Label;
        Label lblgv = row.FindControl("lblgv") as Label;
        TextBox txtNumeroFecha = row.FindControl("txtNumeroFecha") as TextBox;
        Jugo = Convert.ToInt32(row.Cells[8].Text);
        if (Jugo == 1)
        {
          txtGl.Visible = false;
          txtGv.Visible = false;
          lblgl.Text = row.Cells[10].Text;
          lblgv.Text = row.Cells[11].Text;
          txtNumeroFecha.Text = row.Cells[7].Text;

        }
        else
        {
          txtGl.Visible = true;
          txtGv.Visible = true;
          lblgl.Visible = false;
          lblgv.Visible = false;
        }
      }
    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow ||
        e.Row.RowType == DataControlRowType.Header)
      {
      //  e.Row.Cells[0].Visible = false;
        e.Row.Cells[1].Visible = false;
        e.Row.Cells[4].Visible = false;
        e.Row.Cells[10].Visible = false;
        e.Row.Cells[11].Visible = false;
      }
    }

    protected void btnGrabar_Click(object sender, EventArgs e)
    {
      int Graba = 0;
      if (txtUsuario.Text =="pmz" && txtClave.Text =="332211")
      {
        Graba = 1;
      }

      if (Graba ==0)
      {
        lblMensaje.Text = "USUARIO INCORRECTO ";
        return;
      }
      Partido partido = new Partido();    
      int Jugo = 0;
      foreach (GridViewRow row in Grilla.Rows)
      {
        Jugo = Convert.ToInt32(row.Cells[8].Text);
        if (row.RowType != DataControlRowType.DataRow)
        {
          continue;
        }

        TextBox txtNumeroFecha = row.FindControl("txtNumeroFecha") as TextBox;
        TextBox txtGl = row.FindControl("txtgl") as TextBox;
        TextBox txtGv = row.FindControl("txtgv") as TextBox;

        if (txtGl == null || txtGv == null)
        {
          continue;
        }

        string glText = txtGl.Text.Trim();
        string gvText = txtGv.Text.Trim();

        // No se graba un partido si no se cargaron ambos goles.
        if (glText.Length == 0 || gvText.Length == 0)
        {
          continue;
        }

        int idPartido;
        int gl;
        int gv;

        if (!int.TryParse(row.Cells[0].Text.Trim(), out idPartido) ||
            !int.TryParse(glText, out gl) ||
            !int.TryParse(gvText, out gv) ||
            gl < 0 || gv < 0)
        {
          throw new FormatException("Datos invalidos en la fila " + (row.RowIndex + 1).ToString() + ".");
        }

        int pl;
        int pv;
        int ganoL;
        int ganoV;
        int empateL;
        int empateV;
        int perdioL;
        int perdioV;

        if (gl > gv)
        {
          pl = 3;
          pv = 0;
          ganoL = 1;
          ganoV = 0;
          empateL = 0;
          empateV = 0;
          perdioL = 0;
          perdioV = 1;
        }
        else if (gl < gv)
        {
          pl = 0;
          pv = 3;
          ganoL = 0;
          ganoV = 1;
          empateL = 0;
          empateV = 0;
          perdioL = 1;
          perdioV = 0;
        }
        else
        {
          pl = 1;
          pv = 1;
          ganoL = 0;
          ganoV = 0;
          empateL = 1;
          empateV = 1;
          perdioL = 0;
          perdioV = 0;
        }
        /*
        string fechaPartido = string.Empty;
        if (row.Cells.Count > 7)
        {
          fechaPartido = HttpUtility.HtmlDecode(row.Cells[7].Text ?? string.Empty).Trim();
          if (fechaPartido == "&nbsp;")
          {
            fechaPartido = string.Empty;
          }
        }
        */
        
        if (Jugo ==0)
        {
          partido.CargarResultado(
           idPartido,
           gl,
           gv,
           pl,
           pv,
           ganoL,
           ganoV,
           empateL,
           empateV,
           perdioL,
           perdioV,
           txtNumeroFecha.Text);
          // string script = "document.addEventListener('DOMContentLoaded', function () { var tabEl = document.getElementById('tab-tabla'); if (tabEl && window.bootstrap) { bootstrap.Tab.getOrCreateInstance(tabEl).show(); } });";
          // ClientScript.RegisterStartupScript(GetType(), "MostrarTabTabla", script, true);
          // Response.Write("datos grabados correctamnete");
          lblMensaje.Text = "Datos grabados";
          CargarPartido();
        }
      }
    }

        protected void btnGoles_Click(object sender, EventArgs e)
        {
            
        }
    }
}
