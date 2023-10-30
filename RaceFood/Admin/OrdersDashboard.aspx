<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrdersDashboard.aspx.cs" Inherits="RaceFood.Admin.OrdersDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row" style="padding:3px"></div>
        <div class="row">
    <div class="col-md-2"></div>
    <div class="col-md-3" style="padding:10px">
   
     
    <br />
      <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/OrderDetails.aspx" ForeColor="Black" Font-Size="X-Large" >PendingOrders</asp:HyperLink> &nbsp&nbsp ( <asp:Label ID="LblPending" runat="server" Text="" ForeColor="black"></asp:Label>)
        
  </div>
</div>
      <div class="row">
      <div class="col-md-2"></div>
    <div class="col-md-3" style="padding:10px">
       
     
    <br />
      <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/Admin/CompleteOrders.aspx" ForeColor="Black" Font-Size="X-Large" >CompleteOrders</asp:HyperLink>&nbsp&nbsp( <asp:Label ID="LblComplete" runat="server" Text="" ForeColor="black"></asp:Label>)
    
  </div>
  
</div>
    <div class="row">
      <div class="col-md-2"></div>
    <div class="col-md-3" style="padding:10px">
       
      
    <br />
      <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/Admin/CancelOrders.aspx" ForeColor="Black" Font-Size="X-Large" >CancelOrders</asp:HyperLink>&nbsp&nbsp(<asp:Label ID="LblCancel" runat="server" Text="" ForeColor="black"></asp:Label>)
    
  </div>
  
</div>
</asp:Content>
