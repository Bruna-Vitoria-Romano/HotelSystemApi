using HotelSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Domain.Interfaces
{
    public interface IHotelGuestRepository
    {
        Task<IEnumerable<HotelGuest>> GetHotelGuestsAsync();
        Task<HotelGuest> GetHotelGuestByIdAsync(int? id);
        Task<HotelGuest> CreateAsync(HotelGuest hotelGuest);
        Task<HotelGuest> UpdateAsync(HotelGuest hotelGuest);
        Task<HotelGuest> DeleteAsync(HotelGuest hotelGuest);
    }
}
