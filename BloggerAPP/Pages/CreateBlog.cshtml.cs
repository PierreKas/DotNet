using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace BloggerAPP.Pages
{
    public class CreateBlogModel : PageModel
    {
        public string conString = @"Data Source=PIERRE-KASANANI\SQLEXPRESS;Initial Catalog=blogApp;Integrated Security=True";
        public string message="";
        BlogPosts blogPosts = new BlogPosts();
        public void OnPost()
        {
            try {
                //get input from the view
                blogPosts.title= Request.Form["title"]; 
                blogPosts.post= Request.Form["body"];
                blogPosts.blogger = 1;
                //connection
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    string query = "INSERT INTO posts(title,post,blogger) VALUES(@v_title,@v_post,@v_blogger)";
                    using(SqlCommand cmd =  new SqlCommand(query,con))
                    {
                      
                        cmd.Parameters.AddWithValue("@v_title",blogPosts.title);
                        cmd.Parameters.AddWithValue("@v_post",blogPosts.post);
                        cmd.Parameters.AddWithValue("@v_blogger",blogPosts.blogger);
                        
                        int rowsAffected= cmd.ExecuteNonQuery();
                        if (rowsAffected > 0) 
                        {
                            message = "Blog created";
                        }
                        else
                        {
                            message = "Blog not created";
                        }
                    }
                    con.Close();
                }

            } catch (Exception ex){ 
                message = ex.Message;
            }
        }
    }
    public class BlogPosts
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? post { get; set; }
        public DateTime? post_date { get; set; }
        public int? blogger { get; set;}
        public int? post_id { get; set;}
    }
}
