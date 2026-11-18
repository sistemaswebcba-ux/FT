using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TablaDLL;

namespace AdminLte
{                     //FrmTabla?Id=2
  public partial class FrmTabla : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        int Id = Convert.ToInt32(Request.QueryString["Id"]);
        string Tipo = Request.QueryString["t"].ToString();
        CargarNombreTorneo(Id,Tipo);
        CargarTabla(Id,Tipo);
      }
    }

    private void CargarTabla(Int32 Id, string Tipo)
    {
      Tabla obj = new Tabla();
      switch(Tipo)
      {
        case "a":
          DataView tb = obj.TablaGral(Id);
          Grilla.DataSource = tb;
          Grilla.DataBind();
          break;
        case "l":
          DataTable tl = obj.CargarTablaL(Id);
          Grilla.DataSource = tl;
          Grilla.DataBind();
          break;
        case "v":
          DataTable tv = obj.CargarTablaV(Id);
          Grilla.DataSource = tv;
          Grilla.DataBind();
          break;
      }
     
    }

    private void CargarNombreTorneo(Int32 Id, string Tipo)
    {
      Torneo obj = new Torneo();
      DataTable trdo = obj.TorneoGetbyId(Id);
      String Nombre = "";
      string Categoria = "";
      string NombreTorneo = "";
      if (trdo.Rows.Count >0)
      {
        Nombre = trdo.Rows[0]["Torneo"].ToString();
        Categoria = trdo.Rows[0]["Temporada"].ToString();
        NombreTorneo = Nombre + " " + Categoria;
        
      }

      switch(Tipo)
      {
        case "a":
          NombreTorneo = NombreTorneo + " Tabla Anual"; 
          break;
        case "l":
          NombreTorneo = NombreTorneo + " Tabla Locales";
          break;
        case "v":
          NombreTorneo = NombreTorneo + " Tabla Visitantes";
          break;
      }
      lblTorneo.Text = NombreTorneo;

    }

    protected void Grilla_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
      {
        // Ocultar IdEquipo (columna 1)
        if (e.Row.Cells.Count > 1)
          e.Row.Cells[1].Visible = false;

        // Alinear a la izquierda la columna EQUIPO (encabezado y celdas)
        for (int i = 0; i < e.Row.Cells.Count; i++)
        {
          string headerText = "";
          if (e.Row.RowType == DataControlRowType.Header)
          {
            headerText = e.Row.Cells[i].Text.ToLower();
          }
          else if (Grilla.HeaderRow != null && Grilla.HeaderRow.Cells.Count > i)
          {
            headerText = Grilla.HeaderRow.Cells[i].Text.ToLower();
          }

          if (headerText.Contains("equipo") && headerText != "idequipo")
          {
            e.Row.Cells[i].HorizontalAlign = HorizontalAlign.Left;
            e.Row.Cells[i].Style["text-align"] = "left";
          }
        }
      }
    }
  }
}
