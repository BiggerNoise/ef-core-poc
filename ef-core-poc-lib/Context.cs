using Microsoft.EntityFrameworkCore;

namespace ef_core_poc.model
{
    public class Context : DbContext
    {
        public DbSet<ScriptsRun> ScriptsRun { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQL2016;Database=ef-core-poc;Trusted_Connection=True;", 
                o => o.MigrationsHistoryTable("__EFMigrations", "RoundhouseE"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ScriptsRun>()
                .ToTable("scripts_run", "RoundhousE")
                .Property(s => s.id)
                .IsRequired()
                .ValueGeneratedOnAdd();
        }
    }
}
