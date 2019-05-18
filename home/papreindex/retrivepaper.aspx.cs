using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class retrivepaper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

      

    protected void Vertpagebyid_Click(object sender, EventArgs e)
    {
        Response.Redirect("retrivebyid.aspx");
    }

    protected void Vertpagebytitle_Click(object sender, EventArgs e)
    {
        Response.Redirect("retrivebytitle.aspx");
    }
}