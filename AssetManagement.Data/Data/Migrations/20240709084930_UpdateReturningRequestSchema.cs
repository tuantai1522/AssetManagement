using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReturningRequestSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("310d7095-14ab-4db5-80e8-342edade11ed"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("46702563-2808-41b1-892d-3b7b26d9737b"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("8621630b-f5fe-4861-8b70-f0617d08668e"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("a1746cd6-d446-4304-931c-dc135c70fa1a"));

            migrationBuilder.AddColumn<Guid>(
                name: "RequestedByUserId",
                table: "ReturningRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("a50232d9-c3da-44d6-81a1-da151617d805"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.InsertData(
                table: "ReturningRequest",
                columns: new[] { "Id", "AcceptedByUserId", "AssignmentId", "RequestedByUserId", "ReturnedDate", "State" },
                values: new object[,]
                {
                    { new Guid("2e8c9694-c0d6-4252-8d4c-8d9cb2608297"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("a50232d9-c3da-44d6-81a1-da151617d805"), new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da"), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(303), 1 },
                    { new Guid("d229472a-9bab-4105-b4e7-7e63d9c0c50a"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"), new Guid("60c17fcb-178e-4181-ad50-3690524f5190"), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(298), 1 },
                    { new Guid("d65a4de9-e65b-4df8-a4ca-937b0e2945a3"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"), new Guid("59339cda-7d6d-4cbf-833c-367d7db965e1"), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(287), 1 },
                    { new Guid("d892c782-34de-401f-abd8-145f2682b463"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"), new Guid("5a1c0199-f674-408d-84fe-37e2a890d93b"), new DateTime(2024, 7, 9, 15, 49, 28, 667, DateTimeKind.Local).AddTicks(294), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturningRequest_RequestedByUserId",
                table: "ReturningRequest",
                column: "RequestedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturningRequest_AspNetUsers_RequestedByUserId",
                table: "ReturningRequest",
                column: "RequestedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturningRequest_AspNetUsers_RequestedByUserId",
                table: "ReturningRequest");

            migrationBuilder.DropIndex(
                name: "IX_ReturningRequest_RequestedByUserId",
                table: "ReturningRequest");

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("2e8c9694-c0d6-4252-8d4c-8d9cb2608297"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("d229472a-9bab-4105-b4e7-7e63d9c0c50a"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("d65a4de9-e65b-4df8-a4ca-937b0e2945a3"));

            migrationBuilder.DeleteData(
                table: "ReturningRequest",
                keyColumn: "Id",
                keyValue: new Guid("d892c782-34de-401f-abd8-145f2682b463"));

            migrationBuilder.DropColumn(
                name: "RequestedByUserId",
                table: "ReturningRequest");

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("a50232d9-c3da-44d6-81a1-da151617d805"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"),
                columns: new[] { "AssignedDate", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.InsertData(
                table: "ReturningRequest",
                columns: new[] { "Id", "AcceptedByUserId", "AssignmentId", "ReturnedDate", "State" },
                values: new object[,]
                {
                    { new Guid("310d7095-14ab-4db5-80e8-342edade11ed"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2903), 1 },
                    { new Guid("46702563-2808-41b1-892d-3b7b26d9737b"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2913), 1 },
                    { new Guid("8621630b-f5fe-4861-8b70-f0617d08668e"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new Guid("a50232d9-c3da-44d6-81a1-da151617d805"), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2917), 1 },
                    { new Guid("a1746cd6-d446-4304-931c-dc135c70fa1a"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"), new DateTime(2024, 7, 9, 13, 53, 55, 739, DateTimeKind.Local).AddTicks(2909), 1 }
                });
        }
    }
}
