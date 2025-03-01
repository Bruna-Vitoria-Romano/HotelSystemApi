﻿using HotelSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Infra.Data.IdentityConfiguration
{
    public class HotelReceptionConfiguration : IEntityTypeConfiguration<HotelReception>
    {
        public void Configure(EntityTypeBuilder<HotelReception> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(p => p.Name).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50).IsRequired();
        }
    }
}
