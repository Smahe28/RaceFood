<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="RaceFood.Admin.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 style="padding: 50px; color: black">Users</h2>
    </div>

   
       <%-- <div class="row">
             <div class="col-md-2"></div>
            <div class="col-md-1"><asp:Label ID="LblPending" runat="server" Text="Search By ID:" ForeColor="black" Font-Bold="true"></asp:Label></div>
            <div class="col-md-2">
                
                <asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control"></asp:TextBox>
                
            </div>
            <div class="col-md-4"><asp:Button ID="BtnSearch" runat="server" Text="Search" CssClass="btn btn-success" /></div>
        </div>
        <br />
        <br />--%>
    
     <div class="container-fluid">

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" ForeColor="black" CssClass=" table" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White">
            <Columns>
              
                <asp:BoundField DataField="ID" HeaderText="UserID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="ContactNumer" HeaderText="ContactNo" />
                <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" />
                  <asp:BoundField DataField="SignDate" HeaderText="SignDate" />

                <asp:BoundField DataField="Password" HeaderText="Password" />
               

                <asp:TemplateField HeaderStyle-BackColor="#006666" HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ID") %>' OnClick="LinkButton1_Click" CssClass="btn btn-danger">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
 
    </div>
</asp:Content>
