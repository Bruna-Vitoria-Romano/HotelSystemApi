using HotelSystemApi.Domain.Entities;
using HotelSystemApi.Domain.Interfaces;
using HotelSystemApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Infra.Data.Repositories
{
    public class HotelReceptionRepository : IHotelReceptionRepository
    {
        private readonly DbContextApplication _dbContext;
        public HotelReceptionRepository(DbContextApplication dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HotelReception> CreateAsync(HotelReception hotelReception)
        {
            _dbContext.Add(hotelReception);
            await _dbContext.SaveChangesAsync();
            return hotelReception;
        }

        public async Task<HotelReception> DeleteAsync(HotelReception hotelReception)
        {
            _dbContext.Remove(hotelReception);
            await _dbContext.SaveChangesAsync();
            return hotelReception;
        }

        public async Task<IEnumerable<HotelReception>> GetHotelReceptionAsync()
        {
            return await _dbContext.Reception.ToListAsync();
        }

        public async Task<HotelReception> GetHotelReceptionByIdAsync(int? id)
        {
            return await _dbContext.Reception.FindAsync(id);
        }

        public async Task<HotelReception> UpdateAsync(HotelReception hotelReception)
        {
            _dbContext.Update(hotelReception);
            await _dbContext.SaveChangesAsync();
            return hotelReception;
        }
    }
}
