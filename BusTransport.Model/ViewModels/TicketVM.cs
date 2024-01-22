using BusTransport.Model.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusTransport.Model.ViewModels
{
    public class TicketVM
    {
        public Ticket Ticket { get; set; }
        public BusStop BusStop { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DiscountList { get; set; }
        public IEnumerable<SelectListItem> BusStopList { get; set; }

    }
}