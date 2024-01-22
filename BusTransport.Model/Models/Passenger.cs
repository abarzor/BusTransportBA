using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransport.Model.Models
{
    public class Passenger
    {
        public int Passenger_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Ticket Ticket { get; set; }
    }
}
