<%@ Page Title="ADD FOOD BLOG" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodBlogAdd.aspx.cs" Inherits="HTTP_5101_FinalAssign_N01363730_FoodDrifters.FoodBlogAdd" %>
<asp:Content ID="foodblog_add" ContentPlaceHolderID="MainContent" runat="server">

    <h3>New Recipe</h3>
    <div class="formrow">
        <label>Recipe Title: </label>
        <asp:TextBox runat="server" ID="foodblogtitle"></asp:TextBox>
    </div>
    <div class="formrow">
        <label>Chef Name: </label>
        <asp:TextBox runat="server" ID="chefname"></asp:TextBox>
    </div>
    <div class="formrow">
        <label>Recipe details: </label>
        <asp:TextBox runat="server" ID="foodblogbody"></asp:TextBox>
    </div>

    <asp:Button OnClick="Add_Recipe" Text="Add Recipe" runat="server" />
</asp:Content>
