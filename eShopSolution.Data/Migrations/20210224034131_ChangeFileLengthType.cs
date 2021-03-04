using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e3dd2764-6c09-435a-b043-33ded4d71139");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b00db104-edd6-4b9e-97b3-45433440592b"),
                column: "ConcurrencyStamp",
                value: "b4997b1d-e1b1-44f5-af27-40bcd7100fb1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72992b61-1dbe-430c-b483-9b0731f09afd", "AQAAAAEAACcQAAAAEBOW3mRTAVSsKFxfQDemMFAY49FykckeQdaQgZZn62ZdGB4jHgbyvl1DJYNTsINaqg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2021, 2, 24, 10, 41, 31, 55, DateTimeKind.Local).AddTicks(2064));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "97655d91-f7d3-40a8-9d51-4bc66f9b9324");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b00db104-edd6-4b9e-97b3-45433440592b"),
                column: "ConcurrencyStamp",
                value: "59de400e-178f-469b-81d4-e99951f9962f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3c6f11e-4ac2-41e3-8527-84d43c9389ff", "AQAAAAEAACcQAAAAEKcqyWW3Zrar9PmEs7Zr/o9gZ5GhHDqHRxB3HSSLXR3ORfRHvykhID4+Cd2T69oHfA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2021, 2, 23, 14, 7, 20, 175, DateTimeKind.Local).AddTicks(6801));
        }
    }
}
