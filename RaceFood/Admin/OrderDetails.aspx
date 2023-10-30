<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="RaceFood.Admin.OrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 style="padding: 50px; color: white">Yours Orders</h2>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">
                  <asp:Label ID="LblNoOrders" runat="server" Text="" ForeColor="black" Font-Bold="true"></asp:Label>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="black" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="OrderID" />
                        <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" />
                        <asp:BoundField DataField="DelivaryAddress" HeaderText="DeliverAddress" />
                        <asp:BoundField DataField="PaymentMethod" HeaderText="PaymentMethod" />
                        <asp:BoundField DataField="Date" HeaderText="OrderDate" />
                        <asp:TemplateField HeaderText="See">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/Admin/OrderFoods.aspx?YoursOrderID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString())) %>'>See</asp:HyperLink>

                            </ItemTemplate>
                        </asp:TemplateField>
                     

                      
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
