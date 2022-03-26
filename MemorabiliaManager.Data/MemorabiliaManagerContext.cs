using Microsoft.EntityFrameworkCore;
using MemorabiliaManager.Domain;

namespace MemorabiliaManager.Data
{
    public class MemorabiliaManagerContext : DbContext
    {
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PlayerItem> PlayerItems { get; set; }

        //Temp override, this is considered poor practice
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=MemorabiliaManagerAppData");
        }
    }
}
