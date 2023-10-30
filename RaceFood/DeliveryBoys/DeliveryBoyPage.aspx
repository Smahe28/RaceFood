<%@ Page Title="" Language="C#" MasterPageFile="~/DeliveryBoys/DeliveryBoyMaster.Master" AutoEventWireup="true" CodeBehind="DeliveryBoyPage.aspx.cs" Inherits="RaceFood.DeliveryBoys.DeliveryBoyPage" %>
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
                        <asp:BoundField DataField="ID" HeaderText="OrderID" ControlStyle-BackColor="WhiteSmoke"  />
                           <asp:BoundField DataField="Name" HeaderText="Name" ControlStyle-BackColor="WhiteSmoke" />
                       <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" ControlStyle-BackColor="WhiteSmoke" />
                       <asp:BoundField DataField="DelivaryAddress" HeaderText="DeliverAddress" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="PaymentMethod" HeaderText="PaymentMethod" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="Date" HeaderText="OrderDate" ControlStyle-BackColor="WhiteSmoke" />
                      
                        <asp:TemplateField HeaderText="See" >
                            <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/Admin/OrderFoods.aspx?YoursOrderID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString())) %>'>See</asp:HyperLink>

                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Status">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkAccept" runat="server" CssClass="btn btn-success" CommandArgument='<%# Eval("ID") %>' OnClick="LinkAccept_Click">Accept</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
            
                         <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Cancel">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkDelete" runat="server" CssClass="btn btn-danger" CommandArgument='<%# Eval("ID") %>' >Cancel</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
            </div>
        </div>
</asp:Content>
