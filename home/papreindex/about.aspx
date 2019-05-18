<%@ Page Title="" Language="C#" MasterPageFile="~/MA.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                <div style="border-style:solid;border-width:thin;border-color:#DEBA84;padding:3px;padding-top:8px;background-color:hsla(0, 1%, 39%, 0.14)">
  <asp:SiteMapPath ID="SiteMapPath1" runat="server" BorderStyle="None" BorderWidth="1px" Font-Names="Verdana" Font-Size="Large" Height="30px" PathSeparator=" : ">
        <CurrentNodeStyle ForeColor="#333333" />
        <NodeStyle Font-Bold="True" Font-Size="12pt" ForeColor="#990000" />
        <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
        <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
    </asp:SiteMapPath>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    
    <div class="container"  >
     
        <div class="row main-low-margin text-center" >
                <div class="INDEX" >
                 
                    <h3> &nbsp;</h3>
                    <b>&nbsp;</b><br />
                    <br />
                </div>
           
           
    </div>
        </div>
    <div class="space-bottom">
        <asp:Image ID="Image1" runat="server" Height="98px" ImageUrl="~/Images/Thank-You.jpg" Width="614px" />
    </div>
     
</asp:Content>

