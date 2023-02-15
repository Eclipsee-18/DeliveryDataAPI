using Microsoft.EntityFrameworkCore;
using WebAPIPost.Model;

namespace WebAPIPost.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}
		public DbSet<CustomerData> CustomersData { get; set; }
		public DbSet<UserInfo>? UserInfos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserInfo>(entity =>
			{
				entity.HasNoKey();
				entity.ToTable("UserInfo");
				entity.Property(e => e.UserId).HasColumnName("UserId");
				entity.Property(e => e.DisplayName).HasMaxLength(60).IsUnicode(false);
				entity.Property(e => e.UserName).HasMaxLength(30).IsUnicode(false);
				entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false);
				entity.Property(e => e.Password).HasMaxLength(20).IsUnicode(false);
				entity.Property(e => e.CreatedDate).IsUnicode(false);
			});
		}
	}
}
