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

public partial class deletepaper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        paperdelete.Visible = false;
        paperdelete.Enabled = false;
        lblResult.Visible = false;
        errorresult.Visible = false;
        paperresult.Visible = false;
        
        
    }

    protected void search_Click(object sender, EventArgs e)
    {

        papershare showpap = new papershare();

       int p  = int.Parse(searchtxt.Text);
        HttpChannel chn2 = new HttpChannel();
        ChannelServices.RegisterChannel(chn2, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");

       showpap =  serve.retrivepaper(p);

    
       

     
        txtPJtitle.Text = showpap.JTitle;
        txtPabstract.Text = showpap.PAbstract;
        txtPauthers.Text = showpap.Pauther;
        txtin.Text = Convert.ToString(showpap.PInumber);
        txtkeywords.Text = showpap.PKeywords;
        txtPnunmerofauthers.Text = Convert.ToString(showpap.PNofauthers);
        
        txtpj1.Text = Convert.ToString(showpap.PPagesN) + " - " + Convert.ToString(showpap.PPagesF);
        txtPtitle.Text = showpap.PTitle;
        txtvn.Text = Convert.ToString(showpap.PVnumber);
        txtYearofpublishing.Text = Convert.ToString(showpap.PYear);
        errorresult.Text = showpap.PTitle;

      

            paperresult.Visible = true;
            paperdelete.Enabled = true;
            paperdelete.Visible = true;
            errorresult.Visible = true; 
         
           
        
  

    ChannelServices.UnregisterChannel(chn2);
    }


    protected void paperdelete_Click(object sender, EventArgs e)
    {
        HttpChannel chn3 = new HttpChannel();
        ChannelServices.RegisterChannel(chn3, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");
        papershare showpap = new papershare();
        int d = int.Parse(searchtxt.Text);


        serve.deletepaper(d);
        paperresult.Visible = false;
        paperdelete.Enabled = false;
        paperdelete.Visible = false;
        lblResult.Text = " Paper deleted Succeded ";
        lblResult.Visible = true;
        ChannelServices.UnregisterChannel(chn3);

    }
}