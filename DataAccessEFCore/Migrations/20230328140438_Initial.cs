using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessEFCore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 28, 19, 34, 38, 180, DateTimeKind.Local).AddTicks(6592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 28, 19, 34, 38, 180, DateTimeKind.Local).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7299));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 3, 28, 19, 34, 38, 180, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 3, 26, 23, 41, 40, 248, DateTimeKind.Local).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2023, 3, 28, 19, 34, 38, 180, DateTimeKind.Local).AddTicks(6029));
        }
    }
}
