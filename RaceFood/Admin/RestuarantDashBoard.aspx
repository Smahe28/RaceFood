<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RestuarantDashBoard.aspx.cs" Inherits="RaceFood.Admin.RestuarantDashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding:3px"></div>
        <div class="row">
    <div class="col-md-2"></div>
    <div class="col-md-3" style="padding:10px">
   
      
    <br />
      <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/Register.aspx" ForeColor="Black" Font-Size="X-Large" >Register </asp:HyperLink> &nbsp&nbsp
     
        
  </div>
</div>
      <div class="row">
      <div class="col-md-2"></div>
    <div class="col-md-3" style="padding:10px">
       
      <asp:Label ID="Label2" runat="server" Text="" ForeColor="black"></asp:Label>
    <br />
      <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/Admin/RestuarantDetails.aspx" ForeColor="Black" Font-Size="X-Large" >RegisterRestuarants</asp:HyperLink>
    
  </div>
  
</div>

</asp:Content>
