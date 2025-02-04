using HotelSystemApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Infra.Data.IdentityConfiguration
{
    public class HotelGuestConfiguration : IEntityTypeConfiguration<HotelGuest>
    {
        public void Configure(EntityTypeBuilder<HotelGuest> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50).IsRequired();
        } 
    }
}
