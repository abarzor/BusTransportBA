using BusTransport.DataAccess.Repository;
using BusTransport.DataAccess.Repository.IRepository;
using BusTransport.Model.Models;
using BusTransport.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusTransport.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TicketPurchaseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TicketPurchaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public IActionResult TicketPurchase()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            List<Ticket> objTickettList = _unitOfWork.Ticket.GetAll().ToList();

            return View(objTickettList);
        }
        public IActionResult TicketPurchase()
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
        public IActionResult TicketPurchase(TicketVM obj)
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
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Ticket? ticketFromDb = _unitOfWork.Ticket.Get(u => u.Ticket_Id == id);
            if (ticketFromDb == null) return NotFound();
            return View(ticketFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Ticket obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Ticket.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Ticket? ticketFromDb = _unitOfWork.Ticket.Get(u => u.Ticket_Id == id);

            if (ticketFromDb == null) return NotFound();
            return View(ticketFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Ticket? obj = _unitOfWork.Ticket.Get(u => u.Ticket_Id == id);

            if (obj == null) return NotFound();
            _unitOfWork.Ticket.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");
        }
    }
}