using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RankenClassSchedule.Models.DomainModels;

namespace RankenClassSchedule.Models.Configuration
{
    public class ClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> entity)
        {
            //Fluent API to change the delte behavior to restrict
            entity
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Classes)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Class
                {
                    ClassId = 1,
                    Title = "Intro to C#",
                    Number = 100,
                    MilitaryTime = "0800",
                    TeacherId = 1,
                    DayId = 1
                },
                new Class
                {
                    ClassId = 2,
                    Title = "Intro to Web Dev",
                    Number = 101,
                    MilitaryTime = "0800",
                    TeacherId = 1,
                    DayId = 2
                },
                new Class
                {
                    ClassId = 3,
                    Title = "Intro to MERN",
                    Number = 103,
                    MilitaryTime = "0800",
                    TeacherId = 1,
                    DayId = 3
                },
                new Class
                {
                    ClassId = 4,
                    Title = "Intro to .NET MVC Core",
                    Number = 104,
                    MilitaryTime = "0900",
                    TeacherId = 1,
                    DayId = 4
                },
                new Class
                {
                    ClassId = 5,
                    Title = "Intro to Desktop Support",
                    Number = 105,
                    MilitaryTime = "0900",
                    TeacherId = 2,
                    DayId = 5
                },
                new Class
                {
                    ClassId = 6,
                    Title = "Advanced C#",
                    Number = 200,
                    MilitaryTime = "1000",
                    TeacherId = 3,
                    DayId = 1
                },
                new Class
                {
                    ClassId = 7,
                    Title = "Advanced Web Dev",
                    Number = 201,
                    MilitaryTime = "1000",
                    TeacherId = 4,
                    DayId = 2
                },
                new Class
                {
                    ClassId = 8,
                    Title = "Advanced MERN",
                    Number = 203,
                    MilitaryTime = "1100",
                    TeacherId = 5,
                    DayId = 3
                }

            );
        }
    }
}
