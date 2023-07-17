using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnico.Model
{
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTeste { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
    }

    public class UserResponse
    {
        public bool success { get; set; }
        public string time { get; set; }
        public string message { get; set; }
        public int total_users { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<User> users { get; set; }
    }

    public class User
    {
        [Key]
        public int id { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string street { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public double latitude { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string job { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double longitude { get; set; }
    }

    public class BlogResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<Blog> blogs { get; set; }
    }

    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string content_text { get; set; }
        public string photo_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int user_id { get; set; }
        public string description { get; set; }
        public string content_html { get; set; }
        public string category { get; set; }
    }
    
}