using System.ComponentModel.DataAnnotations;

namespace BusTransport.Model.Models
{
    public class Driver
    {
        public int Driver_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LicenseNumber { get; set; }
        public int LoginPIN { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
