using HMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BAL.Interface
{
    public interface IRoomManager
    {
         bool GetRoomAvailability(int Id, DateTime date);
        IEnumerable<Room> GetAllRoombyCity(String city);
        IEnumerable<Room> GetAllRoombyPincode(int pincode);
        IEnumerable<Room> GetAllRoombyRoomPrice(float price);
        IEnumerable<Room> GetAllRoombyCategory(int category);

        string CreateRoom(Room model);
    }
}
