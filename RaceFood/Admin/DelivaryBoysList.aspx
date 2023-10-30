<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DelivaryBoysList.aspx.cs" Inherits="RaceFood.Admin.DelivaryBoysList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Black" Font-Size="X-Large" NavigateUrl="~/Admin/DeliveryBoyRegister.aspx">DeliveryRegister</asp:HyperLink>

    </div>
    <br />
    <div class="container-fluid">
        <center>
  
        <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#006666" AutoGenerateColumns="false" HeaderStyle-ForeColor="White" CssClass="table" >
    
         <Columns>
                 <asp:BoundField DataField="ID" HeaderText="DeliveryBoyID" ControlStyle-BackColor="WhiteSmoke" />
                    <asp:BoundField DataField="Name" HeaderText="Name" ControlStyle-BackColor="WhiteSmoke"  />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" ControlStyle-BackColor="WhiteSmoke"  />
               <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" ControlStyle-BackColor="WhiteSmoke" />
                    <asp:BoundField DataField="Address" HeaderText="Address" ControlStyle-BackColor="WhiteSmoke" />
     
                    <asp:BoundField DataField="Email" HeaderText="Email" ControlStyle-BackColor="WhiteSmoke"  />
                    <asp:BoundField DataField="ContactNo" HeaderText="ConatactNo" ControlStyle-BackColor="WhiteSmoke" />
                    <asp:BoundField DataField="Date" HeaderText="RegisterDate" ControlStyle-BackColor="WhiteSmoke" />
                    <asp:BoundField DataField="Password" HeaderText="Password" ControlStyle-BackColor="WhiteSmoke"  />
                
                <asp:TemplateField>
    <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/Admin/CompleteForDeliBoy.aspx?DeliBoyID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString())) %>'>CompleteOrders</asp:HyperLink>
    </ItemTemplate>
</asp:TemplateField>
   <asp:TemplateField>
    <ItemTemplate>
        <asp:LinkButton ID="LinkDelete" runat="server" CssClass="btn btn-danger"  CommandArgument='<%# Eval("ID") %>' OnClick="LinkDelete_Click" >Delete</asp:LinkButton>
    </ItemTemplate>
</asp:TemplateField>
                </Columns>
</asp:GridView>
    </center>


    </div>
</asp:Content>
