using Clean.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }

        public UniversityDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
