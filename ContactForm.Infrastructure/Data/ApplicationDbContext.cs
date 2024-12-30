using Microsoft.EntityFrameworkCore;
using ContactForm.Domain.Entities;

namespace ContactForm.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ContactFormInfo> ContactForms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactFormInfo>()
                .Property(c => c.DepartmentId)
                .HasConversion<int>(); // Enum'u integer olarak kaydetmek için.
        }
    }
}
