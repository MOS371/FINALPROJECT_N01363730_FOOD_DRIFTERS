using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public class FoodBlog
    {
        private string FoodBlogTitle;
        private string ChefName;
        private string FoodBlogBody;
        

       
        public string GetFoodBlogTitle()
        {
            return FoodBlogTitle;
        }
        public string GetChefName()
        {
            return ChefName;
        }
        public string GetFoodBlogBody()
        {
            return FoodBlogBody;
        }
        
        public void SetFoodBlogTitle(string value)
        {
            FoodBlogTitle = value;
        }
        public void SetChefName(string value)
        {
            ChefName = value;
        }
        public void SetFoodBlogBody(string value)
        {
            FoodBlogBody = value;
        }
        

    }

}
