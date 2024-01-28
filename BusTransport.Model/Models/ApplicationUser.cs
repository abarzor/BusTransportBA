using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BusTransport.Model.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
