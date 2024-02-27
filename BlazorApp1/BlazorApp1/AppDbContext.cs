using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using BlazorApp1.Components.Pages.Classes;

namespace BlazorApp1
{
	public class AppDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Part> Parts { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
	}
}
