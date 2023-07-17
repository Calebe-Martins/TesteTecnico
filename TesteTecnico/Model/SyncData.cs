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

                // Filtra os usuários que não existem no banco de dados
                var newUsers = users.Where(u => !_db.User.Any(dbUser => dbUser.id == u.id)).ToList();

                if (newUsers.Any())
                {
                    _db.User.AddRange(newUsers);
                    _db.SaveChanges();
                }
            }

            BlogResponse responseBlog = await client.GetFromJsonAsync<BlogResponse>("https://api.slingacademy.com/v1/sample-data/blog-posts?offset=0&limit=1000");
            if (responseBlog != null)
            {
                List<Blog> blogs = responseBlog.blogs;

                // Filtra os blogs que não existem no banco de dados
                var newBlogs = blogs.Where(b => !_db.Blog.Any(dbBlog => dbBlog.id == b.id)).ToList();

                if (newBlogs.Any())
                {
                    _db.Blog.AddRange(newBlogs);
                    _db.SaveChanges();
                }
            }
        }
    }
}

