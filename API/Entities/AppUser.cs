using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
    public int userid { get; set; }
    public string username {get;set;}
    }
}