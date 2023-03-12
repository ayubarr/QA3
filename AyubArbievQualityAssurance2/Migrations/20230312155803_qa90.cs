using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QualityAssurance2.Data.Migrations
{
    /// <inheritdoc />
    public partial class qa90 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdd",
                value: new DateTime(2023, 3, 12, 21, 58, 2, 745, DateTimeKind.Local).AddTicks(3146));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdd",
                value: new DateTime(2023, 2, 27, 2, 6, 45, 121, DateTimeKind.Local).AddTicks(4971));
        }
    }
}
