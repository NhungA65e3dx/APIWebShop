using Microsoft.AspNetCore.Identity;

namespace APIWebShop.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
      
    }
}
