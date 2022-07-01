using BlazorIdentityServerTutorial.Shared;
using Microsoft.AspNetCore.Identity;

namespace BlazorIdentityServerTutorial.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
    }
}