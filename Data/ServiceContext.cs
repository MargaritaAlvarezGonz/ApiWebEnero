using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<ProductItem> Products { get; set; }
        public DbSet<OrderItem> Orders { get; set; }
        public DbSet<PersonItem> Persons { get; set; }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<BuyerItem> Buyers { get; set; }
        public DbSet<UserRollItem> UserRols { get; set; }
        public DbSet<RolItem> RolItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductItem>()
            .ToTable("Products");

            builder.Entity<OrderItem>()
            .ToTable("Orders")
            .HasOne<ProductItem>()
            .WithMany()
            .HasForeignKey(o => o.ProductId);

            builder.Entity<PersonItem>()
            .ToTable("Persons");


            builder.Entity<UserItem>(user =>
            {
                user.ToTable("Users");
                user.HasOne<PersonItem>().WithMany().HasForeignKey(u => u.IdPerson);
                user.HasOne<UserRollItem>().WithMany().HasForeignKey(u => u.IdRol);
            });


            builder.Entity<UserRollItem>()
            .ToTable("UserRols");

            builder.Entity<RolItem>()
            .ToTable("Roles");

            builder.Entity<BuyerItem>(buyer =>
            {
                buyer.ToTable("Buyers");
                buyer.HasOne<PersonItem>().WithMany().HasForeignKey(b => b.IdPerson);
                buyer.HasOne<UserRollItem>().WithMany().HasForeignKey(b => b.IdRol);
            });
            

        }   
    }

    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}
