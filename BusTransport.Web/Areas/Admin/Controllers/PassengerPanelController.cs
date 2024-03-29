﻿using BusTransport.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using BusTransport.Model.Models;
using BusTransport.Utility;
using Microsoft.AspNetCore.Authorization;

namespace BusTransport.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = StaticDetails.Role_Passenger)]
    [Area("Admin")]
    public class PassengerPanelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PassengerPanelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult PassengerDetails()
        {
            //List<Passenger> objPassengerList = _unitOfWork?.Passenger?.GetAll()?.ToList() ?? new List<Passenger>();
            List<BusTransport.Model.Models.Passenger> objPassengerList = _unitOfWork.Passenger.GetAll().ToList();
            return View(objPassengerList);
        }

        public IActionResult PassengerDetailsCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PassengerDetailsCreate(BusTransport.Model.Models.Passenger obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Passenger.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult PassengerDetailsEdit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            BusTransport.Model.Models.Passenger? passengerFromDb = _unitOfWork.Passenger.Get(u => u.Passenger_Id == id);
            if (passengerFromDb == null) return NotFound();
            return View(passengerFromDb);
        }
        [HttpPost]
        public IActionResult PassengerDetailsEdit(BusTransport.Model.Models.Passenger obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Passenger.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult PassengerDetailsDelete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            BusTransport.Model.Models.Passenger? passengerFromDb = _unitOfWork.Passenger.Get(u => u.Passenger_Id == id);

            if (passengerFromDb == null) return NotFound();
            return View(passengerFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult PassengerDeletePOST(int? id)
        {
            BusTransport.Model.Models.Passenger? obj = _unitOfWork.Passenger.Get(u => u.Passenger_Id == id);

            if (obj == null) return NotFound();
            _unitOfWork.Passenger.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Passenger deleted successfully";
            return RedirectToAction("Index");
        }

        public IActionResult CompletedCourse()
        {
            return View();
        }
        public IActionResult TicketReturn()
        {
            return View();
        }
    }
}
