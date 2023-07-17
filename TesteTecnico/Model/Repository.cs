using Microsoft.Extensions.Hosting;
using TesteTecnico;
using TesteTecnico.Model;

public class Repository
{
    private readonly AppDbContext _db;

    public Repository(AppDbContext db)
    {
        _db = db;
    }

    public User GetUserById(int userId)
    {
        return _db.User.FirstOrDefault(u => u.id == userId);
    }

    public List<Blog> GetBlogsByUserId(int userId)
    {
        return _db.Blog.Where(p => p.user_id == userId).ToList();
    }
}