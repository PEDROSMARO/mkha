<%@ Page Title="" Language="C#" MasterPageFile="~/wcf.master" AutoEventWireup="true" CodeFile="authers.aspx.cs" Inherits="authers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
              <div style="border-style:solid;border-width:thin;border-color:#DEBA84;padding:3px;padding-top:8px;background-color:hsla(0, 1%, 39%, 0.14)">
  <asp:SiteMapPath ID="SiteMapPath" runat="server" BorderStyle="None" BorderWidth="1px" Font-Names="Verdana" Font-Size="Large" Height="30px" PathSeparator=" : ">
        <CurrentNodeStyle ForeColor="#333333" />
        <NodeStyle Font-Bold="True" Font-Size="12pt" ForeColor="#990000" />
        <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
        <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
    </asp:SiteMapPath>

</div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <h3>&nbsp;Auther Result</h3>


                      
    <b>            Please Enter Auther Name&nbsp;&nbsp;&nbsp;&nbsp;                              </b>

    <asp:TextBox ID="searchtxt" runat="server" Width="134px"></asp:TextBox>

         <asp:Button ID="searchbtn" Text="search" runat="server" Width="100px" OnClick="search_Click" />

       <asp:table id="autherresult" cellspacing="15" class="coffeeTable"  runat="server" >
                         <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b>Name of Auhter</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtName" runat="server" Width="300px"></asp:TextBox>
                         </asp:TableCell>
                             </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Number of Papers </b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="txtPnunmerofPapers" runat="server" Width="300px"></asp:TextBox>
                        </asp:TableCell>
                             </asp:TableRow>
         
                              </asp:table>
         <asp:GridView ID="autherview" runat="server" AutoGenerateColumns="true" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="190px">
         <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
         <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
         <RowStyle BackColor="White" ForeColor="#330099" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
         <SortedAscendingCellStyle BackColor="#FEFCEB" />
         <SortedAscendingHeaderStyle BackColor="#AF0101" />
         <SortedDescendingCellStyle BackColor="#F6F0C0" />
         <SortedDescendingHeaderStyle BackColor="#7E0000" />
         

     </asp:GridView>
                    

   

 
    <asp:GridView ID="GridView1"  runat="server"></asp:GridView>


      <asp:Button ID="getscore" Text="Get Score For This Auther"  runat="server" Width="275px" OnClick="getscore_Click" />
       <asp:table id="TableResult" cellspacing="15" class="coffeeTable"  runat="server" Width="554px" >
                         <asp:TableRow>
                             <asp:TableCell style="width: 80px">  
                                 <b>Score By Paper Years</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="TxtScoresbyyear" runat="server" Width="300px"></asp:TextBox>
                         </asp:TableCell>
                             </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Score By Auther Order </b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="Txtscorebyorder" runat="server" Width="300px"></asp:TextBox>
                        </asp:TableCell>
                             </asp:TableRow>
         
            <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Score By Journal Class </b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="Txtscorebyjclass" runat="server" Width="300px"></asp:TextBox>
                        </asp:TableCell>
                             </asp:TableRow>
                              
     <asp:TableRow>
                            <asp:TableCell style="width: 120px">
                                 <b>Full Score For Auther</b>
                             </asp:TableCell>
                             <asp:TableCell>
                                 <asp:TextBox ID="Fullscore" runat="server" Width="300px"></asp:TextBox>
                        </asp:TableCell>
                             </asp:TableRow>
    
    </asp:table>

   
    <br />



    </asp:Content>

