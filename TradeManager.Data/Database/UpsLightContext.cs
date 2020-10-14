using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UCDealManagerSample.Domain.Deals;

namespace UCDealManagerSample.Infrastructure.Database
{
    public class UpsLightContext : DbContext
    {
        public DbSet<Deal> Deals { get; set; }

        public UpsLightContext (DbContextOptions options) : base(options)
        {

        }
    }
}
