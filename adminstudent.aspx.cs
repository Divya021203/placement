﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace CAMPUS
{
    public partial class adminstudent : System.Web.UI.Page
        
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("studreg.aspx");
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("updatestudent.aspx");
        }
    }
}