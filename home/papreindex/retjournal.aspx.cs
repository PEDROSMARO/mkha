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

public partial class retjournal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        jouresult.Visible = false;
    }

    protected void search_Click(object sender, EventArgs e)
    {

        Journalshared showjou = new Journalshared();

        int p = int.Parse(searchtxt.Text);
        HttpChannel chn2 = new HttpChannel();
        ChannelServices.RegisterChannel(chn2, false);

        IJournalManger serve = (IJournalManger)Activator.GetObject(typeof(IJournalManger), "http://localhost:1234/journalservice.soap");

        showjou = serve.getById(p);

        txtJtitle.Text = showjou.Jtitle;
        txtJcity.Text = showjou.Jcity;
        txtJsub.Text = showjou.Jsub;
        txtJclass.Text = Convert.ToString(showjou.Jclass);

        jouresult.Visible = true;


        ChannelServices.UnregisterChannel(chn2);
    }
}