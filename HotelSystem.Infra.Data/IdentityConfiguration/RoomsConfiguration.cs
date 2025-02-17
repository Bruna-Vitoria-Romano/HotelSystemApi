using HotelSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Infra.Data.IdentityConfiguration
{
    public class RoomsConfiguration : IEntityTypeConfiguration<Rooms>
    {
        public void Configure(EntityTypeBuilder<Rooms> builder)
        {
            builder.HasKey(t => t.NumberRoom);
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.IdGuest).IsRequired();
        }
    }
}
