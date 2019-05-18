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


public partial class retrivepaper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Visible = false;
        paperresult.Visible = false;

    }

    protected void search_Click(object sender, EventArgs e)
    {

        papershare showpap = new papershare();

       int p  = int.Parse(searchtxt.Text);
        HttpChannel chn4 = new HttpChannel();
        ChannelServices.RegisterChannel(chn4, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");

        showpap = serve.retrivepaper(p);



        txtPJtitle.Text = showpap.JTitle;
        txtPabstract.Text = showpap.PAbstract;
        txtPauthers.Text = showpap.Pauther;
        txtin.Text = Convert.ToString(showpap.PInumber);
        txtkeywords.Text = showpap.PKeywords;
        txtPnunmerofauthers.Text = Convert.ToString(showpap.PNofauthers);
        txtpj2.Text = Convert.ToString(showpap.PPagesF);
        txtpj1.Text = Convert.ToString(showpap.PPagesN)  ;
        txtPtitle.Text = showpap.PTitle;
        txtvn.Text = Convert.ToString(showpap.PVnumber);
        txtYearofpublishing.Text = Convert.ToString(showpap.PYear);
    

                paperresult.Visible = true;
       
        errorresult.Visible = true; 
     
        

       
     

        ChannelServices.UnregisterChannel(chn4);




    }
}