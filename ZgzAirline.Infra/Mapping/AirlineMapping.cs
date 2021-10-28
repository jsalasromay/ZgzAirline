using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ZgzAirline.Core.Models;

namespace ZgzAirline.Infra.Mapping
{
    public class AirlineMapping : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            _ = builder.ToTable("Airline");
            builder.HasKey(b => b.Id);
        }
    }
}
