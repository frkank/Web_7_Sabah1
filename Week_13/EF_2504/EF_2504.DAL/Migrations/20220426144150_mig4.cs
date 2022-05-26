using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_2504.DAL.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 17, 41, 49, 839, DateTimeKind.Local).AddTicks(2173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 17, 37, 17, 572, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 17, 41, 49, 822, DateTimeKind.Local).AddTicks(1975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 17, 37, 17, 555, DateTimeKind.Local).AddTicks(1123));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 17, 37, 17, 572, DateTimeKind.Local).AddTicks(538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 17, 41, 49, 839, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 17, 37, 17, 555, DateTimeKind.Local).AddTicks(1123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 17, 41, 49, 822, DateTimeKind.Local).AddTicks(1975));
        }
    }
}
