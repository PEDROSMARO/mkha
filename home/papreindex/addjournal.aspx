<%@ Page Title="" Language="C#" MasterPageFile="~/Remoting.master" AutoEventWireup="true" CodeFile="addjournal.aspx.cs" Inherits="addjournal" %>

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
          <h3>Add new Journal </h3>
                    <asp:table id="jouresult" cellspacing="15" class="coffeeTable"  runat="server" >
                         <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b> Journal Title</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtJtitle" runat="server" Width="300px"></asp:TextBox>
                         
</asp:TableCell>
                             </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Journal City</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtJcity" runat="server" Width="300px"></asp:TextBox>
                        
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b>Journal subjects</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtJsub" runat="server" Width="300px"></asp:TextBox>
                         
</asp:TableCell>
                             </asp:TableRow>
                             <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>journal class</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtJclass" runat="server" Width="300px"></asp:TextBox>
                           
</asp:TableCell>
                             </asp:TableRow>
                        </asp:table>

     <asp:Button ID="jousave" Text="SAVE" runat="server" Width="100px" OnClick="jousave_Click" />
     <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
</asp:Content>

