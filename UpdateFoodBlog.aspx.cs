using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public partial class UpdateFoodBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                FoodDriftersdb db = new FoodDriftersdb();
                ShowFoodBlogInfo(db);
            }
        }
            protected void Update_FoodBlog(object sender, EventArgs e)
            {
            Debug.WriteLine("Please allow me to update");
               
                FoodDriftersdb db = new FoodDriftersdb();

                bool valid = true;
                string foodblogid = Request.QueryString["foodblogid"];
                if (String.IsNullOrEmpty(foodblogid)) valid = false;
                if (valid)
                {
                    FoodBlog new_foodblog = new FoodBlog();
                    //set that food blog data
                    new_foodblog.SetFoodBlogTitle(foodblogtitle.Text);
                    new_foodblog.SetChefName(chefname.Text);
                    new_foodblog.SetFoodBlogBody(foodblogbody.Text);

                    //add the food blog to the database
                    try
                    {
                        db.UpdateFoodBlog(Int32.Parse(foodblogid), new_foodblog);
                        Response.Redirect("ShowFoodBolg.aspx?foodblogid=" + foodblogid);
                    }
                    catch
                    {
                        valid = false;
                    }

                }

                if (!valid)
                {
                    foodblog.InnerHtml = "There was an error updating that student.";
                }

            }

        protected void ShowFoodBlogInfo(FoodDriftersdb db)
        {

            bool valid = true;
            string foodblogid = Request.QueryString["foodblogid"];
            if (String.IsNullOrEmpty(foodblogid)) valid = false;


            if (valid)
            {
                Debug.WriteLine("show the data");
                FoodBlog foodblog_record = db.FindFoodBlog(Int32.Parse(foodblogid));

                foodblogtitle.Text = foodblog_record.GetFoodBlogTitle();
                chefname.Text = foodblog_record.GetChefName();
                foodblogbody.Text = foodblog_record.GetFoodBlogBody();
            }

            if (!valid)
            {
                ErrorBox.InnerHtml = "There was an error finding that foodblog.";
            }
        }
    }
    }