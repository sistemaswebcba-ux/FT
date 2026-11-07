using System;
using System.Web.UI;

namespace AdminLte.dist.forms
{
    public partial class Master2 : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // CurrentYear.Text = DateTime.Now.Year.ToString();
            }
        }
    }
}
