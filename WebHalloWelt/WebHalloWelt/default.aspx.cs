﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHalloWelt
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text + ", willkommen auf meiner Webseite!";
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           
                Label1.Text = Convert.ToString(Calendar1.SelectedDate);

            }
    }
}