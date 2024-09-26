using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cat_Adoption.Models
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cat> CatsForAdoption { get; set; }
    }
}

