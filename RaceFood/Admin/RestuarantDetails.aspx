<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RestuarantDetails.aspx.cs" Inherits="RaceFood.Admin.RestuarantDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" ForeColor="black" CssClass=" table" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White">
            <Columns>
             
                <asp:BoundField DataField="ID" HeaderText="RestuarantID" />
                <asp:BoundField DataField="RestuarantName" HeaderText="RestuarantName" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Category" HeaderText="Category" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="ContactNo" HeaderText="ContactNo" />
                <asp:BoundField DataField="Date" HeaderText="RegisterDate" />
                <asp:BoundField DataField="RestuarantNo" HeaderText="RestuarantNo" />
                <asp:BoundField DataField="Password" HeaderText="Password" />
<%--                <asp:HyperLinkField Text="Food Details" ControlStyle-CssClass="btn btn-success" DataNavigateUrlFields="RestuarantName,RestuarantNo,Address" DataNavigateUrlFormatString="FoodUpdate.aspx?RestuarantName={0}&RestuarantNo={1}&Address={2}" />--%>

                  <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Foods">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/Admin/FoodDetails.aspx?RestuarantID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString()))%>'>Foods</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Foods">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkDelete" runat="server" CommandArgument='<%# Eval("ID") %>' CssClass="btn btn-danger" OnClick ="LinkDelete_Click">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
  
    </div>

</asp:Content>
