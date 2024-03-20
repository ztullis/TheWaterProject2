using Microsoft.EntityFrameworkCore;

namespace TheWaterProject2.Models
{
    public class WaterProjectContext2: DbContext
    {
        public WaterProjectContext2(DbContextOptions<WaterProjectContext2> context) : base(context) { }

        public DbSet<Project> Projects { get; set; }
    }
}
