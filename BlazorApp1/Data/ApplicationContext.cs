using BlazorApp1.Data.ModelData;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(
			DbContextOptions<ApplicationContext> options) : base(options)
		{

		}
		public DbSet<TableCustomer> TableCustomer { get; set; }
		

	}
}
