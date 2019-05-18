using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization;
using sharedlib;

public partial class modifypaper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        paperupdate.Visible = false;
        paperupdate.Enabled = false;
        lblResult.Visible = false;
        errorresult.Visible = false;
        paperresult.Visible = false;

    }


  
    

     protected void search_Click(object sender, EventArgs e)
    {

        papershare showpap = new papershare();

        int p = int.Parse(searchtxt.Text);
        HttpChannel chn5 = new HttpChannel();
        ChannelServices.RegisterChannel(chn5, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");

        showpap = serve.retrivepaper(p);





        txtPJtitle.Text = showpap.JTitle;
        txtPabstract.Text = showpap.PAbstract;
        txtPauthers.Text = showpap.Pauther;
        txtin.Text = Convert.ToString(showpap.PInumber);
        txtkeywords.Text = showpap.PKeywords;
        txtPnunmerofauthers.Text = Convert.ToString(showpap.PNofauthers);
        txtpj2.Text = Convert.ToString(showpap.PPagesF);
        txtpj1.Text = Convert.ToString(showpap.PPagesN);
        txtPtitle.Text = showpap.PTitle;
        txtvn.Text = Convert.ToString(showpap.PVnumber);
        txtYearofpublishing.Text = Convert.ToString(showpap.PYear);
       



        paperresult.Visible = true;
        paperupdate.Enabled = true;
        paperupdate.Visible = true;
        errorresult.Visible = true;

        ChannelServices.UnregisterChannel(chn5);


    }


    protected void paperUpdate_Click(object sender, EventArgs e)
    {
        HttpChannel chn6 = new HttpChannel();
        ChannelServices.RegisterChannel(chn6, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");
        papershare showpap = new papershare();

        
        showpap.PId = int.Parse(searchtxt.Text);
        showpap.PTitle = txtPtitle.Text;
        showpap.JTitle = txtPJtitle.Text;
        showpap.PAbstract = txtPabstract.Text;
        showpap.Pauther = txtPauthers.Text;
        showpap.PInumber = int.Parse(txtin.Text);
        showpap.PKeywords = txtkeywords.Text;
        showpap.PNofauthers = int.Parse(txtPnunmerofauthers.Text);
        showpap.PPagesF = int.Parse(txtpj2.Text);
        showpap.PPagesN = int.Parse(txtpj1.Text);
        showpap.PVnumber = int.Parse(txtvn.Text);
        showpap.PYear = int.Parse(txtYearofpublishing.Text);

        ValidationResult rest = serve.validate(showpap);
        if (rest.Ok == true)
        {

            serve.modifaypaper(showpap);
            paperresult.Visible = false;
            paperupdate.Enabled = false;
            paperupdate.Visible = false;
            lblResult.Text = " Paper  Updated Succeded ";
            lblResult.Visible = true;
            paperupdate.Visible = false;


        }

        else
        {
            errorresult.Text = rest.Msg;
            errorresult.Visible = true;
            paperresult.Visible = true;
            paperupdate.Visible = true;
            paperupdate.Enabled = true;
        }
        ChannelServices.UnregisterChannel(chn6);
    }
}
