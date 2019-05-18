<%@ Page Language="C#" MasterPageFile="~/MA.master"  AutoEventWireup="true"  CodeFile="Home.aspx.cs" Inherits="Home" %>

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

    	 <div id="header-section" >
   
                    <div class="text-center">
                        <h2 class="head-line" >Paper Indexing</h2>
                    </div>
            
    </div> 


     <div id="about-section" class="section" >
        <div class="container" >
          
               
            <div class="row main-low-margin">
                <div class="col-md-10 col-md-offset-1 col-sm-10 col-sm-offset-1" >
                    <h1>Our Project</h1>
                    <div>  Paper Indexing is distributed application that should serve as a paper indexing system.</div>
                
                  
                </div>
            </div>
           
            
        </div>
    </div>

     <!--PARALLAX SECTION ONE-->
 
   
    
        <div class="container" >
                         
           
                    <h1>Paper Indexing System Details</h1>
                    <h4>   Database </h4>
     <div>    <b> Database should be designed in order to contain paper information which are: </b>
 
         <div>
             <h3>  Paper Table</h3>

 Contains Coloums :   <br />
     Paper  ID <br />
 Title    <br />
Number of authors <br />
First author, second author… (first letter of his first name and full last name) <br />
Journal title <br />
Year of publishing<br />
Volume number<br />
Issue number<br />
Pages in the journal<br />
Abstract<br />
Keywords    </div>

            
              <div>
                  <h3> Journal Table </h3>
Contains Coloums : <br />
Journal ID <br />
Journal title <br />
Journal city <br />
Journal subjects <br />
Journal class (1,2,3 or 4)  <br />
                  <asp:Image ID="Image1" runat="server" Height="196px" ImageUrl="~/Images/Database.jpg" Width="524px" />

              </div>
          
                </div>

            <div>
                <h4>   Shared Library </h4>
library using remotineg Serializing Contains : <br />
 A class of Paper Shared object <br />
An interface For class Paper Shared <br />
 A class of Journal Shared object <br />
An interface For Journal  Shared <br />
A Class for Validtion Result
            </div>


              <div>
                <h4>   Server Project </h4>
A Project contains : <br />
 A class of Paper Manger to implicate interface Ipapere Service <br />
 A class of Journal Service to implicate interface IJournal Manger <br />
 A class of Startup to config remoting setting <br />
 A Setting file to Access to Databse by Linq to sql 

            </div>
            
            
                <div>
                <h4>   Wcf Project </h4>
library using Wcf service  Contains : <br />
 A class of Auther Service object <br />
An interface For class Auther Service <br />
 A Setting file to Access to Databse by Linq to sql
            </div> 

        <div>
                <h4>   Client Server </h4>
AspAsp Web Apllication have refrence to shared library and web refernce to wcf project 
            </div> 

            
     
        </div>



     <div id="contact-section" class="section" >
        <div class="container" >
                     
            <div class="row main-low-margin">
                <div class="col-md-10 col-md-offset-1 col-sm-10 col-sm-offset-1" >
                    <h5>
                        &nbsp;</h5>
                </div>
            </div>
         
            
        </div>
    </div>

    



      <div class="text-center"  id="foot" >

    <br /><br />
         2017 www.svuonline.org | All Right Reserved
  
   iv>


   
   

  


    </asp:Content>
