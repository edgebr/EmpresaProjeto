using System.Data.Entity.ModelConfiguration.Conventions;
using EmpresaProjeto.WebApi.Models;

namespace EmpresaProjeto.WebApi
{
    using System.Data.Entity;

    public class DbExemploContext : DbContext
    {
        // Your context has been configured to use a 'DbExemploContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmpresaProjeto.WebApi.DbExemploContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbExemploContext' 
        // connection string in the application configuration file.
        public DbExemploContext() : base("name=DbExemploContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}