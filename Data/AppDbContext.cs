using BlazingShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().ToTable("Categories");
			modelBuilder.Entity<Product>().ToTable("Products");
		}
	}
}
