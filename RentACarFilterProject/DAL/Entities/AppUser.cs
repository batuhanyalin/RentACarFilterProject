using Microsoft.AspNetCore.Identity;

namespace RentACarFilterProject.DAL.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
