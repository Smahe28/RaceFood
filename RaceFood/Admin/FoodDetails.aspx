<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="FoodDetails.aspx.cs" Inherits="RaceFood.Admin.FoodDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
    <h2 style="padding:50px; color:black">Food Details</h2>
    </div>
    <div class="row">
        <div class="col-md-6" style="padding:50px">
              <asp:Label ID="LblRestuarantName" runat="server" Text="" ForeColor="Black" Font-Size="30px"  Font-Bold="true"></asp:Label>
            <br />
            <br />
              <asp:Label ID="LblAddress" runat="server" Text=""  ForeColor="Black" Font-Size="30px"  Font-Bold="true"></asp:Label>
        </div>
        <div class="col-md-3">
          
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#006666" CssClass="table " ForeColor="black"  HeaderStyle-ForeColor="white">
                   <Columns>
               
                    <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke"  />
                    <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke"  />
                       
           </Columns>
                        </asp:GridView>
          
            </div>
        
          
     
             </div>
    <div class="container">
        <div class="row">
        <div class="col-md-4"></div>
            <div class="col-md-5">
              
        </div>
    </div>

    </div>
</asp:Content>
