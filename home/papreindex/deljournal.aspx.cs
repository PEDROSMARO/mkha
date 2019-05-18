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

public partial class deljournal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        joudel.Visible = false;
       
        lblResult.Visible = false;

        jouresult.Visible = false;
    }

    protected void search_Click(object sender, EventArgs e)
    {

        Journalshared showjou = new Journalshared();

        int p = int.Parse(searchtxt.Text);
        HttpChannel chn22 = new HttpChannel();
        ChannelServices.RegisterChannel(chn22, false);

        IJournalManger serve = (IJournalManger)Activator.GetObject(typeof(IJournalManger), "http://localhost:1234/journalservice.soap");

        showjou = serve.getById(p);

        txtJtitle.Text = showjou.Jtitle;
        txtJcity.Text = showjou.Jcity;
        txtJsub.Text = showjou.Jsub;
        txtJclass.Text = Convert.ToString(showjou.Jclass);

        jouresult.Visible = true;
        joudel.Visible = true;
       
        ChannelServices.UnregisterChannel(chn22);

    }

    protected void joudel_Click(object sender, EventArgs e)
    {
        HttpChannel chn23 = new HttpChannel();
        ChannelServices.RegisterChannel(chn23, false);

        IJournalManger serve = (IJournalManger)Activator.GetObject(typeof(IJournalManger), "http://localhost:1234/journalservice.soap");

        Journalshared showjou = new Journalshared();
        int d = int.Parse(searchtxt.Text);


        serve.delete(d);
       jouresult.Visible = false;
       joudel.Visible = false;
        lblResult.Text = " Journal deleted Succeded ";
        lblResult.Visible = true;
        ChannelServices.UnregisterChannel(chn23);

    }


}