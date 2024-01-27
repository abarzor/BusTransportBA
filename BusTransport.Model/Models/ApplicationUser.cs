using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BusTransport.Model.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Name { get; set; }
        public int Surname { get; set; }
        public int Age { get; set; }
    }
}
