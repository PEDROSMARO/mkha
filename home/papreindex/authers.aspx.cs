using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;
using System.ServiceModel;
using System.Data;
using System.Web.UI.WebControls.WebParts;

public partial class authers : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        autherview.Visible = false;
        autherresult.Visible = false;
        TableResult.Visible = false;
        getscore.Visible = false;
    }

    protected void search_Click(object sender, EventArgs e)
    {
        string s = searchtxt.Text;
        AutherServiceClient proxy = new AutherServiceClient("IAutherService");
        autherview.DataSource = proxy.Getpapers(s);
        autherview.DataBind();
        txtName.Text = s;
        txtPnunmerofPapers.Text = Convert.ToString(proxy.countpaper(s));
        autherview.Style.Add("Width", "200px");
        autherview.Visible = true; 
        autherresult.Visible = true;
        getscore.Visible = true;

     
    }

    protected void getscore_Click(object sender, EventArgs e)
    {
        string s = searchtxt.Text;
        AutherServiceClient pro = new AutherServiceClient("IAutherService");

        TxtScoresbyyear.Text = Convert.ToString(pro.scorepapersbyyear(s));
        Txtscorebyorder.Text = Convert.ToString(pro.scorepapersbyorder(s));
        Txtscorebyjclass.Text = Convert.ToString(pro.scorepapersbyjournalclass(s));
        Fullscore.Text = Convert.ToString(pro.scorepapersbyyear(s) + pro.scorepapersbyorder(s) + pro.scorepapersbyjournalclass(s));

        TableResult.Visible = true;
        autherview.Visible = true;
        autherresult.Visible = true;
    }


}