using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.WebApi.Migrations
{
    public partial class orderDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "OrderDate",
                table: "Teams",
                type: "date",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Teams");
        }
    }
}
