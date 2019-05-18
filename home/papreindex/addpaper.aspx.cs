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


public partial class addpaper : System.Web.UI.Page
{

    

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Visible = false;
        errorresult.Visible = false;

    }

    protected void papersave_Click(object sender, EventArgs e)
    {

        papershare savpap = new papershare();
        savpap.JTitle = txtPJtitle.Text;
        savpap.PAbstract = txtPabstract.Text;
        savpap.Pauther = txtPauthers.Text;
        savpap.PInumber = int.Parse(txtin.Text);
        savpap.PKeywords = txtkeywords.Text;
        savpap.PNofauthers = int.Parse(txtPnunmerofauthers.Text);
        savpap.PPagesF = int.Parse(txtpj2.Text);
        savpap.PPagesN = int.Parse(txtpj1.Text);
        savpap.PTitle = txtPtitle.Text;
        savpap.PVnumber = int.Parse(txtvn.Text);
        savpap.PYear = int.Parse(txtYearofpublishing.Text);
       

        HttpChannel chnl = new HttpChannel();
        ChannelServices.RegisterChannel(chnl, false);

        Ipaperservice serve = (Ipaperservice)Activator.GetObject(typeof(Ipaperservice), "http://localhost:1234/papmanger.soap");

        ValidationResult rest = serve.validate(savpap);
        if (rest.Ok == false)
        {

            
            errorresult.Text = rest.Msg;
            errorresult.Visible = true;
           
        }

        else
        {

            int s = serve.addpaper(savpap);
            paperresult.Visible = false;
            errorresult.Text = rest.Msg;
            errorresult.Visible = true;
            lblResult.Text = "Paper Add succficly" + " its ID      " + s;
            lblResult.Visible = true;
            papersave.Visible = false;
                      ClearTextFields();          

        }
        ChannelServices.UnregisterChannel(chnl);

    }



    private void ClearTextFields()
    {
       txtPJtitle.Text = "";
       txtPabstract.Text = "";
       txtPauthers.Text = "";
       txtin.Text = "";
       txtkeywords.Text = "";
       txtPnunmerofauthers.Text = "";
       txtpj2.Text = "";
       txtpj1.Text = "";
 
       txtPtitle.Text = "";
       txtvn.Text = "";
       txtYearofpublishing.Text = "";



    }

    



  
    #endregion

  
}