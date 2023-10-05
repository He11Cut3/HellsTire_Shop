using Hells_Tire.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hells_Tire.Infrastructure
{
	public class DataContext: IdentityDbContext<AppUser>
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{ }

		public DbSet<HellsTireProduct> HellsTireProducts { get; set; }

		public DbSet<HellsTireCategory > HellsTireCategories { get; set; }
	}
}
