using Newtonsoft.Json;
using System.Net.Http;
using TesteTecnico;
using TesteTecnico.Model;


public class SyncData
{
    private readonly AppDbContext _db;

    public SyncData(AppDbContext db)
    {
        _db = db;
    }

    public async Task SyncDataDb()
    {
        using (HttpClient client = new HttpClient())
        {
            UserResponse responseUser = await client.GetFromJsonAsync<UserResponse>("https://api.slingacademy.com/v1/sample-data/users?offset=0&limit=1000");
            if (responseUser != null)
            {
                List<User> users = responseUser.users;

                foreach (var user in users)
                {
                    try
                    {
                        var existingUser = _db.User.Find(user.id);

                        if (existingUser == null)
                        {
                            _db.User.Add(user);
                        }

                        _db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            BlogResponse responseBlog = await client.GetFromJsonAsync<BlogResponse>("https://api.slingacademy.com/v1/sample-data/blog-posts?offset=0&limit=1000");
            if (responseBlog != null)
            {
                List<Blog> blogs = responseBlog.blogs;
                foreach (var blog in blogs)
                {
                    try
                    {
                        var existingBlog = _db.Blog.Find(blog.id);

                        if (existingBlog == null)
                        {
                            _db.Blog.Add(blog);
                        }

                        _db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}

