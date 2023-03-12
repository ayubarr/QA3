using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QualityAssurance2.Data.Migrations
{
    /// <inheritdoc />
    public partial class qa87 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdd",
                value: new DateTime(2023, 3, 12, 22, 12, 43, 951, DateTimeKind.Local).AddTicks(2081));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdd",
                value: new DateTime(2023, 3, 12, 22, 8, 6, 967, DateTimeKind.Local).AddTicks(3843));
        }
    }
}
