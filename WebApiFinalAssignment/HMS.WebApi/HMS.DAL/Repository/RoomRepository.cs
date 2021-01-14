using HMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly Database.HotelManagementDBEntities _dbContext;
        public RoomRepository(Database.HotelManagementDBEntities dbContext)

        {
            _dbContext = dbContext;
        }

        public string CreateRoom(Room model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> GetAllRoombyCategory(int category)
        {
            var entities = _dbContext.Rooms.Where(e => e.RoomCategory == category).OrderBy(e => e.RoomPrice).ToList();
            var list = new List<Room>();
            if (entities.Count != 0)
            {
                foreach (var item in entities)
                {
                    var room = new Room()
                    {
                        Id = item.Id,
                        RoomName = item.RoomName,
                        RoomCategory = item.RoomCategory,
                        RoomPrice = item.RoomPrice,
                        IsActive = item.IsActive,
                        CreatedBy = item.CreatedBy,
                        CreatedDate = item.CreatedDate,
                        UpdatedBy = item.UpdatedBy,
                        UpdatedDate = item.UpdatedDate
                    };
                    list.Add(room);
                }
            }
            return list;
        }

        public IEnumerable<Room> GetAllRoombyCity(string city)
        {
            var entities = _dbContext.Rooms.Where(e => e.Hotel.City == city).OrderBy(e => e.RoomPrice).ToList();
            var rooms = new List<Room>();
            if (entities.Count > 0)
            {
                foreach (var item in entities)
                {
                    var room = new Room()
                    {
                        Id = item.Id,
                        RoomName = item.RoomName,
                        RoomCategory = item.RoomCategory,
                        RoomPrice = item.RoomPrice,
                        IsActive = item.IsActive,
                        CreatedBy = item.CreatedBy,
                        CreatedDate = item.CreatedDate,
                        UpdatedBy = item.UpdatedBy,
                        UpdatedDate = item.UpdatedDate
                    };
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        public IEnumerable<Room> GetAllRoombyPincode(int pincode)
        {
            var entities = _dbContext.Rooms.Where(e => e.Hotel.Pincode == pincode).OrderBy(e => e.RoomPrice).ToList();
            var list = new List<Room>();
            if (entities.Count != 0)
            {
                foreach (var item in entities)
                {
                    var room = new Room()
                    {
                        Id = item.Id,
                        RoomName = item.RoomName,
                        RoomCategory = item.RoomCategory,
                        RoomPrice = item.RoomPrice,
                        IsActive = item.IsActive,
                        CreatedBy = item.CreatedBy,
                        CreatedDate = item.CreatedDate,
                        UpdatedBy = item.UpdatedBy,
                        UpdatedDate = item.UpdatedDate
                    };
                    list.Add(room);
                }
            }
            return list;
        }

        public IEnumerable<Room> GetAllRoombyRoomPrice(float price)
        {
            var entities = _dbContext.Rooms.Where(e => e.RoomPrice == price).OrderBy(e => e.RoomPrice).ToList();
            var list = new List<Room>();
            if (entities.Count != 0)
            {
                foreach (var item in entities)
                {
                    var room = new Room()
                    {
                        Id = item.Id,
                        RoomName = item.RoomName,
                        RoomCategory = item.RoomCategory,
                        RoomPrice = item.RoomPrice,
                        IsActive = item.IsActive,
                        CreatedBy = item.CreatedBy,
                        CreatedDate = item.CreatedDate,
                        UpdatedBy = item.UpdatedBy,
                        UpdatedDate = item.UpdatedDate
                    };
                    list.Add(room);
                }
            }
            return list;
        }

        public bool GetRoomAvailability(int Id, DateTime date)
        {
            if (_dbContext.Rooms.Find(Id) != null)
            {
                var entity = _dbContext.Bookings.FirstOrDefault(e => e.RoomId == Id && e.BookingDate.Value.Day == date.Day &&
                (e.StatusOfBooking == (int)BookingStatus.Optional || e.StatusOfBooking == (int)BookingStatus.Definitive));

                if (entity != null)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}