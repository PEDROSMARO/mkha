<%@ Page Title="" Language="C#" MasterPageFile="~/Remoting.master" AutoEventWireup="true" CodeFile="retjournal.aspx.cs" Inherits="retjournal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <h3> Retrieve Journal </h3>


                      
    <b>            Please Enter Journal ID                               </b>

    <asp:TextBox ID="searchtxt" runat="server" Width="50px"></asp:TextBox>

         <asp:Button ID="searchbtn" Text="search" runat="server" Width="100px" OnClick="search_Click" />
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
</asp:Content>

