using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // zona.InnerText = "CUIDADO CON EL PERRITO";
            // zona.InnerHtml = "<h1>CUIDADO CON EL PERRITO</h1>";
            string html = "";
            int i = 1;
            while(i<11)
            {
                html += i + "<br>";
                i++;
            }
            zona.InnerHtml = html;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] frutas = {"UVA", "PERA", "SANDIA", "NARANJA", "MANZANA" };
            string html = "";

            html += "<h1>MIS FRUTAS PREFERIDAS</h1>";
            html += "<ul>";
          
            foreach(string fruta in frutas)
            {
                html += "<li>" + fruta;
            }
            html += "</ul>";

            zona.InnerHtml = html;

        }
    }
}