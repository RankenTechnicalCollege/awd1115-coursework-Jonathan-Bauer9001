using Microsoft.EntityFrameworkCore;
namespace Project4dash1.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Categories> Categories { get; set; } = null!;
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact() {ContactId=1, FirstName = "Delores",LastName="Del Rio",Phone="555-987-6543",Email="delores@hotmail.com", DateAdded = new DateTime(), CategoriesId = 1},
                new Contact() {ContactId=2, FirstName = "Efren",LastName="Herrera",Phone="555-123-4567",Email= "efren@aol.com",DateAdded = new DateTime(),  CategoriesId = 3},
                new Contact() {ContactId=3, FirstName = "Mary",LastName="Ellen",Phone="555-456-7890",Email= "maryellen@yahoo.com",DateAdded = new DateTime(), CategoriesId = 2 }
                );
            modelBuilder.Entity<Categories>().HasData(
                new Categories() { CategoriesId = 1, CategoryName = "Family" },
                new Categories() { CategoriesId = 2, CategoryName = "Friend" },
                new Categories() { CategoriesId = 3, CategoryName = "Work" }
                );
        }
    }
    
}

