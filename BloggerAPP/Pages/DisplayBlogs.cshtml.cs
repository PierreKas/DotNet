using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace BloggerAPP.Pages
{
    public class DisplayBlogsModel : PageModel
    {
        public string conString = @"Data Source=PIERRE-KASANANI\SQLEXPRESS;Initial Catalog=blogApp;Integrated Security=True";
        public string message = "";

        
        public List<BlogPosts> postList = new List<BlogPosts>();

        // load all blogs

        public void DisplayBlogs()
        {
            try
            {
                // connection
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string qry = "SELECT post_id, title, post FROM posts";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BlogPosts posts = new BlogPosts();
                                //posts.post_id = Int32.Parse(reader["post_id"].ToString());
                                posts.post_id = reader.GetInt32(reader.GetOrdinal("post_id"));
                                posts.title = reader["Title"].ToString();
                                posts.post = reader["post"].ToString();

                                postList.Add(posts);
                            }
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
        }
        public void OnGet()
        {
            DisplayBlogs();
        }
        public class BlogPosts
        {
            public int post_id { get; set; }
            public string? title { get; set; }
            public string? post { get; set; }
        }
    }
}
