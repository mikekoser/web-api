using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebAPISandbox.Models;

namespace WebAPISandbox.DAL
{
	public class WebAPIDataContext : DbContext
	{
		public WebAPIDataContext() : base("WebAPIDataContext") { }

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Item> Items { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
		}
	}
}