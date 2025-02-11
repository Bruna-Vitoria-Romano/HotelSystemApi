using HotelSystem.Domain.Entities;
using HotelSystem.Domain.Interfaces;
using HotelSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Infra.Data.Repositories
{
    public class HotelGuestRepository : IHotelGuestRepository
    {
        private readonly DbContextApplication _dbContext;
        public HotelGuestRepository(DbContextApplication dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HotelGuest> CreateAsync(HotelGuest hotelGuest)
        {
            _dbContext.Add(hotelGuest);
            await _dbContext.SaveChangesAsync();
            return hotelGuest;
        }

        public async Task<HotelGuest> DeleteAsync(HotelGuest hotelGuest)
        {
            _dbContext.Remove(hotelGuest);
            await _dbContext.SaveChangesAsync();
            return hotelGuest;
        }

        public async Task<HotelGuest> GetHotelGuestByIdAsync(int? id)
        {
            return await _dbContext.Guests.FindAsync(id);
        }

        public async Task<IEnumerable<HotelGuest>> GetHotelGuestsAsync()
        {
            return await _dbContext.Guests.ToListAsync();
        }

        public async Task<HotelGuest> UpdateAsync(HotelGuest hotelGuest)
        {
            _dbContext.Update(hotelGuest);
            await _dbContext.SaveChangesAsync();
            return hotelGuest;
        }
    }
}
