<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FoodBlogList.aspx.cs" Inherits="HTTP_5101_FinalAssign_N01363730_FoodDrifters.FoodBlogList" %>
<asp:Content ID="foodblogpost_list" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="list_titles">FOOD BLOG POST</h1>
   <div class="search_box">
   <asp:label for="blog_search" class="search_name" runat="server">Search:</asp:label>
      <asp:TextBox ID="blog_search" runat="server"></asp:TextBox>
        <asp:Button CssClass="button" runat="server" text="SUBMIT"/>
    
    </div>
    <div id="foodblogs_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col2">BLOG NAME</div>
            <div class="col2">CHEF NAME</div>
            <div class="col2last">BLOG DESCRIPTION</div>
        </div>
    </div>
     <asp:Button ID="addnewfoodblog_btn" CssClass="button" runat="server" PostBackUrl="~/FoodBlogAdd.aspx" text="Add New Recipe"/>
</asp:Content>
