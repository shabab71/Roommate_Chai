using HomeRental.Data;
using HomeRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeRental.Repository
{
    public class RoomRepository
    {
        private readonly HomeRentalContext _context = null;
        public RoomRepository(HomeRentalContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewRoom(RoomModel model)
        {
            var newRoom = new Rooms()
            {
                Owner = model.Owner,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                Category = model.Category,
                Location = model.Location,
                Rent=model.Rent,
                UpdatedOn=DateTime.UtcNow
            };
            await _context.Rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();
            return newRoom.Id;
        }
        public async Task<List<RoomModel>> GetAllRooms()
        {
            var rooms = new List<RoomModel>();
            var allrooms = await _context.Rooms.ToListAsync();
            if (allrooms?.Any() == true)
            {
                foreach(var room in allrooms)
                {
                    rooms.Add(new RoomModel() {
                        Owner = room.Owner,                      
                        Description = room.Description,
                        Title = room.Title,
                        Category = room.Category,
                        Location = room.Location,
                        Rent = room.Rent

                    });
                }
            }
            return rooms;
        }
        public async Task<RoomModel>  GetRoomById(int id)
        {
            
            var roomk= await _context.Rooms.FindAsync(id);
            if (roomk == null)
            {
                var roomDetails = new RoomModel()
                {
                    Owner = roomk.Owner,
                    Description = roomk.Description,
                    Title = roomk.Title,
                    Category = roomk.Category,
                    Location = roomk.Location,
                    Rent = roomk.Rent
                };
                return roomDetails;
            }
            return null;
        }
        private List<RoomModel> DataSource()
        {
            return new List<RoomModel>()
            {
                new RoomModel(){Id=1,Title="MVC",Owner="Blah", Description="yytustduguiguihoko",Category="gboljkdb",Location="shibgonj,Dhaka",Rent="23000"},
                new RoomModel(){Id=2,Title="C",Owner="Bla", Description="yytustduguiguihoko",Category="dddcdc",Location="kalitola,Bogra",Rent="30000"},
                new RoomModel(){Id=3,Title="MC",Owner="Mahin" ,Description="yytustduguiguihoko",Category="ddd",Location="shibbati",Rent="25000"},
                new RoomModel(){Id=4,Title="MV",Owner="Blh",Description="yytustduguiguihoko",Category="sdsd",Location="shibbaty",Rent="5000"},
            };
        }
    }
}
