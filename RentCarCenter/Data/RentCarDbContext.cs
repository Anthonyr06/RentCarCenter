using RentCarCenter.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace RentCarCenter.Data
{
    public class RentCarDbContext : DbContext
    {
        //public RentCarDbContext(DbContextOptions<RentCarDbContext> context)
        //    : base(context) { }

        #region DbSet

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<RentDetail> RentDetails { get; set; }
        public DbSet<ReturnDetail> ReturnDetails { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=RentCarCenterDB;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            modelBuilder.Entity<Customer>()
                .HasIndex(b => b.Identification)
                .IsUnique();
            modelBuilder.Entity<Customer>()
                .HasIndex(b => b.CreditCard)
                .IsUnique();


            modelBuilder.Entity<Employee>()
                .HasIndex(b => b.Identification)
                .IsUnique();


            modelBuilder.Entity<Inspection>()
                .HasOne(p => p.RentDetail)
                .WithMany(p => p.Inspection)
                .HasForeignKey(p => p.RentDetailId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Inspection");
            modelBuilder.Entity<Inspection>()
                .Property(b => b.Date)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("getdate()");


            modelBuilder.Entity<RentDetail>()
                .HasOne(p => p.Vehicle)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.VehicleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Vehicle");
            modelBuilder.Entity<RentDetail>()
                .HasOne(p => p.Customer)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Customer");
            modelBuilder.Entity<RentDetail>()
                .HasOne(p => p.Employee)
                .WithMany(p => p.RentDetail)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_RentDetail_Employee");
            modelBuilder.Entity<RentDetail>()
                .Property(b => b.RentDate)
                .IsRequired()
                .HasColumnType("date")
                .HasDefaultValueSql("getdate()");



            modelBuilder.Entity<Vehicle>()
                .HasOne(p => p.FuelType)
                .WithMany(p => p.Vehicle)
                .HasForeignKey(p => p.FuelTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Vehicle_FuelType");
            modelBuilder.Entity<Vehicle>()
                .HasOne(p => p.VehicleModel)
                .WithMany(p => p.Vehicle)
                .HasForeignKey(p => p.VehicleModelId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Vehicle_VehicleModel");
            modelBuilder.Entity<Vehicle>()
                .HasIndex(b => b.NoChassis)
                .IsUnique();
            modelBuilder.Entity<Vehicle>()
                .HasIndex(b => b.NoMotor)
                .IsUnique();
            modelBuilder.Entity<Vehicle>()
                .HasIndex(b => b.NoLicensePlate)
                .IsUnique();
        }
    }
}
