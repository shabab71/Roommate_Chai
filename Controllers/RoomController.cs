using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeRental.Repository;
using HomeRental.Models;

namespace HomeRental.Controllers
{
    
    public class RoomController : Controller
    {
        private readonly RoomRepository _roomRepository=null;
        public RoomController(RoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
            
        public async Task<ViewResult> GetAllRooms()
        {
            var data =await  _roomRepository.GetAllRooms();
            return View(data);
        }
        public async Task<ViewResult> GetRoom(int id)
        {
            var data =await _roomRepository.GetRoomById(id);
            return View(data);
        }
        public ViewResult AddNewRoom(bool isSuccess=false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewRoom(RoomModel roomModel)
        {
            int id=await _roomRepository.AddNewRoom(roomModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewRoom),new {isSuccess=true });
            }
            return View();
        }
    }
}
