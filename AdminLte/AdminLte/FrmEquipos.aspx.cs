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
  public partial class FrmEquipos : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      int Categoria = Convert.ToInt32(Request.QueryString["Cat"].ToString());
      CargarEquipos(Categoria);
    }

    private void CargarEquipos(Int32 Categoria)
    {
      Equipo eq = new Equipo();
      DataTable t = eq.EquiposGetbyCategoria(Categoria);
      int Cantidad = t.Rows.Count;
      switch (Cantidad)
      {
        case 30:
          Img1.ImageUrl = "~/Imagen/" + t.Rows[0]["Foto"].ToString();
          Img1.CommandArgument = t.Rows[0]["IdEquipo"].ToString();
          Img1.ToolTip = t.Rows[0]["Equipo"].ToString();

          Img2.ImageUrl = "~/Imagen/" + t.Rows[1]["Foto"].ToString();
          Img2.CommandArgument = t.Rows[1]["IdEquipo"].ToString();
          Img2.ToolTip = t.Rows[1]["Equipo"].ToString();

          Img3.ImageUrl = "~/Imagen/" + t.Rows[2]["Foto"].ToString();
          Img3.CommandArgument = t.Rows[2]["IdEquipo"].ToString();
          Img3.ToolTip = t.Rows[2]["Equipo"].ToString();

          Img4.ImageUrl = "~/Imagen/" + t.Rows[3]["Foto"].ToString();
          Img4.CommandArgument = t.Rows[3]["IdEquipo"].ToString();
          Img4.ToolTip = t.Rows[3]["Equipo"].ToString();

          Img5.ImageUrl = "~/Imagen/" + t.Rows[4]["Foto"].ToString();
          Img5.CommandArgument = t.Rows[4]["IdEquipo"].ToString();
          Img5.ToolTip = t.Rows[4]["Equipo"].ToString();

          Img6.ImageUrl = "~/Imagen/" + t.Rows[5]["Foto"].ToString();
          Img6.CommandArgument = t.Rows[5]["IdEquipo"].ToString();
          Img6.ToolTip = t.Rows[5]["Equipo"].ToString();

          Img7.ImageUrl = "~/Imagen/" + t.Rows[6]["Foto"].ToString();
          Img7.CommandArgument = t.Rows[6]["IdEquipo"].ToString();
          Img7.ToolTip = t.Rows[6]["Equipo"].ToString();

          Img8.ImageUrl = "~/Imagen/" + t.Rows[7]["Foto"].ToString();
          Img8.CommandArgument = t.Rows[7]["IdEquipo"].ToString();
          Img8.ToolTip = t.Rows[7]["Equipo"].ToString();

          Img9.ImageUrl = "~/Imagen/" + t.Rows[8]["Foto"].ToString();
          Img9.CommandArgument = t.Rows[8]["IdEquipo"].ToString();
          Img9.ToolTip = t.Rows[8]["Equipo"].ToString();

          Img10.ImageUrl = "~/Imagen/" + t.Rows[9]["Foto"].ToString();
          Img10.CommandArgument = t.Rows[9]["IdEquipo"].ToString();
          Img10.ToolTip = t.Rows[9]["Equipo"].ToString();

          Img11.ImageUrl = "~/Imagen/" + t.Rows[10]["Foto"].ToString();
          Img11.CommandArgument = t.Rows[10]["IdEquipo"].ToString();
          Img11.ToolTip = t.Rows[10]["Equipo"].ToString();

          Img12.ImageUrl = "~/Imagen/" + t.Rows[11]["Foto"].ToString();
          Img12.CommandArgument = t.Rows[11]["IdEquipo"].ToString();
          Img12.ToolTip = t.Rows[11]["Equipo"].ToString();

          Img13.ImageUrl = "~/Imagen/" + t.Rows[12]["Foto"].ToString();
          Img13.CommandArgument = t.Rows[12]["IdEquipo"].ToString();
          Img13.ToolTip = t.Rows[12]["Equipo"].ToString();

          Img14.ImageUrl = "~/Imagen/" + t.Rows[13]["Foto"].ToString();
          Img14.CommandArgument = t.Rows[13]["IdEquipo"].ToString();
          Img14.ToolTip = t.Rows[13]["Equipo"].ToString();

          Img15.ImageUrl = "~/Imagen/" + t.Rows[14]["Foto"].ToString();
          Img15.CommandArgument = t.Rows[14]["IdEquipo"].ToString();
          Img15.ToolTip = t.Rows[14]["Equipo"].ToString();

          Img16.ImageUrl = "~/Imagen/" + t.Rows[15]["Foto"].ToString();
          Img16.CommandArgument = t.Rows[15]["IdEquipo"].ToString();
          Img16.ToolTip = t.Rows[15]["Equipo"].ToString();

          Img17.ImageUrl = "~/Imagen/" + t.Rows[16]["Foto"].ToString();
          Img17.CommandArgument = t.Rows[16]["IdEquipo"].ToString();
          Img17.ToolTip = t.Rows[16]["Equipo"].ToString();

          Img18.ImageUrl = "~/Imagen/" + t.Rows[17]["Foto"].ToString();
          Img18.CommandArgument = t.Rows[17]["IdEquipo"].ToString();
          Img18.ToolTip = t.Rows[17]["Equipo"].ToString();

          Img19.ImageUrl = "~/Imagen/" + t.Rows[18]["Foto"].ToString();
          Img19.CommandArgument = t.Rows[18]["IdEquipo"].ToString();
          Img19.ToolTip = t.Rows[18]["Equipo"].ToString();

          Img20.ImageUrl = "~/Imagen/" + t.Rows[19]["Foto"].ToString();
          Img20.CommandArgument = t.Rows[19]["IdEquipo"].ToString();
          Img20.ToolTip = t.Rows[19]["Equipo"].ToString();

          break;
      }
    }
  }
}
