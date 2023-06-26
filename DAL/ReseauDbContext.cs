using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ReseauDbContext : DbContext
    {
        public ReseauDbContext(DbContextOptions<ReseauDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Adresses { get; set; }
    }
}