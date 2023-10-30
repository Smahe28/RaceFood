<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RaceFood.Admin.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-left: 100px">


        <h2>Restuarant Register:</h2>

    </div>
    <div class="row">
        <div class="col-sm-3" style="padding: 25px">
        </div>
        <div class="col-sm-3">


            <label>Restuarant Name:</label>
            <asp:TextBox ID="TxtRName" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TxtRName" runat="server" ErrorMessage="Enter Resturant Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Restuarant NO:</label>
            <asp:TextBox ID="TxtRNo" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtRNo" runat="server" ErrorMessage="Enter Restuarant No" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Address:</label>
            <asp:TextBox ID="TxtAddress" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TxtAddress" runat="server" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Contact NO:</label>
            <asp:TextBox ID="TxtPhoneNo" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtPhoneNo" runat="server" ErrorMessage="Enter Contact No" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Email:</label>
            <asp:TextBox ID="TxtEmail" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtEmail" runat="server" ErrorMessage="Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Password:</label>
            <asp:TextBox ID="TxtPassword" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Category:</label>
            <asp:TextBox ID="TxtCategory" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="TxtCategory" runat="server" ErrorMessage="Enter Category" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
           
            <br />
            <br />
            <asp:Label ID="LblMessage" runat="server" CssClass="alert-danger" Text=""></asp:Label>

            <asp:Button ID="BtnRegister" CssClass="btn btn-success" OnClick="BtnCreate_Click" runat="server" Text="Register" />

            <asp:Button ID="BtnCancel" CssClass="btn btn-danger" runat="server" Text="Cancel" />


        </div>
    </div>
</asp:Content>
