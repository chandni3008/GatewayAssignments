using HMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repository
{
    public interface IRoomRepository
    {
        bool GetRoomAvailability(int Id, DateTime date);
        string CreateRoom(Room model);
        IEnumerable<Room> GetAllRoombyCity(String city);
        IEnumerable<Room> GetAllRoombyPincode(int pincode);
        IEnumerable<Room> GetAllRoombyRoomPrice(float price);
        IEnumerable<Room> GetAllRoombyCategory(int category);
    }
}
