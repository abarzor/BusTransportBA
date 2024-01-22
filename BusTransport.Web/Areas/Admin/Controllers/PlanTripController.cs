using BusTransport.DataAccess.Repository.IRepository;
using BusTransport.Model.Models;
using BusTransport.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusTransport.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlanTripController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlanTripController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public IActionResult PlanTrip()
        //{
        //    TicketVM ticketVM = new()
        //    {
        //        BusStopList = _unitOfWork.BusStop.GetAll().Select(z => new SelectListItem
        //        {
        //            Text = z.StopName,
        //            Value = z.BusStop_Id.ToString()
        //        }),
        //        Ticket = new Ticket()
        //    };
        //    return View();
        //}
        public IActionResult PlanTrip()
        {
            TicketVM ticketVM = new()
            {
                DiscountList = _unitOfWork.Discount.GetAll().Select(u => new SelectListItem
                {
                    Text = u.DiscountName,
                    Value = u.Discount_Id.ToString()
                }),
                BusStopList = _unitOfWork.BusStop.GetAll().Select(z => new SelectListItem
                {
                    Text = z.StopName,
                    Value = z.BusStop_Id.ToString()
                }),
                Ticket = new Ticket()
            };
            return View(ticketVM);
        }

        [HttpPost]
        public IActionResult PlanTrip(TicketVM obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Ticket.Add(obj.Ticket);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
