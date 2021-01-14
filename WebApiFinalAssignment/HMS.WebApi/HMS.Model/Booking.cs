using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Model
{

    public enum BookingStatus
{
       Optional,
       Definitive,
       Cancelled,
       Deleted
}

    public class Booking
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public int RoomId { get; set; }
        public BookingStatus StatusOfBooking { get; set; }
    }
}
