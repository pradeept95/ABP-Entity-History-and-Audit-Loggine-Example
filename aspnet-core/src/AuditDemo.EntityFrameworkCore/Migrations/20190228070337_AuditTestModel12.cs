using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditDemo.Migrations
{
    public partial class AuditTestModel12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyProp2",
                table: "m_activity_log",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyProp3",
                table: "m_activity_log",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "m_activity_log",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProp2",
                table: "m_activity_log");

            migrationBuilder.DropColumn(
                name: "MyProp3",
                table: "m_activity_log");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "m_activity_log");
        }
    }
}
