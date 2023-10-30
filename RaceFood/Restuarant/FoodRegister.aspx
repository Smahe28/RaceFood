<%@ Page Title="" Language="C#" MasterPageFile="~/Restuarant/RestuarantHome.Master" AutoEventWireup="true" CodeBehind="FoodRegister.aspx.cs" Inherits="RaceFood.Restuarant.FoodRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-md-6">
            <h2 style="padding: 50px;">Food Registration</h2>
        </div>
        <asp:Label ID="LblID" runat="server" Text="" Visible="false"></asp:Label>
        <div class="col-md-3" style="padding: 50px;">
            <asp:Label ID="Label3" runat="server" Text="RestuarantName:" Font-Bold="true"></asp:Label>

            <asp:Label ID="LblRestuarant" runat="server" Text="" Font-Bold="true"></asp:Label>
        </div>
        <div class="col-md-3" style="padding: 50px;">
            <asp:Label ID="Label2" runat="server" Text="Address:" Font-Bold="true"></asp:Label>

            <asp:Label ID="LblAddress" runat="server" Text="" Font-Bold="true"></asp:Label>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="LblFoodName" runat="server" Text="FoodName:" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="TxtFoodName" CssClass="form-control" runat="server"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TxtFoodName" runat="server" ErrorMessage="Enter FoodName" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Price:" Font-Bold="true"></asp:Label>
                <asp:TextBox ID="TxtPrice" CssClass="form-control" runat="server"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtPrice" runat="server" ErrorMessage="Enter Price" ForeColor="Red"></asp:RequiredFieldValidator>--%>

                <br />
                <br />
                <asp:Label ID="Lbl1" runat="server" Text=""></asp:Label>

                <br />
                <asp:Button ID="BtnAdd" runat="server" Text="Add" CssClass="btn btn-success" OnClick="BtnAdd_Click" />
                <asp:Button ID="BtnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="BtnUpdate_Click" />
            </div>
            <div class="col-md-1"></div>
            <div class="col-md-7">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#006666" CssClass="table " ForeColor="black" HeaderStyle-ForeColor="white">
                    <Columns>

                        <asp:BoundField DataField="FoodID" HeaderText="ID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkEdit" runat="server" CssClass="btn btn-secondary" CommandArgument='<%# Eval("FoodID") %>' OnClick="LinkEdit_Click">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkDelete" runat="server" CssClass="btn btn-danger" CommandArgument='<%# Eval("FoodID") %>' OnClick="LinkDelete_Click">Delete</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
