using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Supalib.Migrations
{
    /// <inheritdoc />
    public partial class newporpsresume : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Resumes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Resumes",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Resumes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Resumes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UploadedAt",
                table: "Resumes",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "UploadedAt",
                table: "Resumes");
        }
    }
}
