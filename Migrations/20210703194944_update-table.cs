using Microsoft.EntityFrameworkCore.Migrations;

namespace office_manage_api.Migrations
{
    public partial class updatetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Checkout",
                table: "WorkingTimes",
                newName: "CheckoutDate");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Tasklists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskStatus",
                table: "Tasklists",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Tasklists");

            migrationBuilder.DropColumn(
                name: "TaskStatus",
                table: "Tasklists");

            migrationBuilder.RenameColumn(
                name: "CheckoutDate",
                table: "WorkingTimes",
                newName: "Checkout");
        }
    }
}
