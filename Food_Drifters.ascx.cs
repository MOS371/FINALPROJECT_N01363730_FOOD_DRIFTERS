using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public partial class Food_Drifters : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FoodDriftersdb db = new FoodDriftersdb();
            food_drifters_menu(db);
        }
        protected void food_drifters_menu(FoodDriftersdb db)
        {

            food_menu.InnerHtml = "";
            string searchkey = "";

            string query = "select * from foodblogpages";

            if (searchkey != "")
            {
                query += " WHERE foodblogtitle like '%" + searchkey + "%' ";
                query += " or chefname like '%" + searchkey + "%' ";
                query += " or foodblogbody like '%" + searchkey + "%' ";
            }


            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                food_menu.InnerHtml += "<div class=\"listitem\">";

                string foodblogid = row["foodblogid"];

                string foodblogtitle = row["foodblogtitle"];
                food_menu.InnerHtml += "<a href=\"ShowFoodBolg.aspx? foodblogid = " + foodblogid + "\">" + foodblogtitle + "</a>";

            }

        }
    }

}