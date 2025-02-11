using HotelSystem.Domain.Entities;
using HotelSystem.Domain.Interfaces;
using HotelSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.Infra.Data.Repositories
{
    public class RoomsRepository : IRoomRepository
    {
        private readonly DbContextApplication _dbContext;
        public RoomsRepository(DbContextApplication dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Rooms> CreateAsync(Rooms room)
        {
            _dbContext.Add(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }

        public async Task<Rooms> DeleteAsync(Rooms room)
        {
            _dbContext.Remove(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }

        public async Task<Rooms> GetIdGuestByIdAsync(int? id)
        {
            return await _dbContext.Rooms.FindAsync(id);
        }

        public async Task<IEnumerable<Rooms>> GetRoomsAsync()
        {
            return await _dbContext.Rooms.ToListAsync();
        }

        public async Task<Rooms> GetRoomsByIdAsync(int? id)
        {
            return await _dbContext.Rooms.FindAsync(id);
        }

        public async Task<Rooms> UpdateAsync(Rooms room)
        {
            _dbContext.Update(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }
    }
}
