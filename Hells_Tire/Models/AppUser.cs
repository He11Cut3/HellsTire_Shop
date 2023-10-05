using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hells_Tire.Models
{
    public class AppUser : IdentityUser
    {
        public string Deff { get; set; }
    }
}
