using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BusTransport.Model.Models
{
    public class Discount
    {
        public int Discount_Id { get; set; }
        public string DiscountName { get; set; }
        public float DiscountValue { get; set; }
        
        public Ticket Ticket { get; set; }
    }
}