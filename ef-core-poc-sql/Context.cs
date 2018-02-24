using Microsoft.EntityFrameworkCore;

namespace ef_core_poc.sql
{
    public class Context : model.Context
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQL2016;Database=ef-core-poc;Trusted_Connection=True;", 
                o => o.MigrationsHistoryTable("__EFMigrations", "RoundhousE"));
        }
    }
}
