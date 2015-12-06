using System.Data.Entity;
using Mic.Almost.Domain;

namespace Mic.Almost.RepositoryInterfaces
{
    public interface IAlmostDbContext
    {
        IDbSet<Customer> Customers { get; set; }
        void Commit();
    }
}