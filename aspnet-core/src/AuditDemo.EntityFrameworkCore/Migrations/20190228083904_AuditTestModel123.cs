using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditDemo.Migrations
{
    public partial class AuditTestModel123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_m_activity_log",
                table: "m_activity_log");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "m_activity_log");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "m_activity_log");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "m_activity_log");

            migrationBuilder.RenameTable(
                name: "m_activity_log",
                newName: "AuditTestModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditTestModel",
                table: "AuditTestModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditTestModel",
                table: "AuditTestModel");

            migrationBuilder.RenameTable(
                name: "AuditTestModel",
                newName: "m_activity_log");

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "m_activity_log",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "m_activity_log",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "m_activity_log",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_activity_log",
                table: "m_activity_log",
                column: "Id");
        }
    }
}
