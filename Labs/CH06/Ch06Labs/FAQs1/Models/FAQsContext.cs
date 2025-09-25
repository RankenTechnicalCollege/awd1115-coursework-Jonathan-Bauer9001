using Microsoft.EntityFrameworkCore;

namespace FAQs1.Models
{
    public class FAQsContext :DbContext
    {
        public FAQsContext(DbContextOptions<FAQsContext> options)
            : base(options)
        {
        }
        public DbSet<FAQ> FAQs { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topic> Topics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "general", Name = "General" },
                new Category { CategoryId = "history", Name = "History" }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "asp", Name = "ASP.NET Core" },
                new Topic { TopicId = "blz", Name = "Blazor" },
                new Topic { TopicId = "ef", Name = "Entity Framework" }
            );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQId = 1,
                    Question = "What is ASP.NET Core?",
                    Answer = "ASP.NET Core is a cross-platform, high-performance framework for building modern, cloud-based, Internet-connected applications.",
                    CategoryId = "general",
                    TopicId = "asp"
                },
                new FAQ
                {
                    FAQId = 2,
                    Question = "When was ASP.NET Core released?",
                    Answer = "ASP.NET Core 1.0 was released on June 7, 2016.",
                    CategoryId = "history",
                    TopicId = "asp"
                },
                new FAQ
                {
                    FAQId = 3,
                    Question = "What is Blazor?",
                    Answer = "Blazor is a framework for building interactive client-side web UI with .NET.",
                    CategoryId = "general",
                    TopicId = "blz"
                },
                new FAQ {
                    FAQId = 5,
                    Question = "When was Blazor released?",
                    Answer = "Blazor was released in May 14, 2020 as part of .NET 5.",
                    CategoryId = "history",
                    TopicId = "blz"
                },
                new FAQ
                {
                    FAQId = 4,
                    Question = "What is Entity Framework?",
                    Answer = "Entity Framework (EF) is an open source object-relational mapping (ORM) framework for ADO.NET.",
                    CategoryId = "general",
                    TopicId = "ef"
                },
                new FAQ
                {
                    FAQId = 6,
                    Question = "When was Entity Framework released?",
                    Answer = "Entity Framework 1.0 was released in August 11, 2008.",
                    CategoryId = "history",
                    TopicId = "ef"
                }
            );
        }
    }
}
