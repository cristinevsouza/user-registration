using UserRegistration.Infrastructure.Address;
using UserRegistration.Infrastructure.User;
using Microsoft.EntityFrameworkCore;

namespace UserRegistration.Infrastructure.Database
{
    public class DataContext : DbContext
    {
		public DataContext() : base()
		{
		}

		public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
		}

        public DbSet<UserEntity> Users { get; set; }
		public DbSet<AddressEntity> Addresses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseNpgsql();
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<UserEntity>().ToTable("Users");
			modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);

			modelBuilder.Entity<AddressEntity>().ToTable("Addresses");
			modelBuilder.Entity<AddressEntity>().HasKey(e => e.Id);

			base.OnModelCreating(modelBuilder);
		}
	}
}
