using Microsoft.EntityFrameworkCore;
using WebAPIPost.Model;

namespace WebAPIPost.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<CustomerData> CustomersData { get; set; }
	}
}
