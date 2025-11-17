using Microsoft.EntityFrameworkCore;
using RankenClassSchedule.Models.DomainModels;

namespace RankenClassSchedule.Models.DataLayer
{
    public class ClassScheduleContext : DbContext
    {
        public ClassScheduleContext(DbContextOptions<ClassScheduleContext> options)
            : base(options)
        {
        }
        public DbSet<Day> Days { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuration.DayConfig());
            modelBuilder.ApplyConfiguration(new Configuration.TeacherConfig());
            modelBuilder.ApplyConfiguration(new Configuration.ClassConfig());
        }
    }
}
