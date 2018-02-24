using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ef_core_poc.model 
{
    public class Context : DbContext
    {
        public DbSet<ScriptsRun> ScriptsRun { get; set; }
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
