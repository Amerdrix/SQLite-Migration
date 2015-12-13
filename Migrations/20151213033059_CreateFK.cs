using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace EFTest.Migrations
{
    public partial class CreateFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Model1Id",
                table: "Model2",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
            migrationBuilder.AddForeignKey(
                name: "FK_Model2_Model1_Model1Id",
                table: "Model2",
                column: "Model1Id",
                principalTable: "Model1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Model2_Model1_Model1Id", table: "Model2");
            migrationBuilder.DropColumn(name: "Model1Id", table: "Model2");
        }
    }
}
