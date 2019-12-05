<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowFoodBolg.aspx.cs" Inherits="HTTP_5101_FinalAssign_N01363730_FoodDrifters.ShowFoodBolg" %>
<asp:Content ID="foodblog_view" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="show_table" id="foodblog" runat="server">
        
        <h2 class="details_name"><span id="foodblogtitle" class="details_results" runat="server"></span></h2><br />
        
        <h3 class="details_name">Chef Name = <span id="chefname" class="details_results" runat="server"></span></h3><br />
        <p class="details_name"><span id="foodblogbody" class="details_results" runat="server"></span></p><br />
       

    </div>
    <asp:Button ID="backtolist" CssClass="button" runat="server" PostBackUrl="~/FoodBlogList.aspx" text="BACK TO LIST" />
    <asp:Button OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="Delete_FoodBlog" ID="foodblogdelete_btn" CssClass="button" runat="server" text="DELETE"/>
     <div class="viewnav">
            <a class="left" href="UpdateFoodBlog.aspx?foodblogid=<%=Request.QueryString["foodblogid"] %>">EDIT</a>
        </div>
      <div id="ErrorBox" runat="server"></div>
    <div class="picture_main">
        <img src="Content/images/food_platter.jpg" alt="Picture" class="picture" />
    </div>
</asp:Content>

