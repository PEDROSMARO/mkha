using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Papers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Vertpage_Click(object sender, EventArgs e)
    {
        Response.Redirect("vertpaper.aspx");
    }

    protected void Addpage_Click(object sender, EventArgs e)
    {
        Response.Redirect("addpaper.aspx");
    }

    protected void Deletepager_Click(object sender, EventArgs e)
    {
        Response.Redirect("deletepaper.aspx");
    }

    protected void Modifypage_Click(object sender, EventArgs e)
    {
        Response.Redirect("modifypaper.aspx");
    }

    protected void Retrivepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("retrivepaper.aspx");
    }


}