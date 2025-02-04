using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotelSystemApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using HotelSystemApi.Domain.Interfaces;
using HotelSystemApi.Infra.Data.Repositories;

namespace HotelSystemApi.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<DbContextApplication>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(DbContextApplication).Assembly.FullName)));

            services.AddScoped<IHotelGuestRepository, HotelGuestRepository>();
            services.AddScoped<IHotelReceptionRepository, HotelReceptionRepository>();
            services.AddScoped<IRoomRepository, RoomsRepository>();

            return services;
        }
    }
}
