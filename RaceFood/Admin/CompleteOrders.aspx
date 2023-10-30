<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CompleteOrders.aspx.cs" Inherits="RaceFood.Admin.CompleteOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 style="padding: 50px; color: white">Yours Orders</h2>
    </div>

    <div class="container-fluid">
        <div class="row">
             <div class="col-md-2"></div>
            <div class="col-md-1"><asp:Label ID="LblPending" runat="server" Text="Search By Date:" ForeColor="black" Font-Bold="true"></asp:Label></div>
            <div class="col-md-2">
                
                <asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                
            </div>
            <div class="col-md-4"><asp:Button ID="BtnSearch" runat="server" Text="Search" CssClass="btn btn-success" OnClick="BtnSearch_Click"/></div>
        </div>
        <br />
        <br />

        <div class="row">
            <div class="col-md-1"></div>

            <div class="col-md-10">
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="black" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="OrderID" />
                        <asp:BoundField DataField="DeliBoyID" HeaderText="DeliverBoyID" />
                        <asp:BoundField DataField="UserID" HeaderText="UserID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="TotalAmount" HeaderText="TotalAmount" />
                        <asp:BoundField DataField="DelivaryAddress" HeaderText="DeliverAddress" />
                        <asp:BoundField DataField="Coordinate" HeaderText="TotalAmount" />
                        <asp:BoundField DataField="PaymentMethod" HeaderText="PaymentMethod" />
                        <asp:BoundField DataField="Date" HeaderText="OrderDate" />
                        <asp:BoundField DataField="FinishTime" HeaderText="FinishDate" />
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
