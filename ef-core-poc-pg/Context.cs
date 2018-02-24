using Microsoft.EntityFrameworkCore;

namespace ef_core_poc.pg
{
    public class Context : model.Context
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(@"host=localhost;database=ef-core-poc;username=postgres;password=a.fine.password", 
                o => o.MigrationsHistoryTable("__EFMigrations", "RoundhousE"));
        }
    }
}
