using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace office_manage_api.Migrations
{
    public partial class workingtimetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkingTimeOtps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Otp = table.Column<int>(type: "int", nullable: false),
                    GenrateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTimeOtps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorkingTimes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckinBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChckinOtp = table.Column<int>(type: "int", nullable: false),
                    CheckoutOtp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTimes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkingTimeOtps");

            migrationBuilder.DropTable(
                name: "WorkingTimes");
        }
    }
}
