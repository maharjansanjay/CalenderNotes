using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarNotes.Web.Data.Migrations
{
    public partial class IdentityColumnNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserClaim",
                newName: "UserClaimId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoleClaim",
                newName: "RoleClaimId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Role",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserClaimId",
                table: "UserClaim",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleClaimId",
                table: "RoleClaim",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Role",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "Id");
        }
    }
}
