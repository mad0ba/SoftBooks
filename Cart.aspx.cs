﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment.aspx");
    }
    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void update_quan(object sender, EventArgs e)
    {
       // Purchases obj = null;

       
        //obj.updateQuan( Convert.ToInt16(((TextBox)FindControl("PurchaseIdLabel1")).Text));
    }
}