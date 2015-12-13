using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace EFTest.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Model1",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model1", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Model2",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Model1");
            migrationBuilder.DropTable("Model2");
        }
    }
}
