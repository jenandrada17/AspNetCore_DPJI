using DPJI.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DPJI.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TblUsers> TblUsers { get; set; } 
    }
}
