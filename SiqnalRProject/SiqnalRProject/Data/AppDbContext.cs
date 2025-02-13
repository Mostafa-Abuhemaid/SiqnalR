using Microsoft.EntityFrameworkCore;
using SiqnalRProject.Model;
using System.Collections.Generic;

namespace SiqnalRProject.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Notification> Notifications { get; set; }

    }
}