<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="FoodPage.aspx.cs" Inherits="RaceFood.User.FoodPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
        <h2 style="padding: 50px; color: white">Searching Food</h2>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="White" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                    <Columns>
                        <asp:BoundField DataField="FoodID" HeaderText="ID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="RestuarantID" HeaderText="RestuarantID" ControlStyle-BackColor="WhiteSmoke" Visible="false" />
                        <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="RestuarantName" HeaderText="RestuarantName" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="Address" HeaderText="Address" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:TemplateField HeaderText="Order" HeaderStyle-ForeColor="White">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/User/Verify.aspx?FoodID={0}",HttpUtility.HtmlEncode(Eval("FoodID").ToString())) %>'>Order</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
