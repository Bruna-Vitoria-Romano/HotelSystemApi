using HotelSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.DTOs
{
    public class RoomsDTO
    {
        public int NumberRoom { get; private set; }

        [Required]
        [DisplayName("Guest")]
        public HotelGuest IdGuest { get; set; }

        [Required]
        [DisplayName("Status")]
        public Enum Status { get; private set; }
    }
}
