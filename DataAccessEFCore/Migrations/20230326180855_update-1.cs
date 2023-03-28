using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessEFCore.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(6777));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);
        }
    }
}
