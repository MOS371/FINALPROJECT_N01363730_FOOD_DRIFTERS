using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HTTP_5101_FinalAssign_N01363730_FoodDrifters
{
    public class FoodDriftersdb
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "food drifters"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }
        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query" + query);
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }


        public void AddFoodBlog(FoodBlog new_recipe)
        {

            string query = "insert into foodblogpages (foodblogtitle, chefname, foodblogbody) values ('{0}','{1}','{2}')";
            query = String.Format(query, new_recipe.GetFoodBlogTitle(), new_recipe.GetChefName(), new_recipe.GetFoodBlogBody());
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddFoodBlog Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public FoodBlog FindFoodBlog(int id)
        {
            
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            FoodBlog result_foodblog = new FoodBlog();

            
            try
            {
                
                string query = "select * from foodblogpages where foodblogid = " + id;
                Debug.WriteLine("Connection Initialized...");
                Connect.Open();
                
                MySqlCommand cmd = new MySqlCommand(query, Connect);
               
                MySqlDataReader resultset = cmd.ExecuteReader();

               
                List<FoodBlog> foodblogs = new List<FoodBlog>();

                
                while (resultset.Read())
                {
                   
                    FoodBlog currentfoodblog = new FoodBlog();

                   
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        switch (key)
                        {
                            case "foodblogtitle":
                                currentfoodblog.SetFoodBlogTitle(value);
                                break;
                            case "chefname":
                                currentfoodblog.SetChefName(value);
                                break;
                            case "foodblogbody":
                                currentfoodblog.SetFoodBlogBody(value);
                                break;
                            
                        }

                    }
                    foodblogs.Add(currentfoodblog);
                }

                result_foodblog = foodblogs[0]; 

            }
            catch (Exception ex)
            {

                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_foodblog;
        }

        public void UpdateFoodBlog(int foodblogid, FoodBlog new_foodblog)
        {
            string query = "update foodblogpages set foodblogtitle='{0}', chefname='{1}', foodblogbody='{2}' where foodblogid={3}";
            query = String.Format(query, new_foodblog.GetFoodBlogTitle(), new_foodblog.GetChefName(), new_foodblog.GetFoodBlogBody(), foodblogid);
            

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                //Try to update a food blog with the information provided to us.
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the UpdateFoodBlog Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeleteFoodBlog(int foodblogid)
        {
           

           
            //DELETING ON THE PRIMARY KEY OF FOODBLOGS
            string removefoodblog = "delete from foodblogpages where foodblogid = {0}";
            removefoodblog = String.Format(removefoodblog, foodblogid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            //This command removes the particular food blog from the table
            MySqlCommand cmd_removefoodblog = new MySqlCommand(removefoodblog, Connect);
            try
            {
                
                Connect.Open();

                // delete 
                cmd_removefoodblog.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removefoodblog);
            }
            catch (Exception ex)
            {
                
                Debug.WriteLine("Something went wrong in the delete Food Blog Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }



    }
}