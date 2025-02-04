﻿using HotelSystemApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystemApi.Infra.Data.IdentityConfiguration
{
    public class RoomsConfiguration : IEntityTypeConfiguration<Rooms>
    {
        public void Configure(EntityTypeBuilder<Rooms> builder)
        {
            builder.HasKey(t => t.NumberRoom);
            builder.Property(p => p.Status).IsRequired();
            //builder.Property(p => p.IdGuest).IsRequired();
        }
    }
}
