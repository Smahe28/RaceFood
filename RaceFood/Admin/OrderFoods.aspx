<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrderFoods.aspx.cs" Inherits="RaceFood.Admin.OrderFoods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
        <h2 style="padding: 30px; color: black">Order Details</h2>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md-3">
               
                  <br />
                    <br />
                    <label style="font-weight: 700; color: black;" id="Total" runat="server">TotalAmount :</label>
                    <asp:Label ID="LblTotalAmount" runat="server" Text="" ForeColor="black" Font-Bold="true"></asp:Label>
                    &nbsp&nbsp&nbsp&nbsp<br />
                <br />
                     <label style="font-weight: 700; color: black;" id="Label1" runat="server">DelivaryAddrress :</label>
                    <asp:Label ID="LblDAddress" runat="server" Text="" ForeColor="black" Font-Bold="true"></asp:Label>
                     &nbsp&nbsp&nbsp&nbsp  <br />
                  <br />
                     <label style="font-weight: 700; color: black;" id="Label3" runat="server">PaymentMethod :</label>
                    <asp:Label ID="lblPaymethod" runat="server" Text="" ForeColor="black" Font-Bold="true"></asp:Label>
                     &nbsp&nbsp&nbsp&nbsp  <br />  <br />
                   
                     <label style="font-weight: 700; color: black;" id="Label2" runat="server">OrderDate :</label>
                    <asp:Label ID="LblOrderdate" runat="server" Text="" ForeColor="black" Font-Bold="true"></asp:Label>
                   
            </div>
             <div class="col-md-1"></div>
            <div class="col-md-8">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="black" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="UserID" HeaderText="UserID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="ResturantID" HeaderText="RestuarantID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="RestuarantName" HeaderText="RestuarantName" ControlStyle-BackColor="WhiteSmoke" />
                          <asp:BoundField DataField="Address" HeaderText="RestuarantAddress" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke" />
                          <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="Amount" HeaderText="TotalAmount" ControlStyle-BackColor="WhiteSmoke" />
                      
            

                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <br />
                  </div>
                <div class="row">
               
                <div class="col-md-10" >
                  
                </div>
            </div>
            
            </div>
      
        


    </div>
</asp:Content>
