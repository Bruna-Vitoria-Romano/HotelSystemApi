using HotelSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.Interfaces
{
    public interface IHotelReceptionServices
    {
        Task<IEnumerable<HotelReceptionDTO>> GetHotelReception();
        Task<HotelReceptionDTO> GetById(int? id);
        Task Add(HotelReceptionDTO guestDto);
        Task Update(HotelReceptionDTO guestDto);
        Task Remove(int? id);
    }
}
