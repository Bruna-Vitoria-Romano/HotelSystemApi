using HotelSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Domain.Interfaces
{
    public interface IHotelReceptionRepository
    {
        Task<IEnumerable<HotelReception>> GetHotelReceptionAsync();
        Task<HotelReception> GetHotelReceptionByIdAsync(int? id);
        Task<HotelReception> CreateAsync(HotelReception hotelReception);
        Task<HotelReception> UpdateAsync(HotelReception hotelReception);
        Task<HotelReception> DeleteAsync(HotelReception hotelReception);
    }
}
