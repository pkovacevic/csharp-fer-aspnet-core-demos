using System.Data.Entity;
using ASPNetCoreDemo1.Core.Models;

namespace ASPNetCoreDemo1.Core
{
    /// <summary>
    /// We'll explain this code on Database lecture...
    /// </summary>
    public class StudentDbContext : DbContext
    {
        public IDbSet<Student> Students { get; set; }

        // Hardcoded connection string is a terrible practice
        // You should use config files, but for demo simplicity this is okay 
        public StudentDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=StudentDb;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(c => c.Jmbag);
            modelBuilder.Entity<Student>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<Student>().Property(c => c.LastName).IsRequired();
        }
    }
}
