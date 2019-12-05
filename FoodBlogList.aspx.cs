using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public partial class FoodBlogList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foodblogs_result.InnerHtml = "";
            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = blog_search.Text;

            }
            string query = "select * from foodblogpages";

            if (searchkey != "")
            {
                query += " WHERE foodblogtitle like '%" + searchkey + "%' ";
                query += " or chefname like '%" + searchkey + "%' ";
                query += " or foodblogbody like '%" + searchkey + "%' ";
            }
            
            var db = new FoodDriftersdb();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                foodblogs_result.InnerHtml += "<div class=\"listitem\">";

                string foodblogid = row["foodblogid"];

                string foodblogtitle = row["foodblogtitle"];
                foodblogs_result.InnerHtml += "<div class=\"col2\"><a href=\"ShowFoodBolg.aspx?foodblogid=" + foodblogid + "\">" + foodblogtitle + "</a></div>";

                string chefname = row["chefname"];
                foodblogs_result.InnerHtml += "<div class=\"col2\">" + chefname + "</div>";

                string foodblogbody = row["foodblogbody"];
                foodblogs_result.InnerHtml += "<div class=\"col2last\">" + foodblogbody + "</div>";

                
            }

        }
    }
    
}