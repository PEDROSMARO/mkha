using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contectus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Addjou_Click(object sender, EventArgs e)
    {
        Response.Redirect("addjournal.aspx");
    }

    protected void Deletejou_Click(object sender, EventArgs e)
    {
        Response.Redirect("deljournal.aspx");
    }

    protected void Modifyjou_Click(object sender, EventArgs e)
    {
        Response.Redirect("modifajournal.aspx");
    }

    protected void Retrivejou_Click(object sender, EventArgs e)
    {
        Response.Redirect("retjournal.aspx");
    }
}