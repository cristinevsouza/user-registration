using UserRegistration.Infrastructure.Adress;
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
		public DbSet<AdressEntity> Adresses { get; set; }

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

			modelBuilder.Entity<AdressEntity>().ToTable("Adresses");
			modelBuilder.Entity<AdressEntity>().HasKey(e => e.Id);

			base.OnModelCreating(modelBuilder);
		}
	}
}
