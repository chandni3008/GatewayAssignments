﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment1.Models;

namespace TestingAssignment1.Repository
{
   public interface IDataRepository
    {
        Passenger AddPassenger(Passenger passenger);
        bool Delete(Guid Id);
        Passenger GetById(Guid Id);
        IList<Passenger> getPassengersList();
        Passenger Update(Passenger passenger);
    }
}
