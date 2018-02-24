using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace efcorepocsql.Migrations
{
    public partial class AddScriptsRun_run_action : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "run_action",
                schema: "RoundhousE",
                table: "scripts_run",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "run_action",
                schema: "RoundhousE",
                table: "scripts_run");
        }
    }
}
