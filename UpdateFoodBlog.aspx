<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateFoodBlog.aspx.cs" Inherits="HTTP_5101_FinalAssign_N01363730_FoodDrifters.UpdateFoodBlog" %>
<asp:Content ID="Update_FoodBlog" ContentPlaceHolderID="MainContent" runat="server">

     <div id="foodblog" runat="server">
        <div class="viewnav">
            <a class="left" href="ShowFoodBolg.aspx?foodblogid=<%=Request.QueryString["foodblogid"] %>">Cancel</a>
        </div>
        <h1>Updating the Food blog</h1>
        
        <div class="formrow">
            <h2>Title </h2>
            <asp:TextBox runat="server" ID="foodblogtitle"></asp:TextBox>
        </div>
        <div class="formrow">
            <h2>Chef Name </h2>
            <asp:TextBox runat="server" ID="chefname"></asp:TextBox>
        </div>
        <div class="formrow">
            <h2>Blog body </h2>
            <asp:TextBox TextMode="MultiLine" Rows="10" runat="server" ID="foodblogbody"></asp:TextBox>
        </div>

        <asp:Button cssclass= "button" Text="Update Recipe" OnClick="Update_FoodBlog" runat="server" />
    </div>
    <div id="ErrorBox" runat="server"></div>
</asp:Content>
