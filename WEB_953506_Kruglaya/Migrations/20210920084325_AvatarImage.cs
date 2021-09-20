using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_953506_Kruglaya.Migrations
{
    public partial class AvatarImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "AvatarImage",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarImage",
                table: "AspNetUsers");
        }
    }
}
