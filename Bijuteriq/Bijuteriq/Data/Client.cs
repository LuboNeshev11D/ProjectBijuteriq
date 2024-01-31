using Microsoft.AspNetCore.Identity;

namespace Bijuteriq.Data
{
    public class Client:IdentityUser
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; } 
        public string Adress { get; set; }
        public DateTime RegDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}