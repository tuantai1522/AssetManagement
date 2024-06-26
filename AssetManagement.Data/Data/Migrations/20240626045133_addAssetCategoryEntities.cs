using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class addAssetCategoryEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("03d91902-9062-4325-bb30-643f2575ff43") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("0489f519-4748-4e81-a15f-4e2a2e0f9ae3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("06dd70d1-e4c9-4101-b442-7de4f36b9554") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("09b6284f-33ee-40d2-907c-2fc862f0d8bd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0b45399b-a3a1-4f5c-968d-6646c573cd36") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0cc00854-9a10-4b69-829b-b377f210c4fd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1103c0f0-155e-427b-83d7-5fea6cb410ef") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1848d773-d2b9-41d5-beb0-30bce683ee39") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("18ce48a2-4009-4843-892b-fc51b7a9b8f8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1fdb74ca-5c8d-40a4-83a6-80939d461d25") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("21bbb148-429e-49fd-ae9d-0e825da9ec99") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23e756fa-611e-4d0c-ae7a-1d8f14590b8c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("27415b59-9f41-4fd6-ba2a-8199973e5e43") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2abba0b9-d478-48c8-82a5-2b7a27a7280b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("31078880-f94b-42be-b1c1-47fcf29987fc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("327958e8-ad2c-417b-b64e-9067738bb545") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("402b9eed-63c0-4c78-9480-4138d6dea2cb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42bd2301-fc60-4a2a-91be-47f480f776de") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("47145e66-e2eb-4f73-b1ef-7c1f2f586808") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("496d798b-bf1e-4f66-8e43-d49b737fac1f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4c6dd844-4062-4b80-bca7-b551824088d3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f052c7d-c641-4038-8025-e62c6c907af4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("55a92256-68ae-4f3e-968b-c22fe3aab90a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("61fa02b5-4915-4e86-990c-85893183623a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6802928d-0f02-4b72-8b43-1db24fc8b23f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6b4a9dd6-3fd9-442c-9638-ea2c7799a86f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("710ab883-57d4-43dc-958c-a7a03a418544") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("714e937a-fd40-4dc2-b363-108f68db4a24") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("72b48eee-21c3-48c7-9538-8c6b7f0ad746") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("78c1ef91-491a-4291-9bb5-1f23cac1c42d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("82f0c5f9-9a1c-4f95-8324-4e1eee010f91") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8432a75b-e554-401c-8c92-e5b4a28862d3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8925111b-5fce-4123-89f3-fdb05999f42c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("90d63137-1b3b-4e43-bae5-0ebd797b83f9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("93844e0b-faef-418e-89b8-3990ee492989") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("957e78ba-c77d-45e4-a011-2826fa9fde0b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9809bdfc-bcc0-4523-8bd5-162c53725cf0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a1d289d4-ba1b-47b2-9963-9fb13ef37400") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a2411634-c0d2-4583-8eb0-15357175819a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a3f5f0a8-f4cb-45fc-bb41-a51b68d14e14") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6a937b6-fd80-4b0b-8958-92434c2c6441") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("acff3a06-fcae-42fc-a3c0-2e25f90a1f35") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ad02a5ed-fe5c-41c0-a0aa-be318fcb8c18") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b08d0072-3adc-4f92-ba60-fa7af7ef33df") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b39ad638-5d86-43fb-8f2f-f388010c3ae9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b4f64fa9-ce89-4eb4-a8f3-8e15411ab0c2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b5258cca-f62f-4cbc-a47d-b13cf97268da") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c0f70aad-6e26-4ff7-ba66-c41fc4cd531c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d20fc02a-bfc4-4847-a2c7-68cbe3556b59") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("d819bb0d-56f4-4c14-a28c-adc2a1695c0b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d83ccd9c-1ee8-4bdf-9a93-855d320d0cae") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("db9f6cb7-0292-40e4-9fbb-6c6cf283ba74") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("deb7087d-1796-4eed-8ab9-a9d61bb7bcdf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e4f7217b-5376-420b-b6d1-edb2dd7e454b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e6b99ee6-79bd-4e94-b605-777b04a4a4b7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e87d29b7-8ac8-4b1f-9df6-e7a678a17e8b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e8af5f75-15fa-4e85-a516-b32bfbb40642") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e9f2870f-a466-4581-9fa5-33d99822b714") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e9f5406c-808a-4c5c-95d1-f327e6861abb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ed409a65-1371-4cb1-98b0-6f2006e07216") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f2c60c11-2452-4628-b5e0-b241bf54e0e9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f83cbb85-9147-40a9-b881-1e49d123faed") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("fca33a88-a37d-4873-8d2f-02c12aa377f3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ffb4f37e-01bc-4f62-ae0d-cadac80df4ec") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("03d91902-9062-4325-bb30-643f2575ff43"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0489f519-4748-4e81-a15f-4e2a2e0f9ae3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06dd70d1-e4c9-4101-b442-7de4f36b9554"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("09b6284f-33ee-40d2-907c-2fc862f0d8bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b45399b-a3a1-4f5c-968d-6646c573cd36"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0cc00854-9a10-4b69-829b-b377f210c4fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1103c0f0-155e-427b-83d7-5fea6cb410ef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1848d773-d2b9-41d5-beb0-30bce683ee39"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("18ce48a2-4009-4843-892b-fc51b7a9b8f8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1fdb74ca-5c8d-40a4-83a6-80939d461d25"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21bbb148-429e-49fd-ae9d-0e825da9ec99"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23e756fa-611e-4d0c-ae7a-1d8f14590b8c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27415b59-9f41-4fd6-ba2a-8199973e5e43"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2abba0b9-d478-48c8-82a5-2b7a27a7280b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31078880-f94b-42be-b1c1-47fcf29987fc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("327958e8-ad2c-417b-b64e-9067738bb545"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("402b9eed-63c0-4c78-9480-4138d6dea2cb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("42bd2301-fc60-4a2a-91be-47f480f776de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("47145e66-e2eb-4f73-b1ef-7c1f2f586808"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("496d798b-bf1e-4f66-8e43-d49b737fac1f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c6dd844-4062-4b80-bca7-b551824088d3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f052c7d-c641-4038-8025-e62c6c907af4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55a92256-68ae-4f3e-968b-c22fe3aab90a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61fa02b5-4915-4e86-990c-85893183623a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6802928d-0f02-4b72-8b43-1db24fc8b23f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b4a9dd6-3fd9-442c-9638-ea2c7799a86f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("710ab883-57d4-43dc-958c-a7a03a418544"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("714e937a-fd40-4dc2-b363-108f68db4a24"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72b48eee-21c3-48c7-9538-8c6b7f0ad746"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78c1ef91-491a-4291-9bb5-1f23cac1c42d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("82f0c5f9-9a1c-4f95-8324-4e1eee010f91"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8432a75b-e554-401c-8c92-e5b4a28862d3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8925111b-5fce-4123-89f3-fdb05999f42c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("90d63137-1b3b-4e43-bae5-0ebd797b83f9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("93844e0b-faef-418e-89b8-3990ee492989"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("957e78ba-c77d-45e4-a011-2826fa9fde0b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9809bdfc-bcc0-4523-8bd5-162c53725cf0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1d289d4-ba1b-47b2-9963-9fb13ef37400"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2411634-c0d2-4583-8eb0-15357175819a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3f5f0a8-f4cb-45fc-bb41-a51b68d14e14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6a937b6-fd80-4b0b-8958-92434c2c6441"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acff3a06-fcae-42fc-a3c0-2e25f90a1f35"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad02a5ed-fe5c-41c0-a0aa-be318fcb8c18"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08d0072-3adc-4f92-ba60-fa7af7ef33df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b39ad638-5d86-43fb-8f2f-f388010c3ae9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f64fa9-ce89-4eb4-a8f3-8e15411ab0c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5258cca-f62f-4cbc-a47d-b13cf97268da"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0f70aad-6e26-4ff7-ba66-c41fc4cd531c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d20fc02a-bfc4-4847-a2c7-68cbe3556b59"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d819bb0d-56f4-4c14-a28c-adc2a1695c0b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d83ccd9c-1ee8-4bdf-9a93-855d320d0cae"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db9f6cb7-0292-40e4-9fbb-6c6cf283ba74"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("deb7087d-1796-4eed-8ab9-a9d61bb7bcdf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4f7217b-5376-420b-b6d1-edb2dd7e454b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6b99ee6-79bd-4e94-b605-777b04a4a4b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e87d29b7-8ac8-4b1f-9df6-e7a678a17e8b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e8af5f75-15fa-4e85-a516-b32bfbb40642"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9f2870f-a466-4581-9fa5-33d99822b714"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9f5406c-808a-4c5c-95d1-f327e6861abb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed409a65-1371-4cb1-98b0-6f2006e07216"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2c60c11-2452-4628-b5e0-b241bf54e0e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f83cbb85-9147-40a9-b881-1e49d123faed"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fca33a88-a37d-4873-8d2f-02c12aa377f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffb4f37e-01bc-4f62-ae0d-cadac80df4ec"));

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstalledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("02c00cd6-95ed-4bee-b725-7a9a4a37e480"), 0, "0913a459-5133-4e18-9a6e-837c1097ecd2", new DateTime(2024, 6, 26, 4, 51, 30, 577, DateTimeKind.Utc).AddTicks(5398), new DateTime(1998, 10, 11, 11, 51, 30, 577, DateTimeKind.Local).AddTicks(5380), "amelial@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 577, DateTimeKind.Local).AddTicks(5397), "Lewis", new DateTime(2024, 6, 26, 4, 51, 30, 577, DateTimeKind.Utc).AddTicks(5399), "HN", true, null, "AMELIAL@GMAIL.COM", "AMELIAL", "AQAAAAIAAYagAAAAEBli3hH4UpJG6xVTpRENpCKJSad7HkFrG4kMSagOjYDSzeUs6lggAGfJl11hUiYMiw==", null, false, "95ba4429-f8d0-478d-b7c7-2005ae2cb258", "SD0047", false, "amelial" },
                    { new Guid("053ddb36-7323-47d2-9284-73f2c6ea1273"), 0, "fef2d7bb-e1ac-4e00-b94d-0d9400fb15c4", new DateTime(2024, 6, 26, 4, 51, 29, 788, DateTimeKind.Utc).AddTicks(4713), new DateTime(2002, 11, 14, 11, 51, 29, 788, DateTimeKind.Local).AddTicks(4699), "johnl@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 788, DateTimeKind.Local).AddTicks(4712), "Lewis", new DateTime(2024, 6, 26, 4, 51, 29, 788, DateTimeKind.Utc).AddTicks(4713), "HN", true, null, "JOHNL@GMAIL.COM", "JOHNL", "AQAAAAIAAYagAAAAEAdW/5Tags17qqpcQp3LbWt/IHeBdZmSPaBVQXhQPu3DmL2irPmg8L9+v+IbfJEWng==", null, false, "41536446-c837-47cf-9cb9-6024d25e60fc", "SD0034", false, "johnl" },
                    { new Guid("179e497c-bd98-48dc-a3bc-eaaccd6646c6"), 0, "f05426fb-3483-48d9-856c-6dc43351566e", new DateTime(2024, 6, 26, 4, 51, 30, 455, DateTimeKind.Utc).AddTicks(6717), new DateTime(2001, 4, 12, 11, 51, 30, 455, DateTimeKind.Local).AddTicks(6707), "miaw@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 455, DateTimeKind.Local).AddTicks(6717), "Williams", new DateTime(2024, 6, 26, 4, 51, 30, 455, DateTimeKind.Utc).AddTicks(6718), "HCM", true, null, "MIAW@GMAIL.COM", "MIAW", "AQAAAAIAAYagAAAAEJhiaboNjCtUuDZLJ4lX1yrXUpG7SKMYlPXAQdm8oHMOZKTfwvSneLNpGBTehVBb1Q==", null, false, "602c59ee-3294-4b66-bb23-12b82b247190", "SD0045", false, "miaw" },
                    { new Guid("1bafcb42-fd2a-474a-a7cb-edf688698275"), 0, "9ad83496-c906-4185-8f76-78b78f94b9ce", new DateTime(2024, 6, 26, 4, 51, 29, 425, DateTimeKind.Utc).AddTicks(5067), new DateTime(1997, 10, 6, 11, 51, 29, 425, DateTimeKind.Local).AddTicks(5058), "elijahj@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 425, DateTimeKind.Local).AddTicks(5067), "Johnson", new DateTime(2024, 6, 26, 4, 51, 29, 425, DateTimeKind.Utc).AddTicks(5068), "HCM", true, null, "ELIJAHJ@GMAIL.COM", "ELIJAHJ", "AQAAAAIAAYagAAAAEIMaapvaxMSBASwLlnbzzxcMje2PFZUWq8EZ+6SAoYfG932v7bIjrWQNSbyyLc+FLw==", null, false, "a3207719-107b-447f-ba56-9fde5fc3a512", "SD0028", false, "elijahj" },
                    { new Guid("1dfad98a-05de-453e-870e-f70a74e0def8"), 0, "1dba72b4-90b1-4196-af82-0c20909e40bc", new DateTime(2024, 6, 26, 4, 51, 29, 486, DateTimeKind.Utc).AddTicks(1946), new DateTime(1996, 4, 2, 11, 51, 29, 486, DateTimeKind.Local).AddTicks(1934), "emmay1@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 486, DateTimeKind.Local).AddTicks(1945), "Young", new DateTime(2024, 6, 26, 4, 51, 29, 486, DateTimeKind.Utc).AddTicks(1947), "HCM", true, null, "EMMAY1@GMAIL.COM", "EMMAY1", "AQAAAAIAAYagAAAAENj6NbIC9WjCw4Oba7kxR15Z+IvetEr1zvo5y7FoyJp+v6RONrLNN8n5BpJ8Vlsd9g==", null, false, "437888ed-8751-4346-b32b-70d723628c09", "SD0029", false, "emmay1" },
                    { new Guid("1f768a11-d032-4c32-b1cf-87f054096f45"), 0, "dd87edaf-ae15-404d-bd38-5fb36435f102", new DateTime(2024, 6, 26, 4, 51, 30, 274, DateTimeKind.Utc).AddTicks(2843), new DateTime(2001, 7, 22, 11, 51, 30, 274, DateTimeKind.Local).AddTicks(2828), "jamesh1@gmail.com", false, "James", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 274, DateTimeKind.Local).AddTicks(2842), "Harris", new DateTime(2024, 6, 26, 4, 51, 30, 274, DateTimeKind.Utc).AddTicks(2844), "HCM", true, null, "JAMESH1@GMAIL.COM", "JAMESH1", "AQAAAAIAAYagAAAAEEEgPlFCAGr7faCKUcVhRK/AxLnhQoyQtFCQ66pTRZotAUPyidtUMWc/BEhAX7ChCQ==", null, false, "3a61c707-026f-4a93-88e6-3622554d8e93", "SD0042", false, "jamesh1" },
                    { new Guid("2109accc-be1d-4ba7-a8ea-909e7b101a55"), 0, "ec4c050d-b508-497e-a092-a34d446aef81", new DateTime(2024, 6, 26, 4, 51, 28, 35, DateTimeKind.Utc).AddTicks(6004), new DateTime(2005, 11, 1, 11, 51, 28, 35, DateTimeKind.Local).AddTicks(5991), "michaelb1@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 35, DateTimeKind.Local).AddTicks(6004), "Brown", new DateTime(2024, 6, 26, 4, 51, 28, 35, DateTimeKind.Utc).AddTicks(6005), "HN", true, null, "MICHAELB1@GMAIL.COM", "MICHAELB1", "AQAAAAIAAYagAAAAECnGVMWtgom8q/MT+5Ljzz0r8aWMD/ZM9Jrsn5IFiR25laFWjRo/Rek8tpa75dk0Dg==", null, false, "fd531caf-31e0-4a19-9a23-4d0901fd4764", "SD0006", false, "michaelb1" },
                    { new Guid("2350e093-53b8-4ea9-80d5-74b32b82c5f3"), 0, "35a971eb-a69e-40c7-9a24-152bd0e2fcfd", new DateTime(2024, 6, 26, 4, 51, 27, 849, DateTimeKind.Utc).AddTicks(4763), new DateTime(1998, 1, 7, 11, 51, 27, 849, DateTimeKind.Local).AddTicks(4734), "staffhcm@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 27, 849, DateTimeKind.Local).AddTicks(4762), "HCM", new DateTime(2024, 6, 26, 4, 51, 27, 849, DateTimeKind.Utc).AddTicks(4764), "HCM", true, null, "STAFFHCM@GMAIL.COM", "STAFFHCM", "AQAAAAIAAYagAAAAEP5hjO0WAjrARTugyyPFUoZoWXzBPtp/N++PqyhPTD1DjWysyaZXhaFbRahAEFqNOQ==", null, false, "ed3e6d2a-3be8-453a-aebb-0138ae589d40", "SD0003", false, "staffhcm" },
                    { new Guid("2507b36e-6b9d-484a-b6f8-d3882a4e8526"), 0, "9f373bd1-b72e-47f2-b3f7-5ade7d2dc826", new DateTime(2024, 6, 26, 4, 51, 28, 350, DateTimeKind.Utc).AddTicks(4364), new DateTime(2003, 7, 3, 11, 51, 28, 350, DateTimeKind.Local).AddTicks(4352), "williamm@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 350, DateTimeKind.Local).AddTicks(4363), "Miller", new DateTime(2024, 6, 26, 4, 51, 28, 350, DateTimeKind.Utc).AddTicks(4364), "HN", true, null, "WILLIAMM@GMAIL.COM", "WILLIAMM", "AQAAAAIAAYagAAAAEDhMu47759sV40tn8iwtPzj8VEJMaAxS1+fuqt5rPta2IrwFYbdct3urJ+Po2aDLXg==", null, false, "5812dcf9-f059-4aa7-a2af-fe4139127361", "SD0011", false, "williamm" },
                    { new Guid("26c2f3a3-742f-41cd-935d-36a8cff2971b"), 0, "93bca8ce-2258-45df-8ed0-6d3a6b92643e", new DateTime(2024, 6, 26, 4, 51, 29, 185, DateTimeKind.Utc).AddTicks(3384), new DateTime(2002, 1, 24, 11, 51, 29, 185, DateTimeKind.Local).AddTicks(3370), "emmaw@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 185, DateTimeKind.Local).AddTicks(3383), "White", new DateTime(2024, 6, 26, 4, 51, 29, 185, DateTimeKind.Utc).AddTicks(3384), "HN", true, null, "EMMAW@GMAIL.COM", "EMMAW", "AQAAAAIAAYagAAAAEKSdLehygP4EDdO+DMrJhqDpY20b4iGYXqH0zsLXKQwPA76hWKKAOqVYZlowBEDYKQ==", null, false, "e40c2374-63d6-4187-8e75-ec599cb257d4", "SD0024", false, "emmaw" },
                    { new Guid("2da658d2-2acd-4c24-bfff-18eb74caf856"), 0, "27d3993b-c824-4938-ad53-fee3effe3c24", new DateTime(2024, 6, 26, 4, 51, 30, 334, DateTimeKind.Utc).AddTicks(6221), new DateTime(1997, 6, 15, 11, 51, 30, 334, DateTimeKind.Local).AddTicks(6205), "ameliah@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 334, DateTimeKind.Local).AddTicks(6220), "Harris", new DateTime(2024, 6, 26, 4, 51, 30, 334, DateTimeKind.Utc).AddTicks(6221), "HN", true, null, "AMELIAH@GMAIL.COM", "AMELIAH", "AQAAAAIAAYagAAAAEMusUEy64oPfZMNzKEisOrj4QwbJ+7ansMa8EgNPM7j0lrBFo3Zrz1xkHEwvBk8BZg==", null, false, "62e3f691-ffeb-4168-bdfc-e97f8b3f2cae", "SD0043", false, "ameliah" },
                    { new Guid("2feda927-3c44-4cc4-bb05-17b87d0c090a"), 0, "2647f32e-e82e-47fe-aa3f-1dae836ed17d", new DateTime(2024, 6, 26, 4, 51, 31, 10, DateTimeKind.Utc).AddTicks(4809), new DateTime(2006, 2, 27, 11, 51, 31, 10, DateTimeKind.Local).AddTicks(4797), "danielt1@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 10, DateTimeKind.Local).AddTicks(4809), "Thomas", new DateTime(2024, 6, 26, 4, 51, 31, 10, DateTimeKind.Utc).AddTicks(4810), "HN", true, null, "DANIELT1@GMAIL.COM", "DANIELT1", "AQAAAAIAAYagAAAAEFm52Q9hqlgVqT6zsweyXphA6KEDoyuLHfgbVdz47M2JppkClbVzl9k+QJ6UkECpPg==", null, false, "4bbfa946-a3a4-42a6-b0a3-9612b5df5cc7", "SD0054", false, "danielt1" },
                    { new Guid("303d48fc-0549-4c21-81e8-4de9de20e483"), 0, "08a76304-ed36-4057-a38a-aa789c7caa70", new DateTime(2024, 6, 26, 4, 51, 29, 55, DateTimeKind.Utc).AddTicks(5336), new DateTime(1995, 4, 3, 11, 51, 29, 55, DateTimeKind.Local).AddTicks(5324), "harperw1@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 55, DateTimeKind.Local).AddTicks(5335), "Wilson", new DateTime(2024, 6, 26, 4, 51, 29, 55, DateTimeKind.Utc).AddTicks(5336), "HCM", true, null, "HARPERW1@GMAIL.COM", "HARPERW1", "AQAAAAIAAYagAAAAEPNr37qnV8DcRUVwHfrbRGom+JGQUG6v6nqGewckfDSxWt+lb6QZ41mLdzyHDvrgjQ==", null, false, "26b7851e-475a-4c08-a543-6700275e9acc", "SD0022", false, "harperw1" },
                    { new Guid("31d293ce-9ff5-4c1f-8e05-d5468207e1bf"), 0, "adbf6a49-2e07-4f8a-ae70-0817cef6de5c", new DateTime(2024, 6, 26, 4, 51, 28, 724, DateTimeKind.Utc).AddTicks(6298), new DateTime(1997, 5, 18, 11, 51, 28, 724, DateTimeKind.Local).AddTicks(6281), "josephw@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 724, DateTimeKind.Local).AddTicks(6298), "Wilson", new DateTime(2024, 6, 26, 4, 51, 28, 724, DateTimeKind.Utc).AddTicks(6299), "HN", true, null, "JOSEPHW@GMAIL.COM", "JOSEPHW", "AQAAAAIAAYagAAAAENenEmhCWJNFdYooAWxLnz3sP3lHgDneufFea9le8JRCthbksIv5lASFDVKccCaHow==", null, false, "f2d3adb8-068b-4255-bf4c-501206e3be7f", "SD0017", false, "josephw" },
                    { new Guid("34658999-d121-48f9-9056-bb76d0993e3a"), 0, "a3dc6d84-6199-46ee-8d03-7fefe8ba6120", new DateTime(2024, 6, 26, 4, 51, 28, 225, DateTimeKind.Utc).AddTicks(7080), new DateTime(2001, 12, 26, 11, 51, 28, 225, DateTimeKind.Local).AddTicks(7057), "alexanderj@gmail.com", false, "Alexander", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 225, DateTimeKind.Local).AddTicks(7080), "Jones", new DateTime(2024, 6, 26, 4, 51, 28, 225, DateTimeKind.Utc).AddTicks(7081), "HN", true, null, "ALEXANDERJ@GMAIL.COM", "ALEXANDERJ", "AQAAAAIAAYagAAAAEAisf29UcQx69nITPH1Lx4qjW0ZAv74Cl93j4Mq3eDQHN+e3rprZpf8QmBdx3ag4wg==", null, false, "9487a65a-a981-4cf6-ab3a-4761f967cd8d", "SD0009", false, "alexanderj" },
                    { new Guid("35e8bc5b-aa36-4190-982c-83e6ab2e865b"), 0, "25f80c0f-6c9c-45d4-b587-10317c044384", new DateTime(2024, 6, 26, 4, 51, 30, 395, DateTimeKind.Utc).AddTicks(1642), new DateTime(2002, 9, 30, 11, 51, 30, 395, DateTimeKind.Local).AddTicks(1633), "michaelj@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 395, DateTimeKind.Local).AddTicks(1642), "Jones", new DateTime(2024, 6, 26, 4, 51, 30, 395, DateTimeKind.Utc).AddTicks(1643), "HCM", true, null, "MICHAELJ@GMAIL.COM", "MICHAELJ", "AQAAAAIAAYagAAAAEKfcqtKhFjNpNyk5o4Cmj2c66LPntW9qAoOUHsIZwXxfpXMig5s38FLvYzxqamFcPQ==", null, false, "d7370e9a-0f9e-431d-a90c-0eba6898d009", "SD0044", false, "michaelj" },
                    { new Guid("3b07c9af-e63f-4b55-98bb-1d847140c768"), 0, "72f1175c-a2fb-46b9-bf6d-b342d130d844", new DateTime(2024, 6, 26, 4, 51, 31, 194, DateTimeKind.Utc).AddTicks(6499), new DateTime(1998, 4, 1, 11, 51, 31, 194, DateTimeKind.Local).AddTicks(6410), "benjaminw@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 194, DateTimeKind.Local).AddTicks(6499), "Williams", new DateTime(2024, 6, 26, 4, 51, 31, 194, DateTimeKind.Utc).AddTicks(6500), "HCM", true, null, "BENJAMINW@GMAIL.COM", "BENJAMINW", "AQAAAAIAAYagAAAAEBp/nkYCXq0bqi3jFg1kognRkTE6JPUyuyXedUJfUwCR1MAwq1mpF0/LTwhd7guqOQ==", null, false, "23fbbdfd-ceaf-4c22-b393-44f69f5880f3", "SD0057", false, "benjaminw" },
                    { new Guid("42a3456b-1bc5-4d53-bb2f-0fb81f5f9623"), 0, "d50fe52b-3450-4093-8765-60ccd7cfbe77", new DateTime(2024, 6, 26, 4, 51, 31, 504, DateTimeKind.Utc).AddTicks(4960), new DateTime(1998, 9, 21, 11, 51, 31, 504, DateTimeKind.Local).AddTicks(4945), "michaely@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 504, DateTimeKind.Local).AddTicks(4959), "Young", new DateTime(2024, 6, 26, 4, 51, 31, 504, DateTimeKind.Utc).AddTicks(4961), "HN", true, null, "MICHAELY@GMAIL.COM", "MICHAELY", "AQAAAAIAAYagAAAAENoK6d+vZUzs1jrFOTM4cZdM3NJC4/MpQEkzcy5PSXe5f244R6JbxrdS1XuejdwtcQ==", null, false, "c11601b2-ec72-412c-814a-99650f0504b1", "SD0062", false, "michaely" },
                    { new Guid("491343c8-ba78-4697-b21a-753b1e70b800"), 0, "1ee7c309-9691-43fc-9c39-b1db37664034", new DateTime(2024, 6, 26, 4, 51, 31, 566, DateTimeKind.Utc).AddTicks(3083), new DateTime(1996, 10, 19, 11, 51, 31, 566, DateTimeKind.Local).AddTicks(3063), "alexanderb1@gmail.com", false, "Alexander", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 566, DateTimeKind.Local).AddTicks(3083), "Brown", new DateTime(2024, 6, 26, 4, 51, 31, 566, DateTimeKind.Utc).AddTicks(3085), "HN", true, null, "ALEXANDERB1@GMAIL.COM", "ALEXANDERB1", "AQAAAAIAAYagAAAAEJqeqf6Vglc+zuFG3uHXmkqlDyTtzC9KMzsEmm7mBss7Nb6SswphLr7Wb/7imwDg6Q==", null, false, "95c3709d-6c1c-415d-83d6-1f9f98df404b", "SD0063", false, "alexanderb1" },
                    { new Guid("4d97ffeb-42b2-4d2c-9945-4b043a007b25"), 0, "b51d9468-30b0-4b36-9cc0-6df6c1d61b1f", new DateTime(2024, 6, 26, 4, 51, 30, 516, DateTimeKind.Utc).AddTicks(7216), new DateTime(2001, 1, 23, 11, 51, 30, 516, DateTimeKind.Local).AddTicks(7201), "miab@gmail.com", false, "Mia", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 516, DateTimeKind.Local).AddTicks(7216), "Brown", new DateTime(2024, 6, 26, 4, 51, 30, 516, DateTimeKind.Utc).AddTicks(7216), "HN", true, null, "MIAB@GMAIL.COM", "MIAB", "AQAAAAIAAYagAAAAEKUH7HiX1yv77yTqLTe/z2oCwmsP7SZNx130a46dr7t4jFGmVrIyt4yHaAh6lXz6AA==", null, false, "75e4cadc-e4ab-4a2d-9dcc-2e0a7768733b", "SD0046", false, "miab" },
                    { new Guid("4f957938-a42c-43f9-88a5-ce08e115ae63"), 0, "35a26539-d4cc-4e86-bda5-d9f96523ac18", new DateTime(2024, 6, 26, 4, 51, 30, 826, DateTimeKind.Utc).AddTicks(2292), new DateTime(2002, 4, 11, 11, 51, 30, 826, DateTimeKind.Local).AddTicks(2270), "sophiag@gmail.com", false, "Sophia", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 826, DateTimeKind.Local).AddTicks(2291), "Garcia", new DateTime(2024, 6, 26, 4, 51, 30, 826, DateTimeKind.Utc).AddTicks(2292), "HN", true, null, "SOPHIAG@GMAIL.COM", "SOPHIAG", "AQAAAAIAAYagAAAAECO8OM24aueXAZGMgrfcmpWU36OIjM/YBi3dN1hP+dmISJAMl8sV+7sBhPSf5DEhfw==", null, false, "15d93915-678b-4095-aca5-cdcc680c0708", "SD0051", false, "sophiag" },
                    { new Guid("508f28ef-3c01-4c39-90df-2d9c79ab2946"), 0, "c5fe9845-e36d-44cb-aa91-13a7782a6ddf", new DateTime(2024, 6, 26, 4, 51, 29, 121, DateTimeKind.Utc).AddTicks(5765), new DateTime(2004, 10, 26, 11, 51, 29, 121, DateTimeKind.Local).AddTicks(5744), "danielr@gmail.com", false, "Daniel", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 121, DateTimeKind.Local).AddTicks(5764), "Rodriguez", new DateTime(2024, 6, 26, 4, 51, 29, 121, DateTimeKind.Utc).AddTicks(5766), "HN", true, null, "DANIELR@GMAIL.COM", "DANIELR", "AQAAAAIAAYagAAAAECIVWZSSCibmUoD3SItn4SxSJJdQqHrX5lBlYtn/MxLAvn6z6isBtgLjwEEeg7Vkqg==", null, false, "6eff73b3-b63d-4d5e-8a08-a25828cb99e1", "SD0023", false, "danielr" },
                    { new Guid("59119720-8f37-4c70-8cd9-2a1ae1b9ad29"), 0, "9e36c197-28c3-40c5-9300-e38bb3626300", new DateTime(2024, 6, 26, 4, 51, 28, 787, DateTimeKind.Utc).AddTicks(5319), new DateTime(1995, 6, 5, 11, 51, 28, 787, DateTimeKind.Local).AddTicks(5308), "harperg@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 787, DateTimeKind.Local).AddTicks(5318), "Garcia", new DateTime(2024, 6, 26, 4, 51, 28, 787, DateTimeKind.Utc).AddTicks(5319), "HN", true, null, "HARPERG@GMAIL.COM", "HARPERG", "AQAAAAIAAYagAAAAEEB+p5A+W+EzJfqm9y3nqpsS5PB1yT8UkUHSocBNoY4ugcIN3QndoWF2Cy1Vm4/BkA==", null, false, "15c7a626-21f9-4338-ba21-7864030060e7", "SD0018", false, "harperg" },
                    { new Guid("5a889ad4-16d9-41e7-bf62-a8da4f6a06c7"), 0, "d0c6e011-7a3c-4f2d-b4ce-08ab999329b9", new DateTime(2024, 6, 26, 4, 51, 28, 849, DateTimeKind.Utc).AddTicks(7575), new DateTime(2003, 1, 24, 11, 51, 28, 849, DateTimeKind.Local).AddTicks(7560), "benjamint1@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 849, DateTimeKind.Local).AddTicks(7574), "Thomas", new DateTime(2024, 6, 26, 4, 51, 28, 849, DateTimeKind.Utc).AddTicks(7575), "HCM", true, null, "BENJAMINT1@GMAIL.COM", "BENJAMINT1", "AQAAAAIAAYagAAAAEC1kpB9hkDzLfpv/AgBBm0v3UzFjfg+x/RiZxkCIRHjccQYMxj4+tZrDrVoP5Ol50g==", null, false, "40b3e6e7-020f-421a-a1dd-cf1656daac62", "SD0019", false, "benjamint1" },
                    { new Guid("5d8a3c54-7350-4245-8906-d832d487d80e"), 0, "c5f79d14-ded1-4774-88a1-6fecdf7aae2c", new DateTime(2024, 6, 26, 4, 51, 29, 247, DateTimeKind.Utc).AddTicks(4017), new DateTime(2002, 12, 3, 11, 51, 29, 247, DateTimeKind.Local).AddTicks(4003), "avaj2@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 247, DateTimeKind.Local).AddTicks(4016), "Johnson", new DateTime(2024, 6, 26, 4, 51, 29, 247, DateTimeKind.Utc).AddTicks(4018), "HN", true, null, "AVAJ2@GMAIL.COM", "AVAJ2", "AQAAAAIAAYagAAAAEMA/9og1+/vp33TnVPTRCSTuJSvGqW832bPPHenTQAkcYCe7+41J0dn+7TNhVWTvzQ==", null, false, "0adfd331-f5b9-4c0f-a3d6-4787176e458d", "SD0025", false, "avaj2" },
                    { new Guid("60d32ca1-6500-458b-b808-2d47adf76393"), 0, "56aa1261-ab8f-49dd-93f8-6e66d4fdba65", new DateTime(2024, 6, 26, 4, 51, 29, 546, DateTimeKind.Utc).AddTicks(5151), new DateTime(2000, 5, 25, 11, 51, 29, 546, DateTimeKind.Local).AddTicks(5130), "josepht@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 546, DateTimeKind.Local).AddTicks(5150), "Thomas", new DateTime(2024, 6, 26, 4, 51, 29, 546, DateTimeKind.Utc).AddTicks(5151), "HN", true, null, "JOSEPHT@GMAIL.COM", "JOSEPHT", "AQAAAAIAAYagAAAAEC0deV7/MwscaVUdyRIP13q/TuU/WMZuQ4EI5zOt51QiCiSemzOEJGD3JsU2iH1r1w==", null, false, "a22339c4-d242-4aeb-bbeb-38b1f8e3a658", "SD0030", false, "josepht" },
                    { new Guid("6323d914-8d5c-49e7-a602-8163d4e46555"), 0, "b8324588-943f-4829-8d61-8da5f471d140", new DateTime(2024, 6, 26, 4, 51, 29, 607, DateTimeKind.Utc).AddTicks(1143), new DateTime(1994, 10, 14, 11, 51, 29, 607, DateTimeKind.Local).AddTicks(1132), "davidj1@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 607, DateTimeKind.Local).AddTicks(1143), "Jones", new DateTime(2024, 6, 26, 4, 51, 29, 607, DateTimeKind.Utc).AddTicks(1144), "HN", true, null, "DAVIDJ1@GMAIL.COM", "DAVIDJ1", "AQAAAAIAAYagAAAAEIcDQVCREpW6P/eQmHMynxY4bM7sa1urHzWF0Zyu/odcrbOtPyEunf1KtDNGc/vP/g==", null, false, "641fc983-9ae2-48f6-be00-11e4270cd671", "SD0031", false, "davidj1" },
                    { new Guid("6b62e024-c19e-4ecd-a80f-743380b243f8"), 0, "f5c5cd47-abb9-405e-8bee-9b4d1209e327", new DateTime(2024, 6, 26, 4, 51, 30, 888, DateTimeKind.Utc).AddTicks(3240), new DateTime(1995, 10, 30, 11, 51, 30, 888, DateTimeKind.Local).AddTicks(3221), "harperj1@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 888, DateTimeKind.Local).AddTicks(3239), "Johnson", new DateTime(2024, 6, 26, 4, 51, 30, 888, DateTimeKind.Utc).AddTicks(3240), "HN", true, null, "HARPERJ1@GMAIL.COM", "HARPERJ1", "AQAAAAIAAYagAAAAENsD9r8AhRMTPhf/OcUX2H1yHPjechqGl3UtkgzpsFCQR8o0DG49YHOsrJTubJPGgA==", null, false, "e532f5b3-149f-45e9-b611-5a13b150a243", "SD0052", false, "harperj1" },
                    { new Guid("6edc217f-9463-4952-ad32-042e43de2ef6"), 0, "17ebac2d-67a8-4d86-b005-f7c759cebd75", new DateTime(2024, 6, 26, 4, 51, 28, 412, DateTimeKind.Utc).AddTicks(8766), new DateTime(2000, 8, 17, 11, 51, 28, 412, DateTimeKind.Local).AddTicks(8754), "jamesj@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 412, DateTimeKind.Local).AddTicks(8765), "Jones", new DateTime(2024, 6, 26, 4, 51, 28, 412, DateTimeKind.Utc).AddTicks(8767), "HCM", true, null, "JAMESJ@GMAIL.COM", "JAMESJ", "AQAAAAIAAYagAAAAENaZRk+BZm7X7O8cgDc4AKUkpz7b6sffRPKYSqnPcoyC3VYAjw1Rsm7rcqMYbt2xbQ==", null, false, "2062d418-3f5b-4848-bfea-8b2cc585b9db", "SD0012", false, "jamesj" },
                    { new Guid("74c1cc5e-ea23-43ca-bf02-1f68567a1b44"), 0, "c4ded487-07b4-4edc-b155-1edf74098484", new DateTime(2024, 6, 26, 4, 51, 30, 762, DateTimeKind.Utc).AddTicks(2986), new DateTime(1996, 11, 6, 11, 51, 30, 762, DateTimeKind.Local).AddTicks(2967), "benjaminl1@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 762, DateTimeKind.Local).AddTicks(2985), "Lewis", new DateTime(2024, 6, 26, 4, 51, 30, 762, DateTimeKind.Utc).AddTicks(2986), "HCM", true, null, "BENJAMINL1@GMAIL.COM", "BENJAMINL1", "AQAAAAIAAYagAAAAENcse3qGXKsXYlvX3t9HA3yAEOlFtVJ8dkxwJhUYa+P/y6PzRk7atvXvRyQu9gewzA==", null, false, "bbeb006b-0d44-4636-93f2-813ec2303d70", "SD0050", false, "benjaminl1" },
                    { new Guid("75bd282b-bab3-43f4-8022-52ef2641fbe5"), 0, "ee3bf9ea-0ef5-4f25-a9a2-cfd4ff2fab55", new DateTime(2024, 6, 26, 4, 51, 29, 667, DateTimeKind.Utc).AddTicks(3217), new DateTime(2002, 11, 18, 11, 51, 29, 667, DateTimeKind.Local).AddTicks(3205), "avat@gmail.com", false, "Ava", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 667, DateTimeKind.Local).AddTicks(3217), "Taylor", new DateTime(2024, 6, 26, 4, 51, 29, 667, DateTimeKind.Utc).AddTicks(3218), "HN", true, null, "AVAT@GMAIL.COM", "AVAT", "AQAAAAIAAYagAAAAEDiQH6+CfLqSvomQcuNw+obpexeiR6BplxyfM3dDPaXfptVPOmqEqgP0JgteawMdHA==", null, false, "a1c39e9d-75ed-4230-b359-38383f667c4a", "SD0032", false, "avat" },
                    { new Guid("79873b6a-3155-4b83-8e04-208ec6f7ff87"), 0, "ab70fbee-7bb2-4a7b-bb1b-0e145caac7fb", new DateTime(2024, 6, 26, 4, 51, 30, 92, DateTimeKind.Utc).AddTicks(9952), new DateTime(2001, 1, 21, 11, 51, 30, 92, DateTimeKind.Local).AddTicks(9937), "avar1@gmail.com", false, "Ava", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 92, DateTimeKind.Local).AddTicks(9952), "Rodriguez", new DateTime(2024, 6, 26, 4, 51, 30, 92, DateTimeKind.Utc).AddTicks(9952), "HN", true, null, "AVAR1@GMAIL.COM", "AVAR1", "AQAAAAIAAYagAAAAEASf4qOVcftkZY4qPytjcalYlKRtjz4ppbSZj3uvgeq28FVuJV7faGL3FUUF37BVeA==", null, false, "9ddca3a9-41c4-4834-9f6b-980c788b93a0", "SD0039", false, "avar1" },
                    { new Guid("7a44116a-f6d4-4215-b815-f8c4dbf3fc74"), 0, "61501e34-276e-4962-bdd9-f4fafda1317e", new DateTime(2024, 6, 26, 4, 51, 28, 98, DateTimeKind.Utc).AddTicks(7935), new DateTime(1998, 3, 28, 11, 51, 28, 98, DateTimeKind.Local).AddTicks(7923), "jamesg@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 98, DateTimeKind.Local).AddTicks(7934), "Garcia", new DateTime(2024, 6, 26, 4, 51, 28, 98, DateTimeKind.Utc).AddTicks(7935), "HCM", true, null, "JAMESG@GMAIL.COM", "JAMESG", "AQAAAAIAAYagAAAAEG00K2SFjepr/mPhOL0bIgE/f6NovrKwmSn61TzUdljxRndtg01OYdnbpeYbGXNZoQ==", null, false, "ce10e0e7-d8ed-4a0e-8f36-9cd1408974de", "SD0007", false, "jamesg" },
                    { new Guid("80d66234-2f84-445a-90e3-4571f611737b"), 0, "37e9ccc4-f38e-4062-9718-e002ad0b83d2", new DateTime(2024, 6, 26, 4, 51, 30, 213, DateTimeKind.Utc).AddTicks(2342), new DateTime(1996, 5, 26, 11, 51, 30, 213, DateTimeKind.Local).AddTicks(2337), "jamest1@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 213, DateTimeKind.Local).AddTicks(2342), "Taylor", new DateTime(2024, 6, 26, 4, 51, 30, 213, DateTimeKind.Utc).AddTicks(2342), "HN", true, null, "JAMEST1@GMAIL.COM", "JAMEST1", "AQAAAAIAAYagAAAAENSDGVGdGOLFK0y3w5O1UAKWfeLA8IoGDJ+2GY87ygVkbhlKl2zcNjuth5fZh0SQbA==", null, false, "8ad533c4-5b18-4b39-a295-e60e51cf860b", "SD0041", false, "jamest1" },
                    { new Guid("85d49393-320e-445b-9921-12a4bf8e1e6a"), 0, "ae1dda70-922a-4207-b9da-7f401d558482", new DateTime(2024, 6, 26, 4, 51, 31, 319, DateTimeKind.Utc).AddTicks(800), new DateTime(1999, 3, 4, 11, 51, 31, 319, DateTimeKind.Local).AddTicks(777), "charlottes@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 319, DateTimeKind.Local).AddTicks(799), "Smith", new DateTime(2024, 6, 26, 4, 51, 31, 319, DateTimeKind.Utc).AddTicks(801), "HCM", true, null, "CHARLOTTES@GMAIL.COM", "CHARLOTTES", "AQAAAAIAAYagAAAAEObTfB23Jv4JdHLnZsQDPlThu5ODltyRujtU0wdBYonPEBjyTz6FiHw7Ha+J0GVBqg==", null, false, "5f0ab925-0e39-428e-b0dc-22a7153ab452", "SD0059", false, "charlottes" },
                    { new Guid("866db22c-43da-4dc5-8419-c3aab32df21c"), 0, "3966744a-ef50-4600-ba67-cda5a36aeab6", new DateTime(2024, 6, 26, 4, 51, 31, 71, DateTimeKind.Utc).AddTicks(5620), new DateTime(1995, 1, 11, 11, 51, 31, 71, DateTimeKind.Local).AddTicks(5591), "alexanderj1@gmail.com", false, "Alexander", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 71, DateTimeKind.Local).AddTicks(5620), "Jones", new DateTime(2024, 6, 26, 4, 51, 31, 71, DateTimeKind.Utc).AddTicks(5621), "HCM", true, null, "ALEXANDERJ1@GMAIL.COM", "ALEXANDERJ1", "AQAAAAIAAYagAAAAEIDBt63UIZMEbgK4/RYdFl7L83SO3u3qLfWhTY4+oFtQn5oWj6vrjU+yK9ejWrgi9w==", null, false, "7841508a-499b-43ab-b9c9-392ae32edf68", "SD0055", false, "alexanderj1" },
                    { new Guid("87ea0f4c-11c6-4a00-834f-db8541fc2bd3"), 0, "010dbbca-453e-41a9-9489-ae3479ebca02", new DateTime(2024, 6, 26, 4, 51, 29, 307, DateTimeKind.Utc).AddTicks(6719), new DateTime(2005, 11, 14, 11, 51, 29, 307, DateTimeKind.Local).AddTicks(6699), "charlotteh@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 307, DateTimeKind.Local).AddTicks(6718), "Harris", new DateTime(2024, 6, 26, 4, 51, 29, 307, DateTimeKind.Utc).AddTicks(6719), "HN", true, null, "CHARLOTTEH@GMAIL.COM", "CHARLOTTEH", "AQAAAAIAAYagAAAAEOBFTiQGi/032QAsH5W5j3TfDdwzk2QKjTZ1ISNgQV80G3GgTNOpXwDiz5iOkYBkFw==", null, false, "5000229f-9180-4589-a344-5247400e7224", "SD0026", false, "charlotteh" },
                    { new Guid("886e1e1e-c746-4811-86af-92bf669407ba"), 0, "41bd452d-c6ff-4de5-b279-d4959fa96358", new DateTime(2024, 6, 26, 4, 51, 28, 536, DateTimeKind.Utc).AddTicks(2022), new DateTime(1997, 8, 3, 11, 51, 28, 536, DateTimeKind.Local).AddTicks(2004), "avaj1@gmail.com", false, "Ava", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 536, DateTimeKind.Local).AddTicks(2021), "Johnson", new DateTime(2024, 6, 26, 4, 51, 28, 536, DateTimeKind.Utc).AddTicks(2022), "HCM", true, null, "AVAJ1@GMAIL.COM", "AVAJ1", "AQAAAAIAAYagAAAAEGR9AlAR6r6grSnxIy6iLW8zY/n06aZ8uetk3EH38Gqi0jttjOZsc2oclLDWxIdueA==", null, false, "b9001158-42fe-4dc8-80a0-6af86a9d5937", "SD0014", false, "avaj1" },
                    { new Guid("8b482df8-0697-4671-a59f-7e783210e1fd"), 0, "5c60f89e-1718-4d13-aed2-e8f1384944e1", new DateTime(2024, 6, 26, 4, 51, 31, 628, DateTimeKind.Utc).AddTicks(9532), new DateTime(1997, 9, 6, 11, 51, 31, 628, DateTimeKind.Local).AddTicks(9519), "amelial1@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 628, DateTimeKind.Local).AddTicks(9531), "Lewis", new DateTime(2024, 6, 26, 4, 51, 31, 628, DateTimeKind.Utc).AddTicks(9532), "HN", true, null, "AMELIAL1@GMAIL.COM", "AMELIAL1", "AQAAAAIAAYagAAAAEJ+xNlDUDcvylt4RDp+QZdj+9YTQM2uc75OvUh1LE82lJLCVfRA+FuvK1kU5grGtQA==", null, false, "8476b2a5-9886-4bab-a74a-0eae76ec6788", "SD0064", false, "amelial1" },
                    { new Guid("9561c769-db6d-4c13-b35a-18c61eda8905"), 0, "9112be0a-80f9-4fb5-b3d9-ea60cf66b6ea", new DateTime(2024, 6, 26, 4, 51, 29, 850, DateTimeKind.Utc).AddTicks(3052), new DateTime(1999, 1, 12, 11, 51, 29, 850, DateTimeKind.Local).AddTicks(3034), "harpert@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 850, DateTimeKind.Local).AddTicks(3052), "Taylor", new DateTime(2024, 6, 26, 4, 51, 29, 850, DateTimeKind.Utc).AddTicks(3053), "HN", true, null, "HARPERT@GMAIL.COM", "HARPERT", "AQAAAAIAAYagAAAAEKWn+XqCNulkfpZXQcK6hRTKTyg31cbenM6EGMLApPO5Jntdb2EUGVf5cwnn3a+VIA==", null, false, "6f56bc91-ca41-4b6e-8493-2b061731d420", "SD0035", false, "harpert" },
                    { new Guid("95fb555f-8a30-4334-bbbb-b42bbada0217"), 0, "3b07dd0a-50ee-4bf6-a8cd-5ab3dccd85e1", new DateTime(2024, 6, 26, 4, 51, 28, 599, DateTimeKind.Utc).AddTicks(7816), new DateTime(2002, 7, 1, 11, 51, 28, 599, DateTimeKind.Local).AddTicks(7804), "harperj@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 599, DateTimeKind.Local).AddTicks(7815), "Jackson", new DateTime(2024, 6, 26, 4, 51, 28, 599, DateTimeKind.Utc).AddTicks(7816), "HN", true, null, "HARPERJ@GMAIL.COM", "HARPERJ", "AQAAAAIAAYagAAAAEOR8KYQ4bWXy5lGO3Pt61cXNgvaoePTGZX1B7BIBrbPLd832NZ0FQSYx4/a400l+1A==", null, false, "b91c061d-3b3b-488b-9547-d8e2d60fc1e0", "SD0015", false, "harperj" },
                    { new Guid("968e7dcc-3d14-47e7-a5ee-18716abeb5a4"), 0, "22cebf06-9f29-4482-b42f-472fdf9fbb9b", new DateTime(2024, 6, 26, 4, 51, 27, 728, DateTimeKind.Utc).AddTicks(7740), new DateTime(2000, 12, 22, 11, 51, 27, 728, DateTimeKind.Local).AddTicks(7730), "adminhcm@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 27, 728, DateTimeKind.Local).AddTicks(7739), "HCM", new DateTime(2024, 6, 26, 4, 51, 27, 728, DateTimeKind.Utc).AddTicks(7741), "HCM", true, null, "ADMINHCM@GMAIL.COM", "ADMINHCM", "AQAAAAIAAYagAAAAEDJK4DZwUOCb/0wmYr38eTd02MV/Wo4hTmQWFsEl6r/I+PO9yUhQejgupVx1+QfmXw==", null, false, "02e41b84-4220-4eea-91cb-f4df538e260b", "SD0001", false, "adminhcm" },
                    { new Guid("9eaf916c-f4e9-4e66-aa23-b13d04b401f0"), 0, "02ce8582-ad02-4fbb-a3d7-87156935736a", new DateTime(2024, 6, 26, 4, 51, 28, 162, DateTimeKind.Utc).AddTicks(6753), new DateTime(2002, 9, 21, 11, 51, 28, 162, DateTimeKind.Local).AddTicks(6687), "harpers@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 162, DateTimeKind.Local).AddTicks(6752), "Smith", new DateTime(2024, 6, 26, 4, 51, 28, 162, DateTimeKind.Utc).AddTicks(6753), "HN", true, null, "HARPERS@GMAIL.COM", "HARPERS", "AQAAAAIAAYagAAAAEDAAxeXPZfVq7FB1TEgvY0qUNju1HPVrHCuzcdpUXthQpCVKNihaSEKg5DmUmSQ2yA==", null, false, "f9b05358-2f0a-4107-bd4e-7375251a28f9", "SD0008", false, "harpers" },
                    { new Guid("a421ac87-80a3-4501-b650-b84d656c1273"), 0, "9a5bb5a4-7c35-474a-94c9-93760200a66d", new DateTime(2024, 6, 26, 4, 51, 30, 699, DateTimeKind.Utc).AddTicks(1161), new DateTime(1998, 1, 1, 11, 51, 30, 699, DateTimeKind.Local).AddTicks(1147), "williamr1@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 699, DateTimeKind.Local).AddTicks(1161), "Rodriguez", new DateTime(2024, 6, 26, 4, 51, 30, 699, DateTimeKind.Utc).AddTicks(1162), "HN", true, null, "WILLIAMR1@GMAIL.COM", "WILLIAMR1", "AQAAAAIAAYagAAAAEAphhmGkrWGHHKDgzyBmyyh5D2RJQZ2lXbGgb/3+B+i+8B1K3h1njyX7BOo+x3y+Kw==", null, false, "d3f5d55d-2b3f-461a-b3e7-d91928214c09", "SD0049", false, "williamr1" },
                    { new Guid("a5a060a2-ce22-49da-aaab-24e42fb94041"), 0, "15badcf0-9be5-4101-a6d1-4a3e76c1fe46", new DateTime(2024, 6, 26, 4, 51, 27, 788, DateTimeKind.Utc).AddTicks(8996), new DateTime(1994, 9, 1, 11, 51, 27, 788, DateTimeKind.Local).AddTicks(8972), "adminhn@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 27, 788, DateTimeKind.Local).AddTicks(8995), "HN", new DateTime(2024, 6, 26, 4, 51, 27, 788, DateTimeKind.Utc).AddTicks(8996), "HN", true, null, "ADMINHN@GMAIL.COM", "ADMINHN", "AQAAAAIAAYagAAAAENMCdAf9I6biLjpyhoHg9gifFJaKl4OtNNMtcWss/22bWGEXmVcu7s3fWsOqOK/CaQ==", null, false, "0e8158f2-92c7-44bb-a5e0-ee588e4d3166", "SD0002", false, "adminhn" },
                    { new Guid("ab7352a0-2452-4d4e-bb01-9d79a3e95ef6"), 0, "e10ac3fc-115e-401d-adb8-0fd36357d0d4", new DateTime(2024, 6, 26, 4, 51, 28, 985, DateTimeKind.Utc).AddTicks(9763), new DateTime(1997, 11, 19, 11, 51, 28, 985, DateTimeKind.Local).AddTicks(9746), "evelynm@gmail.com", false, "Evelyn", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 985, DateTimeKind.Local).AddTicks(9762), "Miller", new DateTime(2024, 6, 26, 4, 51, 28, 985, DateTimeKind.Utc).AddTicks(9764), "HCM", true, null, "EVELYNM@GMAIL.COM", "EVELYNM", "AQAAAAIAAYagAAAAELPYKUjObbsrha1h3VopSov6y1Tp/e1n5KAWGN+RU+yyHL6KFyy5vyoX16CLPud6jA==", null, false, "130e2051-c17f-4b55-8bbd-cf62e23d4ee4", "SD0021", false, "evelynm" },
                    { new Guid("b5a8b18c-e865-4b14-98cc-f52a30113b5f"), 0, "a31dcbc6-8555-40eb-9ff6-9ce5d2ac6278", new DateTime(2024, 6, 26, 4, 51, 31, 132, DateTimeKind.Utc).AddTicks(6797), new DateTime(2003, 6, 22, 11, 51, 31, 132, DateTimeKind.Local).AddTicks(6785), "michaelr@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 132, DateTimeKind.Local).AddTicks(6796), "Rodriguez", new DateTime(2024, 6, 26, 4, 51, 31, 132, DateTimeKind.Utc).AddTicks(6797), "HN", true, null, "MICHAELR@GMAIL.COM", "MICHAELR", "AQAAAAIAAYagAAAAEPsuv3QV67eBG1F5yxqhsBHxVKztpfMvYYwvSRoWNkJ8XTr0+OHEKMgslzIuXULyeg==", null, false, "8c4e87ee-09b6-48a5-9a8b-cdcb8d3b392a", "SD0056", false, "michaelr" },
                    { new Guid("b623a2d8-6f19-455b-bb45-2a2b96960182"), 0, "a1f88a8b-d210-4b7a-89cf-18e2665c9db4", new DateTime(2024, 6, 26, 4, 51, 30, 33, DateTimeKind.Utc).AddTicks(9156), new DateTime(2000, 1, 18, 11, 51, 30, 33, DateTimeKind.Local).AddTicks(9145), "jamesh@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 33, DateTimeKind.Local).AddTicks(9155), "Harris", new DateTime(2024, 6, 26, 4, 51, 30, 33, DateTimeKind.Utc).AddTicks(9157), "HCM", true, null, "JAMESH@GMAIL.COM", "JAMESH", "AQAAAAIAAYagAAAAEBqgCEYzJIo19zd0+SVTBo9Hjp6EYM3JJgpgp+aP+dkLywy8G61uc7lDuPMgoEjeaA==", null, false, "27308c52-d319-4571-8b6b-f1ca2477444b", "SD0038", false, "jamesh" },
                    { new Guid("bc2339cb-bcc6-4456-b309-f27454232914"), 0, "5e3681dd-58cf-4345-a927-dc11a0a26f0f", new DateTime(2024, 6, 26, 4, 51, 31, 380, DateTimeKind.Utc).AddTicks(8214), new DateTime(1998, 9, 9, 11, 51, 31, 380, DateTimeKind.Local).AddTicks(8202), "isabellaa1@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 380, DateTimeKind.Local).AddTicks(8213), "Anderson", new DateTime(2024, 6, 26, 4, 51, 31, 380, DateTimeKind.Utc).AddTicks(8214), "HN", true, null, "ISABELLAA1@GMAIL.COM", "ISABELLAA1", "AQAAAAIAAYagAAAAENToirgWrKIGTIkO2u+9ovBkNyz8RNQlUii6woZqHJo7g/8VqBQXJ6zn01jkpPpa6A==", null, false, "4363aac7-1b1a-445b-9b72-50ff844d1986", "SD0060", false, "isabellaa1" },
                    { new Guid("bfc104d0-aaa1-4dc9-919b-d52fb62231aa"), 0, "8365dd81-9fa8-4a18-bfd5-2a13868cf2c5", new DateTime(2024, 6, 26, 4, 51, 28, 661, DateTimeKind.Utc).AddTicks(9435), new DateTime(1995, 12, 8, 11, 51, 28, 661, DateTimeKind.Local).AddTicks(9425), "emmah@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 661, DateTimeKind.Local).AddTicks(9435), "Harris", new DateTime(2024, 6, 26, 4, 51, 28, 661, DateTimeKind.Utc).AddTicks(9436), "HN", true, null, "EMMAH@GMAIL.COM", "EMMAH", "AQAAAAIAAYagAAAAEKgFP1WyEhZLuHzUXavF+xruy9gGxVkqc3q5XNyqeQ5mgSgnOjTvvuwMVMhyLfj4oQ==", null, false, "f5ec0427-a035-4a8a-b2c0-7d65bbdddd5f", "SD0016", false, "emmah" },
                    { new Guid("c022f701-63fd-462d-b5cf-5727ecb8c9b9"), 0, "fca5e269-e5c1-4910-9de3-7d535226648b", new DateTime(2024, 6, 26, 4, 51, 29, 912, DateTimeKind.Utc).AddTicks(7203), new DateTime(2003, 10, 26, 11, 51, 29, 912, DateTimeKind.Local).AddTicks(7192), "johnh@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 912, DateTimeKind.Local).AddTicks(7202), "Harris", new DateTime(2024, 6, 26, 4, 51, 29, 912, DateTimeKind.Utc).AddTicks(7203), "HN", true, null, "JOHNH@GMAIL.COM", "JOHNH", "AQAAAAIAAYagAAAAENx+jLsYGyIR4inwPuU17vHHWaPXzbjIANj18YejE+hV4L+nvIpvKNhP0pwnR5CnCA==", null, false, "992420bc-9999-46ee-822c-8d250997839f", "SD0036", false, "johnh" },
                    { new Guid("c7586623-5797-4a25-9055-550ea5dcd88a"), 0, "07749342-77df-4ee6-aa85-0813ce75f838", new DateTime(2024, 6, 26, 4, 51, 31, 256, DateTimeKind.Utc).AddTicks(5976), new DateTime(1999, 8, 9, 11, 51, 31, 256, DateTimeKind.Local).AddTicks(5962), "charlottew@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 256, DateTimeKind.Local).AddTicks(5975), "White", new DateTime(2024, 6, 26, 4, 51, 31, 256, DateTimeKind.Utc).AddTicks(5976), "HCM", true, null, "CHARLOTTEW@GMAIL.COM", "CHARLOTTEW", "AQAAAAIAAYagAAAAEEhuD/zbAEFbOmghP6rFr+ii2+KoP7owGNN29vqMm/5lLDwBIkY8pLGFe3d833vqqQ==", null, false, "2a11e323-2cbb-4d06-8773-c83b1fc6e4bf", "SD0058", false, "charlottew" },
                    { new Guid("ca9dd632-360d-4097-a742-136471be87df"), 0, "faf7bba0-0d8a-4117-856d-7cbb47dc7018", new DateTime(2024, 6, 26, 4, 51, 30, 152, DateTimeKind.Utc).AddTicks(9316), new DateTime(1999, 5, 17, 11, 51, 30, 152, DateTimeKind.Local).AddTicks(9303), "avaa@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 152, DateTimeKind.Local).AddTicks(9315), "Anderson", new DateTime(2024, 6, 26, 4, 51, 30, 152, DateTimeKind.Utc).AddTicks(9316), "HN", true, null, "AVAA@GMAIL.COM", "AVAA", "AQAAAAIAAYagAAAAEMeH+dCy4HuIQPtwOdbtqGEhnUAyGwH8MGMX8S0/Ia9rw8JmHJwpF6AON14F9PbKdA==", null, false, "80763c87-3389-49cb-8ff6-d06b8e4fbdcc", "SD0040", false, "avaa" },
                    { new Guid("d0416073-d9cf-4278-afc7-f0200a0a1b9b"), 0, "7f539231-a5aa-49d5-b342-cd0265a3e079", new DateTime(2024, 6, 26, 4, 51, 28, 288, DateTimeKind.Utc).AddTicks(534), new DateTime(2001, 2, 21, 11, 51, 28, 288, DateTimeKind.Local).AddTicks(514), "jamess1@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 288, DateTimeKind.Local).AddTicks(533), "Smith", new DateTime(2024, 6, 26, 4, 51, 28, 288, DateTimeKind.Utc).AddTicks(534), "HN", true, null, "JAMESS1@GMAIL.COM", "JAMESS1", "AQAAAAIAAYagAAAAEIrwjfT265GoBhNXOScBxB9+AyDVwlcVIh5k5WOxsLKTzL2QN2k/8PvmLMM/9pjSnA==", null, false, "bf0379e4-be70-4394-ad45-f216a937232e", "SD0010", false, "jamess1" },
                    { new Guid("d6fbfbfa-3a33-448e-a82c-545a415c4b7e"), 0, "23f7f1e0-dd08-4310-93f9-ebd8d8930a75", new DateTime(2024, 6, 26, 4, 51, 30, 949, DateTimeKind.Utc).AddTicks(269), new DateTime(1996, 8, 7, 11, 51, 30, 949, DateTimeKind.Local).AddTicks(250), "charlottej1@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 949, DateTimeKind.Local).AddTicks(268), "Johnson", new DateTime(2024, 6, 26, 4, 51, 30, 949, DateTimeKind.Utc).AddTicks(269), "HN", true, null, "CHARLOTTEJ1@GMAIL.COM", "CHARLOTTEJ1", "AQAAAAIAAYagAAAAEEkY2fUfnj7LYDmyZgVlyYmts3V/gQg9W7mZJpYZFq0Tf2OFArLSJalEjh9DWShgJQ==", null, false, "e727cef9-e5fa-4e03-8fb6-18d6745ca0bd", "SD0053", false, "charlottej1" },
                    { new Guid("d89e0f90-28e6-440d-9a1d-d3a32ebd8f9f"), 0, "c2232eaa-a507-44c6-81f9-5c0db62416d7", new DateTime(2024, 6, 26, 4, 51, 30, 638, DateTimeKind.Utc).AddTicks(1888), new DateTime(2005, 6, 18, 11, 51, 30, 638, DateTimeKind.Local).AddTicks(1875), "isabellam@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 30, 638, DateTimeKind.Local).AddTicks(1888), "Miller", new DateTime(2024, 6, 26, 4, 51, 30, 638, DateTimeKind.Utc).AddTicks(1888), "HCM", true, null, "ISABELLAM@GMAIL.COM", "ISABELLAM", "AQAAAAIAAYagAAAAEFIQCsyjhjbDpuuU9fWTms+DYlb2h4qOh7Oo0PZ1qtalPBZaCCnpjYitZtZ2DZByPA==", null, false, "caafcca5-0ce7-4f24-a5da-15d7284de7e2", "SD0048", false, "isabellam" },
                    { new Guid("dad82fd6-7acb-44bd-af9d-a1ea3603379c"), 0, "d7f04753-0d3b-4f91-bf18-2ed6eec7e10c", new DateTime(2024, 6, 26, 4, 51, 29, 726, DateTimeKind.Utc).AddTicks(8156), new DateTime(2006, 6, 4, 11, 51, 29, 726, DateTimeKind.Local).AddTicks(8130), "michaelc1@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 726, DateTimeKind.Local).AddTicks(8155), "Clark", new DateTime(2024, 6, 26, 4, 51, 29, 726, DateTimeKind.Utc).AddTicks(8156), "HN", true, null, "MICHAELC1@GMAIL.COM", "MICHAELC1", "AQAAAAIAAYagAAAAEGwx3RmaCtQ+N7TL7S8bzlhJnoxwYzw/PXA9gHaYbP88ks7XeyoLcuMoKWzj2veqLA==", null, false, "d65bb464-b999-4ff6-96bc-ee95d952fb6e", "SD0033", false, "michaelc1" },
                    { new Guid("e48a48c8-4ab3-4553-842c-9212ad26425b"), 0, "21539806-118e-4e32-bd46-51c3360f1e2a", new DateTime(2024, 6, 26, 4, 51, 28, 913, DateTimeKind.Utc).AddTicks(446), new DateTime(1998, 6, 3, 11, 51, 28, 913, DateTimeKind.Local).AddTicks(422), "jamesm1@gmail.com", false, "James", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 913, DateTimeKind.Local).AddTicks(445), "Martinez", new DateTime(2024, 6, 26, 4, 51, 28, 913, DateTimeKind.Utc).AddTicks(446), "HCM", true, null, "JAMESM1@GMAIL.COM", "JAMESM1", "AQAAAAIAAYagAAAAEASHKEfF3OvXtUhJgjGB3UAJ77onUbjNAtur3Mo5kgvRNM59ZVINnH5bPmO2fUtJGA==", null, false, "8b0bc9e6-113a-4227-82b6-41ac4f39cd47", "SD0020", false, "jamesm1" },
                    { new Guid("e9e85f35-cefa-4c86-9966-b9a0151fc3b0"), 0, "4c244ab1-bd9f-49c7-a35f-15484d4134d4", new DateTime(2024, 6, 26, 4, 51, 31, 442, DateTimeKind.Utc).AddTicks(4409), new DateTime(2001, 4, 26, 11, 51, 31, 442, DateTimeKind.Local).AddTicks(4401), "johns@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 51, 31, 442, DateTimeKind.Local).AddTicks(4409), "Smith", new DateTime(2024, 6, 26, 4, 51, 31, 442, DateTimeKind.Utc).AddTicks(4410), "HCM", true, null, "JOHNS@GMAIL.COM", "JOHNS", "AQAAAAIAAYagAAAAEPLq8wrY5YoYI0AZCDpwVwOH2Z6IQX/j9cpv80/IiCIHbKxOTXVAe2nC2aYIf9e3TA==", null, false, "ff7e351f-fe51-491d-9e8d-553f8a051e47", "SD0061", false, "johns" },
                    { new Guid("ef8d0b34-80cd-4173-8cb2-017e00e6a311"), 0, "cd012e6f-9d4b-4709-86d3-a754811d8e86", new DateTime(2024, 6, 26, 4, 51, 27, 910, DateTimeKind.Utc).AddTicks(9645), new DateTime(2002, 7, 1, 11, 51, 27, 910, DateTimeKind.Local).AddTicks(9619), "staffhn@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 27, 910, DateTimeKind.Local).AddTicks(9644), "HN", new DateTime(2024, 6, 26, 4, 51, 27, 910, DateTimeKind.Utc).AddTicks(9646), "HN", true, null, "STAFFHN@GMAIL.COM", "STAFFHN", "AQAAAAIAAYagAAAAEPMkfT9EtLIx5CKv7CV2GNFVFOvUXRnax3oHtfCv+BDtz/1g4EqZfWz6V49bT8Cdhg==", null, false, "0c59d466-b989-42a3-9b2c-bb751d5b8ac7", "SD0004", false, "staffhn" },
                    { new Guid("f2392b64-f771-478d-82a7-70b76ca09aae"), 0, "3232e3ec-4813-4645-8996-4216a178b33e", new DateTime(2024, 6, 26, 4, 51, 28, 475, DateTimeKind.Utc).AddTicks(2413), new DateTime(2003, 4, 24, 11, 51, 28, 475, DateTimeKind.Local).AddTicks(2395), "danielb@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 28, 475, DateTimeKind.Local).AddTicks(2412), "Brown", new DateTime(2024, 6, 26, 4, 51, 28, 475, DateTimeKind.Utc).AddTicks(2413), "HCM", true, null, "DANIELB@GMAIL.COM", "DANIELB", "AQAAAAIAAYagAAAAEIV35gLgg0tTnFP2dyWrtsXNQAMn7WAxVUeUmQnXLoJs8A15j788SXTLPTrwXLNdlA==", null, false, "347d6d4c-a876-475f-9f1c-264b274356af", "SD0013", false, "danielb" },
                    { new Guid("f555e062-8234-408a-a223-1e918198ae3a"), 0, "b167bcd1-35a8-4757-9e9f-e83b7f5292de", new DateTime(2024, 6, 26, 4, 51, 29, 365, DateTimeKind.Utc).AddTicks(8113), new DateTime(2000, 7, 16, 11, 51, 29, 365, DateTimeKind.Local).AddTicks(8098), "isabellac@gmail.com", false, "Isabella", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 365, DateTimeKind.Local).AddTicks(8113), "Clark", new DateTime(2024, 6, 26, 4, 51, 29, 365, DateTimeKind.Utc).AddTicks(8113), "HCM", true, null, "ISABELLAC@GMAIL.COM", "ISABELLAC", "AQAAAAIAAYagAAAAEAEjDWt7Hi8LvHTcdLJBu+1Gz8wbmWIPLpoFHFMuELyS4cLTF5OiLLu5V/QcsA8pGg==", null, false, "0b9f471c-5b82-4bd6-8485-62578c927015", "SD0027", false, "isabellac" },
                    { new Guid("f7176d12-df66-4dda-8ff0-72729d9e94fe"), 0, "656b622b-7dc1-4e9c-93c0-b1029e60958e", new DateTime(2024, 6, 26, 4, 51, 27, 973, DateTimeKind.Utc).AddTicks(9437), new DateTime(1995, 7, 25, 11, 51, 27, 973, DateTimeKind.Local).AddTicks(9413), "benjaminl@gmail.com", false, "Benjamin", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 27, 973, DateTimeKind.Local).AddTicks(9436), "Lewis", new DateTime(2024, 6, 26, 4, 51, 27, 973, DateTimeKind.Utc).AddTicks(9437), "HN", true, null, "BENJAMINL@GMAIL.COM", "BENJAMINL", "AQAAAAIAAYagAAAAEHWrCvZqq6gRZjK8ede8THxXojeEJPwNQ29ayH+rm01QfxuBaQ8kLEuFRSaohiqZtw==", null, false, "17bcd436-f386-44f1-9b3b-5f26aae240dd", "SD0005", false, "benjaminl" },
                    { new Guid("ff66ef50-3946-4bd5-899a-9aa67aa310ce"), 0, "32285982-98b7-4b7b-bbc1-c66094107985", new DateTime(2024, 6, 26, 4, 51, 29, 976, DateTimeKind.Utc).AddTicks(161), new DateTime(2004, 2, 10, 11, 51, 29, 976, DateTimeKind.Local).AddTicks(145), "charlotteg@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 26, 11, 51, 29, 976, DateTimeKind.Local).AddTicks(160), "Garcia", new DateTime(2024, 6, 26, 4, 51, 29, 976, DateTimeKind.Utc).AddTicks(161), "HN", true, null, "CHARLOTTEG@GMAIL.COM", "CHARLOTTEG", "AQAAAAIAAYagAAAAEN5p70eLTvddquXMfS33tpY1OMdA/MNrlMxBIOgCT/gaJIRRPVpp7IwyrXb1qD/dIg==", null, false, "ee1f35b1-0fc5-448a-a1be-e52ee2837719", "SD0037", false, "charlotteg" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "Prefix" },
                values: new object[,]
                {
                    { new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), "Laptop", "LA" },
                    { new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), "Personal Computer", "PC" },
                    { new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), "Monitor", "MO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("02c00cd6-95ed-4bee-b725-7a9a4a37e480"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("053ddb36-7323-47d2-9284-73f2c6ea1273"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("179e497c-bd98-48dc-a3bc-eaaccd6646c6"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1bafcb42-fd2a-474a-a7cb-edf688698275"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1dfad98a-05de-453e-870e-f70a74e0def8"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f768a11-d032-4c32-b1cf-87f054096f45"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2109accc-be1d-4ba7-a8ea-909e7b101a55"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2350e093-53b8-4ea9-80d5-74b32b82c5f3"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2507b36e-6b9d-484a-b6f8-d3882a4e8526"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("26c2f3a3-742f-41cd-935d-36a8cff2971b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2da658d2-2acd-4c24-bfff-18eb74caf856"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2feda927-3c44-4cc4-bb05-17b87d0c090a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("303d48fc-0549-4c21-81e8-4de9de20e483"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("31d293ce-9ff5-4c1f-8e05-d5468207e1bf"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("34658999-d121-48f9-9056-bb76d0993e3a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("35e8bc5b-aa36-4190-982c-83e6ab2e865b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3b07c9af-e63f-4b55-98bb-1d847140c768"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42a3456b-1bc5-4d53-bb2f-0fb81f5f9623"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("491343c8-ba78-4697-b21a-753b1e70b800"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4d97ffeb-42b2-4d2c-9945-4b043a007b25"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f957938-a42c-43f9-88a5-ce08e115ae63"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("508f28ef-3c01-4c39-90df-2d9c79ab2946"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("59119720-8f37-4c70-8cd9-2a1ae1b9ad29"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5a889ad4-16d9-41e7-bf62-a8da4f6a06c7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5d8a3c54-7350-4245-8906-d832d487d80e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("60d32ca1-6500-458b-b808-2d47adf76393"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6323d914-8d5c-49e7-a602-8163d4e46555"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6b62e024-c19e-4ecd-a80f-743380b243f8"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6edc217f-9463-4952-ad32-042e43de2ef6"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("74c1cc5e-ea23-43ca-bf02-1f68567a1b44"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("75bd282b-bab3-43f4-8022-52ef2641fbe5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("79873b6a-3155-4b83-8e04-208ec6f7ff87"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("7a44116a-f6d4-4215-b815-f8c4dbf3fc74"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("80d66234-2f84-445a-90e3-4571f611737b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("85d49393-320e-445b-9921-12a4bf8e1e6a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("866db22c-43da-4dc5-8419-c3aab32df21c"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("87ea0f4c-11c6-4a00-834f-db8541fc2bd3"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("886e1e1e-c746-4811-86af-92bf669407ba"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8b482df8-0697-4671-a59f-7e783210e1fd"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9561c769-db6d-4c13-b35a-18c61eda8905"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("95fb555f-8a30-4334-bbbb-b42bbada0217"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("968e7dcc-3d14-47e7-a5ee-18716abeb5a4"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("9eaf916c-f4e9-4e66-aa23-b13d04b401f0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a421ac87-80a3-4501-b650-b84d656c1273"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a5a060a2-ce22-49da-aaab-24e42fb94041"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ab7352a0-2452-4d4e-bb01-9d79a3e95ef6"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b5a8b18c-e865-4b14-98cc-f52a30113b5f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b623a2d8-6f19-455b-bb45-2a2b96960182"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bc2339cb-bcc6-4456-b309-f27454232914"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bfc104d0-aaa1-4dc9-919b-d52fb62231aa"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c022f701-63fd-462d-b5cf-5727ecb8c9b9"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c7586623-5797-4a25-9055-550ea5dcd88a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ca9dd632-360d-4097-a742-136471be87df"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("d0416073-d9cf-4278-afc7-f0200a0a1b9b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d6fbfbfa-3a33-448e-a82c-545a415c4b7e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d89e0f90-28e6-440d-9a1d-d3a32ebd8f9f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("dad82fd6-7acb-44bd-af9d-a1ea3603379c"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e48a48c8-4ab3-4553-842c-9212ad26425b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e9e85f35-cefa-4c86-9966-b9a0151fc3b0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ef8d0b34-80cd-4173-8cb2-017e00e6a311"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("f2392b64-f771-478d-82a7-70b76ca09aae"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f555e062-8234-408a-a223-1e918198ae3a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("f7176d12-df66-4dda-8ff0-72729d9e94fe"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ff66ef50-3946-4bd5-899a-9aa67aa310ce"), "UserRole" }
                });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetCode", "CategoryId", "CreatedAt", "InstalledDate", "LastUpdated", "Location", "Name", "Specification", "State" },
                values: new object[,]
                {
                    { new Guid("00e78de3-db8a-4e72-aeb5-d29e5276a3ce"), "PC000008", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2065), "HCM", "Personal Computer ASUS ROG", "Core i9, 32GB RAM, 2TB SSD, Windows 11", "NotAvailable" },
                    { new Guid("032bb307-7a2b-4f76-aa8b-ff3b883285da"), "MO000011", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2095), "HCM", "Monitor Samsung Odyssey", "49 inch, QHD", "Available" },
                    { new Guid("0352e98d-d5af-463b-96b9-ab754197cfeb"), "LA000002", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1960), new DateTime(2015, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1961), "HCM", "Laptop Dell XPS 13", "Core i7, 16GB RAM, 512GB SSD, Windows 10", "Available" },
                    { new Guid("05521fb9-7d80-4d4d-84a3-9924a99579fc"), "PC000002", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1968), new DateTime(2016, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1968), "HCM", "Personal Computer HP EliteDesk", "Core i5, 8GB RAM, 512GB SSD, Windows 10", "Available" },
                    { new Guid("2bc64071-f80c-45fb-b1f4-5666e9d6d270"), "PC000005", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2008), new DateTime(2022, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2009), "HCM", "Personal Computer MSI Trident", "Core i9, 32GB RAM, 1TB SSD, Windows 11", "WaitingForRecycling" },
                    { new Guid("2ffa2b83-3909-4666-8e09-56a1fe3848ce"), "LA000005", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1990), new DateTime(2022, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1991), "HN", "Laptop HP Envy", "Core i7, 16GB RAM, 512GB SSD, Windows 11", "NotAvailable" },
                    { new Guid("33a308f3-2b65-4ee0-9bdf-f9f5465c0675"), "MO000003", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1981), new DateTime(2020, 12, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1982), "HCM", "Monitor LG UltraWide", "34 inch, WQHD", "Available" },
                    { new Guid("34d4d806-1c48-4cf4-9b87-0b00f0d90727"), "PC000001", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1957), new DateTime(2012, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1958), "HN", "Personal Computer Dell Inspiron", "Core i7, 16GB RAM, 1TB SSD, Windows 10", "Available" },
                    { new Guid("3c5ed6eb-cddd-4884-bb91-e2ad1eb2d1c0"), "LA000008", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2048), "HN", "Laptop Dell Latitude", "Core i5, 8GB RAM, 256GB SSD, Windows 11", "Available" },
                    { new Guid("4135f4e3-1bb5-4ae5-8a80-3e29611c5803"), "MO000007", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 2, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2051), "HCM", "Monitor Acer Predator", "32 inch, QHD", "Available" },
                    { new Guid("43cc2a5c-24b9-48b6-b6d8-c6d4f79fa38d"), "MO000005", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2004), new DateTime(2022, 5, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2005), "HN", "Monitor BenQ DesignVue", "27 inch, 4K UHD", "WaitingForRecycling" },
                    { new Guid("4bf3c4a7-a69c-4898-a91a-50822b9c5d3f"), "MO000010", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2084), "HN", "Monitor Dell Gaming", "32 inch, QHD", "Available" },
                    { new Guid("56d4593e-fc69-4383-8d0b-bffec9ed952e"), "MO000012", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2107), new DateTime(2024, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2107), "HN", "Monitor LG UltraGear", "32 inch, QHD", "NotAvailable" },
                    { new Guid("598c1e27-a31a-443f-9194-b2a5fa090f03"), "MO000014", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2127), new DateTime(2024, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2127), "HN", "Monitor ASUS TUF", "32 inch, QHD", "Recycled" },
                    { new Guid("5b3d4936-e8ea-4660-bc6c-46a0e20ad954"), "LA000003", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1978), new DateTime(2019, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1979), "HN", "Laptop Lenovo ThinkPad", "Core i5, 8GB RAM, 256GB SSD, Windows 10", "Available" },
                    { new Guid("5bc2ea39-d9e9-45f9-ad0a-4158507ceef3"), "LA000014", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2113), "HN", "Laptop Dell Inspiron", "Core i5, 8GB RAM, 256GB SSD, Windows 11", "WaitingForRecycling" },
                    { new Guid("5c5a3e05-ed01-4d09-aaaf-10ff06c451f4"), "LA000012", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2092), "HN", "Laptop Lenovo Yoga", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "Available" },
                    { new Guid("646397b3-84d5-4197-a191-01413f575ce3"), "PC000012", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2111), "HCM", "Personal Computer ASUS VivoPC", "Core i5, 8GB RAM, 1TB SSD, Windows 11", "NotAvailable" },
                    { new Guid("6877f517-6fec-4938-bf99-e4014d774f50"), "MO000006", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2042), "HCM", "Monitor ViewSonic VP", "27 inch, WQHD", "Recycled" },
                    { new Guid("6c383b1c-f200-485e-8f1b-95e336d1cb74"), "MO000008", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2062), "HN", "Monitor Philips Brilliance", "34 inch, 4K UHD", "NotAvailable" },
                    { new Guid("6e0764d8-5dd5-4fee-af8a-a0f10041faf4"), "MO000002", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1963), new DateTime(2018, 1, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1963), "HN", "Monitor Samsung Curved", "27 inch, QHD", "Available" },
                    { new Guid("6fbe694c-7890-4b4a-87d3-c3c7a08dff0d"), "LA000004", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1987), new DateTime(2021, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1988), "HCM", "Laptop Asus ZenBook", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "Available" },
                    { new Guid("7b504e67-f53b-4242-9faf-4c6e3fcb61aa"), "PC000007", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2054), "HN", "Personal Computer Apple iMac", "M1, 16GB RAM, 512GB SSD, macOS", "Available" },
                    { new Guid("7fb2515f-8a21-4137-ad4b-85509e30dafd"), "LA000015", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2124), "HCM", "Laptop ASUS ZenBook Duo", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "Available" },
                    { new Guid("863ed79f-23b5-42da-a073-a8c5b0ff1cbd"), "PC000009", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2074), "HN", "Personal Computer HP Pavilion", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "WaitingForRecycling" },
                    { new Guid("8b323bc6-6b12-485e-8597-8855f8f145a1"), "MO000013", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2118), "HCM", "Monitor ViewSonic Elite", "32 inch, QHD", "WaitingForRecycling" },
                    { new Guid("90fad77b-c859-4c4a-83de-3f5917d447f0"), "PC000010", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2089), "HCM", "Personal Computer HP Envy", "Core i9, 32GB RAM, 2TB SSD, Windows 11", "Available" },
                    { new Guid("9418119b-52e4-40d4-8d35-1f7d7d6288a0"), "LA000011", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2077), "HCM", "Laptop ASUS VivoBook", "Core i5, 8GB RAM, 512GB SSD, Windows 11", "Recycled" },
                    { new Guid("98e6d058-ecc9-4a52-99fb-f88e6f71e92c"), "PC000011", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2100), "HN", "Personal Computer Dell Optiplex", "Core i7, 16GB RAM, 512GB SSD, Windows 11", "Available" },
                    { new Guid("996474f2-30a6-4dc2-abd5-e6075ae99ef9"), "PC000004", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1997), "HN", "Personal Computer Lenovo IdeaCentre", "Core i5, 8GB RAM, 1TB HDD, Windows 10", "NotAvailable" },
                    { new Guid("a9ac9da1-2180-40e7-8e2f-00a21995e13e"), "PC000013", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2121), new DateTime(2024, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2121), "HN", "Personal Computer Apple Mac Mini", "M1, 8GB RAM, 256GB SSD, macOS", "WaitingForRecycling" },
                    { new Guid("aa7cbbb9-59e7-43f5-bd74-f12e6220b876"), "LA000006", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2000), "HCM", "Laptop Apple MacBook Air", "M1, 8GB RAM, 256GB SSD, macOS", "WaitingForRecycling" },
                    { new Guid("b43bd63a-e500-4b42-b91f-ba2ad2f91287"), "MO000004", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1993), new DateTime(2022, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1994), "HCM", "Monitor ASUS ProArt", "32 inch, 4K UHD", "NotAvailable" },
                    { new Guid("b5291e6e-518e-49cf-b0f2-5c72889be044"), "PC000014", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2130), new DateTime(2024, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2130), "HCM", "Personal Computer Lenovo ThinkCentre", "Core i7, 16GB RAM, 512GB SSD, Windows 11", "Recycled" },
                    { new Guid("b7914386-d0de-4e6a-8911-9d76e4309bac"), "LA000001", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1941), new DateTime(2008, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1946), "HN", "Laptop HP ProBook 450 G1", "Core i5, 8GB RAM, 750 GB HDD, Window 8", "Available" },
                    { new Guid("c2d9d3b5-52ac-4a63-b950-a9d779fe39d3"), "MO000001", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1953), new DateTime(2010, 7, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1954), "HCM", "Monitor Dell UltraSharp", "24 inch, Full HD", "Available" },
                    { new Guid("c45fef63-ade5-4841-b093-0cd193120327"), "LA000010", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2068), "HN", "Laptop HP Spectre", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "WaitingForRecycling" },
                    { new Guid("d08b5fe4-e519-4f48-9509-1f16f06c45c9"), "PC000006", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2044), new DateTime(2022, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2045), "HN", "Personal Computer Dell G5", "Core i7, 16GB RAM, 1TB SSD, Windows 11", "Recycled" },
                    { new Guid("e2d07492-1774-4f8c-be25-0b6e41d9d9bd"), "LA000007", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2012), "HN", "Laptop Microsoft Surface", "Core i7, 16GB RAM, 512GB SSD, Windows 11", "Recycled" },
                    { new Guid("eb437832-1509-4a18-b4c1-78213d77454f"), "LA000009", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2059), "HCM", "Laptop Acer Swift", "Core i5, 8GB RAM, 512GB SSD, Windows 11", "NotAvailable" },
                    { new Guid("eec8d16b-b8ad-4f55-a93c-e9e85c7004b5"), "PC000003", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1984), new DateTime(2013, 4, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(1985), "HN", "Personal Computer Acer Aspire", "Core i3, 4GB RAM, 1TB HDD, Windows 8", "Available" },
                    { new Guid("f925bb2a-9e87-4cb6-bef2-5f41b863a187"), "MO000009", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2071), "HCM", "Monitor HP Omen", "32 inch, QHD", "WaitingForRecycling" },
                    { new Guid("f9e74102-b64d-4217-b4f3-1d1e7b1029f0"), "LA000013", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2102), new DateTime(2024, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 11, 51, 31, 694, DateTimeKind.Local).AddTicks(2103), "HCM", "Laptop Apple MacBook Pro", "M1 Pro, 16GB RAM, 1TB SSD, macOS", "NotAvailable" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_CategoryId",
                table: "Asset",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("02c00cd6-95ed-4bee-b725-7a9a4a37e480") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("053ddb36-7323-47d2-9284-73f2c6ea1273") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("179e497c-bd98-48dc-a3bc-eaaccd6646c6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1bafcb42-fd2a-474a-a7cb-edf688698275") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1dfad98a-05de-453e-870e-f70a74e0def8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f768a11-d032-4c32-b1cf-87f054096f45") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2109accc-be1d-4ba7-a8ea-909e7b101a55") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2350e093-53b8-4ea9-80d5-74b32b82c5f3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2507b36e-6b9d-484a-b6f8-d3882a4e8526") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("26c2f3a3-742f-41cd-935d-36a8cff2971b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2da658d2-2acd-4c24-bfff-18eb74caf856") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2feda927-3c44-4cc4-bb05-17b87d0c090a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("303d48fc-0549-4c21-81e8-4de9de20e483") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("31d293ce-9ff5-4c1f-8e05-d5468207e1bf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("34658999-d121-48f9-9056-bb76d0993e3a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("35e8bc5b-aa36-4190-982c-83e6ab2e865b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3b07c9af-e63f-4b55-98bb-1d847140c768") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42a3456b-1bc5-4d53-bb2f-0fb81f5f9623") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("491343c8-ba78-4697-b21a-753b1e70b800") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4d97ffeb-42b2-4d2c-9945-4b043a007b25") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f957938-a42c-43f9-88a5-ce08e115ae63") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("508f28ef-3c01-4c39-90df-2d9c79ab2946") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("59119720-8f37-4c70-8cd9-2a1ae1b9ad29") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5a889ad4-16d9-41e7-bf62-a8da4f6a06c7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5d8a3c54-7350-4245-8906-d832d487d80e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("60d32ca1-6500-458b-b808-2d47adf76393") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6323d914-8d5c-49e7-a602-8163d4e46555") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6b62e024-c19e-4ecd-a80f-743380b243f8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6edc217f-9463-4952-ad32-042e43de2ef6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("74c1cc5e-ea23-43ca-bf02-1f68567a1b44") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("75bd282b-bab3-43f4-8022-52ef2641fbe5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("79873b6a-3155-4b83-8e04-208ec6f7ff87") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("7a44116a-f6d4-4215-b815-f8c4dbf3fc74") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("80d66234-2f84-445a-90e3-4571f611737b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("85d49393-320e-445b-9921-12a4bf8e1e6a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("866db22c-43da-4dc5-8419-c3aab32df21c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("87ea0f4c-11c6-4a00-834f-db8541fc2bd3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("886e1e1e-c746-4811-86af-92bf669407ba") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8b482df8-0697-4671-a59f-7e783210e1fd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9561c769-db6d-4c13-b35a-18c61eda8905") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("95fb555f-8a30-4334-bbbb-b42bbada0217") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("968e7dcc-3d14-47e7-a5ee-18716abeb5a4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("9eaf916c-f4e9-4e66-aa23-b13d04b401f0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a421ac87-80a3-4501-b650-b84d656c1273") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a5a060a2-ce22-49da-aaab-24e42fb94041") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ab7352a0-2452-4d4e-bb01-9d79a3e95ef6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b5a8b18c-e865-4b14-98cc-f52a30113b5f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b623a2d8-6f19-455b-bb45-2a2b96960182") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bc2339cb-bcc6-4456-b309-f27454232914") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bfc104d0-aaa1-4dc9-919b-d52fb62231aa") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c022f701-63fd-462d-b5cf-5727ecb8c9b9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c7586623-5797-4a25-9055-550ea5dcd88a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ca9dd632-360d-4097-a742-136471be87df") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("d0416073-d9cf-4278-afc7-f0200a0a1b9b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d6fbfbfa-3a33-448e-a82c-545a415c4b7e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d89e0f90-28e6-440d-9a1d-d3a32ebd8f9f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("dad82fd6-7acb-44bd-af9d-a1ea3603379c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e48a48c8-4ab3-4553-842c-9212ad26425b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e9e85f35-cefa-4c86-9966-b9a0151fc3b0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ef8d0b34-80cd-4173-8cb2-017e00e6a311") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("f2392b64-f771-478d-82a7-70b76ca09aae") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f555e062-8234-408a-a223-1e918198ae3a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("f7176d12-df66-4dda-8ff0-72729d9e94fe") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ff66ef50-3946-4bd5-899a-9aa67aa310ce") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("02c00cd6-95ed-4bee-b725-7a9a4a37e480"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("053ddb36-7323-47d2-9284-73f2c6ea1273"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("179e497c-bd98-48dc-a3bc-eaaccd6646c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1bafcb42-fd2a-474a-a7cb-edf688698275"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1dfad98a-05de-453e-870e-f70a74e0def8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1f768a11-d032-4c32-b1cf-87f054096f45"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2109accc-be1d-4ba7-a8ea-909e7b101a55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2350e093-53b8-4ea9-80d5-74b32b82c5f3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2507b36e-6b9d-484a-b6f8-d3882a4e8526"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26c2f3a3-742f-41cd-935d-36a8cff2971b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2da658d2-2acd-4c24-bfff-18eb74caf856"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2feda927-3c44-4cc4-bb05-17b87d0c090a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("303d48fc-0549-4c21-81e8-4de9de20e483"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31d293ce-9ff5-4c1f-8e05-d5468207e1bf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34658999-d121-48f9-9056-bb76d0993e3a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e8bc5b-aa36-4190-982c-83e6ab2e865b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b07c9af-e63f-4b55-98bb-1d847140c768"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("42a3456b-1bc5-4d53-bb2f-0fb81f5f9623"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("491343c8-ba78-4697-b21a-753b1e70b800"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4d97ffeb-42b2-4d2c-9945-4b043a007b25"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f957938-a42c-43f9-88a5-ce08e115ae63"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("508f28ef-3c01-4c39-90df-2d9c79ab2946"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59119720-8f37-4c70-8cd9-2a1ae1b9ad29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a889ad4-16d9-41e7-bf62-a8da4f6a06c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d8a3c54-7350-4245-8906-d832d487d80e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60d32ca1-6500-458b-b808-2d47adf76393"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6323d914-8d5c-49e7-a602-8163d4e46555"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b62e024-c19e-4ecd-a80f-743380b243f8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6edc217f-9463-4952-ad32-042e43de2ef6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("74c1cc5e-ea23-43ca-bf02-1f68567a1b44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("75bd282b-bab3-43f4-8022-52ef2641fbe5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79873b6a-3155-4b83-8e04-208ec6f7ff87"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a44116a-f6d4-4215-b815-f8c4dbf3fc74"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("80d66234-2f84-445a-90e3-4571f611737b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85d49393-320e-445b-9921-12a4bf8e1e6a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("866db22c-43da-4dc5-8419-c3aab32df21c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87ea0f4c-11c6-4a00-834f-db8541fc2bd3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("886e1e1e-c746-4811-86af-92bf669407ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b482df8-0697-4671-a59f-7e783210e1fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9561c769-db6d-4c13-b35a-18c61eda8905"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95fb555f-8a30-4334-bbbb-b42bbada0217"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("968e7dcc-3d14-47e7-a5ee-18716abeb5a4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9eaf916c-f4e9-4e66-aa23-b13d04b401f0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a421ac87-80a3-4501-b650-b84d656c1273"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5a060a2-ce22-49da-aaab-24e42fb94041"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab7352a0-2452-4d4e-bb01-9d79a3e95ef6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5a8b18c-e865-4b14-98cc-f52a30113b5f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b623a2d8-6f19-455b-bb45-2a2b96960182"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc2339cb-bcc6-4456-b309-f27454232914"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfc104d0-aaa1-4dc9-919b-d52fb62231aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c022f701-63fd-462d-b5cf-5727ecb8c9b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7586623-5797-4a25-9055-550ea5dcd88a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ca9dd632-360d-4097-a742-136471be87df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0416073-d9cf-4278-afc7-f0200a0a1b9b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6fbfbfa-3a33-448e-a82c-545a415c4b7e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d89e0f90-28e6-440d-9a1d-d3a32ebd8f9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dad82fd6-7acb-44bd-af9d-a1ea3603379c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e48a48c8-4ab3-4553-842c-9212ad26425b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9e85f35-cefa-4c86-9966-b9a0151fc3b0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ef8d0b34-80cd-4173-8cb2-017e00e6a311"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2392b64-f771-478d-82a7-70b76ca09aae"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f555e062-8234-408a-a223-1e918198ae3a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7176d12-df66-4dda-8ff0-72729d9e94fe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ff66ef50-3946-4bd5-899a-9aa67aa310ce"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("03d91902-9062-4325-bb30-643f2575ff43"), 0, "1cd5c8ca-05a3-4155-9a68-ec992217da9e", new DateTime(2024, 6, 26, 4, 46, 16, 974, DateTimeKind.Utc).AddTicks(3918), new DateTime(1994, 10, 5, 11, 46, 16, 974, DateTimeKind.Local).AddTicks(3892), "miah1@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 974, DateTimeKind.Local).AddTicks(3917), "Harris", new DateTime(2024, 6, 26, 4, 46, 16, 974, DateTimeKind.Utc).AddTicks(3918), "HCM", true, null, "MIAH1@GMAIL.COM", "MIAH1", "AQAAAAIAAYagAAAAEMl9NVuZt90KTQz7tJwKdK0R2QgaazdqCkRrLi63ZueOr6RsY2HqJxCofDSdoMt63Q==", null, false, "099220ed-216c-47df-96fd-c2789c57ed23", "SD0010", false, "miah1" },
                    { new Guid("0489f519-4748-4e81-a15f-4e2a2e0f9ae3"), 0, "587ad406-475e-48b3-ad82-39d6af437e9d", new DateTime(2024, 6, 26, 4, 46, 17, 162, DateTimeKind.Utc).AddTicks(2433), new DateTime(2003, 3, 27, 11, 46, 17, 162, DateTimeKind.Local).AddTicks(2416), "alexanderj@gmail.com", false, "Alexander", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 162, DateTimeKind.Local).AddTicks(2433), "Jackson", new DateTime(2024, 6, 26, 4, 46, 17, 162, DateTimeKind.Utc).AddTicks(2434), "HN", true, null, "ALEXANDERJ@GMAIL.COM", "ALEXANDERJ", "AQAAAAIAAYagAAAAEIDmn9fAXOeia/X/QwJID8cibglefaHWIL7lRw3H/z7kS2OgF87ACeH/uCERCeKCZQ==", null, false, "7179c255-add0-4c53-b936-68a3a9c62d15", "SD0013", false, "alexanderj" },
                    { new Guid("06dd70d1-e4c9-4101-b442-7de4f36b9554"), 0, "eebb0efe-f0fc-40f1-b203-acf099741817", new DateTime(2024, 6, 26, 4, 46, 17, 571, DateTimeKind.Utc).AddTicks(62), new DateTime(2005, 2, 22, 11, 46, 17, 571, DateTimeKind.Local).AddTicks(54), "danielj@gmail.com", false, "Daniel", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 571, DateTimeKind.Local).AddTicks(62), "Jones", new DateTime(2024, 6, 26, 4, 46, 17, 571, DateTimeKind.Utc).AddTicks(64), "HCM", true, null, "DANIELJ@GMAIL.COM", "DANIELJ", "AQAAAAIAAYagAAAAEHkuaXskKOZzH1NpPDZtphh4WYmCUmPTryRGHz6pzQuoeyO8yItXe+xWuMXErWbn1A==", null, false, "371c8f02-7a05-4908-bccc-fc62dd55ed17", "SD0020", false, "danielj" },
                    { new Guid("09b6284f-33ee-40d2-907c-2fc862f0d8bd"), 0, "b432e78c-a6a4-4a49-99af-ca4d4790625a", new DateTime(2024, 6, 26, 4, 46, 17, 687, DateTimeKind.Utc).AddTicks(4047), new DateTime(1998, 7, 21, 11, 46, 17, 687, DateTimeKind.Local).AddTicks(4037), "harperw@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 687, DateTimeKind.Local).AddTicks(4046), "Wilson", new DateTime(2024, 6, 26, 4, 46, 17, 687, DateTimeKind.Utc).AddTicks(4048), "HCM", true, null, "HARPERW@GMAIL.COM", "HARPERW", "AQAAAAIAAYagAAAAEHn+uSf0u1CnadzUKrD068eLKmsedf0ojYMlnFuiitjfzzjSYlFxhmmtbjj6aVB9Og==", null, false, "85ee89dc-018c-4c1a-a09f-b4b3e9a4f71f", "SD0022", false, "harperw" },
                    { new Guid("0b45399b-a3a1-4f5c-968d-6646c573cd36"), 0, "1e3cbdda-1d08-4bdf-9cd6-0fdb3bcba6a1", new DateTime(2024, 6, 26, 4, 46, 18, 626, DateTimeKind.Utc).AddTicks(2047), new DateTime(1995, 3, 10, 11, 46, 18, 626, DateTimeKind.Local).AddTicks(2030), "josepht@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 626, DateTimeKind.Local).AddTicks(2046), "Taylor", new DateTime(2024, 6, 26, 4, 46, 18, 626, DateTimeKind.Utc).AddTicks(2047), "HCM", true, null, "JOSEPHT@GMAIL.COM", "JOSEPHT", "AQAAAAIAAYagAAAAEJXcYZxICbXC2639GUhLE5BEsDOZiWtLVbRfhOH7rIN4WzMN3WrHbXmpe4Hcn3RAnA==", null, false, "87b2a3ed-5a75-40fe-8765-73557c0b2491", "SD0038", false, "josepht" },
                    { new Guid("0cc00854-9a10-4b69-829b-b377f210c4fd"), 0, "0706dff8-e467-4ff8-852c-f4fcadf7de31", new DateTime(2024, 6, 26, 4, 46, 18, 332, DateTimeKind.Utc).AddTicks(8786), new DateTime(2005, 7, 14, 11, 46, 18, 332, DateTimeKind.Local).AddTicks(8774), "isabellaj2@gmail.com", false, "Isabella", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 332, DateTimeKind.Local).AddTicks(8785), "Jackson", new DateTime(2024, 6, 26, 4, 46, 18, 332, DateTimeKind.Utc).AddTicks(8787), "HCM", true, null, "ISABELLAJ2@GMAIL.COM", "ISABELLAJ2", "AQAAAAIAAYagAAAAEMIj7JPiLB/ljTLjkpJFo/S8S/zLT2vjo+ZKbM77srnIz3qvKCQ1Up6zvc6l50svOg==", null, false, "72b05b8a-85cc-4743-9fda-066e763aca66", "SD0033", false, "isabellaj2" },
                    { new Guid("1103c0f0-155e-427b-83d7-5fea6cb410ef"), 0, "73251d01-af60-433b-84bb-7dd3ae18aae0", new DateTime(2024, 6, 26, 4, 46, 17, 922, DateTimeKind.Utc).AddTicks(5093), new DateTime(2005, 10, 12, 11, 46, 17, 922, DateTimeKind.Local).AddTicks(5084), "isabellaj1@gmail.com", false, "Isabella", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 922, DateTimeKind.Local).AddTicks(5092), "Johnson", new DateTime(2024, 6, 26, 4, 46, 17, 922, DateTimeKind.Utc).AddTicks(5093), "HN", true, null, "ISABELLAJ1@GMAIL.COM", "ISABELLAJ1", "AQAAAAIAAYagAAAAEJpRqDEVnx5rRQKTsMgE264iH+91ewEVnDzKeM43a0DYKMYRRBfU8MIepUBQrt0Q4g==", null, false, "bf55290d-5957-44a4-80e0-a407500c0953", "SD0026", false, "isabellaj1" },
                    { new Guid("1848d773-d2b9-41d5-beb0-30bce683ee39"), 0, "fe16664d-fcaf-4767-9462-4a8c8f6d6f24", new DateTime(2024, 6, 26, 4, 46, 19, 153, DateTimeKind.Utc).AddTicks(1561), new DateTime(2002, 1, 8, 11, 46, 19, 153, DateTimeKind.Local).AddTicks(1541), "elijahj1@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 153, DateTimeKind.Local).AddTicks(1560), "Johnson", new DateTime(2024, 6, 26, 4, 46, 19, 153, DateTimeKind.Utc).AddTicks(1562), "HN", true, null, "ELIJAHJ1@GMAIL.COM", "ELIJAHJ1", "AQAAAAIAAYagAAAAEAamVzk3HcQ3A2NIlQIBCb9Hj70dI97beuwLWlIgQGtXj8Rnw9l5RvRzqFw4vSViKA==", null, false, "daf69000-4ec7-4abc-879b-85b6f3e8de45", "SD0047", false, "elijahj1" },
                    { new Guid("18ce48a2-4009-4843-892b-fc51b7a9b8f8"), 0, "8d31708d-7d10-4576-b411-b4a697b8510e", new DateTime(2024, 6, 26, 4, 46, 20, 142, DateTimeKind.Utc).AddTicks(2878), new DateTime(1998, 5, 19, 11, 46, 20, 142, DateTimeKind.Local).AddTicks(2872), "charlottet1@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 20, 142, DateTimeKind.Local).AddTicks(2878), "Thomas", new DateTime(2024, 6, 26, 4, 46, 20, 142, DateTimeKind.Utc).AddTicks(2879), "HCM", true, null, "CHARLOTTET1@GMAIL.COM", "CHARLOTTET1", "AQAAAAIAAYagAAAAEEe67qsp7h9RtC9jhHL0DynJmrzimHZdgb4yetQsU5KAXs5M8M4UILquI1RxmwgvFw==", null, false, "accdd017-c26e-493b-8256-9f19f16c4f15", "SD0064", false, "charlottet1" },
                    { new Guid("1fdb74ca-5c8d-40a4-83a6-80939d461d25"), 0, "970a76a2-d705-4664-baca-4fb04c75e83a", new DateTime(2024, 6, 26, 4, 46, 18, 98, DateTimeKind.Utc).AddTicks(8365), new DateTime(1995, 4, 2, 11, 46, 18, 98, DateTimeKind.Local).AddTicks(8351), "ameliab@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 98, DateTimeKind.Local).AddTicks(8364), "Brown", new DateTime(2024, 6, 26, 4, 46, 18, 98, DateTimeKind.Utc).AddTicks(8366), "HN", true, null, "AMELIAB@GMAIL.COM", "AMELIAB", "AQAAAAIAAYagAAAAENi7QB0ZMTpVny71FNuLxUts04KnrNUpK4zTTqXZLLGlXfTzK8kSam9EdDV6ENDs7g==", null, false, "307c817b-8b4b-4ec8-8e6b-28e76516e4ed", "SD0029", false, "ameliab" },
                    { new Guid("21bbb148-429e-49fd-ae9d-0e825da9ec99"), 0, "daef6c22-6e56-4b94-9bdb-e2c295b84440", new DateTime(2024, 6, 26, 4, 46, 19, 795, DateTimeKind.Utc).AddTicks(3304), new DateTime(1998, 12, 26, 11, 46, 19, 795, DateTimeKind.Local).AddTicks(3295), "williamy1@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 795, DateTimeKind.Local).AddTicks(3303), "Young", new DateTime(2024, 6, 26, 4, 46, 19, 795, DateTimeKind.Utc).AddTicks(3304), "HN", true, null, "WILLIAMY1@GMAIL.COM", "WILLIAMY1", "AQAAAAIAAYagAAAAEEc5aPXkop//+rMP9cHvfKOd3cGXLA1YGzh5M1e/eK7ZGQ3lY2WXeXfDMHaaHT2urA==", null, false, "8b828ca7-25d2-49fd-bec2-daa919adf501", "SD0058", false, "williamy1" },
                    { new Guid("23e756fa-611e-4d0c-ae7a-1d8f14590b8c"), 0, "e647f181-b1bd-47ac-a005-d435b0d3b452", new DateTime(2024, 6, 26, 4, 46, 17, 805, DateTimeKind.Utc).AddTicks(199), new DateTime(2004, 3, 26, 11, 46, 17, 805, DateTimeKind.Local).AddTicks(191), "michaelc@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 805, DateTimeKind.Local).AddTicks(199), "Clark", new DateTime(2024, 6, 26, 4, 46, 17, 805, DateTimeKind.Utc).AddTicks(200), "HCM", true, null, "MICHAELC@GMAIL.COM", "MICHAELC", "AQAAAAIAAYagAAAAEJpDP/vr3p6p+oOpvn4r/SWg8TvqMJbKwSS48gUSRAaoHxI6PUQbEBXLEji45PLHOg==", null, false, "7cdf95f4-ecac-4c00-8a16-69f75b1580ef", "SD0024", false, "michaelc" },
                    { new Guid("27415b59-9f41-4fd6-ba2a-8199973e5e43"), 0, "8783ae55-824f-43de-a67b-bbf617817459", new DateTime(2024, 6, 26, 4, 46, 17, 35, DateTimeKind.Utc).AddTicks(3414), new DateTime(2003, 4, 17, 11, 46, 17, 35, DateTimeKind.Local).AddTicks(3400), "williamy@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 35, DateTimeKind.Local).AddTicks(3413), "Young", new DateTime(2024, 6, 26, 4, 46, 17, 35, DateTimeKind.Utc).AddTicks(3415), "HCM", true, null, "WILLIAMY@GMAIL.COM", "WILLIAMY", "AQAAAAIAAYagAAAAEDKI3eamTMo9PuWdgrkawN2gD91W6h8arobGugoK/LilrzxkEf7siWdNkSQjMPwXsA==", null, false, "df9728af-88e7-43e4-89ae-8cf0b8663564", "SD0011", false, "williamy" },
                    { new Guid("2abba0b9-d478-48c8-82a5-2b7a27a7280b"), 0, "d85ad535-5887-42e3-a724-4e69d833133e", new DateTime(2024, 6, 26, 4, 46, 17, 746, DateTimeKind.Utc).AddTicks(3185), new DateTime(2001, 1, 13, 11, 46, 17, 746, DateTimeKind.Local).AddTicks(3163), "danielr1@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 746, DateTimeKind.Local).AddTicks(3184), "Rodriguez", new DateTime(2024, 6, 26, 4, 46, 17, 746, DateTimeKind.Utc).AddTicks(3185), "HN", true, null, "DANIELR1@GMAIL.COM", "DANIELR1", "AQAAAAIAAYagAAAAEAI0nefCTxxZMHzvGHVDMDfAwcdMr6lCNv5R24mfnnLVs3UC9f68VjMzseu+tzOrGg==", null, false, "5ab82761-0ff7-4d2d-bd1d-19455a551137", "SD0023", false, "danielr1" },
                    { new Guid("31078880-f94b-42be-b1c1-47fcf29987fc"), 0, "907840ea-b206-465c-b6b0-2f8631cf5113", new DateTime(2024, 6, 26, 4, 46, 18, 918, DateTimeKind.Utc).AddTicks(6124), new DateTime(2001, 7, 23, 11, 46, 18, 918, DateTimeKind.Local).AddTicks(6105), "davidm1@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 918, DateTimeKind.Local).AddTicks(6123), "Miller", new DateTime(2024, 6, 26, 4, 46, 18, 918, DateTimeKind.Utc).AddTicks(6126), "HN", true, null, "DAVIDM1@GMAIL.COM", "DAVIDM1", "AQAAAAIAAYagAAAAENfbvNvC00/IeW9tnutllAWCLsMsIDaGEyaissyM0B0by2sXsGfjOCKZPHoltbT1bQ==", null, false, "c3ad2001-107e-4101-8225-2bb3c810da0c", "SD0043", false, "davidm1" },
                    { new Guid("327958e8-ad2c-417b-b64e-9067738bb545"), 0, "6420b0d1-e418-4293-8aae-1fcbcf6493e2", new DateTime(2024, 6, 26, 4, 46, 18, 801, DateTimeKind.Utc).AddTicks(4946), new DateTime(1997, 5, 26, 11, 46, 18, 801, DateTimeKind.Local).AddTicks(4940), "charlottec@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 801, DateTimeKind.Local).AddTicks(4945), "Clark", new DateTime(2024, 6, 26, 4, 46, 18, 801, DateTimeKind.Utc).AddTicks(4946), "HCM", true, null, "CHARLOTTEC@GMAIL.COM", "CHARLOTTEC", "AQAAAAIAAYagAAAAEAdDSpht+UJ1WwkUDLHnmnnvhFFnEsOI3HnYP86oUNajZJ+mR1D3bm2yvm5104BVSg==", null, false, "96c90ebc-c2b7-4403-a9de-9d5ab2bf9c97", "SD0041", false, "charlottec" },
                    { new Guid("402b9eed-63c0-4c78-9480-4138d6dea2cb"), 0, "6dc75c25-cce9-43ec-a07d-cf7360258294", new DateTime(2024, 6, 26, 4, 46, 19, 450, DateTimeKind.Utc).AddTicks(1194), new DateTime(1995, 11, 27, 11, 46, 19, 450, DateTimeKind.Local).AddTicks(1179), "alexanderj1@gmail.com", false, "Alexander", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 450, DateTimeKind.Local).AddTicks(1193), "Jones", new DateTime(2024, 6, 26, 4, 46, 19, 450, DateTimeKind.Utc).AddTicks(1194), "HN", true, null, "ALEXANDERJ1@GMAIL.COM", "ALEXANDERJ1", "AQAAAAIAAYagAAAAENsKxzfqSxHyf7Fs17kJUyC4qQ+Onpke78mbnKPYFOh1MpN+POhuYj6IAtpixDYiYA==", null, false, "dbfb2f6c-604d-418f-953a-aa9f796c9241", "SD0052", false, "alexanderj1" },
                    { new Guid("42bd2301-fc60-4a2a-91be-47f480f776de"), 0, "68dbeeb3-6967-40e9-ba9a-f66b0cdc3516", new DateTime(2024, 6, 26, 4, 46, 19, 211, DateTimeKind.Utc).AddTicks(9031), new DateTime(2004, 2, 26, 11, 46, 19, 211, DateTimeKind.Local).AddTicks(9014), "michaels1@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 211, DateTimeKind.Local).AddTicks(9030), "Smith", new DateTime(2024, 6, 26, 4, 46, 19, 211, DateTimeKind.Utc).AddTicks(9031), "HCM", true, null, "MICHAELS1@GMAIL.COM", "MICHAELS1", "AQAAAAIAAYagAAAAEOvPQS6MN0dDhRKjAXi20WFaWPZ40s8sL7U65AsI0dqfmIXGUe3qRXy1rne+701oHQ==", null, false, "e1b7b4d3-bb0a-46eb-9e8d-06287cf9988a", "SD0048", false, "michaels1" },
                    { new Guid("47145e66-e2eb-4f73-b1ef-7c1f2f586808"), 0, "cacb3559-ac95-4129-8352-1e552640e5fb", new DateTime(2024, 6, 26, 4, 46, 16, 600, DateTimeKind.Utc).AddTicks(5933), new DateTime(1997, 9, 9, 11, 46, 16, 600, DateTimeKind.Local).AddTicks(5918), "johnm@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 600, DateTimeKind.Local).AddTicks(5933), "Miller", new DateTime(2024, 6, 26, 4, 46, 16, 600, DateTimeKind.Utc).AddTicks(5934), "HN", true, null, "JOHNM@GMAIL.COM", "JOHNM", "AQAAAAIAAYagAAAAEAaElkDsV0Znr1A1Cl6RkTJ4AXQm8rFXXzqyASKcSfIh4lR1JapxCUyQoAylWJf5aw==", null, false, "3a65b183-8810-4587-8f4d-0cd1aaf43b7b", "SD0005", false, "johnm" },
                    { new Guid("496d798b-bf1e-4f66-8e43-d49b737fac1f"), 0, "c125ab5f-e539-488c-884f-3dc849383799", new DateTime(2024, 6, 26, 4, 46, 16, 409, DateTimeKind.Utc).AddTicks(8844), new DateTime(1998, 11, 14, 11, 46, 16, 409, DateTimeKind.Local).AddTicks(8824), "adminhn@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 409, DateTimeKind.Local).AddTicks(8844), "HN", new DateTime(2024, 6, 26, 4, 46, 16, 409, DateTimeKind.Utc).AddTicks(8845), "HN", true, null, "ADMINHN@GMAIL.COM", "ADMINHN", "AQAAAAIAAYagAAAAEL6fcYhxEHczv0SafDguDJHblJCVRylTrSMbm8zq2jEytHHISRvrorHGDBOBJ3CWFQ==", null, false, "46ba2a33-6e7d-468f-82ba-c75ab2033e35", "SD0002", false, "adminhn" },
                    { new Guid("4c6dd844-4062-4b80-bca7-b551824088d3"), 0, "7028280f-b8f8-45d1-85d0-c6271daa1ec1", new DateTime(2024, 6, 26, 4, 46, 17, 337, DateTimeKind.Utc).AddTicks(4849), new DateTime(2000, 8, 1, 11, 46, 17, 337, DateTimeKind.Local).AddTicks(4832), "charlottet@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 337, DateTimeKind.Local).AddTicks(4848), "Taylor", new DateTime(2024, 6, 26, 4, 46, 17, 337, DateTimeKind.Utc).AddTicks(4849), "HCM", true, null, "CHARLOTTET@GMAIL.COM", "CHARLOTTET", "AQAAAAIAAYagAAAAEI+Q7IXV/6y8iBe+QiccJfkiwNyz+2pPHXWOVg/4s+cFQZVtmNebT+18N4xwM4x+1A==", null, false, "e8bc0ae7-99c6-4001-a63a-bffa3cded15f", "SD0016", false, "charlottet" },
                    { new Guid("4f052c7d-c641-4038-8025-e62c6c907af4"), 0, "4754df98-1e41-4bf2-881e-540af25b83d9", new DateTime(2024, 6, 26, 4, 46, 19, 269, DateTimeKind.Utc).AddTicks(8357), new DateTime(1996, 3, 10, 11, 46, 19, 269, DateTimeKind.Local).AddTicks(8339), "williamw1@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 269, DateTimeKind.Local).AddTicks(8356), "White", new DateTime(2024, 6, 26, 4, 46, 19, 269, DateTimeKind.Utc).AddTicks(8357), "HCM", true, null, "WILLIAMW1@GMAIL.COM", "WILLIAMW1", "AQAAAAIAAYagAAAAEOnK2RdvzHsAK5PW7mmzhKUVnOMUhrf8Pk1lpUiQCChcIaDbSlDPhxkEsYfb3Dzjfw==", null, false, "47d78ce8-2c0d-44a6-8a9b-16701e37be68", "SD0049", false, "williamw1" },
                    { new Guid("55a92256-68ae-4f3e-968b-c22fe3aab90a"), 0, "d085f28b-aaa7-4f32-9656-da2f3b78566e", new DateTime(2024, 6, 26, 4, 46, 18, 39, DateTimeKind.Utc).AddTicks(8222), new DateTime(2000, 10, 5, 11, 46, 18, 39, DateTimeKind.Local).AddTicks(8214), "williamh@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 39, DateTimeKind.Local).AddTicks(8221), "Harris", new DateTime(2024, 6, 26, 4, 46, 18, 39, DateTimeKind.Utc).AddTicks(8222), "HN", true, null, "WILLIAMH@GMAIL.COM", "WILLIAMH", "AQAAAAIAAYagAAAAEID0+GnXglIZ49DiwH95Pe4zIlV378GzphhyY+z7zu8+t1hoqaoDmEUSVkyZsYuTOw==", null, false, "d9873a02-b651-42cc-9d4f-864bec5ea7db", "SD0028", false, "williamh" },
                    { new Guid("61fa02b5-4915-4e86-990c-85893183623a"), 0, "de0dd2ce-1d77-4d05-b74a-7e33137bf774", new DateTime(2024, 6, 26, 4, 46, 17, 220, DateTimeKind.Utc).AddTicks(1560), new DateTime(2002, 1, 9, 11, 46, 17, 220, DateTimeKind.Local).AddTicks(1552), "harperj@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 220, DateTimeKind.Local).AddTicks(1559), "Johnson", new DateTime(2024, 6, 26, 4, 46, 17, 220, DateTimeKind.Utc).AddTicks(1560), "HN", true, null, "HARPERJ@GMAIL.COM", "HARPERJ", "AQAAAAIAAYagAAAAEEaBDPcLQMdlfNZJopFW107YJSCz9f8igfTZGhe9DYcJiRG5KixFj2Usrurr9+O9fg==", null, false, "2c638bb6-1398-4aa7-a5f4-bd43fec0d9f1", "SD0014", false, "harperj" },
                    { new Guid("6802928d-0f02-4b72-8b43-1db24fc8b23f"), 0, "f7709b75-2646-4bdd-91ce-674739d85519", new DateTime(2024, 6, 26, 4, 46, 19, 329, DateTimeKind.Utc).AddTicks(6730), new DateTime(2003, 7, 23, 11, 46, 19, 329, DateTimeKind.Local).AddTicks(6717), "miat@gmail.com", false, "Mia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 329, DateTimeKind.Local).AddTicks(6729), "Thomas", new DateTime(2024, 6, 26, 4, 46, 19, 329, DateTimeKind.Utc).AddTicks(6731), "HCM", true, null, "MIAT@GMAIL.COM", "MIAT", "AQAAAAIAAYagAAAAEOx4zP99G/ks41GtRqUUSbsn3eOn2/BEpB4js2dPjAV25eKTpW/1lUKHNbD/e6pBow==", null, false, "d614889a-7d4d-47c4-b856-633cebbbcd0a", "SD0050", false, "miat" },
                    { new Guid("6b4a9dd6-3fd9-442c-9638-ea2c7799a86f"), 0, "1251c9c4-acb3-4a97-ac5d-9d984416dcae", new DateTime(2024, 6, 26, 4, 46, 17, 863, DateTimeKind.Utc).AddTicks(9479), new DateTime(2003, 4, 26, 11, 46, 17, 863, DateTimeKind.Local).AddTicks(9465), "michaelg@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 863, DateTimeKind.Local).AddTicks(9478), "Garcia", new DateTime(2024, 6, 26, 4, 46, 17, 863, DateTimeKind.Utc).AddTicks(9479), "HN", true, null, "MICHAELG@GMAIL.COM", "MICHAELG", "AQAAAAIAAYagAAAAEHPKF1mFpxm4DODx4OWEfGZsHfMBPGk00wJWSZtfBKGsEp9fsl1mtLkIFwKHMCMivQ==", null, false, "edbb20b4-b37a-4df2-b9b1-f88c804aac40", "SD0025", false, "michaelg" },
                    { new Guid("710ab883-57d4-43dc-958c-a7a03a418544"), 0, "5ee46835-160c-4151-a2aa-41a108fa33a7", new DateTime(2024, 6, 26, 4, 46, 18, 391, DateTimeKind.Utc).AddTicks(6520), new DateTime(1997, 5, 15, 11, 46, 18, 391, DateTimeKind.Local).AddTicks(6511), "oliviaw@gmail.com", false, "Olivia", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 391, DateTimeKind.Local).AddTicks(6519), "Wilson", new DateTime(2024, 6, 26, 4, 46, 18, 391, DateTimeKind.Utc).AddTicks(6522), "HCM", true, null, "OLIVIAW@GMAIL.COM", "OLIVIAW", "AQAAAAIAAYagAAAAEFJIOep38wYRGLoXs9BJBwDW9CLbtXWFxB4iK78Q7WKKR1tEcmvRqr5G3bQ1ZtOqFg==", null, false, "982b900c-85bb-4afb-8acb-86d0c1611350", "SD0034", false, "oliviaw" },
                    { new Guid("714e937a-fd40-4dc2-b363-108f68db4a24"), 0, "57c777f8-f8f6-4423-8357-2da3fa81b481", new DateTime(2024, 6, 26, 4, 46, 19, 94, DateTimeKind.Utc).AddTicks(5265), new DateTime(1995, 2, 19, 11, 46, 19, 94, DateTimeKind.Local).AddTicks(5252), "oliviah@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 94, DateTimeKind.Local).AddTicks(5265), "Harris", new DateTime(2024, 6, 26, 4, 46, 19, 94, DateTimeKind.Utc).AddTicks(5265), "HN", true, null, "OLIVIAH@GMAIL.COM", "OLIVIAH", "AQAAAAIAAYagAAAAEDVkVqWGhDZ3Z9lskXGjCv7JZ0aNUs33eJ6EFWWWJ0jjWczQoYE8vgFrtCXLfrtHlQ==", null, false, "d9f46848-a3c7-43bf-9dde-e95391af4134", "SD0046", false, "oliviah" },
                    { new Guid("72b48eee-21c3-48c7-9538-8c6b7f0ad746"), 0, "bee8e21e-5aec-41d6-86bc-d61fcbe03db7", new DateTime(2024, 6, 26, 4, 46, 18, 449, DateTimeKind.Utc).AddTicks(9563), new DateTime(1999, 6, 11, 11, 46, 18, 449, DateTimeKind.Local).AddTicks(9550), "evelynr@gmail.com", false, "Evelyn", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 449, DateTimeKind.Local).AddTicks(9562), "Rodriguez", new DateTime(2024, 6, 26, 4, 46, 18, 449, DateTimeKind.Utc).AddTicks(9563), "HCM", true, null, "EVELYNR@GMAIL.COM", "EVELYNR", "AQAAAAIAAYagAAAAENJDDgzjOMepswLiDtzlgTA53V74fXL5gHOas6ScC+Ec3XS2NeWl+PJjquZzag0jHQ==", null, false, "f0c11805-0b3f-42b7-84cc-489da0a2af32", "SD0035", false, "evelynr" },
                    { new Guid("78c1ef91-491a-4291-9bb5-1f23cac1c42d"), 0, "2292b892-6f6b-4b02-b6b4-961d417df2dd", new DateTime(2024, 6, 26, 4, 46, 18, 508, DateTimeKind.Utc).AddTicks(8004), new DateTime(1996, 12, 27, 11, 46, 18, 508, DateTimeKind.Local).AddTicks(7989), "ameliaw@gmail.com", false, "Amelia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 508, DateTimeKind.Local).AddTicks(8003), "Williams", new DateTime(2024, 6, 26, 4, 46, 18, 508, DateTimeKind.Utc).AddTicks(8004), "HN", true, null, "AMELIAW@GMAIL.COM", "AMELIAW", "AQAAAAIAAYagAAAAEB31BMy9CZf1XDDJ2cV4ViBCsCk46RFoQGa/wk7w0pIwxXHEQA7eJoXYvPa/d8Um1g==", null, false, "6237896e-9dc6-4957-90fe-5266fbadd4cf", "SD0036", false, "ameliaw" },
                    { new Guid("82f0c5f9-9a1c-4f95-8324-4e1eee010f91"), 0, "3af7f0a7-19a5-4253-9d42-6d8839ac2f67", new DateTime(2024, 6, 26, 4, 46, 19, 389, DateTimeKind.Utc).AddTicks(7589), new DateTime(2000, 3, 3, 11, 46, 19, 389, DateTimeKind.Local).AddTicks(7578), "miaj1@gmail.com", false, "Mia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 389, DateTimeKind.Local).AddTicks(7589), "Jackson", new DateTime(2024, 6, 26, 4, 46, 19, 389, DateTimeKind.Utc).AddTicks(7590), "HN", true, null, "MIAJ1@GMAIL.COM", "MIAJ1", "AQAAAAIAAYagAAAAEHFFIi6y1Qps7UkDEWDnAIErVe4zQked1UzIINM5YGUIEMBE3LCQLqRdE3gN4M0qBg==", null, false, "2fd5df2d-e8da-4287-b3a0-48e1a18375ce", "SD0051", false, "miaj1" },
                    { new Guid("8432a75b-e554-401c-8c92-e5b4a28862d3"), 0, "7f305e9e-38d6-492e-b8b1-ee242dab6061", new DateTime(2024, 6, 26, 4, 46, 16, 795, DateTimeKind.Utc).AddTicks(4963), new DateTime(1996, 11, 1, 11, 46, 16, 795, DateTimeKind.Local).AddTicks(4944), "avab@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 795, DateTimeKind.Local).AddTicks(4962), "Brown", new DateTime(2024, 6, 26, 4, 46, 16, 795, DateTimeKind.Utc).AddTicks(4963), "HCM", true, null, "AVAB@GMAIL.COM", "AVAB", "AQAAAAIAAYagAAAAEK/cob6Go1RvKi1f+RLK+uQGhPD19r3afskSG6S3/2vgcIovt8LSRCpml9aYYgWYwg==", null, false, "106a1cbb-107f-47cb-96e6-bfd40ad16e09", "SD0007", false, "avab" },
                    { new Guid("8925111b-5fce-4123-89f3-fdb05999f42c"), 0, "7b2aa9d6-d12a-4477-be83-280b78f1da3c", new DateTime(2024, 6, 26, 4, 46, 17, 395, DateTimeKind.Utc).AddTicks(9925), new DateTime(2002, 6, 10, 11, 46, 17, 395, DateTimeKind.Local).AddTicks(9914), "johnc@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 395, DateTimeKind.Local).AddTicks(9924), "Clark", new DateTime(2024, 6, 26, 4, 46, 17, 395, DateTimeKind.Utc).AddTicks(9925), "HN", true, null, "JOHNC@GMAIL.COM", "JOHNC", "AQAAAAIAAYagAAAAEKhY75GfqMujiDoqfr9RTAvfTsM6fi5/Qocl2Ts+2VpZOetuCm65zzO1VubN0vnBrg==", null, false, "1153fd04-62a4-4879-84f2-07edd704e49e", "SD0017", false, "johnc" },
                    { new Guid("90d63137-1b3b-4e43-bae5-0ebd797b83f9"), 0, "578a030b-22e4-4eb1-827d-2a6ba5aa0d78", new DateTime(2024, 6, 26, 4, 46, 16, 914, DateTimeKind.Utc).AddTicks(6172), new DateTime(2005, 6, 22, 11, 46, 16, 914, DateTimeKind.Local).AddTicks(6158), "davidj@gmail.com", false, "David", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 914, DateTimeKind.Local).AddTicks(6171), "Johnson", new DateTime(2024, 6, 26, 4, 46, 16, 914, DateTimeKind.Utc).AddTicks(6173), "HCM", true, null, "DAVIDJ@GMAIL.COM", "DAVIDJ", "AQAAAAIAAYagAAAAEJlPiWfvFj52k7UvZqudhBZ0rAOCQ1o/ValSD49kKt61olz3581FRBI7autqmm8a+w==", null, false, "49bb7135-a9a7-4a3b-9928-d85d7df7a98e", "SD0009", false, "davidj" },
                    { new Guid("93844e0b-faef-418e-89b8-3990ee492989"), 0, "9bbc5d1f-3553-4cb0-a610-fd5f8fd8dd45", new DateTime(2024, 6, 26, 4, 46, 18, 215, DateTimeKind.Utc).AddTicks(6126), new DateTime(2006, 2, 1, 11, 46, 18, 215, DateTimeKind.Local).AddTicks(6120), "elijaht@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 215, DateTimeKind.Local).AddTicks(6126), "Taylor", new DateTime(2024, 6, 26, 4, 46, 18, 215, DateTimeKind.Utc).AddTicks(6127), "HN", true, null, "ELIJAHT@GMAIL.COM", "ELIJAHT", "AQAAAAIAAYagAAAAEEi5VjSv1/NQ9awrjYsnpNhfpVZf7U6WOYqsf/MDrl5289TmHF79wIDcKph4uTnwnQ==", null, false, "3bdf29a8-2aef-485c-ab91-46a9f81b0dd7", "SD0031", false, "elijaht" },
                    { new Guid("957e78ba-c77d-45e4-a011-2826fa9fde0b"), 0, "28c5ccfa-8414-47d0-bc23-cd46f9662423", new DateTime(2024, 6, 26, 4, 46, 16, 350, DateTimeKind.Utc).AddTicks(3303), new DateTime(1997, 4, 16, 11, 46, 16, 350, DateTimeKind.Local).AddTicks(3289), "adminhcm@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 350, DateTimeKind.Local).AddTicks(3302), "HCM", new DateTime(2024, 6, 26, 4, 46, 16, 350, DateTimeKind.Utc).AddTicks(3303), "HCM", true, null, "ADMINHCM@GMAIL.COM", "ADMINHCM", "AQAAAAIAAYagAAAAEIbAKeKeTROe/URh05VsMJXEkr2Lgpny6Iats4fACzG8DijrADaoGnf1b2xWhKCfdw==", null, false, "84ef6ede-1dbb-4e02-85ac-4523b0de6f57", "SD0001", false, "adminhcm" },
                    { new Guid("9809bdfc-bcc0-4523-8bd5-162c53725cf0"), 0, "fb8ca45d-28f5-4baf-83a7-dbcf36865a51", new DateTime(2024, 6, 26, 4, 46, 16, 538, DateTimeKind.Utc).AddTicks(9554), new DateTime(1998, 9, 2, 11, 46, 16, 538, DateTimeKind.Local).AddTicks(9536), "staffhn@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 538, DateTimeKind.Local).AddTicks(9554), "HN", new DateTime(2024, 6, 26, 4, 46, 16, 538, DateTimeKind.Utc).AddTicks(9555), "HN", true, null, "STAFFHN@GMAIL.COM", "STAFFHN", "AQAAAAIAAYagAAAAEG0m7FWs3UTi8YFTZdMIiGM9YmJJtWm8+CjSs0X3XSIv4HyzyvFxZorOfaTbT+fj2A==", null, false, "887636e6-d965-43a6-aff7-78bfe4cdca7e", "SD0004", false, "staffhn" },
                    { new Guid("a1d289d4-ba1b-47b2-9963-9fb13ef37400"), 0, "acd3d92b-a905-4449-af4c-4ef3d5ec869e", new DateTime(2024, 6, 26, 4, 46, 19, 624, DateTimeKind.Utc).AddTicks(1797), new DateTime(1995, 11, 11, 11, 46, 19, 624, DateTimeKind.Local).AddTicks(1776), "emmay@gmail.com", false, "Emma", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 624, DateTimeKind.Local).AddTicks(1796), "Young", new DateTime(2024, 6, 26, 4, 46, 19, 624, DateTimeKind.Utc).AddTicks(1798), "HCM", true, null, "EMMAY@GMAIL.COM", "EMMAY", "AQAAAAIAAYagAAAAEGUymgsvXFU1/ayiP3DWSZVvM3cCWQkSWjHfBawPscH4z2ZwGL8zNXh8pKQeX8BHaw==", null, false, "c8537c6d-49c8-443e-8e3b-a61e430a22b7", "SD0055", false, "emmay" },
                    { new Guid("a2411634-c0d2-4583-8eb0-15357175819a"), 0, "46820c47-3856-453a-91f9-5109eeaa0b40", new DateTime(2024, 6, 26, 4, 46, 16, 470, DateTimeKind.Utc).AddTicks(3985), new DateTime(2005, 9, 24, 11, 46, 16, 470, DateTimeKind.Local).AddTicks(3967), "staffhcm@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 470, DateTimeKind.Local).AddTicks(3984), "HCM", new DateTime(2024, 6, 26, 4, 46, 16, 470, DateTimeKind.Utc).AddTicks(3985), "HCM", true, null, "STAFFHCM@GMAIL.COM", "STAFFHCM", "AQAAAAIAAYagAAAAEBeNLAMe9lOV8tYhqTlw8rLJFp9SpKVaqztJOPI/4NMJ9KMPE/xVIlUBqDRTfiTzlw==", null, false, "d1e84159-21f6-4054-9ba1-79fb13d286f1", "SD0003", false, "staffhcm" },
                    { new Guid("a3f5f0a8-f4cb-45fc-bb41-a51b68d14e14"), 0, "7220fb2d-7b1d-4d57-8af9-5e58a9b965a6", new DateTime(2024, 6, 26, 4, 46, 19, 681, DateTimeKind.Utc).AddTicks(3464), new DateTime(1997, 8, 19, 11, 46, 19, 681, DateTimeKind.Local).AddTicks(3456), "danielt@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 681, DateTimeKind.Local).AddTicks(3464), "Taylor", new DateTime(2024, 6, 26, 4, 46, 19, 681, DateTimeKind.Utc).AddTicks(3464), "HN", true, null, "DANIELT@GMAIL.COM", "DANIELT", "AQAAAAIAAYagAAAAEMPO+/yJMteAhoaQFqXLf9QayiYVk8BxCDCsrsv8rD2KTPhjCDMZoQNDrm+OnZpthQ==", null, false, "b5d8f73f-bb78-448e-bc21-405408dbd2cc", "SD0056", false, "danielt" },
                    { new Guid("a6a937b6-fd80-4b0b-8958-92434c2c6441"), 0, "2fb2531f-8159-43e7-96de-7c6823fe2ee4", new DateTime(2024, 6, 26, 4, 46, 17, 278, DateTimeKind.Utc).AddTicks(4113), new DateTime(1998, 7, 18, 11, 46, 17, 278, DateTimeKind.Local).AddTicks(4101), "jamesj@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 278, DateTimeKind.Local).AddTicks(4112), "Johnson", new DateTime(2024, 6, 26, 4, 46, 17, 278, DateTimeKind.Utc).AddTicks(4113), "HCM", true, null, "JAMESJ@GMAIL.COM", "JAMESJ", "AQAAAAIAAYagAAAAEFHvierjQiLoh4/nbJaXYZJuBfgcfvJk/v/PiI1Ay4L/wysxHX8AXwUdF7tbRBseew==", null, false, "4b82ab90-63e0-4123-aef4-9a5e2ce71712", "SD0015", false, "jamesj" },
                    { new Guid("acff3a06-fcae-42fc-a3c0-2e25f90a1f35"), 0, "62e381fd-f009-425c-b6d3-ff336ca5f1d6", new DateTime(2024, 6, 26, 4, 46, 18, 860, DateTimeKind.Utc).AddTicks(704), new DateTime(1999, 5, 7, 11, 46, 18, 860, DateTimeKind.Local).AddTicks(691), "josephw1@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 860, DateTimeKind.Local).AddTicks(699), "Williams", new DateTime(2024, 6, 26, 4, 46, 18, 860, DateTimeKind.Utc).AddTicks(705), "HN", true, null, "JOSEPHW1@GMAIL.COM", "JOSEPHW1", "AQAAAAIAAYagAAAAENp0SyboxqNfEMJd+Gb/9rqGb5HEQTaLdcXgZ4CR13Ph2J0dTiV7eDGqZxMqjbJ//w==", null, false, "fee0ff2b-713f-4d5c-a755-f9bd01f9a31c", "SD0042", false, "josephw1" },
                    { new Guid("ad02a5ed-fe5c-41c0-a0aa-be318fcb8c18"), 0, "0c5f8ae7-6acb-49eb-bf33-2129620e80ea", new DateTime(2024, 6, 26, 4, 46, 18, 157, DateTimeKind.Utc).AddTicks(1189), new DateTime(2002, 11, 11, 11, 46, 18, 157, DateTimeKind.Local).AddTicks(1182), "oliviaj1@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 157, DateTimeKind.Local).AddTicks(1189), "Johnson", new DateTime(2024, 6, 26, 4, 46, 18, 157, DateTimeKind.Utc).AddTicks(1189), "HCM", true, null, "OLIVIAJ1@GMAIL.COM", "OLIVIAJ1", "AQAAAAIAAYagAAAAEN0GSLJMvT8K2LLtNQ72VwvRz4y+JTZ0/Ads3UaERI7k0Ekqbv6p1VE6Une4ihnUXQ==", null, false, "ea70335b-7a07-47f9-b6c3-a014dffa0268", "SD0030", false, "oliviaj1" },
                    { new Guid("b08d0072-3adc-4f92-ba60-fa7af7ef33df"), 0, "843e820f-b6cf-481a-919f-1b8b418837ec", new DateTime(2024, 6, 26, 4, 46, 17, 629, DateTimeKind.Utc).AddTicks(821), new DateTime(2001, 6, 22, 11, 46, 17, 629, DateTimeKind.Local).AddTicks(817), "oliviaj@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 629, DateTimeKind.Local).AddTicks(821), "Jones", new DateTime(2024, 6, 26, 4, 46, 17, 629, DateTimeKind.Utc).AddTicks(822), "HN", true, null, "OLIVIAJ@GMAIL.COM", "OLIVIAJ", "AQAAAAIAAYagAAAAEGRGijBNYBfRWyRQq+5v/u/p7hlieo/FD4Q+wBfLc7ppecGHfCURxp82qvQxW6NRdA==", null, false, "ee8b2a6b-743d-4ae4-9ad5-cdb4a4305932", "SD0021", false, "oliviaj" },
                    { new Guid("b39ad638-5d86-43fb-8f2f-f388010c3ae9"), 0, "9aa07e34-0704-407e-9eb8-9fa4f9a37cb2", new DateTime(2024, 6, 26, 4, 46, 16, 718, DateTimeKind.Utc).AddTicks(6495), new DateTime(1996, 2, 6, 11, 46, 16, 718, DateTimeKind.Local).AddTicks(6467), "sophiah@gmail.com", false, "Sophia", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 718, DateTimeKind.Local).AddTicks(6494), "Harris", new DateTime(2024, 6, 26, 4, 46, 16, 718, DateTimeKind.Utc).AddTicks(6496), "HN", true, null, "SOPHIAH@GMAIL.COM", "SOPHIAH", "AQAAAAIAAYagAAAAEGa3Mik8CDcwCYI+RdFD0vEIbPsYGKb3pgvh4qcNo4u+tMdLe2+mKlwPCIFPQPeBtw==", null, false, "41c11eea-89da-4579-b2c2-e0b2cbb04ab0", "SD0006", false, "sophiah" },
                    { new Guid("b4f64fa9-ce89-4eb4-a8f3-8e15411ab0c2"), 0, "4575958d-5a82-478f-a623-85925c7f8972", new DateTime(2024, 6, 26, 4, 46, 18, 977, DateTimeKind.Utc).AddTicks(5794), new DateTime(1995, 2, 18, 11, 46, 18, 977, DateTimeKind.Local).AddTicks(5779), "michaelc1@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 977, DateTimeKind.Local).AddTicks(5794), "Clark", new DateTime(2024, 6, 26, 4, 46, 18, 977, DateTimeKind.Utc).AddTicks(5795), "HCM", true, null, "MICHAELC1@GMAIL.COM", "MICHAELC1", "AQAAAAIAAYagAAAAEMxxvTFyGBOdFYKsyB+c695/BbO2IQQ84gw4ooimaPex7WLBaPrNlkwGkrXrcZDE9w==", null, false, "fbd65348-6e96-4f09-a55d-b5137bc9a5ff", "SD0044", false, "michaelc1" },
                    { new Guid("b5258cca-f62f-4cbc-a47d-b13cf97268da"), 0, "0684356c-81f7-4193-9a9c-aa97fcbe2738", new DateTime(2024, 6, 26, 4, 46, 20, 26, DateTimeKind.Utc).AddTicks(4800), new DateTime(2002, 9, 14, 11, 46, 20, 26, DateTimeKind.Local).AddTicks(4785), "williams1@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 20, 26, DateTimeKind.Local).AddTicks(4799), "Smith", new DateTime(2024, 6, 26, 4, 46, 20, 26, DateTimeKind.Utc).AddTicks(4801), "HN", true, null, "WILLIAMS1@GMAIL.COM", "WILLIAMS1", "AQAAAAIAAYagAAAAECpoe6cZ2CW5XVPx6Oa6JzJ0MDUFSIb8zIjMCmF4b+pax2g011uLL0auMoszT9GDJg==", null, false, "ce03a2a7-71c6-4267-b204-bf1b4d9593d6", "SD0062", false, "williams1" },
                    { new Guid("c0f70aad-6e26-4ff7-ba66-c41fc4cd531c"), 0, "cbc3c743-b125-4c75-8eef-f76fb121dae4", new DateTime(2024, 6, 26, 4, 46, 18, 567, DateTimeKind.Utc).AddTicks(5972), new DateTime(2004, 9, 25, 11, 46, 18, 567, DateTimeKind.Local).AddTicks(5958), "danielm@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 567, DateTimeKind.Local).AddTicks(5971), "Miller", new DateTime(2024, 6, 26, 4, 46, 18, 567, DateTimeKind.Utc).AddTicks(5973), "HCM", true, null, "DANIELM@GMAIL.COM", "DANIELM", "AQAAAAIAAYagAAAAEHfarTY6UXOEFExBTNtmEJCvvSLIpvFCckFYuApLvZERyu38XXpMBMPZRVwkhiSqgA==", null, false, "23530771-ba22-46e8-b5d6-b4718b527032", "SD0037", false, "danielm" },
                    { new Guid("d20fc02a-bfc4-4847-a2c7-68cbe3556b59"), 0, "0caa6e67-7a13-4bad-aeec-4d1fc54f6016", new DateTime(2024, 6, 26, 4, 46, 19, 852, DateTimeKind.Utc).AddTicks(9818), new DateTime(2002, 8, 19, 11, 46, 19, 852, DateTimeKind.Local).AddTicks(9795), "charlottec1@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 852, DateTimeKind.Local).AddTicks(9818), "Clark", new DateTime(2024, 6, 26, 4, 46, 19, 852, DateTimeKind.Utc).AddTicks(9819), "HN", true, null, "CHARLOTTEC1@GMAIL.COM", "CHARLOTTEC1", "AQAAAAIAAYagAAAAEPnexR9uRO6Gnpsy9FJ3GsvEixJARk3lurRD6umwNsUcM+rKUie4WeGaFA3AvUIYUA==", null, false, "4d9039ab-a6d1-4c90-b2ea-74cb36fe1773", "SD0059", false, "charlottec1" },
                    { new Guid("d819bb0d-56f4-4c14-a28c-adc2a1695c0b"), 0, "b38d7a33-3d20-4468-9233-503e3076f39d", new DateTime(2024, 6, 26, 4, 46, 16, 855, DateTimeKind.Utc).AddTicks(4636), new DateTime(2003, 2, 6, 11, 46, 16, 855, DateTimeKind.Local).AddTicks(4612), "isabellac@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 16, 855, DateTimeKind.Local).AddTicks(4636), "Clark", new DateTime(2024, 6, 26, 4, 46, 16, 855, DateTimeKind.Utc).AddTicks(4637), "HCM", true, null, "ISABELLAC@GMAIL.COM", "ISABELLAC", "AQAAAAIAAYagAAAAEGL9QvPtTRW8pRa7c0xUnr4c+62vCz3hVoBSTczvBmDgs8tRpZuMyYyuXjyYZ+pbEg==", null, false, "7b98a03b-fa5d-42f0-bc7e-e3a846106511", "SD0008", false, "isabellac" },
                    { new Guid("d83ccd9c-1ee8-4bdf-9a93-855d320d0cae"), 0, "beaab486-b84b-40ec-9dd9-0c0dde0c680a", new DateTime(2024, 6, 26, 4, 46, 19, 910, DateTimeKind.Utc).AddTicks(6865), new DateTime(2005, 10, 2, 11, 46, 19, 910, DateTimeKind.Local).AddTicks(6856), "michaelw@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 910, DateTimeKind.Local).AddTicks(6865), "Wilson", new DateTime(2024, 6, 26, 4, 46, 19, 910, DateTimeKind.Utc).AddTicks(6866), "HCM", true, null, "MICHAELW@GMAIL.COM", "MICHAELW", "AQAAAAIAAYagAAAAENRbiywAPzpJUy1MlaTqZyRq25ywKp3uIHEQOZHoxywAEFlFcD6ajMbP/oOSfJT9LA==", null, false, "1fd0ec64-43c4-4838-8a1c-5cf1bb44c946", "SD0060", false, "michaelw" },
                    { new Guid("db9f6cb7-0292-40e4-9fbb-6c6cf283ba74"), 0, "afcf3a52-7d64-44d2-b27a-b93ac1a78d4b", new DateTime(2024, 6, 26, 4, 46, 19, 36, DateTimeKind.Utc).AddTicks(15), new DateTime(2003, 12, 12, 11, 46, 19, 36, DateTimeKind.Local).AddTicks(6), "michaelj1@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 36, DateTimeKind.Local).AddTicks(14), "Jackson", new DateTime(2024, 6, 26, 4, 46, 19, 36, DateTimeKind.Utc).AddTicks(16), "HN", true, null, "MICHAELJ1@GMAIL.COM", "MICHAELJ1", "AQAAAAIAAYagAAAAEOVSDiBiL45Rf6NJdAjood9DNvAIogp64NfHpyV+rOAzho3Qcqewac3K3SjKkNfZkA==", null, false, "5c170adb-8d37-43a5-87a9-69e50c4acd46", "SD0045", false, "michaelj1" },
                    { new Guid("deb7087d-1796-4eed-8ab9-a9d61bb7bcdf"), 0, "78ed6990-d629-4671-973e-cecdd83373be", new DateTime(2024, 6, 26, 4, 46, 17, 981, DateTimeKind.Utc).AddTicks(2303), new DateTime(1997, 1, 28, 11, 46, 17, 981, DateTimeKind.Local).AddTicks(2282), "harperm@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 981, DateTimeKind.Local).AddTicks(2302), "Miller", new DateTime(2024, 6, 26, 4, 46, 17, 981, DateTimeKind.Utc).AddTicks(2304), "HCM", true, null, "HARPERM@GMAIL.COM", "HARPERM", "AQAAAAIAAYagAAAAEFmUuwgnYYuPPTpQ3ymTZ+oX8jdcCYdqlNaNtTO3ZXndp+d/MJ0taBQFkGACubBb5A==", null, false, "2ea1f14e-c82f-431d-b354-7b3937ca0ad8", "SD0027", false, "harperm" },
                    { new Guid("e4f7217b-5376-420b-b6d1-edb2dd7e454b"), 0, "b98a4a30-5058-4fd9-84ff-187e8acf6d22", new DateTime(2024, 6, 26, 4, 46, 17, 454, DateTimeKind.Utc).AddTicks(5617), new DateTime(1995, 4, 14, 11, 46, 17, 454, DateTimeKind.Local).AddTicks(5600), "olivias@gmail.com", false, "Olivia", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 454, DateTimeKind.Local).AddTicks(5616), "Smith", new DateTime(2024, 6, 26, 4, 46, 17, 454, DateTimeKind.Utc).AddTicks(5617), "HCM", true, null, "OLIVIAS@GMAIL.COM", "OLIVIAS", "AQAAAAIAAYagAAAAECKTJA+kscv/3sRAfuHmbjJDOcYvq8SgmiDWcKnGmezR31HE9f3XIw2v+atA2PKn4Q==", null, false, "e6020214-54b0-4b52-bdbd-85cda6723d0b", "SD0018", false, "olivias" },
                    { new Guid("e6b99ee6-79bd-4e94-b605-777b04a4a4b7"), 0, "fd6ba45b-abd2-421a-8df8-2793939c09fa", new DateTime(2024, 6, 26, 4, 46, 17, 512, DateTimeKind.Utc).AddTicks(9001), new DateTime(2000, 2, 8, 11, 46, 17, 512, DateTimeKind.Local).AddTicks(8988), "isabellaj@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 512, DateTimeKind.Local).AddTicks(9001), "Jones", new DateTime(2024, 6, 26, 4, 46, 17, 512, DateTimeKind.Utc).AddTicks(9002), "HCM", true, null, "ISABELLAJ@GMAIL.COM", "ISABELLAJ", "AQAAAAIAAYagAAAAEEs9eUnZGI37An6CiICEL7QpC+ShzzVO5VnRReODBtYVcLZ8sjQtgyLI1GoUos8U6A==", null, false, "d3a7c900-98b0-4ab3-bd96-d5e2ee4bff0e", "SD0019", false, "isabellaj" },
                    { new Guid("e87d29b7-8ac8-4b1f-9df6-e7a678a17e8b"), 0, "9c688f19-ef73-40d8-9579-b73f9e9aae85", new DateTime(2024, 6, 26, 4, 46, 19, 968, DateTimeKind.Utc).AddTicks(9300), new DateTime(2001, 7, 19, 11, 46, 19, 968, DateTimeKind.Local).AddTicks(9282), "avaj@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 968, DateTimeKind.Local).AddTicks(9299), "Johnson", new DateTime(2024, 6, 26, 4, 46, 19, 968, DateTimeKind.Utc).AddTicks(9300), "HCM", true, null, "AVAJ@GMAIL.COM", "AVAJ", "AQAAAAIAAYagAAAAEP6fEIrnQlMrUH3YdDcyo7k4EPqeUO5mxB5WxF472a3w5b+6PW+LZs16uGU7k2+mkg==", null, false, "9cee90d7-0c3b-447c-9e13-f7f56d26e30e", "SD0061", false, "avaj" },
                    { new Guid("e8af5f75-15fa-4e85-a516-b32bfbb40642"), 0, "2e3acf03-40f3-496b-ba88-9fad2c6b7ba5", new DateTime(2024, 6, 26, 4, 46, 18, 274, DateTimeKind.Utc).AddTicks(2930), new DateTime(2000, 3, 3, 11, 46, 18, 274, DateTimeKind.Local).AddTicks(2920), "johnd@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 274, DateTimeKind.Local).AddTicks(2929), "Davis", new DateTime(2024, 6, 26, 4, 46, 18, 274, DateTimeKind.Utc).AddTicks(2931), "HCM", true, null, "JOHND@GMAIL.COM", "JOHND", "AQAAAAIAAYagAAAAECqYHBgf9yaG6IsVPbjexOSN2mSCy6n+RMLtrn182Cv1dO/4opVENBTBzM9YqGmWCg==", null, false, "aab823eb-eb28-49e9-b1ae-8e00b66cabf8", "SD0032", false, "johnd" },
                    { new Guid("e9f2870f-a466-4581-9fa5-33d99822b714"), 0, "6cdbcee0-8f47-4461-b2e4-357173ef6efc", new DateTime(2024, 6, 26, 4, 46, 19, 567, DateTimeKind.Utc).AddTicks(14), new DateTime(2003, 4, 29, 11, 46, 19, 567, DateTimeKind.Local).AddTicks(1), "benjaminj2@gmail.com", false, "Benjamin", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 567, DateTimeKind.Local).AddTicks(13), "Jackson", new DateTime(2024, 6, 26, 4, 46, 19, 567, DateTimeKind.Utc).AddTicks(15), "HN", true, null, "BENJAMINJ2@GMAIL.COM", "BENJAMINJ2", "AQAAAAIAAYagAAAAEHz6p3F06KImHmnS3Rf16NyWeP9NkzRTUzauchtQGLHtVl/yzONbddUPlRdc1eMkkg==", null, false, "8165a56d-ed9f-44fa-9fae-9053a5a8e813", "SD0054", false, "benjaminj2" },
                    { new Guid("e9f5406c-808a-4c5c-95d1-f327e6861abb"), 0, "42134645-e501-4ae9-b850-b0222ab4010f", new DateTime(2024, 6, 26, 4, 46, 17, 101, DateTimeKind.Utc).AddTicks(7386), new DateTime(1997, 10, 12, 11, 46, 17, 101, DateTimeKind.Local).AddTicks(7366), "sophiaj2@gmail.com", false, "Sophia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 17, 101, DateTimeKind.Local).AddTicks(7385), "Jones", new DateTime(2024, 6, 26, 4, 46, 17, 101, DateTimeKind.Utc).AddTicks(7387), "HN", true, null, "SOPHIAJ2@GMAIL.COM", "SOPHIAJ2", "AQAAAAIAAYagAAAAEGl7U77x809Or91at3rTnOpON1zHEkOT4LK0vChuj8XQyVed/PVYG5cgwvjCSL8cog==", null, false, "0407e39c-d7e1-4e2e-ba95-d5400c8320a7", "SD0012", false, "sophiaj2" },
                    { new Guid("ed409a65-1371-4cb1-98b0-6f2006e07216"), 0, "13d5df7b-f41e-401d-a81f-6bf9d5be632c", new DateTime(2024, 6, 26, 4, 46, 20, 84, DateTimeKind.Utc).AddTicks(4463), new DateTime(2004, 5, 3, 11, 46, 20, 84, DateTimeKind.Local).AddTicks(4439), "emmal@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 20, 84, DateTimeKind.Local).AddTicks(4462), "Lewis", new DateTime(2024, 6, 26, 4, 46, 20, 84, DateTimeKind.Utc).AddTicks(4464), "HCM", true, null, "EMMAL@GMAIL.COM", "EMMAL", "AQAAAAIAAYagAAAAEGQpUvT7VPL+FND6GtCfaviYmbYQz5dm132G83HpZswTFVNcO0jifouFxfy9IhXMAQ==", null, false, "7f27dc97-a8ff-47d4-811d-3cf427c1045a", "SD0063", false, "emmal" },
                    { new Guid("f2c60c11-2452-4628-b5e0-b241bf54e0e9"), 0, "2d9415c4-2917-4a1d-98e5-8a593e84a426", new DateTime(2024, 6, 26, 4, 46, 19, 738, DateTimeKind.Utc).AddTicks(2586), new DateTime(1998, 8, 19, 11, 46, 19, 738, DateTimeKind.Local).AddTicks(2580), "benjaming@gmail.com", false, "Benjamin", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 738, DateTimeKind.Local).AddTicks(2585), "Garcia", new DateTime(2024, 6, 26, 4, 46, 19, 738, DateTimeKind.Utc).AddTicks(2586), "HCM", true, null, "BENJAMING@GMAIL.COM", "BENJAMING", "AQAAAAIAAYagAAAAEO5gLd0nYjgNobEYdhRwr/DtCS7tg5eirxB9flKyD+iSQOr/56M2Ywgn1txiBALUvg==", null, false, "0cd0fcf9-e1d9-4e96-ad01-5a6dded232de", "SD0057", false, "benjaming" },
                    { new Guid("f83cbb85-9147-40a9-b881-1e49d123faed"), 0, "264324fc-5d94-40e8-b703-8e5977ba8036", new DateTime(2024, 6, 26, 4, 46, 18, 684, DateTimeKind.Utc).AddTicks(9776), new DateTime(2002, 2, 22, 11, 46, 18, 684, DateTimeKind.Local).AddTicks(9759), "evelynw1@gmail.com", false, "Evelyn", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 684, DateTimeKind.Local).AddTicks(9776), "Wilson", new DateTime(2024, 6, 26, 4, 46, 18, 684, DateTimeKind.Utc).AddTicks(9777), "HCM", true, null, "EVELYNW1@GMAIL.COM", "EVELYNW1", "AQAAAAIAAYagAAAAEIdcbiqeytCScfurMbbkIRqWhoH3lOG9yvKP8Z/+Cm6nLw6uJ1qMAG2mFGLG8S0U1Q==", null, false, "832ee891-f6a5-4420-8fcf-c6f3909034fc", "SD0039", false, "evelynw1" },
                    { new Guid("fca33a88-a37d-4873-8d2f-02c12aa377f3"), 0, "b02dea90-517b-48cc-acf3-54abc555e94e", new DateTime(2024, 6, 26, 4, 46, 18, 743, DateTimeKind.Utc).AddTicks(3949), new DateTime(1999, 9, 16, 11, 46, 18, 743, DateTimeKind.Local).AddTicks(3937), "sophiaw1@gmail.com", false, "Sophia", "Male", false, false, new DateTime(2024, 6, 26, 11, 46, 18, 743, DateTimeKind.Local).AddTicks(3949), "Wilson", new DateTime(2024, 6, 26, 4, 46, 18, 743, DateTimeKind.Utc).AddTicks(3951), "HCM", true, null, "SOPHIAW1@GMAIL.COM", "SOPHIAW1", "AQAAAAIAAYagAAAAEH5sntPyc+XIkw45J8l0UDqBKF0m39MLB92dc2EYaAZ8tdKZt/dmAeL7LjYppAbHKQ==", null, false, "d4c6db21-b4fb-43ca-a99d-1ae1415efdb0", "SD0040", false, "sophiaw1" },
                    { new Guid("ffb4f37e-01bc-4f62-ae0d-cadac80df4ec"), 0, "849393ca-74d3-40bb-ba54-39422fef5e70", new DateTime(2024, 6, 26, 4, 46, 19, 509, DateTimeKind.Utc).AddTicks(7837), new DateTime(2003, 8, 28, 11, 46, 19, 509, DateTimeKind.Local).AddTicks(7820), "michaelr2@gmail.com", false, "Michael", "Female", false, false, new DateTime(2024, 6, 26, 11, 46, 19, 509, DateTimeKind.Local).AddTicks(7836), "Rodriguez", new DateTime(2024, 6, 26, 4, 46, 19, 509, DateTimeKind.Utc).AddTicks(7837), "HCM", true, null, "MICHAELR2@GMAIL.COM", "MICHAELR2", "AQAAAAIAAYagAAAAEM7QhcSQk5AQrCE6tUBxmbZeedmXHp3YRvkoggF2IFCFPNJ4AJpEMMdZs8PoG18GQA==", null, false, "d399349b-228c-40a1-860c-b925fa7450ba", "SD0053", false, "michaelr2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("03d91902-9062-4325-bb30-643f2575ff43"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("0489f519-4748-4e81-a15f-4e2a2e0f9ae3"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("06dd70d1-e4c9-4101-b442-7de4f36b9554"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("09b6284f-33ee-40d2-907c-2fc862f0d8bd"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0b45399b-a3a1-4f5c-968d-6646c573cd36"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0cc00854-9a10-4b69-829b-b377f210c4fd"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1103c0f0-155e-427b-83d7-5fea6cb410ef"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1848d773-d2b9-41d5-beb0-30bce683ee39"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("18ce48a2-4009-4843-892b-fc51b7a9b8f8"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1fdb74ca-5c8d-40a4-83a6-80939d461d25"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("21bbb148-429e-49fd-ae9d-0e825da9ec99"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23e756fa-611e-4d0c-ae7a-1d8f14590b8c"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("27415b59-9f41-4fd6-ba2a-8199973e5e43"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2abba0b9-d478-48c8-82a5-2b7a27a7280b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("31078880-f94b-42be-b1c1-47fcf29987fc"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("327958e8-ad2c-417b-b64e-9067738bb545"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("402b9eed-63c0-4c78-9480-4138d6dea2cb"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("42bd2301-fc60-4a2a-91be-47f480f776de"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("47145e66-e2eb-4f73-b1ef-7c1f2f586808"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("496d798b-bf1e-4f66-8e43-d49b737fac1f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4c6dd844-4062-4b80-bca7-b551824088d3"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4f052c7d-c641-4038-8025-e62c6c907af4"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("55a92256-68ae-4f3e-968b-c22fe3aab90a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("61fa02b5-4915-4e86-990c-85893183623a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6802928d-0f02-4b72-8b43-1db24fc8b23f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6b4a9dd6-3fd9-442c-9638-ea2c7799a86f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("710ab883-57d4-43dc-958c-a7a03a418544"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("714e937a-fd40-4dc2-b363-108f68db4a24"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("72b48eee-21c3-48c7-9538-8c6b7f0ad746"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("78c1ef91-491a-4291-9bb5-1f23cac1c42d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("82f0c5f9-9a1c-4f95-8324-4e1eee010f91"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8432a75b-e554-401c-8c92-e5b4a28862d3"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8925111b-5fce-4123-89f3-fdb05999f42c"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("90d63137-1b3b-4e43-bae5-0ebd797b83f9"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("93844e0b-faef-418e-89b8-3990ee492989"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("957e78ba-c77d-45e4-a011-2826fa9fde0b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9809bdfc-bcc0-4523-8bd5-162c53725cf0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a1d289d4-ba1b-47b2-9963-9fb13ef37400"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a2411634-c0d2-4583-8eb0-15357175819a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a3f5f0a8-f4cb-45fc-bb41-a51b68d14e14"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6a937b6-fd80-4b0b-8958-92434c2c6441"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("acff3a06-fcae-42fc-a3c0-2e25f90a1f35"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ad02a5ed-fe5c-41c0-a0aa-be318fcb8c18"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b08d0072-3adc-4f92-ba60-fa7af7ef33df"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("b39ad638-5d86-43fb-8f2f-f388010c3ae9"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b4f64fa9-ce89-4eb4-a8f3-8e15411ab0c2"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("b5258cca-f62f-4cbc-a47d-b13cf97268da"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c0f70aad-6e26-4ff7-ba66-c41fc4cd531c"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d20fc02a-bfc4-4847-a2c7-68cbe3556b59"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("d819bb0d-56f4-4c14-a28c-adc2a1695c0b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d83ccd9c-1ee8-4bdf-9a93-855d320d0cae"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("db9f6cb7-0292-40e4-9fbb-6c6cf283ba74"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("deb7087d-1796-4eed-8ab9-a9d61bb7bcdf"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e4f7217b-5376-420b-b6d1-edb2dd7e454b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e6b99ee6-79bd-4e94-b605-777b04a4a4b7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e87d29b7-8ac8-4b1f-9df6-e7a678a17e8b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e8af5f75-15fa-4e85-a516-b32bfbb40642"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e9f2870f-a466-4581-9fa5-33d99822b714"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e9f5406c-808a-4c5c-95d1-f327e6861abb"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ed409a65-1371-4cb1-98b0-6f2006e07216"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f2c60c11-2452-4628-b5e0-b241bf54e0e9"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f83cbb85-9147-40a9-b881-1e49d123faed"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("fca33a88-a37d-4873-8d2f-02c12aa377f3"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ffb4f37e-01bc-4f62-ae0d-cadac80df4ec"), "UserRole" }
                });
        }
    }
}
