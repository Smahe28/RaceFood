<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="AddCart.aspx.cs" Inherits="RaceFood.User.AddCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-1"></div>
    </div>
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-6">
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ForeColor="White" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                <Columns>


                    <asp:BoundField DataField="ID" HeaderText="OrderID" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                           <asp:BoundField DataField="RestuarantName" HeaderText="RestuarantName" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                     <asp:BoundField DataField="Address" HeaderText="Address" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                    <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                    <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
                    <asp:BoundField DataField="Amount" HeaderText="Amount" ControlStyle-BackColor="WhiteSmoke"></asp:BoundField>
              
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkDelete" runat="server" CssClass="btn btn-danger" CommandArgument='<%# Eval("ID") %>' OnClick="LinkDelete_Click">Remove</asp:LinkButton>

                        </ItemTemplate>
                    </asp:TemplateField>


                </Columns>

            </asp:GridView>
            <div class="row">
                <div class="col-md-7"></div>
                <div class="col-md-5" >
                    <br />
                    <br />
                    <label style="font-weight: 700; color: white;" id="Total" runat="server">TotalAmount :</label>
                    <asp:Label ID="LblTotalAmount" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>
                    <asp:Label ID="LblNoCarts" runat="server" Text="" ForeColor="White" Font-Bold="true"></asp:Label>
                    &nbsp&nbsp&nbsp&nbsp
                    <asp:Button ID="BtnConfirm" runat="server" Text="Confirm" CssClass="btn btn-success" OnClick="BtnConfirm_Click" />&nbsp&nbsp&nbsp&nbsp<asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-outline-secondary" NavigateUrl="~/User/UserEntrance.aspx">More</asp:HyperLink>
                </div>
            </div>

        </div>
        <div class="col-md-1"></div>
        <div class="col-md-3" style="padding: 70px" visible="false" id="Delivary" runat="server">
            <br />
            <br />
            <br />
            <br />
            <br />
            <h2>Deliver Address:</h2>
            <br />
            <br />
            <label>Address:</label>
            <asp:TextBox ID="TxtAddress" runat="server" CssClass="form-control" Height="100px" TextMode="MultiLine" Font-Size="Small"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="dxfg" ControlToValidate="TxtAddress" runat="server" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
               <label>Popular Location:</label>
            <asp:DropDownList ID="DdlArea" runat="server" CssClass="form-control">
                <asp:ListItem Text="VanathirayanPatti"></asp:ListItem>
                <asp:ListItem Text="NambamPatti"></asp:ListItem>
                <asp:ListItem Text="Viralur"></asp:ListItem>
                 <asp:ListItem Text="Viralimalai"></asp:ListItem>
                 <asp:ListItem Text="Kodalikudi"></asp:ListItem>
                 <asp:ListItem Text="Kodumbalur"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <label>Coordinate:</label>
            <asp:TextBox ID="TxtCo" runat="server" CssClass="form-control"></asp:TextBox>

            <br />
            <label>PaymentMethod</label>
            <asp:DropDownList ID="DdlPayment" runat="server" CssClass="form-control">
                <asp:ListItem Text="Cash On Delivary"></asp:ListItem>
                <asp:ListItem Text="Card"></asp:ListItem>
                <asp:ListItem Text="OnlinePayment"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="BtnPayment" runat="server" Text="Order" CssClass="btn btn-success" OnClick="BtnPayment_Click" />
        </div>
    </div>
</asp:Content>
