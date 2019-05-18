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
using System.Data;
using System.Collections;

public partial class retrivepaper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Visible = false;
       

    }

    protected void search_Click(object sender, EventArgs e)
    {

        papershare showpap = new papershare();
        string s = searchtxt.Text;

       
        HttpChannel chn7 = new HttpChannel();
        ChannelServices.RegisterChannel(chn7, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");


        List<papershare> temp = serve.retrivepaper(s).ToList();
        ChannelServices.UnregisterChannel(chn7);
        GridView1.DataSource = new List<papershare>();

        GridView1.DataSource = temp;

        GridView1.DataBind();

       

 




    }
}