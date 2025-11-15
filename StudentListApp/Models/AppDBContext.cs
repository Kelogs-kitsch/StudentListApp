using Microsoft.EntityFrameworkCore;
using System;
namespace StudentListApp.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
