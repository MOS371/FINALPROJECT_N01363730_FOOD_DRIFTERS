using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public partial class ShowFoodBolg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FoodDriftersdb db = new FoodDriftersdb();
                ShowFoodBlogInfo(db);
            }
        }
        //delete the record
        protected void Delete_FoodBlog(object sender, EventArgs e)
        {
            bool valid = true;
            string foodblogid = Request.QueryString["foodblogid"];
            if (String.IsNullOrEmpty(foodblogid)) valid = false;

            FoodDriftersdb db = new FoodDriftersdb();

            //deleting the foodblog from the system
            if (valid)
            {
                db.DeleteFoodBlog(Int32.Parse(foodblogid));
                Response.Redirect("FoodBlogList.aspx");
            }
        }
        //Show the info of the foodblog

        protected void ShowFoodBlogInfo(FoodDriftersdb db)
        {

            bool valid = true;
            string foodblogid = Request.QueryString["foodblogid"];
            if (String.IsNullOrEmpty(foodblogid)) valid = false;


            if (valid)
            {
                Debug.WriteLine("show the data");
                FoodBlog foodblog_record = db.FindFoodBlog(Int32.Parse(foodblogid));

                foodblogtitle.InnerHtml = foodblog_record.GetFoodBlogTitle();
                chefname.InnerHtml = foodblog_record.GetChefName();
                foodblogbody.InnerHtml = foodblog_record.GetFoodBlogBody();
            }

            if (!valid)
            {
                ErrorBox.InnerHtml = "There was an error finding that foodblog.";
            }
        }
    }
}
