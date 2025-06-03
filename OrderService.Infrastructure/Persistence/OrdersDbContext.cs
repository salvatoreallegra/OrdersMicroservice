﻿using Microsoft.EntityFrameworkCore;
using OrderService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Infrastructure.Persistence
{
    public class OrdersDbContext : DbContext
    {
        
            public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options) { }

            public DbSet<Order> Orders => Set<Order>();
            public DbSet<OrderItem> OrderDetails => Set<OrderItem>();

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrdersDbContext).Assembly);
            }
        
    }

}
