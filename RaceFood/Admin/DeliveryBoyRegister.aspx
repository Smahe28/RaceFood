<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DeliveryBoyRegister.aspx.cs" Inherits="RaceFood.Admin.DeliveryBoyRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-left: 100px">


        <h2>Request</h2>

    </div>
    <div class="row">
        <div class="col-sm-3" style="padding: 25px">
        </div>
        <div class="col-sm-3">


            <label>Name:</label>
            <asp:TextBox ID="TxtName" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtName" runat="server" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Gender:</label>
            <asp:DropDownList ID="DdlType" BackColor="WhiteSmoke" CssClass="form-select" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>FeMale</asp:ListItem>
                <asp:ListItem> Others</asp:ListItem>

            </asp:DropDownList>
            <br />
            <label>DateOfBirth:</label>
            <asp:TextBox ID="Txtdob" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Txtdob" runat="server" ErrorMessage="Enter DateOfBirth" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Address:</label>
            <asp:TextBox ID="TxtAddress" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtAddress" runat="server" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Popular Location:</label>
               <asp:DropDownList ID="ddllocate" BackColor="WhiteSmoke" CssClass="form-select" runat="server">
                <asp:ListItem Text="VanathirayanPatti"></asp:ListItem>
                <asp:ListItem Text="NambamPatti"></asp:ListItem>
                <asp:ListItem Text="Viralur"></asp:ListItem>
                 <asp:ListItem Text="Viralimalai"></asp:ListItem>
                 <asp:ListItem Text="Kodalikudi"></asp:ListItem>
                 <asp:ListItem Text="Kodumbalur"></asp:ListItem>

            </asp:DropDownList>
            <br />
            <label>Email:</label>
            <asp:TextBox ID="TxtEmail" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtEmail" runat="server" ErrorMessage="Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>ContactNo:</label>
            <asp:TextBox ID="TxtConatactNo" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="TxtConatactNo" runat="server" ErrorMessage="Enter ContactNo" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <label>Password:</label>
            <asp:TextBox ID="TxtPassword" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="BtnRegister" CssClass="btn btn-success" runat="server" Text=" Apply To Register" OnClick="BtnRegister_Click" />

            <asp:Button ID="BtnCancel" CssClass="btn btn-danger" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
            <asp:Label ID="LblMessage" runat="server" CssClass="alert-danger" Text=""></asp:Label>

        </div>
    </div>
</asp:Content>
