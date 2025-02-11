using HotelSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.Interfaces
{
    public interface IHotelGuestServices
    {
        Task<IEnumerable<HotelGuestDTO>> GetGuest();
        Task<HotelGuestDTO> GetById(int? id);
        Task Add(HotelGuestDTO guestDto);
        Task Update(HotelGuestDTO guestDto);
        Task Remove(int? id);
    }
}
