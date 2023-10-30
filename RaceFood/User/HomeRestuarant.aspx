<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="HomeRestuarant.aspx.cs" Inherits="RaceFood.User.HomeRestuarant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding:50px;">
     <div class="col-md-4">
    <h2 style="color:white;">Food Selection</h2>
         <br />
         <br />
         <asp:Label ID="Lab" runat="server" Text="Name      :" Font-Bold="true" ForeColor="white"></asp:Label>
                           <asp:Label ID="LblRestuarant" runat="server" Text=""  Font-Bold="true"  ForeColor="White"></asp:Label>
         <br />
         <asp:Label ID="Label1" runat="server" Text="Location:" Font-Bold="true" ForeColor="White"></asp:Label>
                  <asp:Label ID="LblAddress" runat="server" Text="" Font-Bold="true" ForeColor="white"></asp:Label>

    </div>
     <div class="col-md-1"></div>
     <div class="col-md-5">
         <br />
         <br />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="White" HeaderStyle-BackColor="#006666" HeaderStyle-ForeColor="White" CssClass="table">
                    <Columns>
                           
                       
                      <asp:BoundField DataField="FoodID" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke"  Visible="false"/>
                        <asp:BoundField DataField="FoodName" HeaderText="FoodName" ControlStyle-BackColor="WhiteSmoke" />
                        <asp:BoundField DataField="FoodPrice" HeaderText="FoodPrice" ControlStyle-BackColor="WhiteSmoke" />
                        
                       <asp:TemplateField>
                            <ItemTemplate>
                              
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/User/Verify.aspx?FoodID={0}",HttpUtility.HtmlEncode(Eval("FoodID").ToString())) %>'>Order</asp:HyperLink>                               
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>                

     </div>
     
     </div>
                         
</asp:Content>
