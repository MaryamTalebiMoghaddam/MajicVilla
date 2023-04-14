using Microsoft.AspNetCore.Identity;

namespace MagicVilla_VillaApi.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }
    }
}
