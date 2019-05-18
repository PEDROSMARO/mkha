using sharedlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addjournal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Visible = false;
    }

    protected void jousave_Click(object sender, EventArgs e)
    {

        Journalshared joupap = new Journalshared();
        joupap.Jtitle = txtJtitle.Text;

        joupap.Jcity = txtJcity.Text;

        joupap.Jclass = int.Parse(txtJclass.Text);

        joupap.Jsub = txtJsub.Text;
    


        HttpChannel chnl0 = new HttpChannel();
        ChannelServices.RegisterChannel(chnl0, false);

        IJournalManger serve = (IJournalManger)Activator.GetObject(typeof(IJournalManger), "http://localhost:1234/journalservice.soap");
       int s = serve.save(joupap);

       lblResult.Text = "Journal Add succficly" + " AND  its ID      " + s;
       lblResult.Visible = true;
       jouresult.Visible = false;

       ChannelServices.UnregisterChannel(chnl0);
    }


}