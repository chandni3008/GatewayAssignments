﻿using HMS.BAL.Interface;
using HMS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace HMS.WebApi.Controllers
{
    public class BookingController : ApiController
    {
        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }
            // GET: api/Booking
            public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Booking/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Booking
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Booking/5
        public HttpResponseMessage Put(int id, [FromBody] Booking model)
        {
            var booking = _bookingManager.UpdateBooking(id, model);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json")
            };
        }

        // DELETE: api/Booking/5
        public HttpResponseMessage Delete(int Id)
        {
            var booking = _bookingManager.DeleteBooking(Id);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json")
            };
        }
    }
}
