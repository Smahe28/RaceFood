<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="RaceFood.User.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 style="padding: 50px; color: white">Yours Orders</h2>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="White" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
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
                <div class="row">

                    <div class="col-md-10">
                        <br />
                        <br />
                        <label style="font-weight: 700; color: white;" id="Total" runat="server">TotalAmount :</label>
                        <asp:Label ID="LblTotalAmount" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>
                        &nbsp&nbsp&nbsp&nbsp
                     <label style="font-weight: 700; color: white;" id="Label1" runat="server">DelivaryAddrress :</label>
                        <asp:Label ID="LblDAddress" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>
                        &nbsp&nbsp&nbsp&nbsp
                     <label style="font-weight: 700; color: white;" id="Label3" runat="server">PaymentMethod :</label>
                        <asp:Label ID="lblPaymethod" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>

                        &nbsp&nbsp&nbsp&nbsp
                     <label style="font-weight: 700; color: white;" id="Label2" runat="server">OrderDate :</label>
                        <asp:Label ID="LblOrderdate" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>

                    </div>
                </div>
                <%--                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/User/Payment.aspx?OrderID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString())) %>'>Payment</asp:HyperLink>--%>
            </div>
        </div>



    </div>
</asp:Content>
