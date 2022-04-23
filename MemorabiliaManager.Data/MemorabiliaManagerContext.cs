using MemorabiliaManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace MemorabiliaManager.Data
{
	public class MemorabiliaManagerContext : DbContext
	{
		public DbSet<EntertainmentCategory> EntertainmentCategories { get; set; }
		public DbSet<Entertainment> Entertainment { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemCategory> ItemCategories { get; set; }
		public DbSet<Signature> Signatures { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<AuthenticationService> AuthenticationServices { get; set; }
		public DbSet<Authentication> Authentications { get; set; }

		//Temp override, this is considered poor practice
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=MemorabiliaManagerAppData");
		}
	}
}
