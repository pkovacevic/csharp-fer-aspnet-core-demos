using System.Data.Entity;
using ASPNetCoreDemo1.Core.Models;

namespace ASPNetCoreDemo1.Core
{
    /// <summary>
    /// We'll explain this code on Database lecture...
    /// </summary>
    public class StudentDatabase : DbContext
    {
        public IDbSet<Student> Students { get; set; }

        // Hardcoded connection string is a terrible practice
        // You should use config files, but for demo simplicity this is okay 
        public StudentDatabase() : base("Server=(localdb)\\mssqllocaldb;Database=aspnet-MvcMovie-4ae3798a;Trusted_Connection=True;MultipleActiveResultSets=true")
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
