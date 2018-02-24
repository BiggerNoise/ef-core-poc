using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace efcorepoclib.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RoundhousE");

            migrationBuilder.CreateTable(
                name: "scripts_run",
                schema: "RoundhousE",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    entered_by = table.Column<string>(nullable: true),
                    entry_date = table.Column<DateTime>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: true),
                    one_time_script = table.Column<bool>(nullable: false),
                    script_name = table.Column<string>(nullable: true),
                    text_hash = table.Column<string>(nullable: true),
                    text_of_script = table.Column<string>(nullable: true),
                    version_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scripts_run", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "scripts_run",
                schema: "RoundhousE");
        }
    }
}
