using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BusTransport.Model.Models
{
    public class Ticket
    {
        public int Ticket_Id { get; set; }
        public string StartStop { get; set; }
        public string EndStop { get; set; }
        public decimal TicketPrice { get; set; }
        public int SeatNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public bool IsVaild { get; set; } = false;

        public int Passenger_Id { get; set; }
        public Passenger Passenger { get; set; }

        public int Discount_Id { get; set; }
        public Discount Discount { get; set; }
    }

    //ID TRASY
}