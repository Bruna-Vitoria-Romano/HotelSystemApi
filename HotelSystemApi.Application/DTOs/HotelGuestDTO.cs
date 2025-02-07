using HotelSystemApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Application.DTOs
{
    public class HotelGuestDTO
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [MinLength(3)]
        [MaxLength(250)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Booking")]
        public Rooms BookingId { get; set; }
    }
}
