<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="RaceFood.User.Verify" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding: 50px;">

        <h2 style="color: white;">Food Selection</h2>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4">

                <label>FoodName:</label>
                <asp:TextBox ID="TxtFoodName" BackColor="WhiteSmoke" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                <br />
                <label>Food Price:</label>
                <asp:TextBox ID="TxtFoodPrice" BackColor="WhiteSmoke" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                <br />
                <label>Quantity:</label>
                <asp:TextBox ID="TxtQuantity" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtQuantity" runat="server" ErrorMessage="Enter Quantity" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="" Visible="false"></asp:Label>

                <br />
                <asp:Button ID="BtnCard" CssClass="btn btn-success" runat="server" Text=" Add To Cart" OnClick="BtnCard_Click" />
                &nbsp   &nbsp
                <asp:Button ID="BtnOrder" runat="server" Text="Order" CssClass="btn btn-success" OnClick="BtnOrder_Click" />

            </div>
        </div>
    </div>
</asp:Content>
