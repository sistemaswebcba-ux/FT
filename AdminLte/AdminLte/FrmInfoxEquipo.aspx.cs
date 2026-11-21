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
  public partial class FrmInfoxEquipo : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
      {
        Cargar();
      }
    }

    public string Ruta { get; set; }

    private void Cargar ()
    {
       int IdTorneo =Convert.ToInt32 (Request.QueryString["IdTorneo"].ToString());
       int IdEquipo = Convert.ToInt32(Request.QueryString["IdEquipo"].ToString());
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
  }
}
