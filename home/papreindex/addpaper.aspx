<%@ Page Language="C#" MasterPageFile="~/Remoting.master" AutoEventWireup="true" CodeFile="addpaper.aspx.cs" Inherits="addpaper" %>


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
                     <h3>Add New Paper </h3>
                    <asp:table id="paperresult" cellspacing="15" class="coffeeTable"  runat="server" >
                         <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b>Title</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPtitle" runat="server" Width="300px"></asp:TextBox>
                         
</asp:TableCell>
                             </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Number of authors</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPnunmerofauthers" runat="server" Width="300px"></asp:TextBox>
                        
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b>Authers's Name</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPauthers" runat="server" Width="300px"></asp:TextBox>
                         
</asp:TableCell>
                             </asp:TableRow>
                             <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Journal Title</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPJtitle" runat="server" Width="300px"></asp:TextBox>
                           
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell style="width: 120px">
                                 <b>Year of publishing</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtYearofpublishing" runat="server" Width="300px"></asp:TextBox>
                            
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow>
                              <asp:TableCell style="width: 120px">
                                 <b>Volume number</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtvn" runat="server" Width="300px"></asp:TextBox>
                          
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow>
                             <asp:TableCell style="width: 120px">
                                 <b>Issue number</b>
                              </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtin" runat="server" Width="300px"></asp:TextBox>
                         
</asp:TableCell>
                             </asp:TableRow>
                          <asp:TableRow  >
                             <asp:TableCell style="width: 120px" HorizontalAlign="Justify">
                                 <b>Pages in the journal</b>
                              </asp:TableCell >
                             <asp:TableCell Width="50px" >
                                 <asp:TextBox ID="txtpj1" runat="server" Width="50px"></asp:TextBox> 
                         
                                 
</asp:TableCell>
                              <asp:TableCell  Width="50" HorizontalAlign="Justify">
<asp:TextBox ID="txtpj2" runat="server" Width="50px"  ></asp:TextBox> 
                             </asp:TableCell>
                         </asp:TableRow>

                         <asp:TableRow>
                              <asp:TableCell style="width: 80px">
                                 <b>Abstract</b>
                            </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPabstract" runat="server" Height="98px" TextMode="MultiLine" Width="332px"></asp:TextBox>
                              
</asp:TableCell>
                        </asp:TableRow>
                            <asp:TableRow>
                              <asp:TableCell style="width: 120px">
                                 <b>Keywords</b>
                             </asp:TableCell>
                            <asp:TableCell>
                                 <asp:TextBox ID="txtkeywords" runat="server" Width="300px"></asp:TextBox>
                             
</asp:TableCell>
                         </asp:TableRow>
                     </asp:table>
                     <asp:Button ID="papersave" Text="SAVE" runat="server" Width="100px" OnClick="papersave_Click" />
                     <asp:Label ID="errorresult" runat="server" Text="" ForeColor="Red"></asp:Label>
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    <br />

    
    

</asp:Content>


