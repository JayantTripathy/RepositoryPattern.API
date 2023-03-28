using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessEFCore.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(5732));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(6777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 38, 55, 219, DateTimeKind.Local).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7299));
        }
    }
}
