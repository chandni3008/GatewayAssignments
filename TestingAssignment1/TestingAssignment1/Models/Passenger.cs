﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingAssignment1.Models
{
    public class Passenger
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}