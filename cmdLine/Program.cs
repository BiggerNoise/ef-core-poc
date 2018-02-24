using ef_core_poc.model;
using System;
using Microsoft.EntityFrameworkCore;

namespace ef_core_poc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var ctxt = CreateContext(args[0]))
            {
                Console.WriteLine("Migrating the database");
                ctxt.Database.Migrate();
                Console.WriteLine("Migrated the database");

            }
            using(var ctxt = CreateContext(args[0]))
            {
                Console.WriteLine("In the context");
                var script = new ScriptsRun()
                {
                    script_name = "test_script.sql",
                    text_hash = "42",
                    one_time_script = true
                };

                ctxt.ScriptsRun.Add(script);
                ctxt.SaveChanges();
            }
        }
        private static ContextBase CreateContext(string arg)
        {
            switch(arg)
            {
                case "pg":
                    return new pg.Context();
                case "mssql":
                default:
                    return new sql.Context();
            }
        }
    }
}
