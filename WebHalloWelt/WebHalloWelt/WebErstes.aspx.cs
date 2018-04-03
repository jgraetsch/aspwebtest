using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHalloWelt
{
    public partial class WebErstes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x, y, z;
            x = 5;
            y = 12;
            z = x + y;
            ergebnis.InnerText = "Ergebnis: " + z;
        }
    }
}