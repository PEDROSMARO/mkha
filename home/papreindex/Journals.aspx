<%@ Page Title="" Language="C#" MasterPageFile="~/MA.master" AutoEventWireup="true" CodeFile="Journals.aspx.cs" Inherits="contectus" %>

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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


  

   
   
        <div>   <asp:Button ID="Button1" runat="server" Text="Add New Journal" CssClass="Buutonpaper" OnClick="Addjou_Click" Width="240px" />  </div>
    <div>   <asp:Button ID="Button6" runat="server" Text="Delete Journal" CssClass="Buutonpaper" OnClick="Deletejou_Click" Width="240px" />      </div>
   <div>   <asp:Button ID="Button7" runat="server" Text="Modify Journal" CssClass="Buutonpaper" OnClick="Modifyjou_Click" Width="240px" />   </div>
<div>   <asp:Button ID="Button3" runat="server" Text="Retrive journal" CssClass="Buutonpaper" OnClick="Retrivejou_Click" Width="240px" />   </div>


  




    </asp:Content>

