<%@ Page Language="C#" MasterPageFile="~/Remoting.master" AutoEventWireup="true" CodeFile="vertpaper.aspx.cs" Inherits="addpaper" %>


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
                     <h3>Vert Paper </h3>
                     <table cellspacing="15" class="coffeeTable">
                         <tr>
                             <td style="width: 80px">
                                 <b>Title</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtPtitle" runat="server" Width="300px"></asp:TextBox>
                              
                             </td>
                         </tr>
                         <tr>
                             <td style="width: 120px">
                                 <b>Number of authors</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtPnunmerofauthers" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td style="width: 80px">
                                 <b>Authers's Name</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtPauthers" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td style="width: 120px">
                                 <b>Journal Title</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtPJtitle" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td style="width: 120px">
                                 <b>Year of publishing</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtYearofpublishing" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>

                         <tr>
                             <td class="auto-style1">
                                 <b>Volume number</b>
                             </td>
                             <td class="auto-style2">
                                 <asp:TextBox ID="txtvn" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>

                            <tr>
                             <td style="width: 120px">
                                 <b>Issue number</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtin" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>

                             <tr>
                             <td style="width: 120px">
                                 <b>Pages in the journal</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtpj1" runat="server" Width="100px"></asp:TextBox> 
                             &nbsp;- &nbsp;
<asp:TextBox ID="txtpj2" runat="server" Width="100px"></asp:TextBox> 
                             </td>
                         </tr>

                         <tr>
                             <td style="width: 80px">
                                 <b>Abstract</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtPabstract" runat="server" Height="98px" TextMode="MultiLine" Width="332px"></asp:TextBox>
                             </td>
                         </tr>
                             <tr>
                             <td style="width: 120px">
                                 <b>Keywords</b>
                             </td>
                             <td>
                                 <asp:TextBox ID="txtkeywords" runat="server" Width="300px"></asp:TextBox>
                             </td>
                         </tr>
                     </table>
                     <asp:Button ID="papersave" Text="Vert this Paper" runat="server" Width="100px" OnClick="papervert_Click" />

    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    <br />

    
    

</asp:Content>


