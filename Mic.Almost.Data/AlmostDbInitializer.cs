using System.Data.Entity;

namespace Mic.Almost.Data
{
    public class AlmostDbInitializer : CreateDatabaseIfNotExists<AlmostDbContext>//CreateDatabaseIfNotExists, DropCreateDatabaseIfModelChanges, AlwaysRecreateDatabase
    {
        protected override void Seed(AlmostDbContext context)
        {
            //Seed initial data here
        }
    }
}