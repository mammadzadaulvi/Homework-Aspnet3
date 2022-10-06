using front_to_back.Models;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }  
        
        public DbSet<RecentWorkComponent> RecentWorkComponents { get; set; }  

        public DbSet<ContactIntroComponent> ContactIntroComponent { get; set; }

        public DbSet<AboutIntroComponent> AboutIntroComponent { get; set; }

        public DbSet<ContactCreateComponent> ContactCreateComponent { get; set; }

        public DbSet<ContactMediaComponent> ContactMediaComponents { get; set; }
    }
}
