using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MimeBooking.Migrations
{
    public partial class datetimefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Bookings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Bookings",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
