﻿using HotelSystemApi.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Domain.Entities
{
    public sealed class Rooms
    {
        public Rooms(int numberRoom, HotelGuest idGuest, Enum status)
        {
            NumberRoom = numberRoom;
            IdGuest = idGuest;
            Status = status;
        }

        public int NumberRoom { get; private set; }
        public HotelGuest IdGuest { get; set; }
        public Enum Status { get; private set; }

        public void ValidationRoom(int numberRoom)
        {
            DomainExceptionValidation.When(numberRoom < 0, "Invalid Number.");
            NumberRoom = numberRoom;
        }
    }
}
