<%@ Page Title="" Language="C#" MasterPageFile="~/Restuarant/RestuarantHome.Master" AutoEventWireup="true" CodeBehind="RestuarantLogin.aspx.cs" Inherits="RaceFood.Restuarant.RestuarantLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row" style="height: 150px"></div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-3">
            <label>RestuarantName:</label>
            <asp:TextBox ID="TxtRestuarantID" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtRestuarantID" runat="server" ErrorMessage="Enter RestuarantName" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
            <label>Password:</label>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
            <asp:Button ID="BtnLogin" CssClass="btn btn-success" runat="server" Text="Log in" OnClick="BtnLogin_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>
