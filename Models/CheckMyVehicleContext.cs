using Microsoft.EntityFrameworkCore;

namespace CheckMyVehicle.Models
{
    public class CheckMyVehicleContext : DbContext
    {
        public CheckMyVehicleContext(DbContextOptions<CheckMyVehicleContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<VehiclePart> VehicleParts { get; set; }
        public DbSet<VehicleReview> VehicleReviews { get; set; }
        public DbSet<PartReview> PartReviews { get; set; }
    }
}