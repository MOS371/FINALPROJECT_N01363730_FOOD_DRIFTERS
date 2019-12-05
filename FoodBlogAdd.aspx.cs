using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public partial class FoodBlogAdd : System.Web.UI.Page
    {
        protected void Add_Recipe(object sender, EventArgs e)
        {
            
            FoodDriftersdb db = new FoodDriftersdb();

            //create a new particular FoodBlog
            FoodBlog new_recipe = new FoodBlog();
            //set that FoodBlog data
            new_recipe.SetFoodBlogTitle(foodblogtitle.Text);
            new_recipe.SetChefName(chefname.Text);
            new_recipe.SetFoodBlogBody(foodblogbody.Text);
           

            //add the food blog to the database
            db.AddFoodBlog(new_recipe);


            Response.Redirect("FoodBlogList.aspx");
        }
    }
}