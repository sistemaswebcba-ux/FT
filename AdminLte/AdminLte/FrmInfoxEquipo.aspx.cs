using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using TablaDLL;

namespace AdminLte
{
  public partial class FrmInfoxEquipo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
          int IdTorneo = Convert.ToInt32(Request.QueryString["IdTorneo"].ToString());
          int IdEquipo = Convert.ToInt32(Request.QueryString["IdEquipo"].ToString());
          Cargar(IdTorneo, IdEquipo);
          CargarResumen(IdTorneo, IdEquipo);
      }
    }

    public string Ruta { get; set; }

    private void Cargar (int IdTorneo, int IdEquipo)
    {
       
       Tabla obj = new Tabla();
       DataTable trdo = obj.TablaResumida(IdTorneo, IdEquipo);
       Grilla.DataSource = trdo;
       Grilla.DataBind();
       CargarEquipo();
    }

    private void CargarEquipo()
    {
       int IdEquipo = Convert.ToInt32(Request.QueryString["IdEquipo"].ToString());
       Equipo eq = new Equipo();
       DataTable teq = eq.EquipoGetbyId(IdEquipo);
       if (teq.Rows.Count > 0)
       {
          lblEquipo.Text = teq.Rows[0]["Equipo"].ToString();
          string foto = teq.Rows[0]["Foto"]?.ToString();
          if (!string.IsNullOrEmpty(foto))
          {
             Ruta = "~/Imagen/" + foto;
             ImgEquipo.ImageUrl = Ruta;
          }
       }
    }

    private void CambiarTituloPor (DataTable tb)
    {
      if (tb != null && tb.Columns.Contains("POR"))
      {
        tb.Columns["POR"].ColumnName = "%";
      }
    }

    private void CargarResumen (int IdTorneo, int IdEquipo)
    {
      Tabla obj = new Tabla();
      DataTable trdo = obj.GetResumenLocal(IdTorneo, IdEquipo);
      CambiarTituloPor(trdo);
      GrillaLocal.DataSource = trdo;
      GrillaLocal.DataBind();
      DataTable trdo2 = obj.GetResumenVisitante(IdTorneo, IdEquipo);
      CambiarTituloPor(trdo2);
      GrillaVisitantes.DataSource = trdo2;
      GrillaVisitantes.DataBind();
      Resumen objResumen = new Resumen();
      DataTable tbLocal = objResumen.GetResumenxEquipoLocal(IdEquipo, IdTorneo);
      DataTable tbVisitante = objResumen.GetResumenxEquipoVisitante(IdEquipo, IdTorneo);
      DataView tbGeneral = obj.GetResumenGeneral(tbLocal, tbVisitante);
      CambiarTituloPor(tbGeneral.Table);
      GrillaGeneral.DataSource = tbGeneral;
      GrillaGeneral.DataBind();
      /*
      DataTable tb = new DataTable();
      tb.Columns.Add("RESULTADO");
      tb.Columns.Add("FRECUENCIA");
      tb.Columns.Add("VEP");
      tb.Columns.Add("POR");
      int gf = 0, gc = 0, dif = 0, can = 0;
      Double  por = 0;
      string vep = "";
      Resumen obj = new Resumen();
      DataTable tbLocal = obj.GetResumenxEquipoLocal(IdEquipo, IdTorneo);
      int TotalPartidos = 0;
      for (int i = 0; i < tbLocal.Rows.Count ; i++)
      {
        TotalPartidos = TotalPartidos + Convert.ToInt32 (tbLocal.Rows[i]["can"]); 
      }

      for (int i = 0; i < tbLocal.Rows.Count; i++)
      {
        DataRow r = tb.NewRow();
        gf = Convert.ToInt32(tbLocal.Rows[i]["gl"]);
        gc = Convert.ToInt32(tbLocal.Rows[i]["gv"]);
        dif = gf - gc;
        r[0] = tbLocal.Rows[i]["gl"].ToString() + " - " + tbLocal.Rows[i]["gv"].ToString();
        r[1] = tbLocal.Rows[i]["can"].ToString(); 
        can = Convert.ToInt32(tbLocal.Rows[i]["can"]);
        if (dif == 0)
          vep = "Empate";
        if (dif > 0)
          vep = "Ganó";
        if (dif < 0)
          vep = "Perdío";
        r[2] = vep;
        por = (can * 100 / TotalPartidos );
        r[3] = por;
        tb.Rows.Add(r);

      }
      GrillaLocal.DataSource = tb;
      GrillaLocal.DataBind();
      */
    }
  }
}
