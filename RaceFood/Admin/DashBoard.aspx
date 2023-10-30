<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="RaceFood.Admin.DashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row"></div>
    <br />
    <br />
    <div class="row" style="padding: 3px">
        <div class="col-md-2"></div>
        <div class="col-md-3" style="padding: 10px">
            <div class="card" style="width: 18rem; background-color: black">
                <div class="card-body">
                    <h5 class="card-title" style="color: white">Restuarant</h5>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="LblNotify" runat="server" Text=" ResTotal  :" ForeColor="White"></asp:Label>&nbsp&nbsp
                   <asp:Label ID="LblNotifyResult" runat="server" Text="" ForeColor="White"></asp:Label>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl="~/Admin/RestuarantDashBoard.aspx">See</asp:HyperLink>
                    

                </div>
            </div>
        </div>



        <div class="col-md-3" style="padding: 10px">
            <div class="card" style="width: 18rem; background-color: black">
                <div class="card-body">
                    <h5 class="card-title" style="color: white">Users</h5>
                
                               &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="LblUser" runat="server" Text="UsersTotal  :" ForeColor="White"></asp:Label>&nbsp&nbsp
                   <asp:Label ID="LblUserResult" runat="server" Text="" ForeColor="White"></asp:Label>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl="~/Admin/UserDetails.aspx">See</asp:HyperLink>

                </div>
            </div>
        </div>
        <div class="col-md-3" style="padding: 10px">
            <div class="card" style="width: 18rem; background-color: black">
                <div class="card-body">
                    <h5 class="card-title" style="color: white">Orders</h5>
                 
                     
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-success" NavigateUrl="~/Admin/OrdersDashboard.aspx">See</asp:HyperLink>

                </div>
            </div>
        </div>

    </div>
    <br />
    <br />
    <br />
    <div class="row" style="padding: 3px">
        <div class="col-md-2"></div>
        <div class="col-md-3" style="padding: 10px">
            <div class="card" style="width: 18rem; background-color: black">
                <div class="card-body">
                    <h5 class="card-title" style="color: white">DelivaryBoys</h5>
                              &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="LblDeliveryBoy" runat="server" Text="BoysTotal  :" ForeColor="White"></asp:Label>&nbsp&nbsp
                   <asp:Label ID="LblDeliveryBoyResult" runat="server" Text="" ForeColor="White"></asp:Label>
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLink4" runat="server" CssClass="btn btn-success" NavigateUrl="~/Admin/DelivaryBoysList.aspx">See</asp:HyperLink>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
