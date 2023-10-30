<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="RaceFood.User.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row" style="padding-left: 100px">


        <h2>SignUp</h2>

    </div>
    <div class="row">
        <div class="col-sm-3" style="padding: 25px">
        </div>
        <div class="col-sm-3">
            <label>Name:</label>
            <asp:TextBox ID="TxtName" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="dxfg" ControlToValidate="TxtName" runat="server" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
        
               <br />
            <label>Gender:</label>
            <asp:DropDownList ID="DdlType" BackColor="WhiteSmoke" CssClass="form-select" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
                <asp:ListItem Text="Others"></asp:ListItem>
            </asp:DropDownList>
             
               <br />
            <label>Date Of Birth</label>
            <asp:TextBox ID="TxtDOB" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>&nbsp
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtDOB" runat="server" ErrorMessage="Enter DateOfBirth" ForeColor="Red"></asp:RequiredFieldValidator>
            
               <br />
            <label>Phone NO:</label>
            <asp:TextBox ID="TxtPhoneNo" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TxtPhoneNo" runat="server" ErrorMessage="Enter Phone NO" ForeColor="Red"></asp:RequiredFieldValidator>
         
               <br />
            <label>Email</label>
            <asp:TextBox ID="TxtEmail" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtEmail" runat="server" ErrorMessage="Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
            
               <br />
            <label>Password</label>
            <asp:TextBox ID="TxtPassword" BackColor="WhiteSmoke" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
            
               <br />
            <label>Adderss</label>
            <asp:TextBox ID="TxtAddress" BackColor="WhiteSmoke" CssClass="form-control" runat="server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TxtAddress" runat="server" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
           
               <br />
            <br />
            <asp:Label ID="LblMessage" runat="server" CssClass="alert-danger" Text=""></asp:Label>

            <asp:Button ID="BtnRegister" CssClass="btn btn-success" runat="server" Text="sign Up" OnClick="BtnRegister_Click" />

            <asp:Button ID="BtnCancel" CssClass="btn btn-danger" runat="server" Text="Cancel" />


        </div>
    </div>
</asp:Content>
