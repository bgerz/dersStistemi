using Microsoft.Extensions.Localization;

namespace Domain;

public class User:BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Role { get; set; }
   
}