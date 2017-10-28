﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Application.Models
{
    public class ApplicationContext : DbContext
    {
        private IConfigurationRoot config;
        
        public DbSet<Event> Events { get; set; }
        
        public ApplicationContext(DbContextOptions options, IConfigurationRoot config) : base(options)
        {
            this.config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(config["ConnectionStrings:AppContextConnection"]);
        }
    }
}
