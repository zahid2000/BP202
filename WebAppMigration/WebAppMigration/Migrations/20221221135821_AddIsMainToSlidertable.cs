﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMigration.Migrations
{
    public partial class AddIsMainToSlidertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Sliders");
        }
    }
}
