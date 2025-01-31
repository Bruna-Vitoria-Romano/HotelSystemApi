using HotelSystemApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Domain.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Rooms>> GetRoomsAsync(int? numberRoom);
        Task<Rooms> GetRoomsByIdAsync(int? id);
        Task<Rooms> GetIdGuestByIdAsync(int? id);
        Task<Rooms> CreateAsync(Rooms room);
        Task<Rooms> UpdateAsync(Rooms room);
        Task<Rooms> DeleteAsync(Rooms room);
    }
}
