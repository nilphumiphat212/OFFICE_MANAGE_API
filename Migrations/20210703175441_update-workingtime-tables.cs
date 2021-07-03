using Microsoft.EntityFrameworkCore.Migrations;

namespace office_manage_api.Migrations
{
    public partial class updateworkingtimetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenrateDate",
                table: "WorkingTimeOtps",
                newName: "GenerateDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenerateDate",
                table: "WorkingTimeOtps",
                newName: "GenrateDate");
        }
    }
}
