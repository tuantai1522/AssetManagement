using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignmentSeedsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "Id", "AssetId", "AssignedById", "AssignedDate", "AssignedToId", "LastUpdated", "Note", "State" },
                values: new object[,]
                {
                    { new Guid("0f9e3ef3-67b5-48e8-b9d7-8535c1db7d8d"), new Guid("9a7e2a23-23b6-4172-946a-28470034253b"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6649), new Guid("151e3a0f-5cd2-48ad-ae50-783614f5d4ff"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6649), "Assignment 4", 2 },
                    { new Guid("3ae20275-bd40-4af2-bfe1-db02e08471c5"), new Guid("48e50b2e-2b0a-44cb-a054-1dc044ef0677"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6636), new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6638), "Assignment 3", 1 },
                    { new Guid("459f77d8-3be7-40b0-8dd5-c4901374bfbd"), new Guid("07ed57d0-9745-43e0-a40e-39a29c957c1b"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6742), new Guid("ede0c1cd-5d7e-422c-a787-8f473c45123b"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6742), "Assignment 8", 2 },
                    { new Guid("70d2ffe9-5293-49ac-9aed-c451ef4e887a"), new Guid("48e50b2e-2b0a-44cb-a054-1dc044ef0677"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6754), new Guid("49c2b516-b12e-4dd8-ae2b-9027446f4b77"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6755), "Assignment 9", 3 },
                    { new Guid("7859aebb-9212-41b2-91b5-75e1c1271683"), new Guid("9a7e2a23-23b6-4172-946a-28470034253b"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6791), new Guid("48bc2207-ec50-455d-99e4-990995f809e0"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6792), "Assignment 10", 3 },
                    { new Guid("7fe9bfb3-3d5d-4650-8304-0049be838783"), new Guid("a91d8139-49ff-43f2-a9c1-379142b3c056"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6726), new Guid("256a9cef-7479-4563-a104-8b310e16ffe0"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6727), "Assignment 7", 1 },
                    { new Guid("91d025ed-9693-426c-ab5f-1b5910ade37d"), new Guid("f673f337-c449-4ff1-97cd-366b79cf3a63"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6695), new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6696), "Assignment 6", 3 },
                    { new Guid("d0179695-8086-426d-a113-8925443c49e7"), new Guid("503c3eb7-3a05-4123-8c69-3011bee3d553"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6681), new Guid("2450bc08-8b39-41cf-90e9-7b10510c557e"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6682), "Assignment 5", 1 },
                    { new Guid("ecab1077-b5af-47ac-ba78-3fb4faf776df"), new Guid("81436c8d-4090-4abf-a926-14d061f1f9c9"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6621), new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6622), "Assignment 2", 2 },
                    { new Guid("f0c2a1d1-7546-482c-badb-f040a57b4d73"), new Guid("797d40d3-217a-4ad9-962b-076a98ebcacb"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6605), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), new DateTime(2024, 7, 2, 10, 34, 7, 856, DateTimeKind.Utc).AddTicks(6606), "Assignment 1", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("0f9e3ef3-67b5-48e8-b9d7-8535c1db7d8d"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("3ae20275-bd40-4af2-bfe1-db02e08471c5"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("459f77d8-3be7-40b0-8dd5-c4901374bfbd"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("70d2ffe9-5293-49ac-9aed-c451ef4e887a"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("7859aebb-9212-41b2-91b5-75e1c1271683"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("7fe9bfb3-3d5d-4650-8304-0049be838783"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("91d025ed-9693-426c-ab5f-1b5910ade37d"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("d0179695-8086-426d-a113-8925443c49e7"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("ecab1077-b5af-47ac-ba78-3fb4faf776df"));

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("f0c2a1d1-7546-482c-badb-f040a57b4d73"));
        }
    }
}
