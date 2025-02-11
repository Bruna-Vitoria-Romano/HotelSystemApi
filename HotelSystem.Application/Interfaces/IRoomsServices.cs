using HotelSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Application.Interfaces
{
    public interface IRoomsServices
    {
        Task<IEnumerable<RoomsDTO>> GetRooms();
        Task<RoomsDTO> GetRoomsById(int? numberRoom);
        Task<RoomsDTO> GetIdGuest(int? id);
        Task Add(RoomsDTO roomsDTO);
        Task update(RoomsDTO roomsDTO);
        Task Remove(int? numberRoom);
    }
}
