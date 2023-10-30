<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryBoyLogin.aspx.cs" Inherits="RaceFood.DeliveryBoys.DeliveryBoyLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Bootsrap/bootstrap.min.css" rel="stylesheet" />
    <script src="../Bootsrap/bootstrap.min.js"></script>
</head>
<body style=" font-family: cursive;">
    <form id="form1" runat="server">
        <div>
            <div class="row" style="height: 150px">
                 <div class="col-md-9"></div>
                <div class="col-md-3">
                    <br />
                    <br />
                <asp:HyperLink ID="HyperLink4" runat="server" Font-Size="Medium" ForeColor="Black" NavigateUrl="~/Login.aspx">Back</asp:HyperLink>
                    </div>
            </div>
            <div class="row"></div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-3">
                    <br />
                    <br />
                    <label>UserName:</label>
                    <asp:TextBox ID="TxtUserid" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="dxfg" ControlToValidate="TxtUserid" runat="server" ErrorMessage="Enter UserID" ForeColor="Red"></asp:RequiredFieldValidator>

                    <br />
                    <label>Password:</label>
                    <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtPassword" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>

                    <br />
                    <asp:Button ID="BtnLogin" CssClass="btn btn-success" runat="server" Text="Log in" OnClick="BtnLogin_Click" />&nbsp&nbsp&nbsp&nbsp
           
             <asp:Label ID="LblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>
