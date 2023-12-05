using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            Personas oPersona = new Personas();
            
            oPersona.Id = Convert.ToInt32(TxtId.Text);
            oPersona.Nombre = TxtNombre.Text;
            oPersona.Barrio = TxtBarrio.Text;

            oPersona.grabar();

            Response.Redirect("WebForm1.aspx");
        }
    }
}