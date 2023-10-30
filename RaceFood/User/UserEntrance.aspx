<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="UserEntrance.aspx.cs" Inherits="RaceFood.User.UserEntrance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        flex{
flex-direction :row;
        }
         #list{
height:100px;
width:100px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row"></div>
    <div class="row">
        <center>
<h1 style="color:white;">
    Welcome To Race Food Park
</h1>
  </center>
    </div>
    <br />
    <br />
    <br />
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-3">

            <asp:TextBox ID="TxtSearch" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <div class="col-md-4">

            <asp:Button ID="BtnSearch" runat="server" Text="Search" CssClass="btn btn-success" OnClick="BtnSearch_Click" />
        </div>
    </div>

    <br />
    <br />
        <div class="row">
            <div class="col-md-1"></div>
           
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-lg-2 col-md-2 col-sm-2">
                        <div class="card" style="color:black">
                            <div class="card-header">
                                 <img src="../Image/vyu.jpg" class="card-img-top" alt="..."  /> 
                            </div>
                            <div class="card-body">
                               <asp:Label ID="Label1" runat="server" Visible="false" Text='<%# Eval ("ID") %>'></asp:Label>
                                RestuarantName:
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval ("RestuarantName") %>'></asp:Label>
                                <br />
                                Address:
                              <asp:Label ID="Label2" runat="server" Text='<%# Eval ("Address") %>'></asp:Label>
                                <br />
                                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-success" NavigateUrl='<%# string.Format("~/User/HomeRestuarant.aspx?RestuarantID={0}",HttpUtility.HtmlEncode(Eval("ID").ToString()))%>'>Order</asp:HyperLink>

                            </div>
                           
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            
        </div>
 

</asp:Content>
