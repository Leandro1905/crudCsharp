using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(DropDownList1.SelectedValue);
            int ciclo = 1;

            string sapito = "";

            while(ciclo < 11)
            {
                // sapito += "<h2>" + valor + " X " + ciclo + " = " + valor * ciclo + "</h2>";

                sapito += $"<h2>{valor} X {ciclo} = {valor*ciclo}</h2>";

                ciclo++;
            }

            LaTabla.InnerHtml = sapito;

        }
    }
}