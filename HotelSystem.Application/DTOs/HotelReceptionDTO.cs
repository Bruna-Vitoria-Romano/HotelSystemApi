using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.DTOs
{
    public class HotelReceptionDTO
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "The name is required.")]
        [MinLength(3)]
        [MaxLength(250)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Position")]
        public string Position { get; set; }
    }
}
