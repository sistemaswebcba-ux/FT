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
  public partial class FrmFechas : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        int Id = Convert.ToInt32(Request.QueryString["Id"]);
        CargarNombreTorneo(Id);
        CargarFechas(Id);
      }
    }

    private void CargarNombreTorneo(Int32 Id)
    {
      Torneo obj = new Torneo();
      System.Data.DataTable trdo = obj.TorneoGetbyId(Id);
      string NombreTorneo = "";
      if (trdo.Rows.Count > 0)
      {
        string Nombre = trdo.Rows[0]["Torneo"].ToString();
        string Categoria = trdo.Rows[0]["Temporada"].ToString();
        NombreTorneo = Nombre + " " + Categoria;
      }
      lblTorneo.Text = NombreTorneo;
    }

    private void CargarFechas(int Id)
    {
      Torneo tor = new Torneo();
      int MaximaFecha = tor.GetMaxFecha(Id);
      CmbFechaDesde.Items.Clear();
      CmbFechaHasta.Items.Clear();
      if (MaximaFecha >= 1)
      {
        for (int i = 1; i <= MaximaFecha; i++)
        {
          CmbFechaDesde.Items.Add(new ListItem(i.ToString(), i.ToString()));
          CmbFechaHasta.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
        if (CmbFechaDesde.Items.Count > 0)
          CmbFechaDesde.SelectedIndex = 0;
        if (CmbFechaHasta.Items.Count > 0)
          CmbFechaHasta.SelectedIndex = CmbFechaHasta.Items.Count - 1;
      }
      else
      {
        for (int i = 1; i <= 1; i++)
        {
          CmbFechaDesde.Items.Add(new ListItem(i.ToString(), i.ToString()));
          CmbFechaHasta.Items.Add(new ListItem(i.ToString(), i.ToString()));
        }
      }
    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.Header)
      {
        for (int i = 0; i < e.Row.Cells.Count; i++)
        {
          string headerText = e.Row.Cells[i].Text.ToLower();
          if (headerText.Contains("equipo"))
          {
            e.Row.Cells[i].HorizontalAlign = HorizontalAlign.Left;
            e.Row.Cells[i].Style["text-align"] = "left";
          }
          if (headerText == "idequipo")
          {
            e.Row.Cells[i].Visible = false;
          }
        }
      }
      else if (e.Row.RowType == DataControlRowType.DataRow)
      {
        for (int i = 0; i < e.Row.Cells.Count; i++)
        {
          if (Grilla.HeaderRow != null && Grilla.HeaderRow.Cells.Count > i)
          {
            string headerText = Grilla.HeaderRow.Cells[i].Text.ToLower();
            if (headerText.Contains("equipo"))
            {
              e.Row.Cells[i].HorizontalAlign = HorizontalAlign.Left;
              e.Row.Cells[i].Style["text-align"] = "left";
            }
            if (headerText == "idequipo")
            {
              e.Row.Cells[i].Visible = false;
            }
          }
        }
      }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
      int Id = Convert.ToInt32(Request.QueryString["Id"]);
      int fechaDesde = 0;
      int fechaHasta = 0;
      Tabla obj = new Tabla();
      
      if (int.TryParse(CmbFechaDesde.SelectedValue, out fechaDesde) && int.TryParse(CmbFechaHasta.SelectedValue, out fechaHasta))
      {
        DataView dt = obj.cargarporfechas(Id, fechaDesde, fechaHasta);
        Grilla.DataSource = dt;
        Grilla.DataBind();
        CargarNombreTorneoConFechas(Id, fechaDesde, fechaHasta);
          // Valores seleccionados: fechaDesde y fechaHasta
      }
    }

    private void CargarNombreTorneoConFechas(Int32 Id,int Desde,int Hasta)
    {
      Torneo obj = new Torneo();
      System.Data.DataTable trdo = obj.TorneoGetbyId(Id);
      string NombreTorneo = "";
      string Poiciones = "Posiciones entre la fecha " + Desde.ToString() + " y " + Hasta.ToString();
      if (trdo.Rows.Count > 0)
      {
        string Nombre = trdo.Rows[0]["Torneo"].ToString();
        string Categoria = trdo.Rows[0]["Temporada"].ToString();
        NombreTorneo = Nombre + " " + Categoria;
      }
      lblTorneo.Text = NombreTorneo + " " + Poiciones;
    }
  }
}
