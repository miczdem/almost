using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Mic.Almost.Domain;
using Mic.Almost.RepositoryInterfaces;

namespace Mic.Almost.Data
{
    public class AlmostDbContext : DbContext, IAlmostDbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        public AlmostDbContext()
            : base("name=DefaultConnection")
        {
        }

        public AlmostDbContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
