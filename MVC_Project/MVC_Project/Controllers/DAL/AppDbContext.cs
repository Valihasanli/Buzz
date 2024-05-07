using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Controllers.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Card> Cards { get; set; }
    }
}
