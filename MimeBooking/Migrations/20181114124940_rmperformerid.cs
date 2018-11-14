using Microsoft.EntityFrameworkCore.Migrations;

namespace MimeBooking.Migrations
{
    public partial class rmperformerid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerformerId",
                table: "Bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerformerId",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);
        }
    }
}
