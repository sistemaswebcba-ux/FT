using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AdminLte
{
  public partial class Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

      string Url = "FrmFixture.aspx?IdTorneo=2";
      Response.Redirect(Url);
      //Response.Redirect("Inicio.aspx?Id=2");
    }
  }
}
