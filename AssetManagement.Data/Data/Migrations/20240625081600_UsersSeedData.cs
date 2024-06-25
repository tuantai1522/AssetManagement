using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsersSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("038b8e4e-9ab6-4861-8cc8-650895a758d7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("081ffc77-0fb0-4af9-969d-5aa03f72ba53") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("26a31c17-8125-4a7b-a8d8-dcb3745a1a2a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("27bfd210-a512-4d1e-a259-c8bbfd3ca5ba") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("285c8f26-66d4-4cf2-8eef-c21d14609450") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2b21584d-bf87-4f41-b7c2-e6b4f6a12eaf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2ce25479-e06e-4996-a1ce-34bc803a2972") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2e50e7cf-9ffe-4cd1-a390-bf95f6abbd7a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("346e2bee-c67b-42c0-af13-72e344af713f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("43e08a6f-fc6d-46ba-80fd-6f0aff00ea26") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("475a8afe-99cc-4f8a-944c-7b35804fb109") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("59bdce92-ce42-48ad-8625-e1961dfb8062") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5ed6f40c-9839-4dd0-88cb-a0a051b8f102") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5f467e99-b7a4-4c90-95a9-8b28ec454805") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("66c63e2f-7878-4299-958a-ad5717e95a1f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6a3f49a7-0e21-4279-b22c-d3503ca9803c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("71f5ba70-142c-4196-8553-3bd829f3bff2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("72ae1c7a-e390-4b93-8bd3-b0e9e2d649d1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7f499e73-5f41-4343-8f87-74884247dd03") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("88d71ff9-04a1-4063-8082-c47c385f9ce7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8a4c7483-162b-4fb6-ab9a-6e746131e02a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8f81b0b9-43d6-4881-ab11-50205a6f210f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("992da7d1-4347-47db-bcdf-684c05dc3c5c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9e7ad160-7e79-40d6-9d2b-ec5c80a68ef8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6a60593-e3f7-4604-8ac7-ef7b3950d87f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("bcfe003e-50bd-4761-a5c8-de3905dee1de") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bfabe129-f256-4dc1-97d7-3e604095a2ba") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c595e65d-cb90-410a-b48e-4b0b58ca6e14") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c762344e-bfd4-4e7b-b6e5-547271b03961") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ce15af4c-830b-4049-a057-80ac898aa677") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d6bdfc32-079f-4a5b-bd97-bb14dd1d3f9b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ddc64ce0-2560-4ca9-af1d-28f5f8a6ee6e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fbdb5ab6-a5b7-44f3-9295-c72f04d24881") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ff8d5c57-2c03-4e2f-956b-77d89b17672d") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("038b8e4e-9ab6-4861-8cc8-650895a758d7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("081ffc77-0fb0-4af9-969d-5aa03f72ba53"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26a31c17-8125-4a7b-a8d8-dcb3745a1a2a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27bfd210-a512-4d1e-a259-c8bbfd3ca5ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285c8f26-66d4-4cf2-8eef-c21d14609450"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b21584d-bf87-4f41-b7c2-e6b4f6a12eaf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2ce25479-e06e-4996-a1ce-34bc803a2972"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e50e7cf-9ffe-4cd1-a390-bf95f6abbd7a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("346e2bee-c67b-42c0-af13-72e344af713f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43e08a6f-fc6d-46ba-80fd-6f0aff00ea26"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("475a8afe-99cc-4f8a-944c-7b35804fb109"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59bdce92-ce42-48ad-8625-e1961dfb8062"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ed6f40c-9839-4dd0-88cb-a0a051b8f102"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5f467e99-b7a4-4c90-95a9-8b28ec454805"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("66c63e2f-7878-4299-958a-ad5717e95a1f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a3f49a7-0e21-4279-b22c-d3503ca9803c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71f5ba70-142c-4196-8553-3bd829f3bff2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72ae1c7a-e390-4b93-8bd3-b0e9e2d649d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7f499e73-5f41-4343-8f87-74884247dd03"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d71ff9-04a1-4063-8082-c47c385f9ce7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a4c7483-162b-4fb6-ab9a-6e746131e02a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f81b0b9-43d6-4881-ab11-50205a6f210f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("992da7d1-4347-47db-bcdf-684c05dc3c5c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e7ad160-7e79-40d6-9d2b-ec5c80a68ef8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6a60593-e3f7-4604-8ac7-ef7b3950d87f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcfe003e-50bd-4761-a5c8-de3905dee1de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfabe129-f256-4dc1-97d7-3e604095a2ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c595e65d-cb90-410a-b48e-4b0b58ca6e14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c762344e-bfd4-4e7b-b6e5-547271b03961"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce15af4c-830b-4049-a057-80ac898aa677"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6bdfc32-079f-4a5b-bd97-bb14dd1d3f9b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ddc64ce0-2560-4ca9-af1d-28f5f8a6ee6e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fbdb5ab6-a5b7-44f3-9295-c72f04d24881"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff8d5c57-2c03-4e2f-956b-77d89b17672d"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("057c7eee-c467-436a-abd8-fe8dcb099fad"), 0, "935c1327-75b5-4fd3-9a14-e3308165d4ee", new DateTime(2024, 6, 25, 8, 15, 58, 69, DateTimeKind.Utc).AddTicks(9045), new DateTime(1996, 1, 3, 15, 15, 58, 69, DateTimeKind.Local).AddTicks(9017), "emmaw@gmail.com", false, "Emma", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 69, DateTimeKind.Local).AddTicks(9044), "Wilson", new DateTime(2024, 6, 25, 8, 15, 58, 69, DateTimeKind.Utc).AddTicks(9045), "HCM", true, null, "EMMAW@GMAIL.COM", "EMMAW", "AQAAAAIAAYagAAAAEGAGXnndkJZPZgdMjD6mWwpXC0AY1LzrPDlWOPbMDXUiC3/MCBPe9K5PYgntUOcusQ==", null, false, "787189c9-83d5-4ad1-aeae-3bca9fd73596", "SD0007", false, "emmaw" },
                    { new Guid("0d7ff7cc-9a44-43fb-96c6-aa0adb0fa897"), 0, "2a495255-d406-4ecc-a0c5-3b0abdc91aeb", new DateTime(2024, 6, 25, 8, 15, 58, 401, DateTimeKind.Utc).AddTicks(7889), new DateTime(2004, 6, 7, 15, 15, 58, 401, DateTimeKind.Local).AddTicks(7871), "daniell@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 401, DateTimeKind.Local).AddTicks(7887), "Lewis", new DateTime(2024, 6, 25, 8, 15, 58, 401, DateTimeKind.Utc).AddTicks(7890), "HN", true, null, "DANIELL@GMAIL.COM", "DANIELL", "AQAAAAIAAYagAAAAEJJCOlpVkBhV2YoPGZQ0y71KuFqtrLJFizIRO/KpGJMu1d0g0zYUlwbb9SD3wRsUEw==", null, false, "f5be713d-f8a8-43b6-91da-d005126559a7", "SD0012", false, "daniell" },
                    { new Guid("119809f5-f4da-4b1b-83e1-5e06b475f3cc"), 0, "5c5d770e-135d-4def-9776-e43ef2f7ac17", new DateTime(2024, 6, 25, 8, 15, 58, 340, DateTimeKind.Utc).AddTicks(2226), new DateTime(1997, 6, 11, 15, 15, 58, 340, DateTimeKind.Local).AddTicks(2207), "ameliat@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 340, DateTimeKind.Local).AddTicks(2224), "Thomas", new DateTime(2024, 6, 25, 8, 15, 58, 340, DateTimeKind.Utc).AddTicks(2226), "HN", true, null, "AMELIAT@GMAIL.COM", "AMELIAT", "AQAAAAIAAYagAAAAEMUw7wLIShOGh6r7vP9OlMs9lqu48A77/Mm09Gqh+2U8xJ7zNhd87JGrkt3UMRxU7g==", null, false, "9244b497-300d-49d6-8e91-ba47dc4ac2d5", "SD0011", false, "ameliat" },
                    { new Guid("16c7753c-e27c-4c48-925f-7d77ef8f5492"), 0, "66add950-2765-4554-a7a2-ee837e2199fa", new DateTime(2024, 6, 25, 8, 15, 59, 386, DateTimeKind.Utc).AddTicks(2544), new DateTime(2004, 12, 30, 15, 15, 59, 386, DateTimeKind.Local).AddTicks(2517), "elijaht@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 386, DateTimeKind.Local).AddTicks(2542), "Thomas", new DateTime(2024, 6, 25, 8, 15, 59, 386, DateTimeKind.Utc).AddTicks(2544), "HN", true, null, "ELIJAHT@GMAIL.COM", "ELIJAHT", "AQAAAAIAAYagAAAAEIbWEGgAD+mBg1yZf9ICMbQO1+arIyYHF8kzDrDKAJ/NjoTtFOiZS8AlMTc2S9MJ4A==", null, false, "e8b5794b-bf1a-4c6b-aaa5-328f70e9d2f2", "SD0028", false, "elijaht" },
                    { new Guid("1803dbcc-6a78-4080-887f-0ef25e57811f"), 0, "c080cc0a-f939-4038-9f08-9d4371497a83", new DateTime(2024, 6, 25, 8, 15, 58, 650, DateTimeKind.Utc).AddTicks(5361), new DateTime(1997, 3, 11, 15, 15, 58, 650, DateTimeKind.Local).AddTicks(5348), "charlottey@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 650, DateTimeKind.Local).AddTicks(5360), "Young", new DateTime(2024, 6, 25, 8, 15, 58, 650, DateTimeKind.Utc).AddTicks(5362), "HN", true, null, "CHARLOTTEY@GMAIL.COM", "CHARLOTTEY", "AQAAAAIAAYagAAAAEMAobjC9e9S1OycE7aoSb48AOIuZDeIXtPcsDLcLLkTw5b+5PAFL4Y9icx0BEoBySQ==", null, false, "94a1f71f-9052-49e6-8069-00d423aa6cdb", "SD0016", false, "charlottey" },
                    { new Guid("1d10808f-d13e-47c8-93ab-9e3fa5d0902b"), 0, "44bf8bd8-d37e-4625-8691-88e6a20fd443", new DateTime(2024, 6, 25, 8, 15, 59, 325, DateTimeKind.Utc).AddTicks(7701), new DateTime(1998, 7, 2, 15, 15, 59, 325, DateTimeKind.Local).AddTicks(7681), "harperr@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 325, DateTimeKind.Local).AddTicks(7700), "Rodriguez", new DateTime(2024, 6, 25, 8, 15, 59, 325, DateTimeKind.Utc).AddTicks(7702), "HN", true, null, "HARPERR@GMAIL.COM", "HARPERR", "AQAAAAIAAYagAAAAELQy3HddWCqE3phgm30D0eDXIyvzxw9kjltpp6BMhSYzcTSKHzKEIkmelhzO8whOrg==", null, false, "2d61d450-ac0a-491d-baf1-d9971e841ee2", "SD0027", false, "harperr" },
                    { new Guid("2af6972d-353c-424d-8fce-858736057342"), 0, "a46d4f62-6425-42b6-9a89-238ee4bf5e02", new DateTime(2024, 6, 25, 8, 15, 59, 200, DateTimeKind.Utc).AddTicks(449), new DateTime(1996, 10, 10, 15, 15, 59, 200, DateTimeKind.Local).AddTicks(335), "alexanderm@gmail.com", false, "Alexander", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 200, DateTimeKind.Local).AddTicks(448), "Miller", new DateTime(2024, 6, 25, 8, 15, 59, 200, DateTimeKind.Utc).AddTicks(450), "HN", true, null, "ALEXANDERM@GMAIL.COM", "ALEXANDERM", "AQAAAAIAAYagAAAAEKp7GRfKY+sly1knAlxVFgM9nOAwzU1naYpiYeieoEak4vg7AdkgYIF2g3c7lryxEQ==", null, false, "a86dfa6f-7d67-4060-aa9c-676f8f5cb3cd", "SD0025", false, "alexanderm" },
                    { new Guid("2ff30446-27c5-44ff-85b4-c7cde3442a5a"), 0, "9b188869-4d40-47a7-8ee9-810fa8130515", new DateTime(2024, 6, 25, 8, 15, 58, 771, DateTimeKind.Utc).AddTicks(2030), new DateTime(2005, 6, 22, 15, 15, 58, 771, DateTimeKind.Local).AddTicks(2018), "danielj@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 771, DateTimeKind.Local).AddTicks(2029), "Jackson", new DateTime(2024, 6, 25, 8, 15, 58, 771, DateTimeKind.Utc).AddTicks(2030), "HCM", true, null, "DANIELJ@GMAIL.COM", "DANIELJ", "AQAAAAIAAYagAAAAEFGOI5T/tNIyBj4lOjL90cnhgRD4dt27lvkYiYBKCsRMMzcU0nb1X0BVcuFudHWIHQ==", null, false, "f40d5140-e7d4-40a7-b769-52361ce1a999", "SD0018", false, "danielj" },
                    { new Guid("42a87121-a807-4d84-9022-3ea002a7b2d8"), 0, "7fa25d46-7bb0-4fc3-9dbd-6aa4ab391689", new DateTime(2024, 6, 25, 8, 15, 57, 886, DateTimeKind.Utc).AddTicks(4027), new DateTime(2003, 10, 11, 15, 15, 57, 886, DateTimeKind.Local).AddTicks(3990), "staffhn@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 57, 886, DateTimeKind.Local).AddTicks(4026), "HN", new DateTime(2024, 6, 25, 8, 15, 57, 886, DateTimeKind.Utc).AddTicks(4028), "HN", true, null, "STAFFHN@GMAIL.COM", "STAFFHN", "AQAAAAIAAYagAAAAEOt0Zu7dCAWLdnFs3Z35diYj4/7a4jXtfhQ4C9fMhR6i1JVjofRNlnfVf0YpJl9jlQ==", null, false, "1fd087df-eb8d-4c95-9e12-75664d8d7424", "SD0004", false, "staffhn" },
                    { new Guid("496b1e47-5954-4c4a-9c85-80d26c53900d"), 0, "a9fb8033-674f-44c0-88d8-d2892817af68", new DateTime(2024, 6, 25, 8, 15, 58, 281, DateTimeKind.Utc).AddTicks(7668), new DateTime(2003, 2, 18, 15, 15, 58, 281, DateTimeKind.Local).AddTicks(7648), "harperm@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 281, DateTimeKind.Local).AddTicks(7666), "Martinez", new DateTime(2024, 6, 25, 8, 15, 58, 281, DateTimeKind.Utc).AddTicks(7668), "HCM", true, null, "HARPERM@GMAIL.COM", "HARPERM", "AQAAAAIAAYagAAAAEGJORVuNEsm/vEdrZEyYcmt3ejnNPlUXj4SSkF2CbxuP9SCV+jhSdeGwOUpeOgWWxg==", null, false, "db21b1d1-7964-48d1-a38b-0f1b0d3445a8", "SD0010", false, "harperm" },
                    { new Guid("4f6683f1-46ad-4226-907a-7e9c6dc38d09"), 0, "e2127d44-df90-4d66-a8cc-57413175875f", new DateTime(2024, 6, 25, 8, 15, 58, 832, DateTimeKind.Utc).AddTicks(4019), new DateTime(2005, 5, 29, 15, 15, 58, 832, DateTimeKind.Local).AddTicks(4004), "michaelc@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 832, DateTimeKind.Local).AddTicks(4017), "Clark", new DateTime(2024, 6, 25, 8, 15, 58, 832, DateTimeKind.Utc).AddTicks(4019), "HN", true, null, "MICHAELC@GMAIL.COM", "MICHAELC", "AQAAAAIAAYagAAAAEOQD4VA4A/zioXlER0tL7BMDpqSujx26tWShQKDYm5NvqK8FC3nPb2LVoYtT9w9MtA==", null, false, "4188a0e9-d1dd-4cd0-84b2-c4b41315f71a", "SD0019", false, "michaelc" },
                    { new Guid("51bcbbac-c187-408d-ae7a-3d66e0174dc7"), 0, "e083b0e2-978d-47a4-b3bd-559c5c1958ec", new DateTime(2024, 6, 25, 8, 15, 57, 821, DateTimeKind.Utc).AddTicks(5774), new DateTime(1997, 6, 5, 15, 15, 57, 821, DateTimeKind.Local).AddTicks(5717), "staffhcm@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 57, 821, DateTimeKind.Local).AddTicks(5772), "HCM", new DateTime(2024, 6, 25, 8, 15, 57, 821, DateTimeKind.Utc).AddTicks(5774), "HCM", true, null, "STAFFHCM@GMAIL.COM", "STAFFHCM", "AQAAAAIAAYagAAAAEGAD3tJpHEe2mNJseHSpSvPkI27FGOHNhC8UPVDDLabFvGXXpoynr/zXBqlwWeDw6Q==", null, false, "e2cbbe6a-02a7-4e9c-8e9f-4378f7e7745f", "SD0003", false, "staffhcm" },
                    { new Guid("528f86cd-75b8-4692-981d-c6e29d5c0882"), 0, "e9978bbf-e6ff-44c5-bb64-948a4b81117f", new DateTime(2024, 6, 25, 8, 15, 59, 760, DateTimeKind.Utc).AddTicks(3201), new DateTime(1995, 6, 19, 15, 15, 59, 760, DateTimeKind.Local).AddTicks(3174), "isabellaj2@gmail.com", false, "Isabella", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 760, DateTimeKind.Local).AddTicks(3200), "Jackson", new DateTime(2024, 6, 25, 8, 15, 59, 760, DateTimeKind.Utc).AddTicks(3201), "HN", true, null, "ISABELLAJ2@GMAIL.COM", "ISABELLAJ2", "AQAAAAIAAYagAAAAECZDwNVwdxjRK4Qot6a6mZFw6M4C4xtXynSwtJx9S5vXGToz7+/hg1sm351A0lGA7w==", null, false, "2be7a5cb-3a96-4640-ac7f-99d679e78644", "SD0034", false, "isabellaj2" },
                    { new Guid("5d983e82-fde8-45c1-9862-374566598c83"), 0, "31c9ec2a-65b9-4202-8167-a717311d2db5", new DateTime(2024, 6, 25, 8, 15, 59, 698, DateTimeKind.Utc).AddTicks(6507), new DateTime(2005, 12, 31, 15, 15, 59, 698, DateTimeKind.Local).AddTicks(6486), "alexanderm1@gmail.com", false, "Alexander", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 698, DateTimeKind.Local).AddTicks(6506), "Miller", new DateTime(2024, 6, 25, 8, 15, 59, 698, DateTimeKind.Utc).AddTicks(6508), "HN", true, null, "ALEXANDERM1@GMAIL.COM", "ALEXANDERM1", "AQAAAAIAAYagAAAAEON3Ipyd2wQGHjnzNZg6d4bWZwrrAXkiKEg6l5lA1RyWvrlvgEACJnKFUbHTljQgeA==", null, false, "15fd9388-43ab-4d7c-9f02-e25f90eb6a1a", "SD0033", false, "alexanderm1" },
                    { new Guid("6bb9f598-0dfc-4ca4-af61-866cc25238f7"), 0, "304bb28f-f043-4dc5-bf40-3604f6e1eecb", new DateTime(2024, 6, 25, 8, 15, 59, 575, DateTimeKind.Utc).AddTicks(6891), new DateTime(2006, 4, 2, 15, 15, 59, 575, DateTimeKind.Local).AddTicks(6875), "oliviaj1@gmail.com", false, "Olivia", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 575, DateTimeKind.Local).AddTicks(6889), "Jackson", new DateTime(2024, 6, 25, 8, 15, 59, 575, DateTimeKind.Utc).AddTicks(6891), "HN", true, null, "OLIVIAJ1@GMAIL.COM", "OLIVIAJ1", "AQAAAAIAAYagAAAAEHZ646+/tkj3ObOIZxhj+skiT1Wee41DiImkv76XzyyvWfGP6Y8vMiiW1SuW298AzQ==", null, false, "9f067050-b858-407d-b365-60702c43298b", "SD0031", false, "oliviaj1" },
                    { new Guid("6d948de7-b0a6-45bd-9ac3-b5ed1c81cdad"), 0, "d1ebed4f-e42f-41ac-a0ca-36afc9e553c3", new DateTime(2024, 6, 25, 8, 15, 59, 449, DateTimeKind.Utc).AddTicks(2233), new DateTime(2004, 5, 19, 15, 15, 59, 449, DateTimeKind.Local).AddTicks(2211), "isabellah@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 449, DateTimeKind.Local).AddTicks(2232), "Harris", new DateTime(2024, 6, 25, 8, 15, 59, 449, DateTimeKind.Utc).AddTicks(2234), "HN", true, null, "ISABELLAH@GMAIL.COM", "ISABELLAH", "AQAAAAIAAYagAAAAELpeK8EKFhKx08I9wpOFdY1s038hU81D+lUztJdOwJl1OEpxV+o/X4Qvhn4YabPdEQ==", null, false, "b51953df-0edd-4820-93ea-56607fcf52e7", "SD0029", false, "isabellah" },
                    { new Guid("6f56a37f-aaa0-49cc-ae7d-1465528d0a55"), 0, "fd7592cf-c984-49de-91d5-f5fb1565bb51", new DateTime(2024, 6, 25, 8, 15, 58, 467, DateTimeKind.Utc).AddTicks(1059), new DateTime(2006, 1, 26, 15, 15, 58, 467, DateTimeKind.Local).AddTicks(1043), "oliviah@gmail.com", false, "Olivia", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 467, DateTimeKind.Local).AddTicks(1058), "Harris", new DateTime(2024, 6, 25, 8, 15, 58, 467, DateTimeKind.Utc).AddTicks(1060), "HN", true, null, "OLIVIAH@GMAIL.COM", "OLIVIAH", "AQAAAAIAAYagAAAAELwYyjFvLF2w7mQh8HFtml/WK5O3/9yKUQNXdFgfuTmDi1t26qWEAIfBUJgRAtFMmw==", null, false, "8e948871-ba5d-41ef-841f-cea156d05345", "SD0013", false, "oliviah" },
                    { new Guid("764dd036-756f-41b4-bf84-65222d64c76f"), 0, "91f58775-2081-43f0-b881-091a9d6a55db", new DateTime(2024, 6, 25, 8, 15, 59, 513, DateTimeKind.Utc).AddTicks(6394), new DateTime(2001, 2, 4, 15, 15, 59, 513, DateTimeKind.Local).AddTicks(6363), "emmat@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 513, DateTimeKind.Local).AddTicks(6392), "Taylor", new DateTime(2024, 6, 25, 8, 15, 59, 513, DateTimeKind.Utc).AddTicks(6394), "HCM", true, null, "EMMAT@GMAIL.COM", "EMMAT", "AQAAAAIAAYagAAAAEOPifAV0tqyT2dkPNP0gkXHbjyCJNtaqsoubN1Jp76TP2TiV7S3GWJHHTyB+bZe+Ng==", null, false, "d8bf67fd-4623-4903-8f09-e1fefdefb014", "SD0030", false, "emmat" },
                    { new Guid("769e20c2-20b1-41aa-be53-c7f3ee380256"), 0, "f8e47364-b6da-40a1-96b3-247e0d5ef4ed", new DateTime(2024, 6, 25, 8, 15, 58, 894, DateTimeKind.Utc).AddTicks(891), new DateTime(1998, 12, 17, 15, 15, 58, 894, DateTimeKind.Local).AddTicks(866), "harperj1@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 894, DateTimeKind.Local).AddTicks(890), "Jackson", new DateTime(2024, 6, 25, 8, 15, 58, 894, DateTimeKind.Utc).AddTicks(892), "HN", true, null, "HARPERJ1@GMAIL.COM", "HARPERJ1", "AQAAAAIAAYagAAAAEJzAPZ65uYuyyHdBgFQUN32EQkFKjzIZodSdAe0ILUCuu7EFKk+PsAC+cOTkYSvA1Q==", null, false, "e0a9980d-72bb-4ebd-a5b1-3bdd1c02c05f", "SD0020", false, "harperj1" },
                    { new Guid("88b2652e-59e8-41f9-b5a1-3a4d68934c97"), 0, "3194e159-2125-4814-8041-8c3444157f4d", new DateTime(2024, 6, 25, 8, 15, 59, 137, DateTimeKind.Utc).AddTicks(8995), new DateTime(2000, 9, 8, 15, 15, 59, 137, DateTimeKind.Local).AddTicks(8969), "avaj@gmail.com", false, "Ava", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 137, DateTimeKind.Local).AddTicks(8993), "Jones", new DateTime(2024, 6, 25, 8, 15, 59, 137, DateTimeKind.Utc).AddTicks(8996), "HN", true, null, "AVAJ@GMAIL.COM", "AVAJ", "AQAAAAIAAYagAAAAEKn0vdKteYJpWdzra9C4ioLhc4uY8WkYcso/nR/ZyJCMw/6JN1f6Jrk2bUbI0qydAQ==", null, false, "6f312f56-9d31-43a7-867a-d4c94002cc3f", "SD0024", false, "avaj" },
                    { new Guid("8ebc0ca4-bd69-478f-b049-ea9f2dcf9358"), 0, "96a459ab-f970-4f18-adbf-f3b4c488c459", new DateTime(2024, 6, 25, 8, 15, 58, 134, DateTimeKind.Utc).AddTicks(4111), new DateTime(1999, 6, 30, 15, 15, 58, 134, DateTimeKind.Local).AddTicks(4080), "michaelj@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 134, DateTimeKind.Local).AddTicks(4110), "Johnson", new DateTime(2024, 6, 25, 8, 15, 58, 134, DateTimeKind.Utc).AddTicks(4112), "HCM", true, null, "MICHAELJ@GMAIL.COM", "MICHAELJ", "AQAAAAIAAYagAAAAELRgJM04ByjYtCWKcPtULE6cVZit179Fkt0JoMmtqrMwhQ/ZeFH0RQeKXKzopWxO7Q==", null, false, "71d26bcf-ff29-4da0-96b1-cfef580e2bdd", "SD0008", false, "michaelj" },
                    { new Guid("a2297cd4-ff02-4054-85a3-f954fae8f5e6"), 0, "a30a3484-81fd-4ea2-b04d-c6094bab7e8a", new DateTime(2024, 6, 25, 8, 15, 58, 710, DateTimeKind.Utc).AddTicks(6000), new DateTime(2004, 9, 23, 15, 15, 58, 710, DateTimeKind.Local).AddTicks(5983), "danielm1@gmail.com", false, "Daniel", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 710, DateTimeKind.Local).AddTicks(5999), "Martinez", new DateTime(2024, 6, 25, 8, 15, 58, 710, DateTimeKind.Utc).AddTicks(6000), "HN", true, null, "DANIELM1@GMAIL.COM", "DANIELM1", "AQAAAAIAAYagAAAAEHwZKm/8eaMAk+54qBZxXt5DPOwmciuKLRbzTp+Gp9VKjwfs4a8tBBGLEZFSvnvD2g==", null, false, "a27c4a47-5f95-419c-953a-122e1da910c3", "SD0017", false, "danielm1" },
                    { new Guid("a5293db5-1b29-4db3-a754-20c97a4b5ebf"), 0, "61da2c75-9078-497d-a671-b45e466abcd9", new DateTime(2024, 6, 25, 8, 15, 58, 8, DateTimeKind.Utc).AddTicks(6908), new DateTime(1999, 2, 14, 15, 15, 58, 8, DateTimeKind.Local).AddTicks(6847), "harperl@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 8, DateTimeKind.Local).AddTicks(6907), "Lewis", new DateTime(2024, 6, 25, 8, 15, 58, 8, DateTimeKind.Utc).AddTicks(6908), "HCM", true, null, "HARPERL@GMAIL.COM", "HARPERL", "AQAAAAIAAYagAAAAEMmJYgq7DEvwvIdk5D/8l/S/kepJymcRr7n5KzdfbYc58EvVtmY6KOrbr+hi5GajCg==", null, false, "53599593-7bee-4179-8cbc-9dc241a8e8ef", "SD0006", false, "harperl" },
                    { new Guid("ad2bc3e9-64d4-45af-8e5d-e0bd598dc218"), 0, "b288851f-da20-40cb-beae-f4889fbbdf4c", new DateTime(2024, 6, 25, 8, 15, 59, 636, DateTimeKind.Utc).AddTicks(5528), new DateTime(2005, 10, 11, 15, 15, 59, 636, DateTimeKind.Local).AddTicks(5515), "elijahw@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 636, DateTimeKind.Local).AddTicks(5527), "Williams", new DateTime(2024, 6, 25, 8, 15, 59, 636, DateTimeKind.Utc).AddTicks(5529), "HCM", true, null, "ELIJAHW@GMAIL.COM", "ELIJAHW", "AQAAAAIAAYagAAAAEPryjVJxOTKQ0wnSH9pnJR2YiLSCym5vWJLlCr5zBIyYVt1Fez+w6fb3iEQhS11AbA==", null, false, "3755d092-9572-4f79-9b43-46557d9290e9", "SD0032", false, "elijahw" },
                    { new Guid("b0128f5b-00a2-4220-9512-73b08c838476"), 0, "736c48f1-d46d-4fef-86d8-99c4612197b2", new DateTime(2024, 6, 25, 8, 15, 58, 218, DateTimeKind.Utc).AddTicks(2682), new DateTime(2002, 9, 10, 15, 15, 58, 218, DateTimeKind.Local).AddTicks(2645), "evelynw@gmail.com", false, "Evelyn", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 218, DateTimeKind.Local).AddTicks(2681), "Williams", new DateTime(2024, 6, 25, 8, 15, 58, 218, DateTimeKind.Utc).AddTicks(2683), "HCM", true, null, "EVELYNW@GMAIL.COM", "EVELYNW", "AQAAAAIAAYagAAAAEFOVjPcmLovTlnVtHDk+fU7ofaX+aG06wGTvRug+mwiqsu2Pu9cA11BXOP1BNRQzlQ==", null, false, "bfce9434-f293-4fb2-8e8b-0b5e1580cce3", "SD0009", false, "evelynw" },
                    { new Guid("b20939f3-fe91-4786-9d5f-dbef3dc7b69d"), 0, "ab63fda1-0e5f-4231-a53c-ae37361a1fc2", new DateTime(2024, 6, 25, 8, 15, 58, 528, DateTimeKind.Utc).AddTicks(2780), new DateTime(2003, 1, 18, 15, 15, 58, 528, DateTimeKind.Local).AddTicks(2761), "davidj@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 528, DateTimeKind.Local).AddTicks(2779), "Johnson", new DateTime(2024, 6, 25, 8, 15, 58, 528, DateTimeKind.Utc).AddTicks(2781), "HCM", true, null, "DAVIDJ@GMAIL.COM", "DAVIDJ", "AQAAAAIAAYagAAAAEJ+eHWqoS/CCTXqNP8AbyKDbF7Z9FQPg4eczDPEi2sO02DzCh1rPa3J1dAZKXoTTNg==", null, false, "f36c38e9-c577-4994-b717-de174734c221", "SD0014", false, "davidj" },
                    { new Guid("b9c2a766-b7f2-4e97-8804-d6e0a3a0d93b"), 0, "5ed543b8-95ca-4126-bad2-5d90495183b6", new DateTime(2024, 6, 25, 8, 15, 59, 262, DateTimeKind.Utc).AddTicks(1176), new DateTime(2002, 7, 25, 15, 15, 59, 262, DateTimeKind.Local).AddTicks(1160), "benjamind@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 262, DateTimeKind.Local).AddTicks(1175), "Davis", new DateTime(2024, 6, 25, 8, 15, 59, 262, DateTimeKind.Utc).AddTicks(1177), "HN", true, null, "BENJAMIND@GMAIL.COM", "BENJAMIND", "AQAAAAIAAYagAAAAEDkMLmUjgHDz1HIuvpBmLRITD8OWNHHE7+SLtE1CPuVVaN/EC+0G+aKn6om5ypPvpA==", null, false, "02797f16-6073-421b-ae10-cb80f36332da", "SD0026", false, "benjamind" },
                    { new Guid("c7308586-7097-445e-936c-2473da75f698"), 0, "04cc5e78-ea78-4b06-8fb8-a13697bcea46", new DateTime(2024, 6, 25, 8, 15, 57, 756, DateTimeKind.Utc).AddTicks(7532), new DateTime(2004, 3, 14, 15, 15, 57, 756, DateTimeKind.Local).AddTicks(7485), "adminhn@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 57, 756, DateTimeKind.Local).AddTicks(7531), "HN", new DateTime(2024, 6, 25, 8, 15, 57, 756, DateTimeKind.Utc).AddTicks(7534), "HN", true, null, "ADMINHN@GMAIL.COM", "ADMINHN", "AQAAAAIAAYagAAAAELQQ8Bubyd7EE1LqwLeR0YUBIXNSOvm73Zr4nFnV9rsh+11NqAF6XsrwKio10PZL6A==", null, false, "c1cac04a-d577-46c0-9852-2f51e35442fc", "SD0002", false, "adminhn" },
                    { new Guid("c986abab-32d7-4112-bf7a-e9a6dfeb8eb4"), 0, "01c31d59-36c6-434d-b5b7-6461654a0275", new DateTime(2024, 6, 25, 8, 15, 59, 76, DateTimeKind.Utc).AddTicks(7639), new DateTime(2006, 1, 19, 15, 15, 59, 76, DateTimeKind.Local).AddTicks(7621), "josephm@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 76, DateTimeKind.Local).AddTicks(7637), "Martinez", new DateTime(2024, 6, 25, 8, 15, 59, 76, DateTimeKind.Utc).AddTicks(7639), "HN", true, null, "JOSEPHM@GMAIL.COM", "JOSEPHM", "AQAAAAIAAYagAAAAEJPbAssWjjEnkcuw+RIVLifWF9SazYnRRMRub/Ni9X9mFoSlfFnyt+hFG7JO/oSI0g==", null, false, "47519493-13d2-4763-a201-9a844bdd610b", "SD0023", false, "josephm" },
                    { new Guid("da88aa77-1ea6-4058-91f8-6d304f6ca14f"), 0, "f913b14c-c30f-485f-8da3-4a7dd093785b", new DateTime(2024, 6, 25, 8, 15, 57, 946, DateTimeKind.Utc).AddTicks(8861), new DateTime(2006, 4, 24, 15, 15, 57, 946, DateTimeKind.Local).AddTicks(8806), "davida@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 57, 946, DateTimeKind.Local).AddTicks(8856), "Anderson", new DateTime(2024, 6, 25, 8, 15, 57, 946, DateTimeKind.Utc).AddTicks(8861), "HCM", true, null, "DAVIDA@GMAIL.COM", "DAVIDA", "AQAAAAIAAYagAAAAEPFyJ2dm7BdVbi8WvJw5O7cisHrKWTXc1R+q7zt/LL2ew8M2OpgN5AXz8HQs5Bm2rQ==", null, false, "f9aa72e6-63b4-4ff6-bf51-4da4fd025c33", "SD0005", false, "davida" },
                    { new Guid("e0b500f6-332e-4f63-8bd9-a43fe8e690ea"), 0, "91dd7e97-4762-41d8-832e-7c36479a6f90", new DateTime(2024, 6, 25, 8, 15, 58, 589, DateTimeKind.Utc).AddTicks(4120), new DateTime(1995, 8, 28, 15, 15, 58, 589, DateTimeKind.Local).AddTicks(4101), "davidm@gmail.com", false, "David", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 589, DateTimeKind.Local).AddTicks(4118), "Martinez", new DateTime(2024, 6, 25, 8, 15, 58, 589, DateTimeKind.Utc).AddTicks(4121), "HCM", true, null, "DAVIDM@GMAIL.COM", "DAVIDM", "AQAAAAIAAYagAAAAEENuUmGW/NVzuyYFlMRq9EnO2qGSCPBxRgFlq9KnSTw1SIcTQFdHnVOMZOewT83ZfA==", null, false, "7001e3bd-eb17-43cb-91fb-78b1816bdac2", "SD0015", false, "davidm" },
                    { new Guid("ea657ee0-892a-4394-ae44-9c88aed2d097"), 0, "23618426-bfce-4bf5-988d-bc0cf50d500c", new DateTime(2024, 6, 25, 8, 15, 59, 15, DateTimeKind.Utc).AddTicks(9202), new DateTime(1998, 12, 18, 15, 15, 59, 15, DateTimeKind.Local).AddTicks(9196), "avay@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 59, 15, DateTimeKind.Local).AddTicks(9201), "Young", new DateTime(2024, 6, 25, 8, 15, 59, 15, DateTimeKind.Utc).AddTicks(9203), "HCM", true, null, "AVAY@GMAIL.COM", "AVAY", "AQAAAAIAAYagAAAAECFO0BkGdLa8DXDGcmapBOH17dxSWsCikjIm5Z7qjSkxJGltVuDugHXkv6ZlnlJKKA==", null, false, "5c798c48-0eb6-48d2-b455-2dec8abb6650", "SD0022", false, "avay" },
                    { new Guid("f1e6e929-b2d4-490b-bb56-d266b4578a6b"), 0, "c7131bff-c101-4891-9ce6-0b37d0bd2c92", new DateTime(2024, 6, 25, 8, 15, 58, 955, DateTimeKind.Utc).AddTicks(3683), new DateTime(2005, 2, 11, 15, 15, 58, 955, DateTimeKind.Local).AddTicks(3670), "olivial@gmail.com", false, "Olivia", "Female", false, false, new DateTime(2024, 6, 25, 15, 15, 58, 955, DateTimeKind.Local).AddTicks(3682), "Lewis", new DateTime(2024, 6, 25, 8, 15, 58, 955, DateTimeKind.Utc).AddTicks(3684), "HCM", true, null, "OLIVIAL@GMAIL.COM", "OLIVIAL", "AQAAAAIAAYagAAAAEJzt96TSUuyGhrT+NzDDNcS4fCmkopibq56l6Ec6APIGLo7Fr8mRLjQ8mYdc5+zaSw==", null, false, "c9058a16-f9d8-47cc-b883-7a0bc68f75c7", "SD0021", false, "olivial" },
                    { new Guid("fe98eb7a-32d6-4c28-95cd-07ec73f3865a"), 0, "cbe47558-72e9-484c-a399-6b2637825f81", new DateTime(2024, 6, 25, 8, 15, 57, 693, DateTimeKind.Utc).AddTicks(8919), new DateTime(1998, 11, 10, 15, 15, 57, 693, DateTimeKind.Local).AddTicks(8906), "adminhcm@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 25, 15, 15, 57, 693, DateTimeKind.Local).AddTicks(8918), "HCM", new DateTime(2024, 6, 25, 8, 15, 57, 693, DateTimeKind.Utc).AddTicks(8919), "HCM", true, null, "ADMINHCM@GMAIL.COM", "ADMINHCM", "AQAAAAIAAYagAAAAEJKu6aDsOrq+jGa9LJlW4nwNx57V67orCWT/7QqUseod7l2OJpXuKl2zh5TIW0hisQ==", null, false, "c4bb062a-1d18-442c-af7e-233a5514049e", "SD0001", false, "adminhcm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("057c7eee-c467-436a-abd8-fe8dcb099fad"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("0d7ff7cc-9a44-43fb-96c6-aa0adb0fa897"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("119809f5-f4da-4b1b-83e1-5e06b475f3cc"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("16c7753c-e27c-4c48-925f-7d77ef8f5492"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1803dbcc-6a78-4080-887f-0ef25e57811f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1d10808f-d13e-47c8-93ab-9e3fa5d0902b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2af6972d-353c-424d-8fce-858736057342"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2ff30446-27c5-44ff-85b4-c7cde3442a5a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42a87121-a807-4d84-9022-3ea002a7b2d8"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("496b1e47-5954-4c4a-9c85-80d26c53900d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f6683f1-46ad-4226-907a-7e9c6dc38d09"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("51bcbbac-c187-408d-ae7a-3d66e0174dc7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("528f86cd-75b8-4692-981d-c6e29d5c0882"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5d983e82-fde8-45c1-9862-374566598c83"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6bb9f598-0dfc-4ca4-af61-866cc25238f7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6d948de7-b0a6-45bd-9ac3-b5ed1c81cdad"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6f56a37f-aaa0-49cc-ae7d-1465528d0a55"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("764dd036-756f-41b4-bf84-65222d64c76f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("769e20c2-20b1-41aa-be53-c7f3ee380256"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("88b2652e-59e8-41f9-b5a1-3a4d68934c97"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8ebc0ca4-bd69-478f-b049-ea9f2dcf9358"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a2297cd4-ff02-4054-85a3-f954fae8f5e6"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a5293db5-1b29-4db3-a754-20c97a4b5ebf"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ad2bc3e9-64d4-45af-8e5d-e0bd598dc218"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b0128f5b-00a2-4220-9512-73b08c838476"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b20939f3-fe91-4786-9d5f-dbef3dc7b69d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b9c2a766-b7f2-4e97-8804-d6e0a3a0d93b"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c7308586-7097-445e-936c-2473da75f698"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c986abab-32d7-4112-bf7a-e9a6dfeb8eb4"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("da88aa77-1ea6-4058-91f8-6d304f6ca14f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e0b500f6-332e-4f63-8bd9-a43fe8e690ea"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ea657ee0-892a-4394-ae44-9c88aed2d097"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f1e6e929-b2d4-490b-bb56-d266b4578a6b"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fe98eb7a-32d6-4c28-95cd-07ec73f3865a"), "UserRole" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("057c7eee-c467-436a-abd8-fe8dcb099fad") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("0d7ff7cc-9a44-43fb-96c6-aa0adb0fa897") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("119809f5-f4da-4b1b-83e1-5e06b475f3cc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("16c7753c-e27c-4c48-925f-7d77ef8f5492") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1803dbcc-6a78-4080-887f-0ef25e57811f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1d10808f-d13e-47c8-93ab-9e3fa5d0902b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2af6972d-353c-424d-8fce-858736057342") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2ff30446-27c5-44ff-85b4-c7cde3442a5a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42a87121-a807-4d84-9022-3ea002a7b2d8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("496b1e47-5954-4c4a-9c85-80d26c53900d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f6683f1-46ad-4226-907a-7e9c6dc38d09") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("51bcbbac-c187-408d-ae7a-3d66e0174dc7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("528f86cd-75b8-4692-981d-c6e29d5c0882") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5d983e82-fde8-45c1-9862-374566598c83") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6bb9f598-0dfc-4ca4-af61-866cc25238f7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6d948de7-b0a6-45bd-9ac3-b5ed1c81cdad") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6f56a37f-aaa0-49cc-ae7d-1465528d0a55") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("764dd036-756f-41b4-bf84-65222d64c76f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("769e20c2-20b1-41aa-be53-c7f3ee380256") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("88b2652e-59e8-41f9-b5a1-3a4d68934c97") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8ebc0ca4-bd69-478f-b049-ea9f2dcf9358") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a2297cd4-ff02-4054-85a3-f954fae8f5e6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a5293db5-1b29-4db3-a754-20c97a4b5ebf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ad2bc3e9-64d4-45af-8e5d-e0bd598dc218") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b0128f5b-00a2-4220-9512-73b08c838476") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b20939f3-fe91-4786-9d5f-dbef3dc7b69d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b9c2a766-b7f2-4e97-8804-d6e0a3a0d93b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c7308586-7097-445e-936c-2473da75f698") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c986abab-32d7-4112-bf7a-e9a6dfeb8eb4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("da88aa77-1ea6-4058-91f8-6d304f6ca14f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e0b500f6-332e-4f63-8bd9-a43fe8e690ea") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ea657ee0-892a-4394-ae44-9c88aed2d097") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f1e6e929-b2d4-490b-bb56-d266b4578a6b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fe98eb7a-32d6-4c28-95cd-07ec73f3865a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("057c7eee-c467-436a-abd8-fe8dcb099fad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0d7ff7cc-9a44-43fb-96c6-aa0adb0fa897"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("119809f5-f4da-4b1b-83e1-5e06b475f3cc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("16c7753c-e27c-4c48-925f-7d77ef8f5492"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1803dbcc-6a78-4080-887f-0ef25e57811f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1d10808f-d13e-47c8-93ab-9e3fa5d0902b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2af6972d-353c-424d-8fce-858736057342"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2ff30446-27c5-44ff-85b4-c7cde3442a5a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("42a87121-a807-4d84-9022-3ea002a7b2d8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("496b1e47-5954-4c4a-9c85-80d26c53900d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f6683f1-46ad-4226-907a-7e9c6dc38d09"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("51bcbbac-c187-408d-ae7a-3d66e0174dc7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("528f86cd-75b8-4692-981d-c6e29d5c0882"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d983e82-fde8-45c1-9862-374566598c83"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6bb9f598-0dfc-4ca4-af61-866cc25238f7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d948de7-b0a6-45bd-9ac3-b5ed1c81cdad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6f56a37f-aaa0-49cc-ae7d-1465528d0a55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("764dd036-756f-41b4-bf84-65222d64c76f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("769e20c2-20b1-41aa-be53-c7f3ee380256"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88b2652e-59e8-41f9-b5a1-3a4d68934c97"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ebc0ca4-bd69-478f-b049-ea9f2dcf9358"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2297cd4-ff02-4054-85a3-f954fae8f5e6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5293db5-1b29-4db3-a754-20c97a4b5ebf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad2bc3e9-64d4-45af-8e5d-e0bd598dc218"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0128f5b-00a2-4220-9512-73b08c838476"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b20939f3-fe91-4786-9d5f-dbef3dc7b69d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9c2a766-b7f2-4e97-8804-d6e0a3a0d93b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7308586-7097-445e-936c-2473da75f698"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c986abab-32d7-4112-bf7a-e9a6dfeb8eb4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("da88aa77-1ea6-4058-91f8-6d304f6ca14f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0b500f6-332e-4f63-8bd9-a43fe8e690ea"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea657ee0-892a-4394-ae44-9c88aed2d097"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1e6e929-b2d4-490b-bb56-d266b4578a6b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fe98eb7a-32d6-4c28-95cd-07ec73f3865a"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("038b8e4e-9ab6-4861-8cc8-650895a758d7"), 0, "ff2db6b3-51c5-43d8-ba70-96204e510913", new DateTime(2024, 6, 25, 8, 5, 7, 910, DateTimeKind.Utc).AddTicks(3267), new DateTime(2005, 7, 9, 15, 5, 7, 910, DateTimeKind.Local).AddTicks(3248), "oliviag@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 910, DateTimeKind.Local).AddTicks(3266), "Garcia", new DateTime(2024, 6, 25, 8, 5, 7, 910, DateTimeKind.Utc).AddTicks(3268), "HN", true, null, "OLIVIAG@GMAIL.COM", "OLIVIAG", "AQAAAAIAAYagAAAAEI3gpvOB5z/+kzTQP/712z0Lih4XR2qn+0PPgpoypNsqGUviu25pv5Y/qHEUkEB5nA==", null, false, "4c29e0fe-b528-43d7-b07d-b6e5f9a01823", "SD0013", false, "oliviag" },
                    { new Guid("081ffc77-0fb0-4af9-969d-5aa03f72ba53"), 0, "c1d98cd0-b374-4a52-ad8f-d317baf542e6", new DateTime(2024, 6, 25, 8, 5, 8, 614, DateTimeKind.Utc).AddTicks(465), new DateTime(2004, 5, 25, 15, 5, 8, 614, DateTimeKind.Local).AddTicks(447), "avab@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 614, DateTimeKind.Local).AddTicks(464), "Brown", new DateTime(2024, 6, 25, 8, 5, 8, 614, DateTimeKind.Utc).AddTicks(466), "HN", true, null, "AVAB@GMAIL.COM", "AVAB", "AQAAAAIAAYagAAAAEPqnvkYXuONa+Dy5t+J+6K62amaiQE41dDe5yOePg3QQq1P0wZKOzAV4TCigEWb7UA==", null, false, "104f7c3a-7582-4b1c-a501-04c82b8a6c48", "SD0024", false, "avab" },
                    { new Guid("26a31c17-8125-4a7b-a8d8-dcb3745a1a2a"), 0, "3b1be6d6-50b6-45db-8e82-05a424f65c0c", new DateTime(2024, 6, 25, 8, 5, 8, 855, DateTimeKind.Utc).AddTicks(8672), new DateTime(2003, 6, 27, 15, 5, 8, 855, DateTimeKind.Local).AddTicks(8653), "harperr@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 855, DateTimeKind.Local).AddTicks(8671), "Rodriguez", new DateTime(2024, 6, 25, 8, 5, 8, 855, DateTimeKind.Utc).AddTicks(8672), "HCM", true, null, "HARPERR@GMAIL.COM", "HARPERR", "AQAAAAIAAYagAAAAENh/HGPpymGgB0ZdFlncYYagOm/112GB2zgS9tzc3rqlXZmLoGh652x94z3ASRe1zw==", null, false, "28e489c3-ebfc-4cf9-b666-fd6d8beaa28e", "SD0028", false, "harperr" },
                    { new Guid("27bfd210-a512-4d1e-a259-c8bbfd3ca5ba"), 0, "ca749129-b6f1-4076-bb2e-761ca1b3f0b8", new DateTime(2024, 6, 25, 8, 5, 7, 976, DateTimeKind.Utc).AddTicks(534), new DateTime(1999, 10, 15, 15, 5, 7, 976, DateTimeKind.Local).AddTicks(502), "johnd@gmail.com", false, "John", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 976, DateTimeKind.Local).AddTicks(533), "Davis", new DateTime(2024, 6, 25, 8, 5, 7, 976, DateTimeKind.Utc).AddTicks(535), "HCM", true, null, "JOHND@GMAIL.COM", "JOHND", "AQAAAAIAAYagAAAAECiQA+ggC/lbEN/a3X51NfamELFaFjRnMlELXcm48eiF3zqPqiMsFd0LfD0VDjjLXw==", null, false, "987f2fc0-0825-4d07-be2d-bb8e2d302bf8", "SD0014", false, "johnd" },
                    { new Guid("285c8f26-66d4-4cf2-8eef-c21d14609450"), 0, "b36c7245-590f-469a-9c55-0b0c184480c0", new DateTime(2024, 6, 25, 8, 5, 8, 429, DateTimeKind.Utc).AddTicks(6332), new DateTime(2001, 5, 15, 15, 5, 8, 429, DateTimeKind.Local).AddTicks(6311), "oliviag1@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 429, DateTimeKind.Local).AddTicks(6330), "Garcia", new DateTime(2024, 6, 25, 8, 5, 8, 429, DateTimeKind.Utc).AddTicks(6332), "HCM", true, null, "OLIVIAG1@GMAIL.COM", "OLIVIAG1", "AQAAAAIAAYagAAAAEJIGDnmsmnwy3dRrCtDohh2aDxlTb6LBBVpQfmBUYA+VliEWOFld8VOdoF+ArOorzg==", null, false, "9ff3ecdf-d7f4-41f8-a534-4a33fe6086c8", "SD0021", false, "oliviag1" },
                    { new Guid("2b21584d-bf87-4f41-b7c2-e6b4f6a12eaf"), 0, "63c3b8c0-4d2d-4dbd-8884-b7cbb25453db", new DateTime(2024, 6, 25, 8, 5, 8, 246, DateTimeKind.Utc).AddTicks(5881), new DateTime(1995, 1, 6, 15, 5, 8, 246, DateTimeKind.Local).AddTicks(5858), "elijaha@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 246, DateTimeKind.Local).AddTicks(5880), "Anderson", new DateTime(2024, 6, 25, 8, 5, 8, 246, DateTimeKind.Utc).AddTicks(5881), "HCM", true, null, "ELIJAHA@GMAIL.COM", "ELIJAHA", "AQAAAAIAAYagAAAAEBsw67yTgG3f/TUHytsPM/7w4BxtcFbg8tGylcihXh7rAptN1nz5jRtwLLce38WpAw==", null, false, "35f280f5-5240-4b31-a12f-881a68540a43", "SD0018", false, "elijaha" },
                    { new Guid("2ce25479-e06e-4996-a1ce-34bc803a2972"), 0, "c6aa9462-66ad-4dc9-b59c-91d7d5051a61", new DateTime(2024, 6, 25, 8, 5, 9, 92, DateTimeKind.Utc).AddTicks(3098), new DateTime(2000, 1, 12, 15, 5, 9, 92, DateTimeKind.Local).AddTicks(3090), "johnj@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 9, 92, DateTimeKind.Local).AddTicks(3097), "Johnson", new DateTime(2024, 6, 25, 8, 5, 9, 92, DateTimeKind.Utc).AddTicks(3098), "HCM", true, null, "JOHNJ@GMAIL.COM", "JOHNJ", "AQAAAAIAAYagAAAAEEX8RHtK8pUcd/X9Ht6dxdG8y9/hCjhcxNnt3nUfQRV+eRpSBbXCZAGd0uTxgPv/gg==", null, false, "12e2176d-910b-4a89-afd5-96ecc34ba8c5", "SD0032", false, "johnj" },
                    { new Guid("2e50e7cf-9ffe-4cd1-a390-bf95f6abbd7a"), 0, "fc850f13-c825-49a4-b6db-3d94ccec4458", new DateTime(2024, 6, 25, 8, 5, 7, 484, DateTimeKind.Utc).AddTicks(4169), new DateTime(2005, 5, 31, 15, 5, 7, 484, DateTimeKind.Local).AddTicks(4137), "emmaj@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 484, DateTimeKind.Local).AddTicks(4168), "Jones", new DateTime(2024, 6, 25, 8, 5, 7, 484, DateTimeKind.Utc).AddTicks(4170), "HN", true, null, "EMMAJ@GMAIL.COM", "EMMAJ", "AQAAAAIAAYagAAAAEGQR0xPMtryCoqbar9sMIl0K75taJqBZgbBgfvnraS1yNEkjgpkoanl/9jhYfxGgGg==", null, false, "bc60c2a7-9df2-4d92-8a30-c5a8589e81ea", "SD0006", false, "emmaj" },
                    { new Guid("346e2bee-c67b-42c0-af13-72e344af713f"), 0, "b5bb339b-baf9-451a-9f91-a58574daf4db", new DateTime(2024, 6, 25, 8, 5, 9, 33, DateTimeKind.Utc).AddTicks(6304), new DateTime(2000, 4, 12, 15, 5, 9, 33, DateTimeKind.Local).AddTicks(6282), "johnw1@gmail.com", false, "John", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 9, 33, DateTimeKind.Local).AddTicks(6303), "Wilson", new DateTime(2024, 6, 25, 8, 5, 9, 33, DateTimeKind.Utc).AddTicks(6305), "HCM", true, null, "JOHNW1@GMAIL.COM", "JOHNW1", "AQAAAAIAAYagAAAAEP+muh75ml0ji9QI0bMlof6tW1YUrsfsLDGUa3+A5idQJ8VazLbB9y1ThZfbZQnupg==", null, false, "f4b860dc-c108-499a-9f6e-74a57e733960", "SD0031", false, "johnw1" },
                    { new Guid("43e08a6f-fc6d-46ba-80fd-6f0aff00ea26"), 0, "04c23db3-b056-4138-95b0-1f4e58bb8fa5", new DateTime(2024, 6, 25, 8, 5, 7, 323, DateTimeKind.Utc).AddTicks(9343), new DateTime(2000, 1, 25, 15, 5, 7, 323, DateTimeKind.Local).AddTicks(9285), "staffhn@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 323, DateTimeKind.Local).AddTicks(9338), "HN", new DateTime(2024, 6, 25, 8, 5, 7, 323, DateTimeKind.Utc).AddTicks(9344), "HN", true, null, "STAFFHN@GMAIL.COM", "STAFFHN", "AQAAAAIAAYagAAAAEAOnuZL5lOWfCEt8c6DTPKi62cWQ40/Z0g981iBc00wwY/ZfgEbu+dGFein9FyoKcg==", null, false, "9da64ac1-a2fd-4214-bec9-2b5beb30a09e", "SD0004", false, "staffhn" },
                    { new Guid("475a8afe-99cc-4f8a-944c-7b35804fb109"), 0, "7398b2c2-9178-4a63-a010-863e5df2f360", new DateTime(2024, 6, 25, 8, 5, 7, 667, DateTimeKind.Utc).AddTicks(2055), new DateTime(2005, 1, 19, 15, 5, 7, 667, DateTimeKind.Local).AddTicks(2033), "davidm@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 667, DateTimeKind.Local).AddTicks(2054), "Miller", new DateTime(2024, 6, 25, 8, 5, 7, 667, DateTimeKind.Utc).AddTicks(2056), "HCM", true, null, "DAVIDM@GMAIL.COM", "DAVIDM", "AQAAAAIAAYagAAAAEB2ch5rTvNosY6rYZfyikANCSNoZ+xONSWh2EB89GhWs4PmmgJgH2fyEChs1ooAWwg==", null, false, "d6428892-65a1-4373-8a5a-66caaf9a47b6", "SD0009", false, "davidm" },
                    { new Guid("59bdce92-ce42-48ad-8625-e1961dfb8062"), 0, "290a22db-233d-4d7a-87cc-5c6433ddcafc", new DateTime(2024, 6, 25, 8, 5, 7, 784, DateTimeKind.Utc).AddTicks(5000), new DateTime(2003, 6, 17, 15, 5, 7, 784, DateTimeKind.Local).AddTicks(4976), "elijahw@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 784, DateTimeKind.Local).AddTicks(4999), "White", new DateTime(2024, 6, 25, 8, 5, 7, 784, DateTimeKind.Utc).AddTicks(5001), "HN", true, null, "ELIJAHW@GMAIL.COM", "ELIJAHW", "AQAAAAIAAYagAAAAECaMhsi/PQmA1iRaLhuW4c97wgpKtfmaYbS/mz/g9Rz31Aakbhgqsnd7LuQUhsqSjA==", null, false, "8990a8a6-09be-4518-ab56-ecc98a3ae519", "SD0011", false, "elijahw" },
                    { new Guid("5ed6f40c-9839-4dd0-88cb-a0a051b8f102"), 0, "ed652f14-65af-4952-b692-eea695c4b445", new DateTime(2024, 6, 25, 8, 5, 8, 34, DateTimeKind.Utc).AddTicks(5072), new DateTime(2002, 2, 24, 15, 5, 8, 34, DateTimeKind.Local).AddTicks(5046), "michaelr@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 34, DateTimeKind.Local).AddTicks(5071), "Rodriguez", new DateTime(2024, 6, 25, 8, 5, 8, 34, DateTimeKind.Utc).AddTicks(5072), "HN", true, null, "MICHAELR@GMAIL.COM", "MICHAELR", "AQAAAAIAAYagAAAAEKKVyt2I/vxUPBJSgNlhFc3KwftNM0mi8Yvf0m3+4DToJWVdYbW7vC2xRia3HwkVXw==", null, false, "f66220e4-9e8c-4c92-bda5-388218d94459", "SD0015", false, "michaelr" },
                    { new Guid("5f467e99-b7a4-4c90-95a9-8b28ec454805"), 0, "27e47b1f-34ef-45cf-a907-f33ef8e9ee15", new DateTime(2024, 6, 25, 8, 5, 8, 306, DateTimeKind.Utc).AddTicks(7716), new DateTime(2001, 2, 15, 15, 5, 8, 306, DateTimeKind.Local).AddTicks(7691), "isabellaj1@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 306, DateTimeKind.Local).AddTicks(7714), "Johnson", new DateTime(2024, 6, 25, 8, 5, 8, 306, DateTimeKind.Utc).AddTicks(7716), "HCM", true, null, "ISABELLAJ1@GMAIL.COM", "ISABELLAJ1", "AQAAAAIAAYagAAAAEPIzU9YLtPTKCwyLQPbV3UpxxUf/GKEaFQzRHkKvH5MQWjTCgbkWw7APBloStTVi7w==", null, false, "896bdd3f-ab79-43e1-b87e-1acf324a8629", "SD0019", false, "isabellaj1" },
                    { new Guid("66c63e2f-7878-4299-958a-ad5717e95a1f"), 0, "1aac0115-3d54-4050-abda-7d52d2fb9f9a", new DateTime(2024, 6, 25, 8, 5, 8, 153, DateTimeKind.Utc).AddTicks(6214), new DateTime(2000, 4, 7, 15, 5, 8, 153, DateTimeKind.Local).AddTicks(6181), "emmay@gmail.com", false, "Emma", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 153, DateTimeKind.Local).AddTicks(6212), "Young", new DateTime(2024, 6, 25, 8, 5, 8, 153, DateTimeKind.Utc).AddTicks(6214), "HN", true, null, "EMMAY@GMAIL.COM", "EMMAY", "AQAAAAIAAYagAAAAEPjblGIC+h96KZu4qDDbS93IsU7gmE6RrQ+Q1EHbO1nHfoKoHpLHtWFag2c5vszhEg==", null, false, "f9dddcfa-b06d-4f1c-8c0a-a57af90f2766", "SD0017", false, "emmay" },
                    { new Guid("6a3f49a7-0e21-4279-b22c-d3503ca9803c"), 0, "36855868-7774-4075-bc9f-39e36a364619", new DateTime(2024, 6, 25, 8, 5, 8, 93, DateTimeKind.Utc).AddTicks(2891), new DateTime(1997, 10, 25, 15, 5, 8, 93, DateTimeKind.Local).AddTicks(2871), "harperb@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 93, DateTimeKind.Local).AddTicks(2890), "Brown", new DateTime(2024, 6, 25, 8, 5, 8, 93, DateTimeKind.Utc).AddTicks(2891), "HN", true, null, "HARPERB@GMAIL.COM", "HARPERB", "AQAAAAIAAYagAAAAEFiPT9tEGluW3Zk47twIEyh/WCmkxFfaFBK/Ge+GmlK/CbBFltJlRsGQxGeKssQH4g==", null, false, "b5563c29-ea6e-41e4-8243-5e20d495bb04", "SD0016", false, "harperb" },
                    { new Guid("71f5ba70-142c-4196-8553-3bd829f3bff2"), 0, "ad925769-320c-4183-b0f6-2645e45552ec", new DateTime(2024, 6, 25, 8, 5, 7, 233, DateTimeKind.Utc).AddTicks(5837), new DateTime(2002, 3, 2, 15, 5, 7, 233, DateTimeKind.Local).AddTicks(5804), "staffhcm@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 233, DateTimeKind.Local).AddTicks(5836), "HCM", new DateTime(2024, 6, 25, 8, 5, 7, 233, DateTimeKind.Utc).AddTicks(5838), "HCM", true, null, "STAFFHCM@GMAIL.COM", "STAFFHCM", "AQAAAAIAAYagAAAAELV+3+y39OSbHv5qOwTjhQQH2tqMSLgyJd03awiEaFhau7qM1EzcWDWgS77m7iAsKQ==", null, false, "c134f046-8ed5-4363-9be8-bfd2f1eccf8a", "SD0003", false, "staffhcm" },
                    { new Guid("72ae1c7a-e390-4b93-8bd3-b0e9e2d649d1"), 0, "1828bbe6-d2a6-4b2b-8a6b-17850ffcabb1", new DateTime(2024, 6, 25, 8, 5, 9, 152, DateTimeKind.Utc).AddTicks(6672), new DateTime(2000, 8, 9, 15, 5, 9, 152, DateTimeKind.Local).AddTicks(6653), "avab1@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 9, 152, DateTimeKind.Local).AddTicks(6670), "Brown", new DateTime(2024, 6, 25, 8, 5, 9, 152, DateTimeKind.Utc).AddTicks(6672), "HN", true, null, "AVAB1@GMAIL.COM", "AVAB1", "AQAAAAIAAYagAAAAEDvkp+Dh2JY55jkEPa3WR/2FfBAjejfRBPrHfE6uMx87PMYXmX3pU7wUAiKG2kEHxQ==", null, false, "940c345d-d054-4756-9301-9633315922d3", "SD0033", false, "avab1" },
                    { new Guid("7f499e73-5f41-4343-8f87-74884247dd03"), 0, "cb70be48-b3c6-4195-8b02-b7e6920c1b8e", new DateTime(2024, 6, 25, 8, 5, 8, 678, DateTimeKind.Utc).AddTicks(9805), new DateTime(1999, 5, 6, 15, 5, 8, 678, DateTimeKind.Local).AddTicks(9783), "ameliaw@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 678, DateTimeKind.Local).AddTicks(9804), "Williams", new DateTime(2024, 6, 25, 8, 5, 8, 678, DateTimeKind.Utc).AddTicks(9806), "HCM", true, null, "AMELIAW@GMAIL.COM", "AMELIAW", "AQAAAAIAAYagAAAAEBzO5dAUDCoI4F57WYscQMnmLxAViADl9woX/s14H+ymNPqXjOUkbTGAHkyjKLe+SQ==", null, false, "c2c89fac-f433-41d4-8ae5-11abe00a08d0", "SD0025", false, "ameliaw" },
                    { new Guid("88d71ff9-04a1-4063-8082-c47c385f9ce7"), 0, "b7d2caa8-84b7-46e5-9a87-5d8afcb5a377", new DateTime(2024, 6, 25, 8, 5, 7, 605, DateTimeKind.Utc).AddTicks(4761), new DateTime(2000, 11, 6, 15, 5, 7, 605, DateTimeKind.Local).AddTicks(4730), "avam@gmail.com", false, "Ava", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 605, DateTimeKind.Local).AddTicks(4760), "Martinez", new DateTime(2024, 6, 25, 8, 5, 7, 605, DateTimeKind.Utc).AddTicks(4762), "HN", true, null, "AVAM@GMAIL.COM", "AVAM", "AQAAAAIAAYagAAAAENtsaVuOhHOPLqP4RbTd+VE4EbOhUuoDMwyPFGyafRx4ajXZx6CrWLYI7zSbLy1SuA==", null, false, "7c641717-aab9-4e73-91d9-1dc239c5e751", "SD0008", false, "avam" },
                    { new Guid("8a4c7483-162b-4fb6-ab9a-6e746131e02a"), 0, "564ecf7d-73d6-4b12-a3e4-cd53536b3116", new DateTime(2024, 6, 25, 8, 5, 8, 795, DateTimeKind.Utc).AddTicks(6496), new DateTime(2003, 10, 26, 15, 5, 8, 795, DateTimeKind.Local).AddTicks(6481), "johns@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 795, DateTimeKind.Local).AddTicks(6494), "Smith", new DateTime(2024, 6, 25, 8, 5, 8, 795, DateTimeKind.Utc).AddTicks(6496), "HN", true, null, "JOHNS@GMAIL.COM", "JOHNS", "AQAAAAIAAYagAAAAEGRz5GxddZ7XtzxECFFZ6aNx3mdFaZRWLtLw+n3xCQQqazqJgNTnLk9tqoKmca8tMg==", null, false, "a1f6d336-c280-42ba-a2f0-36e98d504f99", "SD0027", false, "johns" },
                    { new Guid("8f81b0b9-43d6-4881-ab11-50205a6f210f"), 0, "bb209432-4b91-44a8-84de-863c835d755e", new DateTime(2024, 6, 25, 8, 5, 7, 172, DateTimeKind.Utc).AddTicks(6877), new DateTime(2002, 12, 29, 15, 5, 7, 172, DateTimeKind.Local).AddTicks(6821), "adminhn@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 172, DateTimeKind.Local).AddTicks(6876), "HN", new DateTime(2024, 6, 25, 8, 5, 7, 172, DateTimeKind.Utc).AddTicks(6878), "HN", true, null, "ADMINHN@GMAIL.COM", "ADMINHN", "AQAAAAIAAYagAAAAEKOuImjQrGB7ImoYgQH48z5EKD1LCBouW9pTVdHR3vWCbzWlRvOkG462iC4Jd3X9GQ==", null, false, "0bad931b-c836-45cb-8618-d99816765ed0", "SD0002", false, "adminhn" },
                    { new Guid("992da7d1-4347-47db-bcdf-684c05dc3c5c"), 0, "ed76ed4b-ad4a-40f4-a081-ce03ee440a44", new DateTime(2024, 6, 25, 8, 5, 7, 114, DateTimeKind.Utc).AddTicks(5388), new DateTime(2003, 3, 11, 15, 5, 7, 114, DateTimeKind.Local).AddTicks(5374), "adminhcm@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 114, DateTimeKind.Local).AddTicks(5387), "HCM", new DateTime(2024, 6, 25, 8, 5, 7, 114, DateTimeKind.Utc).AddTicks(5389), "HCM", true, null, "ADMINHCM@GMAIL.COM", "ADMINHCM", "AQAAAAIAAYagAAAAEPXnQewF44zkYSgaiLlBkUte+TG9unkdynV5j00ue+gRlcpKhqndcKmUv7ZW2hJWtA==", null, false, "2ccf79c7-def7-40f8-a7a1-c7541196c626", "SD0001", false, "adminhcm" },
                    { new Guid("9e7ad160-7e79-40d6-9d2b-ec5c80a68ef8"), 0, "b83a2aa5-2de8-4763-9458-76760a914691", new DateTime(2024, 6, 25, 8, 5, 8, 915, DateTimeKind.Utc).AddTicks(4785), new DateTime(2004, 3, 8, 15, 5, 8, 915, DateTimeKind.Local).AddTicks(4765), "miaj@gmail.com", false, "Mia", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 915, DateTimeKind.Local).AddTicks(4783), "Johnson", new DateTime(2024, 6, 25, 8, 5, 8, 915, DateTimeKind.Utc).AddTicks(4785), "HN", true, null, "MIAJ@GMAIL.COM", "MIAJ", "AQAAAAIAAYagAAAAEK5Thoaru4WRjClVjqXkVhS1Az1C0SSMYX5uaRtc1oljTr4QiXp8Ee6Vf30IQuYV1g==", null, false, "d4a71898-7b84-45ec-90a7-9ef1862240aa", "SD0029", false, "miaj" },
                    { new Guid("a6a60593-e3f7-4604-8ac7-ef7b3950d87f"), 0, "fbaf8293-fe6c-4398-85f0-23635091e9c8", new DateTime(2024, 6, 25, 8, 5, 8, 488, DateTimeKind.Utc).AddTicks(9190), new DateTime(2000, 2, 1, 15, 5, 8, 488, DateTimeKind.Local).AddTicks(9172), "benjaminj@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 488, DateTimeKind.Local).AddTicks(9188), "Jackson", new DateTime(2024, 6, 25, 8, 5, 8, 488, DateTimeKind.Utc).AddTicks(9190), "HN", true, null, "BENJAMINJ@GMAIL.COM", "BENJAMINJ", "AQAAAAIAAYagAAAAENT4088C/jV3A4/jNQd5D5BEbLkz8oEuSkJlMH5Rxr1DszgpXAyJY0STJCd8uSHaPQ==", null, false, "702f41e7-1c6a-42af-9b3d-21239167dd4b", "SD0022", false, "benjaminj" },
                    { new Guid("bcfe003e-50bd-4761-a5c8-de3905dee1de"), 0, "684554eb-8b75-4b26-9285-d6b35e8b9da0", new DateTime(2024, 6, 25, 8, 5, 7, 405, DateTimeKind.Utc).AddTicks(6827), new DateTime(2001, 12, 22, 15, 5, 7, 405, DateTimeKind.Local).AddTicks(6798), "williaml@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 405, DateTimeKind.Local).AddTicks(6825), "Lewis", new DateTime(2024, 6, 25, 8, 5, 7, 405, DateTimeKind.Utc).AddTicks(6827), "HN", true, null, "WILLIAML@GMAIL.COM", "WILLIAML", "AQAAAAIAAYagAAAAEH4r5HwCBzelFH631QFwqnDXaahDIU8vz80LmhuT4bwzS7YPs++I3rgEu4iYVRCuHQ==", null, false, "c4abf68c-621b-409d-ac23-b4025873c4c2", "SD0005", false, "williaml" },
                    { new Guid("bfabe129-f256-4dc1-97d7-3e604095a2ba"), 0, "2d98f0e2-8db5-4d18-85d5-b088cf5ca91e", new DateTime(2024, 6, 25, 8, 5, 8, 737, DateTimeKind.Utc).AddTicks(1054), new DateTime(1994, 9, 30, 15, 5, 8, 737, DateTimeKind.Local).AddTicks(1025), "williamj1@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 737, DateTimeKind.Local).AddTicks(1052), "Jackson", new DateTime(2024, 6, 25, 8, 5, 8, 737, DateTimeKind.Utc).AddTicks(1054), "HN", true, null, "WILLIAMJ1@GMAIL.COM", "WILLIAMJ1", "AQAAAAIAAYagAAAAEAGCOywSeh9vxU7W8w6tzrchBKyvjVvICQN/3pbtIZ4PN4CoZoJTFp6UZP2sfyViWw==", null, false, "ae7b43c1-3eee-4573-971a-6c9a4b06f2ea", "SD0026", false, "williamj1" },
                    { new Guid("c595e65d-cb90-410a-b48e-4b0b58ca6e14"), 0, "d1bf1194-0ca4-4497-96e9-ed88a94d65af", new DateTime(2024, 6, 25, 8, 5, 7, 544, DateTimeKind.Utc).AddTicks(8163), new DateTime(2003, 5, 12, 15, 5, 7, 544, DateTimeKind.Local).AddTicks(8124), "josephg@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 544, DateTimeKind.Local).AddTicks(8162), "Garcia", new DateTime(2024, 6, 25, 8, 5, 7, 544, DateTimeKind.Utc).AddTicks(8164), "HCM", true, null, "JOSEPHG@GMAIL.COM", "JOSEPHG", "AQAAAAIAAYagAAAAEBgdi0JuGNqe5x+y6WnayJnNlrX6qkhsWbbg1/3KjD1yFhT81z05j7xHPqxGzJwFDg==", null, false, "d5f91516-a25e-4bdc-b31d-7ba0835a7fb5", "SD0007", false, "josephg" },
                    { new Guid("c762344e-bfd4-4e7b-b6e5-547271b03961"), 0, "2b2a6291-beb3-42ae-901b-040632b10560", new DateTime(2024, 6, 25, 8, 5, 8, 369, DateTimeKind.Utc).AddTicks(5030), new DateTime(2000, 4, 26, 15, 5, 8, 369, DateTimeKind.Local).AddTicks(5011), "sophiar@gmail.com", false, "Sophia", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 369, DateTimeKind.Local).AddTicks(5029), "Rodriguez", new DateTime(2024, 6, 25, 8, 5, 8, 369, DateTimeKind.Utc).AddTicks(5030), "HCM", true, null, "SOPHIAR@GMAIL.COM", "SOPHIAR", "AQAAAAIAAYagAAAAEHkBNzZotA/NvamKK8i90rX8Ud4SZe/Lu8FqtLqvIexa4gECQJDm3+ZUK+u+HmopFA==", null, false, "331d6ce2-952c-49d7-aae1-e148d74c25b3", "SD0020", false, "sophiar" },
                    { new Guid("ce15af4c-830b-4049-a057-80ac898aa677"), 0, "70ea934f-bfc6-4d83-b7b4-fea06873851d", new DateTime(2024, 6, 25, 8, 5, 9, 212, DateTimeKind.Utc).AddTicks(1706), new DateTime(2001, 2, 9, 15, 5, 9, 212, DateTimeKind.Local).AddTicks(1674), "avat@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 9, 212, DateTimeKind.Local).AddTicks(1706), "Taylor", new DateTime(2024, 6, 25, 8, 5, 9, 212, DateTimeKind.Utc).AddTicks(1707), "HN", true, null, "AVAT@GMAIL.COM", "AVAT", "AQAAAAIAAYagAAAAENnIYtHm1pkpYqTiZUhvCxFYyP/b4l8sxhEZmiPqb83ZMdbRZzINALMU8J7baVj1Tw==", null, false, "b5807ce9-f750-48d0-bc39-dd683f899c7e", "SD0034", false, "avat" },
                    { new Guid("d6bdfc32-079f-4a5b-bd97-bb14dd1d3f9b"), 0, "7624de30-2675-4d46-a56b-8dbb8b1ee7fd", new DateTime(2024, 6, 25, 8, 5, 8, 550, DateTimeKind.Utc).AddTicks(6110), new DateTime(1997, 8, 10, 15, 5, 8, 550, DateTimeKind.Local).AddTicks(6086), "williamm1@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 550, DateTimeKind.Local).AddTicks(6109), "Martinez", new DateTime(2024, 6, 25, 8, 5, 8, 550, DateTimeKind.Utc).AddTicks(6111), "HCM", true, null, "WILLIAMM1@GMAIL.COM", "WILLIAMM1", "AQAAAAIAAYagAAAAEIcaxkzO4JyKF6nhhoKI72O/wAes20mdKjpkmokd0JSHzymNslttKfdQ4IoYhljaKA==", null, false, "ca9bd8c5-2dbc-4cd4-b71d-31d0cc4c7f10", "SD0023", false, "williamm1" },
                    { new Guid("ddc64ce0-2560-4ca9-af1d-28f5f8a6ee6e"), 0, "ad9a2743-6458-406e-8e72-daa4aa7bbe35", new DateTime(2024, 6, 25, 8, 5, 8, 974, DateTimeKind.Utc).AddTicks(835), new DateTime(1999, 12, 27, 15, 5, 8, 974, DateTimeKind.Local).AddTicks(817), "miam@gmail.com", false, "Mia", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 8, 974, DateTimeKind.Local).AddTicks(833), "Martinez", new DateTime(2024, 6, 25, 8, 5, 8, 974, DateTimeKind.Utc).AddTicks(836), "HCM", true, null, "MIAM@GMAIL.COM", "MIAM", "AQAAAAIAAYagAAAAEGhmepfe25IjTakQyKn67E7WiI8QA9unZ/JYoRGrdfKbfrG/dZtWpxdmgFA6pmG/7g==", null, false, "d55c98d8-36d6-4143-83a8-1f2c8dab41f1", "SD0030", false, "miam" },
                    { new Guid("fbdb5ab6-a5b7-44f3-9295-c72f04d24881"), 0, "361049b5-0806-49ec-8951-bcd13be0f008", new DateTime(2024, 6, 25, 8, 5, 7, 844, DateTimeKind.Utc).AddTicks(1063), new DateTime(1999, 6, 29, 15, 5, 7, 844, DateTimeKind.Local).AddTicks(928), "johnw@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 844, DateTimeKind.Local).AddTicks(1061), "Wilson", new DateTime(2024, 6, 25, 8, 5, 7, 844, DateTimeKind.Utc).AddTicks(1063), "HN", true, null, "JOHNW@GMAIL.COM", "JOHNW", "AQAAAAIAAYagAAAAEBIcC3VauwVUgmuPHD6tzGqmZweYxtHSPGfqX21WTHecH5Ycx6w7skcUlOr0g4qx+w==", null, false, "57f310cf-befa-4421-a825-f77b497eb419", "SD0012", false, "johnw" },
                    { new Guid("ff8d5c57-2c03-4e2f-956b-77d89b17672d"), 0, "7361cacf-ee9b-4d10-95ba-d4a0212ab482", new DateTime(2024, 6, 25, 8, 5, 7, 726, DateTimeKind.Utc).AddTicks(2028), new DateTime(2005, 10, 13, 15, 5, 7, 726, DateTimeKind.Local).AddTicks(2009), "harperh@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 25, 15, 5, 7, 726, DateTimeKind.Local).AddTicks(2027), "Harris", new DateTime(2024, 6, 25, 8, 5, 7, 726, DateTimeKind.Utc).AddTicks(2029), "HCM", true, null, "HARPERH@GMAIL.COM", "HARPERH", "AQAAAAIAAYagAAAAEGJJXte877M4RFNRKnAIppkItnYkVGHksLUvIAH2US25n1HGOZaThCRJhPcHGvZ1vw==", null, false, "8e66be39-afa0-4041-bbef-47b96afa783a", "SD0010", false, "harperh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("038b8e4e-9ab6-4861-8cc8-650895a758d7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("081ffc77-0fb0-4af9-969d-5aa03f72ba53"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("26a31c17-8125-4a7b-a8d8-dcb3745a1a2a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("27bfd210-a512-4d1e-a259-c8bbfd3ca5ba"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("285c8f26-66d4-4cf2-8eef-c21d14609450"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2b21584d-bf87-4f41-b7c2-e6b4f6a12eaf"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2ce25479-e06e-4996-a1ce-34bc803a2972"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2e50e7cf-9ffe-4cd1-a390-bf95f6abbd7a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("346e2bee-c67b-42c0-af13-72e344af713f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("43e08a6f-fc6d-46ba-80fd-6f0aff00ea26"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("475a8afe-99cc-4f8a-944c-7b35804fb109"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("59bdce92-ce42-48ad-8625-e1961dfb8062"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5ed6f40c-9839-4dd0-88cb-a0a051b8f102"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5f467e99-b7a4-4c90-95a9-8b28ec454805"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("66c63e2f-7878-4299-958a-ad5717e95a1f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6a3f49a7-0e21-4279-b22c-d3503ca9803c"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("71f5ba70-142c-4196-8553-3bd829f3bff2"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("72ae1c7a-e390-4b93-8bd3-b0e9e2d649d1"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7f499e73-5f41-4343-8f87-74884247dd03"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("88d71ff9-04a1-4063-8082-c47c385f9ce7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8a4c7483-162b-4fb6-ab9a-6e746131e02a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8f81b0b9-43d6-4881-ab11-50205a6f210f"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("992da7d1-4347-47db-bcdf-684c05dc3c5c"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9e7ad160-7e79-40d6-9d2b-ec5c80a68ef8"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6a60593-e3f7-4604-8ac7-ef7b3950d87f"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("bcfe003e-50bd-4761-a5c8-de3905dee1de"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bfabe129-f256-4dc1-97d7-3e604095a2ba"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c595e65d-cb90-410a-b48e-4b0b58ca6e14"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c762344e-bfd4-4e7b-b6e5-547271b03961"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ce15af4c-830b-4049-a057-80ac898aa677"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d6bdfc32-079f-4a5b-bd97-bb14dd1d3f9b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ddc64ce0-2560-4ca9-af1d-28f5f8a6ee6e"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fbdb5ab6-a5b7-44f3-9295-c72f04d24881"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ff8d5c57-2c03-4e2f-956b-77d89b17672d"), "UserRole" }
                });
        }
    }
}
