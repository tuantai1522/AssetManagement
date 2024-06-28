using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateAssetStateFieldToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00e78de3-db8a-4e72-aeb5-d29e5276a3ce"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("032bb307-7a2b-4f76-aa8b-ff3b883285da"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("0352e98d-d5af-463b-96b9-ab754197cfeb"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("05521fb9-7d80-4d4d-84a3-9924a99579fc"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("2bc64071-f80c-45fb-b1f4-5666e9d6d270"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("2ffa2b83-3909-4666-8e09-56a1fe3848ce"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("33a308f3-2b65-4ee0-9bdf-f9f5465c0675"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("34d4d806-1c48-4cf4-9b87-0b00f0d90727"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("3c5ed6eb-cddd-4884-bb91-e2ad1eb2d1c0"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("4135f4e3-1bb5-4ae5-8a80-3e29611c5803"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("43cc2a5c-24b9-48b6-b6d8-c6d4f79fa38d"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("4bf3c4a7-a69c-4898-a91a-50822b9c5d3f"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("56d4593e-fc69-4383-8d0b-bffec9ed952e"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("598c1e27-a31a-443f-9194-b2a5fa090f03"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("5b3d4936-e8ea-4660-bc6c-46a0e20ad954"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("5bc2ea39-d9e9-45f9-ad0a-4158507ceef3"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("5c5a3e05-ed01-4d09-aaaf-10ff06c451f4"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("646397b3-84d5-4197-a191-01413f575ce3"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6877f517-6fec-4938-bf99-e4014d774f50"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6c383b1c-f200-485e-8f1b-95e336d1cb74"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6e0764d8-5dd5-4fee-af8a-a0f10041faf4"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6fbe694c-7890-4b4a-87d3-c3c7a08dff0d"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("7b504e67-f53b-4242-9faf-4c6e3fcb61aa"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("7fb2515f-8a21-4137-ad4b-85509e30dafd"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("863ed79f-23b5-42da-a073-a8c5b0ff1cbd"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("8b323bc6-6b12-485e-8597-8855f8f145a1"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("90fad77b-c859-4c4a-83de-3f5917d447f0"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("9418119b-52e4-40d4-8d35-1f7d7d6288a0"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("98e6d058-ecc9-4a52-99fb-f88e6f71e92c"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("996474f2-30a6-4dc2-abd5-e6075ae99ef9"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a9ac9da1-2180-40e7-8e2f-00a21995e13e"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("aa7cbbb9-59e7-43f5-bd74-f12e6220b876"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b43bd63a-e500-4b42-b91f-ba2ad2f91287"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b5291e6e-518e-49cf-b0f2-5c72889be044"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b7914386-d0de-4e6a-8911-9d76e4309bac"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("c2d9d3b5-52ac-4a63-b950-a9d779fe39d3"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("c45fef63-ade5-4841-b093-0cd193120327"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("d08b5fe4-e519-4f48-9509-1f16f06c45c9"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("e2d07492-1774-4f8c-be25-0b6e41d9d9bd"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("eb437832-1509-4a18-b4c1-78213d77454f"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("eec8d16b-b8ad-4f55-a93c-e9e85c7004b5"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("f925bb2a-9e87-4cb6-bef2-5f41b863a187"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("f9e74102-b64d-4217-b4f3-1d1e7b1029f0"));

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

            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Asset",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("029db996-262c-4e07-8a19-644c09e0214a"), 0, "924cc52a-308e-4847-b96c-c6ece245b1cb", new DateTime(2024, 6, 27, 2, 27, 26, 615, DateTimeKind.Utc).AddTicks(7175), new DateTime(1996, 5, 14, 9, 27, 26, 615, DateTimeKind.Local).AddTicks(7154), "harperm@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 615, DateTimeKind.Local).AddTicks(7174), "Miller", new DateTime(2024, 6, 27, 2, 27, 26, 615, DateTimeKind.Utc).AddTicks(7175), "HN", true, null, "HARPERM@GMAIL.COM", "HARPERM", "AQAAAAIAAYagAAAAEJakScg2hK4ISNd4lTAQkqE+OuYXOcTW8xvFHlYe6NSLs7ie8dibegCKaRL1GnPDXw==", null, false, "fe70095f-2446-4696-8d9f-dfd4725f99c6", "SD0042", false, "harperm" },
                    { new Guid("03185a20-27c3-4e3a-88ae-1527d5cf70a1"), 0, "13108eab-fe9f-46df-bb40-d2c3be40c9f3", new DateTime(2024, 6, 27, 2, 27, 24, 45, DateTimeKind.Utc).AddTicks(9340), new DateTime(1996, 12, 29, 9, 27, 24, 45, DateTimeKind.Local).AddTicks(9319), "adminhn@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 45, DateTimeKind.Local).AddTicks(9339), "HN", new DateTime(2024, 6, 27, 2, 27, 24, 45, DateTimeKind.Utc).AddTicks(9341), "HN", true, null, "ADMINHN@GMAIL.COM", "ADMINHN", "AQAAAAIAAYagAAAAEGLtIzRRd4ufUeC3Y/v5TLl5d1NKzHtQ0t5/V9EBXZ1tuAeUbO8MJpqwLbXX1y6wBQ==", null, false, "9c0f0b95-6808-45d8-9238-a6e22dc4dc46", "SD0002", false, "adminhn" },
                    { new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da"), 0, "a099969d-de21-41d4-a438-6ea1be15b888", new DateTime(2024, 6, 27, 2, 27, 24, 110, DateTimeKind.Utc).AddTicks(3336), new DateTime(2004, 9, 1, 9, 27, 24, 110, DateTimeKind.Local).AddTicks(3324), "staffhcm@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 110, DateTimeKind.Local).AddTicks(3335), "HCM", new DateTime(2024, 6, 27, 2, 27, 24, 110, DateTimeKind.Utc).AddTicks(3336), "HCM", true, null, "STAFFHCM@GMAIL.COM", "STAFFHCM", "AQAAAAIAAYagAAAAEIsV9dMGpS01xogdA7pR/Re2J/jqPrerfY+HYgN+iJPV5VdzjR8FhVln/L0cTOFULg==", null, false, "58cc7292-dfb6-43e8-826c-e1407ce78c80", "SD0003", false, "staffhcm" },
                    { new Guid("151e3a0f-5cd2-48ad-ae50-783614f5d4ff"), 0, "8a5caa11-6bc4-434d-b5aa-8a4429924dd0", new DateTime(2024, 6, 27, 2, 27, 27, 776, DateTimeKind.Utc).AddTicks(292), new DateTime(2000, 11, 20, 9, 27, 27, 776, DateTimeKind.Local).AddTicks(264), "johnj@gmail.com", false, "John", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 776, DateTimeKind.Local).AddTicks(290), "Jones", new DateTime(2024, 6, 27, 2, 27, 27, 776, DateTimeKind.Utc).AddTicks(292), "HN", true, null, "JOHNJ@GMAIL.COM", "JOHNJ", "AQAAAAIAAYagAAAAEMealOpIJopVf+5N2u6GN37IRK6vq/oYVBjaEwaXPHH1bt2jLhkR5S37bjGx8/xKtQ==", null, false, "07b5b421-41bc-4305-acb1-70bf26915e47", "SD0060", false, "johnj" },
                    { new Guid("15a89e0f-ddbd-4ffe-acb4-087db1dc7e21"), 0, "67836d30-9de6-4a56-94ae-2ef30626dab0", new DateTime(2024, 6, 27, 2, 27, 25, 399, DateTimeKind.Utc).AddTicks(1842), new DateTime(1995, 9, 30, 9, 27, 25, 399, DateTimeKind.Local).AddTicks(1835), "johng@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 399, DateTimeKind.Local).AddTicks(1841), "Garcia", new DateTime(2024, 6, 27, 2, 27, 25, 399, DateTimeKind.Utc).AddTicks(1842), "HN", true, null, "JOHNG@GMAIL.COM", "JOHNG", "AQAAAAIAAYagAAAAECY3W0zK3uXuT5oTklvQEFelk2c1nKHbORKcmQvBr5Q4n8dEILPUz2TxHUwogpMQBg==", null, false, "79ebc1d2-6ce9-4564-bc42-e97fd4e6e8e6", "SD0023", false, "johng" },
                    { new Guid("16eb8729-b05d-41c0-bf0c-d45ee4b3d38e"), 0, "77eff323-cf9c-4d4b-b562-afcacd054fa8", new DateTime(2024, 6, 27, 2, 27, 25, 974, DateTimeKind.Utc).AddTicks(9482), new DateTime(2000, 11, 30, 9, 27, 25, 974, DateTimeKind.Local).AddTicks(9475), "sophiaa@gmail.com", false, "Sophia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 974, DateTimeKind.Local).AddTicks(9481), "Anderson", new DateTime(2024, 6, 27, 2, 27, 25, 974, DateTimeKind.Utc).AddTicks(9482), "HCM", true, null, "SOPHIAA@GMAIL.COM", "SOPHIAA", "AQAAAAIAAYagAAAAECv/RNwTqC+p95qWsvXrSqtHjAt8g8++Pjgqks/F3k+sQ51pxeMdCwTA3Vbru4SLAQ==", null, false, "71fc03a1-540c-48ad-b97f-d0b0b2ec14a5", "SD0032", false, "sophiaa" },
                    { new Guid("182ae763-6957-46a5-aa6e-88054b4bf786"), 0, "8c5a2c8f-84d1-459b-baf6-96fd055770c5", new DateTime(2024, 6, 27, 2, 27, 25, 272, DateTimeKind.Utc).AddTicks(155), new DateTime(2004, 7, 28, 9, 27, 25, 272, DateTimeKind.Local).AddTicks(145), "benjaminc@gmail.com", false, "Benjamin", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 272, DateTimeKind.Local).AddTicks(154), "Clark", new DateTime(2024, 6, 27, 2, 27, 25, 272, DateTimeKind.Utc).AddTicks(156), "HN", true, null, "BENJAMINC@GMAIL.COM", "BENJAMINC", "AQAAAAIAAYagAAAAEBGmCt6rynTkqbuKgtUvoGax0u/qtc7eERMVvD8AHtM1zEuODCNb2S0jNcXTaQhJbg==", null, false, "c3776674-15c1-48ba-bff4-c521d230acca", "SD0021", false, "benjaminc" },
                    { new Guid("18e23987-101a-45f8-b9bf-28577234acf5"), 0, "f3aa3337-0e5d-4124-91a6-2e801155f3ea", new DateTime(2024, 6, 27, 2, 27, 25, 591, DateTimeKind.Utc).AddTicks(7360), new DateTime(2003, 7, 27, 9, 27, 25, 591, DateTimeKind.Local).AddTicks(7339), "oliviaj@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 591, DateTimeKind.Local).AddTicks(7359), "Jones", new DateTime(2024, 6, 27, 2, 27, 25, 591, DateTimeKind.Utc).AddTicks(7360), "HCM", true, null, "OLIVIAJ@GMAIL.COM", "OLIVIAJ", "AQAAAAIAAYagAAAAEKWO62IP/CAnkng+lHahkEmTXe87qHr9DvdZU+U1LHoomzdyKOW/gy4uzJIBALqbUg==", null, false, "4f487d9b-b336-4ef9-beed-73f6140a7413", "SD0026", false, "oliviaj" },
                    { new Guid("1973d93f-8fd4-4d7f-b7db-fa8c921db220"), 0, "8c398e67-a6c2-4371-910f-d6457242ab13", new DateTime(2024, 6, 27, 2, 27, 24, 760, DateTimeKind.Utc).AddTicks(8179), new DateTime(1995, 7, 30, 9, 27, 24, 760, DateTimeKind.Local).AddTicks(8164), "miay@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 760, DateTimeKind.Local).AddTicks(8178), "Young", new DateTime(2024, 6, 27, 2, 27, 24, 760, DateTimeKind.Utc).AddTicks(8180), "HN", true, null, "MIAY@GMAIL.COM", "MIAY", "AQAAAAIAAYagAAAAEFmg3VFMRbvcPCd7sPTqFEVsP7+yuGtEEnvKwxJNoihaavPW1KMC6zmZKJsfWwomOg==", null, false, "fb40b8d7-3b05-4212-84b8-40912eaa6c66", "SD0013", false, "miay" },
                    { new Guid("19752558-bf20-48b1-a86a-c5918b15e33f"), 0, "66b689fd-a141-4824-819e-9dd822588297", new DateTime(2024, 6, 27, 2, 27, 26, 166, DateTimeKind.Utc).AddTicks(8821), new DateTime(2005, 3, 15, 9, 27, 26, 166, DateTimeKind.Local).AddTicks(8812), "avar@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 166, DateTimeKind.Local).AddTicks(8821), "Rodriguez", new DateTime(2024, 6, 27, 2, 27, 26, 166, DateTimeKind.Utc).AddTicks(8822), "HCM", true, null, "AVAR@GMAIL.COM", "AVAR", "AQAAAAIAAYagAAAAEGuAOBYtkdU0fx2em0k+KczZHPWQxObTK3XQFpYbAXXvde+6ObInwd9R2tBBEojf9A==", null, false, "3e113137-7a60-4f23-8074-4b7679953c97", "SD0035", false, "avar" },
                    { new Guid("1ad51d88-1bdc-4956-8343-adaac1d5cc22"), 0, "40ee0fa8-9b1c-4d91-bb72-cde61aee35bb", new DateTime(2024, 6, 27, 2, 27, 27, 969, DateTimeKind.Utc).AddTicks(6857), new DateTime(2006, 6, 30, 9, 27, 27, 969, DateTimeKind.Local).AddTicks(6835), "evelynw1@gmail.com", false, "Evelyn", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 969, DateTimeKind.Local).AddTicks(6856), "Williams", new DateTime(2024, 6, 27, 2, 27, 27, 969, DateTimeKind.Utc).AddTicks(6858), "HN", true, null, "EVELYNW1@GMAIL.COM", "EVELYNW1", "AQAAAAIAAYagAAAAEEqeDBRfArjVkliD5sNBAqNuGRetqSY56YurfOHKHOhX3hJGHOANf2XXq0HhCpT9Rg==", null, false, "8527e137-65aa-4b65-aae2-57fa53f34000", "SD0063", false, "evelynw1" },
                    { new Guid("23ec06cc-ba03-42b0-a8e4-99e6912a8e72"), 0, "993787a3-fb81-4860-87cf-d1c6dffc68ee", new DateTime(2024, 6, 27, 2, 27, 26, 550, DateTimeKind.Utc).AddTicks(8151), new DateTime(1999, 8, 8, 9, 27, 26, 550, DateTimeKind.Local).AddTicks(8145), "alexandert2@gmail.com", false, "Alexander", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 550, DateTimeKind.Local).AddTicks(8150), "Thomas", new DateTime(2024, 6, 27, 2, 27, 26, 550, DateTimeKind.Utc).AddTicks(8151), "HN", true, null, "ALEXANDERT2@GMAIL.COM", "ALEXANDERT2", "AQAAAAIAAYagAAAAEPjZtDC3QfSyTKu138eDxN0kMgVeeibzfF31/9tQlZWn3IAWGb9rI8cHIwq8tkxRrg==", null, false, "265fe28b-b940-424b-8f00-a634ead6dbe9", "SD0041", false, "alexandert2" },
                    { new Guid("2450bc08-8b39-41cf-90e9-7b10510c557e"), 0, "bc99cfb6-8eae-4186-9b8d-c84e79dc0026", new DateTime(2024, 6, 27, 2, 27, 27, 905, DateTimeKind.Utc).AddTicks(2761), new DateTime(1994, 10, 5, 9, 27, 27, 905, DateTimeKind.Local).AddTicks(2748), "johnj1@gmail.com", false, "John", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 905, DateTimeKind.Local).AddTicks(2760), "Johnson", new DateTime(2024, 6, 27, 2, 27, 27, 905, DateTimeKind.Utc).AddTicks(2761), "HN", true, null, "JOHNJ1@GMAIL.COM", "JOHNJ1", "AQAAAAIAAYagAAAAEBV+PdZSo1H7KjwqhSLyyzhWA7tF7iGMOv7608rkjH1bHXX9Rs3oKjqriXwIA6i3Sg==", null, false, "5fd83133-0dce-4cc7-8d29-40e1a42ec931", "SD0062", false, "johnj1" },
                    { new Guid("256a9cef-7479-4563-a104-8b310e16ffe0"), 0, "84223e43-edc8-43a7-9dcc-15b1b4f3f659", new DateTime(2024, 6, 27, 2, 27, 24, 887, DateTimeKind.Utc).AddTicks(9179), new DateTime(1998, 12, 1, 9, 27, 24, 887, DateTimeKind.Local).AddTicks(9173), "evelyny@gmail.com", false, "Evelyn", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 887, DateTimeKind.Local).AddTicks(9178), "Young", new DateTime(2024, 6, 27, 2, 27, 24, 887, DateTimeKind.Utc).AddTicks(9179), "HN", true, null, "EVELYNY@GMAIL.COM", "EVELYNY", "AQAAAAIAAYagAAAAEOjZ1bkXTEghDLRew00RvenXqaYzunHnykDRwC68d4fDMW86QDUmAegBqNSXgrCpRw==", null, false, "e9690fc5-a31b-4c62-a638-1417580fa852", "SD0015", false, "evelyny" },
                    { new Guid("2aa978c7-a92f-47be-9df2-c4acbe7f88b8"), 0, "4f8c6954-b319-4a09-a4e5-15453de81fca", new DateTime(2024, 6, 27, 2, 27, 27, 456, DateTimeKind.Utc).AddTicks(5592), new DateTime(1997, 4, 10, 9, 27, 27, 456, DateTimeKind.Local).AddTicks(5584), "josephr@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 456, DateTimeKind.Local).AddTicks(5592), "Rodriguez", new DateTime(2024, 6, 27, 2, 27, 27, 456, DateTimeKind.Utc).AddTicks(5593), "HCM", true, null, "JOSEPHR@GMAIL.COM", "JOSEPHR", "AQAAAAIAAYagAAAAEML6qQTdLbant97xNNa2gmcLRikbG2VHxRLA6FAzcpeFR9JQF0LisiqMQRmrpb38Mw==", null, false, "66236e07-73d7-4914-9710-16283818776e", "SD0055", false, "josephr" },
                    { new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), 0, "41ea4a44-6914-4cd5-ab23-440144a97e2c", new DateTime(2024, 6, 27, 2, 27, 24, 437, DateTimeKind.Utc).AddTicks(221), new DateTime(2000, 4, 1, 9, 27, 24, 437, DateTimeKind.Local).AddTicks(197), "oliviac@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 437, DateTimeKind.Local).AddTicks(219), "Clark", new DateTime(2024, 6, 27, 2, 27, 24, 437, DateTimeKind.Utc).AddTicks(221), "HN", true, null, "OLIVIAC@GMAIL.COM", "OLIVIAC", "AQAAAAIAAYagAAAAEGUa5pPxxQFxGb5cmTWomSOXPntNNXIleoAB3yHHFCt5R8Icj3Bc9zoZtZBRnG1nxw==", null, false, "4a5f57a5-5031-46b8-921e-93e5b4066e46", "SD0008", false, "oliviac" },
                    { new Guid("36de2dd1-8013-418b-bb93-aed2279b4f83"), 0, "4bdcdfd9-bae5-4280-a10a-0ae54cae17d9", new DateTime(2024, 6, 27, 2, 27, 25, 910, DateTimeKind.Utc).AddTicks(9140), new DateTime(1999, 1, 28, 9, 27, 25, 910, DateTimeKind.Local).AddTicks(9133), "jamesj@gmail.com", false, "James", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 910, DateTimeKind.Local).AddTicks(9139), "Jones", new DateTime(2024, 6, 27, 2, 27, 25, 910, DateTimeKind.Utc).AddTicks(9140), "HN", true, null, "JAMESJ@GMAIL.COM", "JAMESJ", "AQAAAAIAAYagAAAAEHkYawzm+xm8z2NITgrOJj0lHg6UDFKeUakC4WykEjxe9yJceCMjG2ODlQPymXyFtA==", null, false, "2e21ff73-08c0-4dfc-be2d-315d4e3ef488", "SD0031", false, "jamesj" },
                    { new Guid("375ce69b-6780-4c98-8072-23d9137e1802"), 0, "200780d3-6336-42ff-bc53-80b1d36367d2", new DateTime(2024, 6, 27, 2, 27, 26, 808, DateTimeKind.Utc).AddTicks(3484), new DateTime(2005, 2, 5, 9, 27, 26, 808, DateTimeKind.Local).AddTicks(3474), "williamw1@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 808, DateTimeKind.Local).AddTicks(3480), "Wilson", new DateTime(2024, 6, 27, 2, 27, 26, 808, DateTimeKind.Utc).AddTicks(3485), "HN", true, null, "WILLIAMW1@GMAIL.COM", "WILLIAMW1", "AQAAAAIAAYagAAAAENfMPmjMNA9rhvdSq5IcQXJMGrc+PpjTzQBDF/XHUNaHcfGdKUQln6KSD/xLMa9dbQ==", null, false, "4295e864-ccbb-4a72-a7ea-c880cd09393d", "SD0045", false, "williamw1" },
                    { new Guid("3b720de8-84cd-4533-91eb-67cce3583ade"), 0, "376a1bed-dfa3-41f6-9bc0-348c097cb014", new DateTime(2024, 6, 27, 2, 27, 27, 519, DateTimeKind.Utc).AddTicks(9765), new DateTime(1996, 2, 23, 9, 27, 27, 519, DateTimeKind.Local).AddTicks(9750), "sophias1@gmail.com", false, "Sophia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 519, DateTimeKind.Local).AddTicks(9765), "Smith", new DateTime(2024, 6, 27, 2, 27, 27, 519, DateTimeKind.Utc).AddTicks(9766), "HN", true, null, "SOPHIAS1@GMAIL.COM", "SOPHIAS1", "AQAAAAIAAYagAAAAEMa15QLGKHVVRQLDiObmsKpLnOSyBuq+7G1yEJCkkFny6w+dMDWRCMkKz6YfLVjLdQ==", null, false, "a7ba658d-6d73-4a5e-b81d-0fd63bf36a19", "SD0056", false, "sophias1" },
                    { new Guid("3cf8e11a-c23d-400a-ba32-bf62a7b35f8d"), 0, "62b133f9-ef1b-412e-a9a3-9e30a9a90eee", new DateTime(2024, 6, 27, 2, 27, 26, 936, DateTimeKind.Utc).AddTicks(5359), new DateTime(1998, 8, 28, 9, 27, 26, 936, DateTimeKind.Local).AddTicks(5349), "williamd@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 936, DateTimeKind.Local).AddTicks(5359), "Davis", new DateTime(2024, 6, 27, 2, 27, 26, 936, DateTimeKind.Utc).AddTicks(5360), "HCM", true, null, "WILLIAMD@GMAIL.COM", "WILLIAMD", "AQAAAAIAAYagAAAAECixTY+ymouJ0V1IiJA+BAqA17gRm6AFhHovJNsgyZWJFLaoFdnwAODDbHpTi6JOEA==", null, false, "8b2e219d-ddd0-4e2d-b6ae-95b97ea4a0ff", "SD0047", false, "williamd" },
                    { new Guid("3f6e59ca-2a0b-4ad1-8ad3-a67aa81f188b"), 0, "7a1f1301-08cc-47a1-b0f2-7f762f8e488e", new DateTime(2024, 6, 27, 2, 27, 27, 264, DateTimeKind.Utc).AddTicks(336), new DateTime(1995, 10, 7, 9, 27, 27, 264, DateTimeKind.Local).AddTicks(320), "ameliaj@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 264, DateTimeKind.Local).AddTicks(335), "Jones", new DateTime(2024, 6, 27, 2, 27, 27, 264, DateTimeKind.Utc).AddTicks(336), "HN", true, null, "AMELIAJ@GMAIL.COM", "AMELIAJ", "AQAAAAIAAYagAAAAEGFnkJ+vsXl0bFP2KoQkdt/vsm7LWz9ujzntxX4jn5iLEsddT/EF2Wxo7eKedgTmpw==", null, false, "d5eea9f2-2d32-41bf-b07c-f3c1f1ba7fa4", "SD0052", false, "ameliaj" },
                    { new Guid("4620d11d-4583-42d7-b579-41767c6b5923"), 0, "6c040b35-9b3a-4565-9d42-525a22df0c20", new DateTime(2024, 6, 27, 2, 27, 25, 847, DateTimeKind.Utc).AddTicks(2890), new DateTime(1994, 7, 17, 9, 27, 25, 847, DateTimeKind.Local).AddTicks(2877), "jamest@gmail.com", false, "James", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 847, DateTimeKind.Local).AddTicks(2889), "Taylor", new DateTime(2024, 6, 27, 2, 27, 25, 847, DateTimeKind.Utc).AddTicks(2890), "HN", true, null, "JAMEST@GMAIL.COM", "JAMEST", "AQAAAAIAAYagAAAAECasanqyXoLNyTxb3hp7zvFGfiIRnccWwFnio1Nf9XWel53xrwEBG/zRT72+ZbTEYw==", null, false, "9379277f-57f8-472a-a777-4775758a7ba4", "SD0030", false, "jamest" },
                    { new Guid("48bc2207-ec50-455d-99e4-990995f809e0"), 0, "240388b8-4a5d-440c-ad70-b8c79e601285", new DateTime(2024, 6, 27, 2, 27, 25, 208, DateTimeKind.Utc).AddTicks(4673), new DateTime(1997, 7, 24, 9, 27, 25, 208, DateTimeKind.Local).AddTicks(4667), "oliviaw@gmail.com", false, "Olivia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 208, DateTimeKind.Local).AddTicks(4672), "Williams", new DateTime(2024, 6, 27, 2, 27, 25, 208, DateTimeKind.Utc).AddTicks(4673), "HCM", true, null, "OLIVIAW@GMAIL.COM", "OLIVIAW", "AQAAAAIAAYagAAAAEMAQgnVjghmihUR1TbZahDICn6pnKkTGYU6G1iNc1R1BrlSw8DnXN2Bg2i3dX0mCCg==", null, false, "bd9926a8-4da1-41cf-8224-29ee95e34d53", "SD0020", false, "oliviaw" },
                    { new Guid("49b35fdc-f2be-4286-97f3-fc7e14e2082d"), 0, "c97f7ffc-75d3-416c-b9d7-ef4b61dc5308", new DateTime(2024, 6, 27, 2, 27, 26, 358, DateTimeKind.Utc).AddTicks(9394), new DateTime(1999, 12, 9, 9, 27, 26, 358, DateTimeKind.Local).AddTicks(9367), "williams@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 358, DateTimeKind.Local).AddTicks(9393), "Smith", new DateTime(2024, 6, 27, 2, 27, 26, 358, DateTimeKind.Utc).AddTicks(9395), "HCM", true, null, "WILLIAMS@GMAIL.COM", "WILLIAMS", "AQAAAAIAAYagAAAAENOYt9Uu9TW7PClU4j6iOOA/ttdAjxKQD1oXYQztJhfwMoyfF1xAjg4UW1CWodwl6w==", null, false, "21f09f95-1699-48bb-ac25-6b2e695c1e78", "SD0038", false, "williams" },
                    { new Guid("49c2b516-b12e-4dd8-ae2b-9027446f4b77"), 0, "1df35705-87c6-4fb7-9626-d2687c94407f", new DateTime(2024, 6, 27, 2, 27, 26, 423, DateTimeKind.Utc).AddTicks(1875), new DateTime(2000, 9, 22, 9, 27, 26, 423, DateTimeKind.Local).AddTicks(1864), "josepht@gmail.com", false, "Joseph", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 423, DateTimeKind.Local).AddTicks(1874), "Taylor", new DateTime(2024, 6, 27, 2, 27, 26, 423, DateTimeKind.Utc).AddTicks(1875), "HCM", true, null, "JOSEPHT@GMAIL.COM", "JOSEPHT", "AQAAAAIAAYagAAAAED+p7kWZZ9NFkVMRiJdhP8IkP3M0OZfFM0zyhd/2j7xWNAWr2Gg7mEkqu1pZGNDpJQ==", null, false, "5ce75081-918d-4267-8ce5-13540320b2d5", "SD0039", false, "josepht" },
                    { new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), 0, "893861d2-bbe4-4d75-86fa-b4eff0be477d", new DateTime(2024, 6, 27, 2, 27, 24, 696, DateTimeKind.Utc).AddTicks(2894), new DateTime(2003, 9, 28, 9, 27, 24, 696, DateTimeKind.Local).AddTicks(2884), "danielw@gmail.com", false, "Daniel", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 696, DateTimeKind.Local).AddTicks(2893), "White", new DateTime(2024, 6, 27, 2, 27, 24, 696, DateTimeKind.Utc).AddTicks(2895), "HCM", true, null, "DANIELW@GMAIL.COM", "DANIELW", "AQAAAAIAAYagAAAAEHb6tZCKSAe6XLQjw4f3QGpn42jyKSYUyqYfaUpTPPcLKqjkf1r2Qmd0Gq5kYSMloQ==", null, false, "d4f8dd49-9534-456d-a72c-f67ccf4ed15a", "SD0012", false, "danielw" },
                    { new Guid("4dbc897b-1395-4263-a0be-e590434c67c2"), 0, "0e4b4e15-e97a-4117-a093-a40fdf5510bb", new DateTime(2024, 6, 27, 2, 27, 26, 39, DateTimeKind.Utc).AddTicks(4351), new DateTime(2006, 5, 27, 9, 27, 26, 39, DateTimeKind.Local).AddTicks(4342), "evelynm1@gmail.com", false, "Evelyn", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 39, DateTimeKind.Local).AddTicks(4350), "Martinez", new DateTime(2024, 6, 27, 2, 27, 26, 39, DateTimeKind.Utc).AddTicks(4351), "HCM", true, null, "EVELYNM1@GMAIL.COM", "EVELYNM1", "AQAAAAIAAYagAAAAEGARM0VY8+lw2ZsTucFmKwdAcVd7mlaYvNPAHaK2Z75wyFCAV8xY1I6P8N0j1qZeWA==", null, false, "fd72a0f4-f846-4b99-900b-218c4fa273a8", "SD0033", false, "evelynm1" },
                    { new Guid("5712562b-e4f7-4279-ab8c-f4a5c8c3002d"), 0, "224e0821-93c7-4922-8a5a-cfb4ca0563a3", new DateTime(2024, 6, 27, 2, 27, 23, 981, DateTimeKind.Utc).AddTicks(2512), new DateTime(1994, 8, 11, 9, 27, 23, 981, DateTimeKind.Local).AddTicks(2493), "adminhcm@gmail.com", false, "Admin", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 23, 981, DateTimeKind.Local).AddTicks(2511), "HCM", new DateTime(2024, 6, 27, 2, 27, 23, 981, DateTimeKind.Utc).AddTicks(2512), "HCM", true, null, "ADMINHCM@GMAIL.COM", "ADMINHCM", "AQAAAAIAAYagAAAAEGPr8GqcRbuQqmQPYJkICsgydJ7yITnXgJkaA08DwgGmUfvhMddt9diysFsYPGO7Hg==", null, false, "7c690a9f-f673-4b43-b0fa-f59686d15bad", "SD0001", false, "adminhcm" },
                    { new Guid("59339cda-7d6d-4cbf-833c-367d7db965e1"), 0, "a036ba7f-bf2b-4a07-8544-b4d4f4e4e2f2", new DateTime(2024, 6, 27, 2, 27, 28, 33, DateTimeKind.Utc).AddTicks(9686), new DateTime(2001, 1, 17, 9, 27, 28, 33, DateTimeKind.Local).AddTicks(9680), "ameliab@gmail.com", false, "Amelia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 28, 33, DateTimeKind.Local).AddTicks(9685), "Brown", new DateTime(2024, 6, 27, 2, 27, 28, 33, DateTimeKind.Utc).AddTicks(9686), "HCM", true, null, "AMELIAB@GMAIL.COM", "AMELIAB", "AQAAAAIAAYagAAAAENRQZSyCH6wvmL9tKeSzzDCK2Oy5DOnzOiKhFYh8tECb+/ofO7YRYZXvH4SsHzDbUw==", null, false, "cd805b07-3d76-4aa6-9050-e0acac079bb6", "SD0064", false, "ameliab" },
                    { new Guid("5a1c0199-f674-408d-84fe-37e2a890d93b"), 0, "918afa1c-64b9-4ab0-b0a9-76ab180caa38", new DateTime(2024, 6, 27, 2, 27, 25, 144, DateTimeKind.Utc).AddTicks(6971), new DateTime(2005, 12, 20, 9, 27, 25, 144, DateTimeKind.Local).AddTicks(6964), "charlottew@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 144, DateTimeKind.Local).AddTicks(6970), "Wilson", new DateTime(2024, 6, 27, 2, 27, 25, 144, DateTimeKind.Utc).AddTicks(6971), "HCM", true, null, "CHARLOTTEW@GMAIL.COM", "CHARLOTTEW", "AQAAAAIAAYagAAAAEEn8i54LC0xD27ztANS2coS1rjjKU9FiQB/Qi02/UOA+76IA2g1rBFQ9SZ6bkoOvPA==", null, false, "07ebf679-849d-46d3-8aaa-25f38305f966", "SD0019", false, "charlottew" },
                    { new Guid("60c17fcb-178e-4181-ad50-3690524f5190"), 0, "44f28477-abb2-4bcc-acbc-6cb3b326c851", new DateTime(2024, 6, 27, 2, 27, 26, 103, DateTimeKind.Utc).AddTicks(2880), new DateTime(2002, 9, 13, 9, 27, 26, 103, DateTimeKind.Local).AddTicks(2863), "sophiaw@gmail.com", false, "Sophia", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 103, DateTimeKind.Local).AddTicks(2879), "Williams", new DateTime(2024, 6, 27, 2, 27, 26, 103, DateTimeKind.Utc).AddTicks(2880), "HCM", true, null, "SOPHIAW@GMAIL.COM", "SOPHIAW", "AQAAAAIAAYagAAAAELAK07NSxDmeu50Kl8cM4XUamr90p+sDM7E1PXQ5KgczwVM/6e2sSGfjHqAWMnwYNQ==", null, false, "75808725-da7f-40ad-a989-e271e209587f", "SD0034", false, "sophiaw" },
                    { new Guid("6b360b9c-bb2d-4783-9d49-ca224f7ac790"), 0, "1dc52a95-9818-4b8f-946c-68362d1c9fa7", new DateTime(2024, 6, 27, 2, 27, 24, 502, DateTimeKind.Utc).AddTicks(5970), new DateTime(1997, 4, 22, 9, 27, 24, 502, DateTimeKind.Local).AddTicks(5948), "elijahb@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 502, DateTimeKind.Local).AddTicks(5969), "Brown", new DateTime(2024, 6, 27, 2, 27, 24, 502, DateTimeKind.Utc).AddTicks(5970), "HN", true, null, "ELIJAHB@GMAIL.COM", "ELIJAHB", "AQAAAAIAAYagAAAAEJ5d2tc+GErrxHFNGwwwaxXZtRRrVo5+OvmKiSCuSPZdaioLoHUmKjb9jvNVnTmNBQ==", null, false, "a3bd332f-c6a7-4b12-beca-b3176ba1df8e", "SD0009", false, "elijahb" },
                    { new Guid("6d961aa5-8577-420d-9313-203567e1602b"), 0, "38b17e83-5530-48ee-ab0a-740d32d08f22", new DateTime(2024, 6, 27, 2, 27, 26, 872, DateTimeKind.Utc).AddTicks(5461), new DateTime(1999, 6, 6, 9, 27, 26, 872, DateTimeKind.Local).AddTicks(5452), "avat1@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 872, DateTimeKind.Local).AddTicks(5460), "Thomas", new DateTime(2024, 6, 27, 2, 27, 26, 872, DateTimeKind.Utc).AddTicks(5462), "HCM", true, null, "AVAT1@GMAIL.COM", "AVAT1", "AQAAAAIAAYagAAAAEIOhRSGsWyGdI7ikb0AlPhcYkpPg6qXnW/yUYPpxH2Owt7jZceU5X2UvSMulPU+LQQ==", null, false, "87ea4625-033f-4461-ae5c-6bf044d78ed1", "SD0046", false, "avat1" },
                    { new Guid("7750cb4f-a326-4961-8a51-563d809cb92d"), 0, "73098928-7013-4b96-8e4e-ed489287653f", new DateTime(2024, 6, 27, 2, 27, 27, 328, DateTimeKind.Utc).AddTicks(2856), new DateTime(1996, 6, 2, 9, 27, 27, 328, DateTimeKind.Local).AddTicks(2849), "miag@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 328, DateTimeKind.Local).AddTicks(2856), "Garcia", new DateTime(2024, 6, 27, 2, 27, 27, 328, DateTimeKind.Utc).AddTicks(2857), "HN", true, null, "MIAG@GMAIL.COM", "MIAG", "AQAAAAIAAYagAAAAEDGWgxM1Fhm6gCsDTjpYHsix7DfwAESnbplSSLy9MnHOGSSSedWYU7W6SyHhamT90A==", null, false, "45eae249-3382-435f-bc68-8b2eb46cd54b", "SD0053", false, "miag" },
                    { new Guid("7b6b2681-ee20-4d4b-9f27-ab0a7d4d61c7"), 0, "bb53a906-daa0-4dd1-a053-d179378552f0", new DateTime(2024, 6, 27, 2, 27, 27, 840, DateTimeKind.Utc).AddTicks(6783), new DateTime(1998, 3, 19, 9, 27, 27, 840, DateTimeKind.Local).AddTicks(6765), "miaj@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 840, DateTimeKind.Local).AddTicks(6781), "Johnson", new DateTime(2024, 6, 27, 2, 27, 27, 840, DateTimeKind.Utc).AddTicks(6783), "HN", true, null, "MIAJ@GMAIL.COM", "MIAJ", "AQAAAAIAAYagAAAAEGJRXTCSW5cpXk947Lc0ZTewpJbLM9ASg1O7GSno4Zs6Vw2dTf000xhy+drrjojnEg==", null, false, "166824fc-ffea-4d90-acfa-9770887db031", "SD0061", false, "miaj" },
                    { new Guid("7b9b9e92-9d83-4b1f-ae46-c9b73b9ac6b3"), 0, "226f1125-b483-48e8-bb90-cc965cb0ccfe", new DateTime(2024, 6, 27, 2, 27, 26, 230, DateTimeKind.Utc).AddTicks(3543), new DateTime(2002, 2, 8, 9, 27, 26, 230, DateTimeKind.Local).AddTicks(3529), "michaelj@gmail.com", false, "Michael", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 230, DateTimeKind.Local).AddTicks(3542), "Jackson", new DateTime(2024, 6, 27, 2, 27, 26, 230, DateTimeKind.Utc).AddTicks(3543), "HN", true, null, "MICHAELJ@GMAIL.COM", "MICHAELJ", "AQAAAAIAAYagAAAAED/r7zxXGBEh2I+pWGovxXbzPsk9Cmtz1nGgxoOf7IysmiD/yDwzA7uD6hl7lCbSmw==", null, false, "0dbe8171-663d-48ea-8095-7d281caa57ed", "SD0036", false, "michaelj" },
                    { new Guid("7d92b859-fe2a-4830-9a82-b40ffce97c71"), 0, "75c1f000-b948-4989-aa7b-134bbc5e02cc", new DateTime(2024, 6, 27, 2, 27, 24, 824, DateTimeKind.Utc).AddTicks(5240), new DateTime(2002, 10, 14, 9, 27, 24, 824, DateTimeKind.Local).AddTicks(5226), "miaw@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 824, DateTimeKind.Local).AddTicks(5239), "Wilson", new DateTime(2024, 6, 27, 2, 27, 24, 824, DateTimeKind.Utc).AddTicks(5241), "HN", true, null, "MIAW@GMAIL.COM", "MIAW", "AQAAAAIAAYagAAAAEBbn0HgVEQKBfOj85jNeuXOMtabkGAazFewmDqbxYJjyz1C94ao5st4+ZmubDY7fcQ==", null, false, "140a8936-4c89-44ed-8284-717ba4257a95", "SD0014", false, "miaw" },
                    { new Guid("8254443a-3481-4ba1-86a6-f86a1b9e440b"), 0, "f422ba39-0a76-4d9e-9a76-a0f4f47062db", new DateTime(2024, 6, 27, 2, 27, 25, 80, DateTimeKind.Utc).AddTicks(5111), new DateTime(2003, 9, 15, 9, 27, 25, 80, DateTimeKind.Local).AddTicks(5094), "isabellab@gmail.com", false, "Isabella", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 80, DateTimeKind.Local).AddTicks(5110), "Brown", new DateTime(2024, 6, 27, 2, 27, 25, 80, DateTimeKind.Utc).AddTicks(5111), "HN", true, null, "ISABELLAB@GMAIL.COM", "ISABELLAB", "AQAAAAIAAYagAAAAEA4b0I2WO47+uv4n4UGe9WTBPQjkYbChH6EDUYbok1kPE6XfqBqQMY8uIYMqfkPIYA==", null, false, "4f3a4928-5205-4cad-8277-c2496b206e2d", "SD0018", false, "isabellab" },
                    { new Guid("8627fb23-8914-494c-85fa-e9b9fca43282"), 0, "dba0273b-2d50-4ce8-aaea-79b59c5c2b5e", new DateTime(2024, 6, 27, 2, 27, 24, 631, DateTimeKind.Utc).AddTicks(8452), new DateTime(2004, 4, 10, 9, 27, 24, 631, DateTimeKind.Local).AddTicks(8432), "johnm1@gmail.com", false, "John", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 631, DateTimeKind.Local).AddTicks(8451), "Miller", new DateTime(2024, 6, 27, 2, 27, 24, 631, DateTimeKind.Utc).AddTicks(8453), "HCM", true, null, "JOHNM1@GMAIL.COM", "JOHNM1", "AQAAAAIAAYagAAAAEG1aWTpcX/iA0ZXE/c7MdngIa1edq1uPlb7xF88wBHeB85Z047g9RwZ0pgFPSOYdIA==", null, false, "b4809c45-64a2-47e0-9aee-237fe458182c", "SD0011", false, "johnm1" },
                    { new Guid("880958e1-7efa-4d7f-87b7-eae08b5c516d"), 0, "9250c4c7-9518-411d-9101-59d85abe923b", new DateTime(2024, 6, 27, 2, 27, 24, 175, DateTimeKind.Utc).AddTicks(1781), new DateTime(2004, 6, 19, 9, 27, 24, 175, DateTimeKind.Local).AddTicks(1752), "staffhn@gmail.com", false, "Staff", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 175, DateTimeKind.Local).AddTicks(1780), "HN", new DateTime(2024, 6, 27, 2, 27, 24, 175, DateTimeKind.Utc).AddTicks(1782), "HN", true, null, "STAFFHN@GMAIL.COM", "STAFFHN", "AQAAAAIAAYagAAAAEIUXOFRWdQm7vKrTKiUdDyZ2OYIzBJFQRdt++lJ683H5qOmeWehsXoLND+BUbGrDsA==", null, false, "290ecf92-e93f-4590-bc5d-95aba8ff4bb3", "SD0004", false, "staffhn" },
                    { new Guid("8e19aca1-35ef-45b8-bab3-d65b04b179d0"), 0, "65a61d26-2bc6-420a-aefd-fe313cb4e4f2", new DateTime(2024, 6, 27, 2, 27, 26, 487, DateTimeKind.Utc).AddTicks(3340), new DateTime(2000, 4, 21, 9, 27, 26, 487, DateTimeKind.Local).AddTicks(3334), "emmad@gmail.com", false, "Emma", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 487, DateTimeKind.Local).AddTicks(3339), "Davis", new DateTime(2024, 6, 27, 2, 27, 26, 487, DateTimeKind.Utc).AddTicks(3340), "HCM", true, null, "EMMAD@GMAIL.COM", "EMMAD", "AQAAAAIAAYagAAAAEKdpxqloCq2wb1tTS5+jYR7FHNI8QdykBWCBSGUG3P+9AtBfBqOekuML9xSmauGS1w==", null, false, "00fb0bde-9510-4e75-8593-1c49b7b985f8", "SD0040", false, "emmad" },
                    { new Guid("97bb2876-1bc4-4d19-9bc4-3c7f36de568a"), 0, "7acc90bf-514a-472e-adfb-644bebbf7cf1", new DateTime(2024, 6, 27, 2, 27, 27, 648, DateTimeKind.Utc).AddTicks(737), new DateTime(1995, 7, 10, 9, 27, 27, 648, DateTimeKind.Local).AddTicks(731), "sophiaw1@gmail.com", false, "Sophia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 648, DateTimeKind.Local).AddTicks(736), "Wilson", new DateTime(2024, 6, 27, 2, 27, 27, 648, DateTimeKind.Utc).AddTicks(737), "HN", true, null, "SOPHIAW1@GMAIL.COM", "SOPHIAW1", "AQAAAAIAAYagAAAAEA4eyeb90XEsDy9P0+MJ6o86/d0HN84kq+lExsVW2mEc6grzEHVeNFFJ0CZRLzkGSg==", null, false, "d59b884d-044f-4816-bcad-576e51ead4eb", "SD0058", false, "sophiaw1" },
                    { new Guid("a0722e9f-e18b-4f65-a7d5-a1fb6ba6046e"), 0, "653a0cec-c9d6-4ba5-9994-51846a86c9b3", new DateTime(2024, 6, 27, 2, 27, 24, 305, DateTimeKind.Utc).AddTicks(8313), new DateTime(2002, 5, 1, 9, 27, 24, 305, DateTimeKind.Local).AddTicks(8290), "ameliat1@gmail.com", false, "Amelia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 305, DateTimeKind.Local).AddTicks(8312), "Thomas", new DateTime(2024, 6, 27, 2, 27, 24, 305, DateTimeKind.Utc).AddTicks(8314), "HN", true, null, "AMELIAT1@GMAIL.COM", "AMELIAT1", "AQAAAAIAAYagAAAAEB3QkN/xgrhMUnaSaEPoiFrAUv9iRzEuvKXDfgoWvYmtzNCstaRUOB3VkvFLRVEfig==", null, false, "bc97cde3-2aaa-4bf6-9273-1b4213fdfc7c", "SD0006", false, "ameliat1" },
                    { new Guid("a6eff315-6326-413b-bfe1-aa150eed7dd7"), 0, "2dd69338-49d7-470d-a53e-aaee7138f37e", new DateTime(2024, 6, 27, 2, 27, 27, 583, DateTimeKind.Utc).AddTicks(9750), new DateTime(2006, 6, 12, 9, 27, 27, 583, DateTimeKind.Local).AddTicks(9739), "harperm1@gmail.com", false, "Harper", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 583, DateTimeKind.Local).AddTicks(9749), "Miller", new DateTime(2024, 6, 27, 2, 27, 27, 583, DateTimeKind.Utc).AddTicks(9750), "HN", true, null, "HARPERM1@GMAIL.COM", "HARPERM1", "AQAAAAIAAYagAAAAED4Elm2IsizrzqxZtenTmT43KiJmh3aQrYNUkylmiPcCp+5S50seADfTwHpC/ImM4w==", null, false, "fe996c5e-f9cc-41e4-8631-de2c9c187860", "SD0057", false, "harperm1" },
                    { new Guid("a7453b95-f710-46f4-97a2-100fb351e5f5"), 0, "792c77f5-c0b4-4e95-a2a5-9009652e443e", new DateTime(2024, 6, 27, 2, 27, 25, 655, DateTimeKind.Utc).AddTicks(6125), new DateTime(1996, 3, 14, 9, 27, 25, 655, DateTimeKind.Local).AddTicks(6110), "daniels@gmail.com", false, "Daniel", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 655, DateTimeKind.Local).AddTicks(6123), "Smith", new DateTime(2024, 6, 27, 2, 27, 25, 655, DateTimeKind.Utc).AddTicks(6125), "HCM", true, null, "DANIELS@GMAIL.COM", "DANIELS", "AQAAAAIAAYagAAAAEIP+Z6HRuxb3bwogStGVoDTSs2H7uQtXG+mb918nMVXwqAuGpNJO5ZLP/X/OTnzHmQ==", null, false, "23e39baf-cda5-4688-a41f-3c701878c2a2", "SD0027", false, "daniels" },
                    { new Guid("a9f9da9f-f00f-443a-8e80-6986e3f2ac2c"), 0, "adf908f0-460c-4924-ae57-27ebc5ed0c34", new DateTime(2024, 6, 27, 2, 27, 27, 134, DateTimeKind.Utc).AddTicks(3670), new DateTime(1995, 12, 14, 9, 27, 27, 134, DateTimeKind.Local).AddTicks(3657), "charlottet1@gmail.com", false, "Charlotte", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 134, DateTimeKind.Local).AddTicks(3669), "Thomas", new DateTime(2024, 6, 27, 2, 27, 27, 134, DateTimeKind.Utc).AddTicks(3671), "HN", true, null, "CHARLOTTET1@GMAIL.COM", "CHARLOTTET1", "AQAAAAIAAYagAAAAEJf+GHsGQl9CgwaWZvbSvpQDhzhWRYDQ3ULT4cqJaRbxq1L3kb7O6N16l94jQOCI9w==", null, false, "34c99da2-fc47-4348-b1f4-2881c1a66fb3", "SD0050", false, "charlottet1" },
                    { new Guid("aa7303c0-2d7b-4a5e-b467-41a7234f53ad"), 0, "eaade1bd-476b-4424-9214-f495289da0e6", new DateTime(2024, 6, 27, 2, 27, 24, 371, DateTimeKind.Utc).AddTicks(1511), new DateTime(2004, 9, 23, 9, 27, 24, 371, DateTimeKind.Local).AddTicks(1489), "evelynw@gmail.com", false, "Evelyn", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 371, DateTimeKind.Local).AddTicks(1510), "White", new DateTime(2024, 6, 27, 2, 27, 24, 371, DateTimeKind.Utc).AddTicks(1512), "HCM", true, null, "EVELYNW@GMAIL.COM", "EVELYNW", "AQAAAAIAAYagAAAAEINjp3yAP/07EK69VTDLasiOreUBylXtCnI9iACJMaFPL1J6gsBg2NWF89MvfaiDmQ==", null, false, "32810ccf-85f5-488f-8406-0a0d16b96ef2", "SD0007", false, "evelynw" },
                    { new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf"), 0, "82e3d4ec-a12e-4328-ae4d-2cd24a21de5f", new DateTime(2024, 6, 27, 2, 27, 25, 719, DateTimeKind.Utc).AddTicks(2527), new DateTime(1997, 2, 14, 9, 27, 25, 719, DateTimeKind.Local).AddTicks(2508), "elijaht@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 719, DateTimeKind.Local).AddTicks(2525), "Taylor", new DateTime(2024, 6, 27, 2, 27, 25, 719, DateTimeKind.Utc).AddTicks(2527), "HN", true, null, "ELIJAHT@GMAIL.COM", "ELIJAHT", "AQAAAAIAAYagAAAAEIAXM828q4JtsTNKBrDUzR4MK/exXS0u4fHbcQT8ute0gsK3o4avLaNV20M0IeRTPQ==", null, false, "986ac68d-f499-49d9-83fe-f8f9ab500fea", "SD0028", false, "elijaht" },
                    { new Guid("bc4fbf1c-968d-4e50-b33f-d8478a38671d"), 0, "4d71329b-a2cd-4b8c-ac85-3172d77c62ac", new DateTime(2024, 6, 27, 2, 27, 25, 335, DateTimeKind.Utc).AddTicks(4511), new DateTime(2002, 10, 2, 9, 27, 25, 335, DateTimeKind.Local).AddTicks(4499), "elijahl@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 335, DateTimeKind.Local).AddTicks(4510), "Lewis", new DateTime(2024, 6, 27, 2, 27, 25, 335, DateTimeKind.Utc).AddTicks(4511), "HN", true, null, "ELIJAHL@GMAIL.COM", "ELIJAHL", "AQAAAAIAAYagAAAAEFhYIybQFee3om6S7a9unAhDcy+Jmr7VBul6K5wUclYhBMHM0rYD27NP1hPgf7iLUg==", null, false, "a16a51bf-11db-4dd1-8a65-2bd86607516f", "SD0022", false, "elijahl" },
                    { new Guid("c5e786e1-16f4-4b08-83f3-f1e89a03cbf5"), 0, "75bc9f90-671f-45d4-9e36-89fd3b870e87", new DateTime(2024, 6, 27, 2, 27, 25, 527, DateTimeKind.Utc).AddTicks(6444), new DateTime(1998, 8, 10, 9, 27, 25, 527, DateTimeKind.Local).AddTicks(6433), "elijahb1@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 527, DateTimeKind.Local).AddTicks(6443), "Brown", new DateTime(2024, 6, 27, 2, 27, 25, 527, DateTimeKind.Utc).AddTicks(6444), "HN", true, null, "ELIJAHB1@GMAIL.COM", "ELIJAHB1", "AQAAAAIAAYagAAAAECvGbP6nUFY4YJg0mxSNQtP6yF9W9YhVfRl/hk7++hIrrZ+vhSvZy1A/RZZ6qv+i/w==", null, false, "272b7200-06d2-469e-9e85-6495930f0655", "SD0025", false, "elijahb1" },
                    { new Guid("cc10e718-343b-404f-b622-a6b7f3637e06"), 0, "9d3ceb92-d0f4-4ca1-b6df-fe459738d12c", new DateTime(2024, 6, 27, 2, 27, 26, 679, DateTimeKind.Utc).AddTicks(2372), new DateTime(2001, 7, 20, 9, 27, 26, 679, DateTimeKind.Local).AddTicks(2368), "avaj1@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 679, DateTimeKind.Local).AddTicks(2371), "Jackson", new DateTime(2024, 6, 27, 2, 27, 26, 679, DateTimeKind.Utc).AddTicks(2372), "HCM", true, null, "AVAJ1@GMAIL.COM", "AVAJ1", "AQAAAAIAAYagAAAAEDOTRABkM6TQwg/sX9QaAhYdc6MHqjVYG8iLKTxH4egZz9KoPvaAo2wgRMpi8wYAJw==", null, false, "63da2fcf-3b63-44fd-b013-7b7322cbb4d5", "SD0043", false, "avaj1" },
                    { new Guid("cc8b35de-03b1-4943-83bb-2ab7d3247d9a"), 0, "46f09c7a-afac-4a7d-bf6a-42c4427cf7d8", new DateTime(2024, 6, 27, 2, 27, 27, 711, DateTimeKind.Utc).AddTicks(8778), new DateTime(2001, 12, 12, 9, 27, 27, 711, DateTimeKind.Local).AddTicks(8755), "williamy1@gmail.com", false, "William", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 711, DateTimeKind.Local).AddTicks(8777), "Young", new DateTime(2024, 6, 27, 2, 27, 27, 711, DateTimeKind.Utc).AddTicks(8778), "HN", true, null, "WILLIAMY1@GMAIL.COM", "WILLIAMY1", "AQAAAAIAAYagAAAAENR47HwuBp3OwQ2WwePFbIiyOtR7deaWxeJlUTugPp59sykQ6/wl6S6w1NiCfVxi5g==", null, false, "4af19b34-bdbc-44c6-b248-a83855cd73a0", "SD0059", false, "williamy1" },
                    { new Guid("d3b042b9-d1f4-4dc0-8e04-89ecda62669f"), 0, "2f53b7b4-9346-4bce-8ab2-3b9222eca7d9", new DateTime(2024, 6, 27, 2, 27, 25, 463, DateTimeKind.Utc).AddTicks(2511), new DateTime(1999, 7, 27, 9, 27, 25, 463, DateTimeKind.Local).AddTicks(2501), "charlottet@gmail.com", false, "Charlotte", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 463, DateTimeKind.Local).AddTicks(2510), "Taylor", new DateTime(2024, 6, 27, 2, 27, 25, 463, DateTimeKind.Utc).AddTicks(2511), "HN", true, null, "CHARLOTTET@GMAIL.COM", "CHARLOTTET", "AQAAAAIAAYagAAAAECcfjG7WlpWzRdejXAHyRgStE3lqlEola4YLTbcPjrSzbSPHlW4J/UFkMIqYoZioVQ==", null, false, "30fee4b2-7aaa-430d-8e07-29a8e7cd0b49", "SD0024", false, "charlottet" },
                    { new Guid("d4f64bd3-51ac-4341-ab16-06bcda5abb1d"), 0, "d5961f9a-8e80-429e-bc28-7d9d79d0ee95", new DateTime(2024, 6, 27, 2, 27, 25, 16, DateTimeKind.Utc).AddTicks(4537), new DateTime(1996, 2, 16, 9, 27, 25, 16, DateTimeKind.Local).AddTicks(4520), "miam@gmail.com", false, "Mia", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 16, DateTimeKind.Local).AddTicks(4535), "Miller", new DateTime(2024, 6, 27, 2, 27, 25, 16, DateTimeKind.Utc).AddTicks(4537), "HCM", true, null, "MIAM@GMAIL.COM", "MIAM", "AQAAAAIAAYagAAAAEO3LYjBYmS609mMr7hCWbDSG+oVsw5XovuCnkzRaxMrW1RAo9pi5PbtiDUO73luLlg==", null, false, "6a74c6f7-a04f-4207-b73e-0631584e2c96", "SD0017", false, "miam" },
                    { new Guid("e0a25437-ad54-427f-9223-35bf48a5459a"), 0, "de8b1d7b-4c72-4302-a2c3-ec4dcf9e9bef", new DateTime(2024, 6, 27, 2, 27, 27, 5, DateTimeKind.Utc).AddTicks(7865), new DateTime(2003, 9, 15, 9, 27, 27, 5, DateTimeKind.Local).AddTicks(7835), "avat2@gmail.com", false, "Ava", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 5, DateTimeKind.Local).AddTicks(7864), "Taylor", new DateTime(2024, 6, 27, 2, 27, 27, 5, DateTimeKind.Utc).AddTicks(7866), "HN", true, null, "AVAT2@GMAIL.COM", "AVAT2", "AQAAAAIAAYagAAAAECAuOhxYCq7FXgaSVkYiv314HXOaXQbGwX2ahvjwO0LtMiz+IyVwLkP7LFTIRn/x9g==", null, false, "e92257dd-76ea-451f-b119-9a507d361489", "SD0048", false, "avat2" },
                    { new Guid("e227d00e-e34b-4836-ba97-6f8263d221ff"), 0, "6d92aed1-eb44-409a-84aa-d6b780588d14", new DateTime(2024, 6, 27, 2, 27, 24, 240, DateTimeKind.Utc).AddTicks(4809), new DateTime(2004, 8, 23, 9, 27, 24, 240, DateTimeKind.Local).AddTicks(4780), "davidm1@gmail.com", false, "David", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 240, DateTimeKind.Local).AddTicks(4808), "Miller", new DateTime(2024, 6, 27, 2, 27, 24, 240, DateTimeKind.Utc).AddTicks(4809), "HCM", true, null, "DAVIDM1@GMAIL.COM", "DAVIDM1", "AQAAAAIAAYagAAAAEKgBpchynonich9C3bPhfw2sKvyOs694M/b+IYXjOVNGR2K3jcJxtGo7CiwyrwSZfA==", null, false, "e224623c-016b-4e1f-bf8a-6a0f655bddc3", "SD0005", false, "davidm1" },
                    { new Guid("e4022914-f3f9-4a69-a135-b1a62c10e908"), 0, "80230880-69db-4f61-a160-f1c7556388ac", new DateTime(2024, 6, 27, 2, 27, 27, 392, DateTimeKind.Utc).AddTicks(2531), new DateTime(2004, 2, 25, 9, 27, 27, 392, DateTimeKind.Local).AddTicks(2513), "williamy@gmail.com", false, "William", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 392, DateTimeKind.Local).AddTicks(2530), "Young", new DateTime(2024, 6, 27, 2, 27, 27, 392, DateTimeKind.Utc).AddTicks(2532), "HN", true, null, "WILLIAMY@GMAIL.COM", "WILLIAMY", "AQAAAAIAAYagAAAAEMsmLqrtqh4A32h1tjpRnb4FAnF+rVa5nP5Gv4EXVNeHGizOrqKr6dkfXh/IoojaQA==", null, false, "1878a12a-2603-4845-ace9-a3b571bcf899", "SD0054", false, "williamy" },
                    { new Guid("ebb1d292-a91c-41be-84e0-e32569db74c4"), 0, "e789d45f-5e44-44cc-a979-45445152bde4", new DateTime(2024, 6, 27, 2, 27, 24, 567, DateTimeKind.Utc).AddTicks(7104), new DateTime(2000, 2, 15, 9, 27, 24, 567, DateTimeKind.Local).AddTicks(7075), "elijahj@gmail.com", false, "Elijah", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 567, DateTimeKind.Local).AddTicks(7103), "Jones", new DateTime(2024, 6, 27, 2, 27, 24, 567, DateTimeKind.Utc).AddTicks(7105), "HN", true, null, "ELIJAHJ@GMAIL.COM", "ELIJAHJ", "AQAAAAIAAYagAAAAENBWwtSNS0wdsIwSXSGcXVdwuXFcxHWz/VXO6rR6sOnj679F6lz5GuwGHnc1f//5BA==", null, false, "2a6611c6-290b-4b35-ac00-b9963e727e47", "SD0010", false, "elijahj" },
                    { new Guid("ec506cde-e043-46a9-b542-7dd5d5c0973e"), 0, "14ff76bb-1a19-42a8-8669-70630158ef45", new DateTime(2024, 6, 27, 2, 27, 27, 199, DateTimeKind.Utc).AddTicks(1850), new DateTime(1996, 3, 3, 9, 27, 27, 199, DateTimeKind.Local).AddTicks(1834), "elijaha@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 199, DateTimeKind.Local).AddTicks(1848), "Anderson", new DateTime(2024, 6, 27, 2, 27, 27, 199, DateTimeKind.Utc).AddTicks(1850), "HN", true, null, "ELIJAHA@GMAIL.COM", "ELIJAHA", "AQAAAAIAAYagAAAAEBYIDHOiYEbf0vVhzOioxZAAUoxmH+Pcbv0TFpvliILzHrqiImWDX8MD8LreiADXZA==", null, false, "0e229ea2-8ad1-436b-9fd1-f14d19623534", "SD0051", false, "elijaha" },
                    { new Guid("ede0c1cd-5d7e-422c-a787-8f473c45123b"), 0, "fbb71771-cf18-40ed-a281-32dc7efc5322", new DateTime(2024, 6, 27, 2, 27, 27, 69, DateTimeKind.Utc).AddTicks(5806), new DateTime(1998, 10, 5, 9, 27, 27, 69, DateTimeKind.Local).AddTicks(5792), "harperw@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 27, 69, DateTimeKind.Local).AddTicks(5804), "White", new DateTime(2024, 6, 27, 2, 27, 27, 69, DateTimeKind.Utc).AddTicks(5806), "HN", true, null, "HARPERW@GMAIL.COM", "HARPERW", "AQAAAAIAAYagAAAAECcQA4fsqRQA/S81GseXyiH/WcuV8S53OzInOPswVtXupNK+QL02gTlFmOwRlvfKAg==", null, false, "1bcfb9a4-05fe-4451-988e-f4588ceead8f", "SD0049", false, "harperw" },
                    { new Guid("f4551061-e49e-4e45-97ae-581801221bff"), 0, "5f2c511c-14d8-477b-82b2-8beedf63dcf4", new DateTime(2024, 6, 27, 2, 27, 24, 951, DateTimeKind.Utc).AddTicks(8462), new DateTime(1998, 11, 6, 9, 27, 24, 951, DateTimeKind.Local).AddTicks(8454), "harpers1@gmail.com", false, "Harper", "Male", false, false, new DateTime(2024, 6, 27, 9, 27, 24, 951, DateTimeKind.Local).AddTicks(8461), "Smith", new DateTime(2024, 6, 27, 2, 27, 24, 951, DateTimeKind.Utc).AddTicks(8463), "HN", true, null, "HARPERS1@GMAIL.COM", "HARPERS1", "AQAAAAIAAYagAAAAEK75PIPf3no1hjUTalt3U2llDytW9rdXt5zhNYEK89yrd1oNe2ySvVjXMkSfyI6Cbg==", null, false, "95d0915d-06b1-40a5-8580-a44de31140ba", "SD0016", false, "harpers1" },
                    { new Guid("f55a22b5-f3f2-4620-a2ed-d798a8c808d5"), 0, "fd2cdf18-7678-45f6-915e-660db9704952", new DateTime(2024, 6, 27, 2, 27, 26, 295, DateTimeKind.Utc).AddTicks(233), new DateTime(1999, 2, 22, 9, 27, 26, 295, DateTimeKind.Local).AddTicks(225), "davidm2@gmail.com", false, "David", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 295, DateTimeKind.Local).AddTicks(232), "Miller", new DateTime(2024, 6, 27, 2, 27, 26, 295, DateTimeKind.Utc).AddTicks(233), "HCM", true, null, "DAVIDM2@GMAIL.COM", "DAVIDM2", "AQAAAAIAAYagAAAAEMlh3oRREyj8gxnrZX+iIy5VGASNHerblc3YmlOHcBHjCaZyb0ngd0dMCs41gsdlNA==", null, false, "b262322c-096c-4d7d-bca5-803d3836f759", "SD0037", false, "davidm2" },
                    { new Guid("f65c3016-ee9f-4f9f-8241-bfd79738bf7d"), 0, "5215754a-d8f8-42ef-94d7-c612fd5348b4", new DateTime(2024, 6, 27, 2, 27, 26, 743, DateTimeKind.Utc).AddTicks(5356), new DateTime(1995, 2, 27, 9, 27, 26, 743, DateTimeKind.Local).AddTicks(5344), "josepht1@gmail.com", false, "Joseph", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 26, 743, DateTimeKind.Local).AddTicks(5353), "Taylor", new DateTime(2024, 6, 27, 2, 27, 26, 743, DateTimeKind.Utc).AddTicks(5356), "HN", true, null, "JOSEPHT1@GMAIL.COM", "JOSEPHT1", "AQAAAAIAAYagAAAAEPmcUEwVsgOx0ywUwhu5v78thMP1cNBjSRtm54CRF3pKTbhhontzZqfel1Z4JcEgUg==", null, false, "e1a406b6-1728-4cae-bfe8-937b4ccfbeda", "SD0044", false, "josepht1" },
                    { new Guid("f6670fb1-7053-4fc8-93fb-ff279c3ddde9"), 0, "7e275d16-c939-451a-b80f-2311177a0bb6", new DateTime(2024, 6, 27, 2, 27, 25, 782, DateTimeKind.Utc).AddTicks(6361), new DateTime(1999, 5, 17, 9, 27, 25, 782, DateTimeKind.Local).AddTicks(6354), "elijaht1@gmail.com", false, "Elijah", "Female", false, false, new DateTime(2024, 6, 27, 9, 27, 25, 782, DateTimeKind.Local).AddTicks(6360), "Taylor", new DateTime(2024, 6, 27, 2, 27, 25, 782, DateTimeKind.Utc).AddTicks(6361), "HN", true, null, "ELIJAHT1@GMAIL.COM", "ELIJAHT1", "AQAAAAIAAYagAAAAEJPWLjNfMHN/BpBjh1ISSGDaKWpBkHW53ggnZdQvEWxsLpD5+k7AfScyUgUq/p4Jzw==", null, false, "3a924a8e-55e5-4004-bcaa-536767e2c39c", "SD0029", false, "elijaht1" }
                });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetCode", "CategoryId", "CreatedAt", "InstalledDate", "LastUpdated", "Location", "Name", "Specification", "State" },
                values: new object[,]
                {
                    { new Guid("07ed57d0-9745-43e0-a40e-39a29c957c1b"), "MO000005", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3204), new DateTime(2022, 5, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3205), "HN", "Monitor BenQ DesignVue", "27 inch, 4K UHD", 3 },
                    { new Guid("0eab77a8-ed89-4483-9d98-6ccafa74d450"), "LA000001", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3134), new DateTime(2008, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3139), "HN", "Laptop HP ProBook 450 G1", "Core i5, 8GB RAM, 750 GB HDD, Window 8", 1 },
                    { new Guid("28793bed-3c13-487d-b9ec-7e3c8181b16f"), "LA000005", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3190), "HN", "Laptop HP Envy", "Core i7, 16GB RAM, 512GB SSD, Windows 11", 2 },
                    { new Guid("2fefef1a-cb08-4c2d-bdef-99751bbf7a5c"), "PC000007", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3233), "HN", "Personal Computer Apple iMac", "M1, 16GB RAM, 512GB SSD, macOS", 1 },
                    { new Guid("34adbd02-c110-4d27-86d6-fc009183c254"), "MO000003", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3176), new DateTime(2020, 12, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3176), "HCM", "Monitor LG UltraWide", "34 inch, WQHD", 1 },
                    { new Guid("3644951d-c46e-4efd-959c-dfdd22dd0908"), "LA000008", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3225), "HN", "Laptop Dell Latitude", "Core i5, 8GB RAM, 256GB SSD, Windows 11", 1 },
                    { new Guid("39897458-d30d-4e31-8f23-69ae6a6b32c5"), "LA000002", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3159), new DateTime(2015, 3, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3160), "HCM", "Laptop Dell XPS 13", "Core i7, 16GB RAM, 512GB SSD, Windows 10", 1 },
                    { new Guid("40f0345d-8205-4e90-a6e0-0888dc019ae5"), "LA000011", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3260), "HCM", "Laptop ASUS VivoBook", "Core i5, 8GB RAM, 512GB SSD, Windows 11", 4 },
                    { new Guid("4619a936-baf7-4e47-9300-9d261c6f7e88"), "PC000004", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 3, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3198), "HN", "Personal Computer Lenovo IdeaCentre", "Core i5, 8GB RAM, 1TB HDD, Windows 10", 2 },
                    { new Guid("48e50b2e-2b0a-44cb-a054-1dc044ef0677"), "MO000013", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3305), "HCM", "Monitor ViewSonic Elite", "32 inch, QHD", 3 },
                    { new Guid("4cb354b6-d548-425c-828b-ecd2987d8ae1"), "MO000010", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3269), "HN", "Monitor Dell Gaming", "32 inch, QHD", 1 },
                    { new Guid("503c3eb7-3a05-4123-8c69-3011bee3d553"), "MO000012", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3295), "HN", "Monitor LG UltraGear", "32 inch, QHD", 2 },
                    { new Guid("52a4a0a0-86cb-4bf2-84df-c791df97159a"), "PC000008", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3246), "HCM", "Personal Computer ASUS ROG", "Core i9, 32GB RAM, 2TB SSD, Windows 11", 2 },
                    { new Guid("5a3c187e-1b16-4594-854d-d472df45cfcb"), "PC000012", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3298), new DateTime(2024, 6, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3298), "HCM", "Personal Computer ASUS VivoPC", "Core i5, 8GB RAM, 1TB SSD, Windows 11", 2 },
                    { new Guid("5f1b622c-bda9-4a4e-920c-7790eb950ffc"), "PC000014", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3321), "HCM", "Personal Computer Lenovo ThinkCentre", "Core i7, 16GB RAM, 512GB SSD, Windows 11", 4 },
                    { new Guid("6065254a-2a0d-4500-8934-c633ce166e1e"), "PC000003", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3182), new DateTime(2013, 4, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3182), "HN", "Personal Computer Acer Aspire", "Core i3, 4GB RAM, 1TB HDD, Windows 8", 1 },
                    { new Guid("63595347-4e5a-4bc6-b419-96b17b615c46"), "LA000014", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3302), "HN", "Laptop Dell Inspiron", "Core i5, 8GB RAM, 256GB SSD, Windows 11", 3 },
                    { new Guid("6b04de6a-c45f-466d-b196-da6503c25752"), "PC000006", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3221), new DateTime(2022, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3222), "HN", "Personal Computer Dell G5", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 4 },
                    { new Guid("6fd6d297-5cf4-4a6e-9a6d-6dae42e721fb"), "LA000012", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3275), "HN", "Laptop Lenovo Yoga", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 1 },
                    { new Guid("75b8711b-bbec-401e-9017-6a3ac43e234b"), "MO000006", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3219), "HCM", "Monitor ViewSonic VP", "27 inch, WQHD", 4 },
                    { new Guid("797d40d3-217a-4ad9-962b-076a98ebcacb"), "LA000007", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3213), new DateTime(2022, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3214), "HN", "Laptop Microsoft Surface", "Core i7, 16GB RAM, 512GB SSD, Windows 11", 4 },
                    { new Guid("7b6c911a-d317-4b8e-84fe-8c8aaaf94ebc"), "LA000003", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3172), new DateTime(2019, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3173), "HN", "Laptop Lenovo ThinkPad", "Core i5, 8GB RAM, 256GB SSD, Windows 10", 1 },
                    { new Guid("81436c8d-4090-4abf-a926-14d061f1f9c9"), "MO000007", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 2, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3230), "HCM", "Monitor Acer Predator", "32 inch, QHD", 1 },
                    { new Guid("8f0063d0-4d0b-4fdc-87e6-f53e3f98d75d"), "LA000004", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3186), new DateTime(2021, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3187), "HCM", "Laptop Asus ZenBook", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 1 },
                    { new Guid("9520f38b-34f9-47f4-8f4b-9b414263e21a"), "LA000015", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 10, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3314), "HCM", "Laptop ASUS ZenBook Duo", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 1 },
                    { new Guid("9a7e2a23-23b6-4172-946a-28470034253b"), "PC000010", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3272), new DateTime(2023, 12, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3272), "HCM", "Personal Computer HP Envy", "Core i9, 32GB RAM, 2TB SSD, Windows 11", 1 },
                    { new Guid("9b21cf8c-dc79-4398-87ed-e6142b5b1731"), "MO000002", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3163), new DateTime(2018, 1, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3163), "HN", "Monitor Samsung Curved", "27 inch, QHD", 1 },
                    { new Guid("9c309599-cbe5-4bb6-9040-6fc0cb272804"), "MO000009", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 8, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3253), "HCM", "Monitor HP Omen", "32 inch, QHD", 3 },
                    { new Guid("a36af1ae-ffc0-4690-8d9f-b2e41b0b905a"), "PC000005", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3208), new DateTime(2022, 6, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3208), "HCM", "Personal Computer MSI Trident", "Core i9, 32GB RAM, 1TB SSD, Windows 11", 3 },
                    { new Guid("a5533648-2a7f-4ba7-9474-561c60b88ee5"), "LA000006", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3201), new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3201), "HCM", "Laptop Apple MacBook Air", "M1, 8GB RAM, 256GB SSD, macOS", 3 },
                    { new Guid("a579c96b-700e-47c2-8636-632137f9aa07"), "PC000009", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3257), "HN", "Personal Computer HP Pavilion", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 3 },
                    { new Guid("a91d8139-49ff-43f2-a9c1-379142b3c056"), "MO000008", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3241), "HN", "Monitor Philips Brilliance", "34 inch, 4K UHD", 2 },
                    { new Guid("a99aca9c-3500-4119-a115-a886c67214a6"), "LA000013", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3291), "HCM", "Laptop Apple MacBook Pro", "M1 Pro, 16GB RAM, 1TB SSD, macOS", 2 },
                    { new Guid("b1b70469-f9a5-44e0-8f82-b0e7c6f189b5"), "LA000009", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3237), "HCM", "Laptop Acer Swift", "Core i5, 8GB RAM, 512GB SSD, Windows 11", 2 },
                    { new Guid("b26b66bf-db14-423c-b016-b7f154f54152"), "PC000002", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3169), new DateTime(2016, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3169), "HCM", "Personal Computer HP EliteDesk", "Core i5, 8GB RAM, 512GB SSD, Windows 10", 1 },
                    { new Guid("b8372a82-f598-4410-81ce-6d12565fa707"), "MO000014", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3317), "HN", "Monitor ASUS TUF", "32 inch, QHD", 4 },
                    { new Guid("befb823a-a77f-4507-9ff0-bb0d60396104"), "MO000004", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3193), new DateTime(2022, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3194), "HCM", "Monitor ASUS ProArt", "32 inch, 4K UHD", 2 },
                    { new Guid("bf03a575-fb79-4544-840c-f7fe240ec685"), "PC000011", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 3, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3288), "HN", "Personal Computer Dell Optiplex", "Core i7, 16GB RAM, 512GB SSD, Windows 11", 1 },
                    { new Guid("c08c5c70-2344-4b7e-8d6f-50cf5cd7ab0e"), "MO000011", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3280), "HCM", "Monitor Samsung Odyssey", "49 inch, QHD", 1 },
                    { new Guid("d1e6a66c-3e83-4157-89a8-d6e849a0f333"), "LA000010", new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3249), "HN", "Laptop HP Spectre", "Core i7, 16GB RAM, 1TB SSD, Windows 11", 3 },
                    { new Guid("f0dff85d-6cc7-496b-8437-40b50298e62c"), "PC000001", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3155), new DateTime(2012, 5, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3156), "HN", "Personal Computer Dell Inspiron", "Core i7, 16GB RAM, 1TB SSD, Windows 10", 1 },
                    { new Guid("f673f337-c449-4ff1-97cd-366b79cf3a63"), "MO000001", new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3151), new DateTime(2010, 7, 15, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3152), "HCM", "Monitor Dell UltraSharp", "24 inch, Full HD", 1 },
                    { new Guid("f99aea34-6887-49f9-a606-55afc0be1874"), "PC000013", new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 9, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 27, 28, 103, DateTimeKind.Local).AddTicks(3308), "HN", "Personal Computer Apple Mac Mini", "M1, 8GB RAM, 256GB SSD, macOS", 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("029db996-262c-4e07-8a19-644c09e0214a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("03185a20-27c3-4e3a-88ae-1527d5cf70a1"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("151e3a0f-5cd2-48ad-ae50-783614f5d4ff"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("15a89e0f-ddbd-4ffe-acb4-087db1dc7e21"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("16eb8729-b05d-41c0-bf0c-d45ee4b3d38e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("182ae763-6957-46a5-aa6e-88054b4bf786"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("18e23987-101a-45f8-b9bf-28577234acf5"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("1973d93f-8fd4-4d7f-b7db-fa8c921db220"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("19752558-bf20-48b1-a86a-c5918b15e33f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1ad51d88-1bdc-4956-8343-adaac1d5cc22"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23ec06cc-ba03-42b0-a8e4-99e6912a8e72"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2450bc08-8b39-41cf-90e9-7b10510c557e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("256a9cef-7479-4563-a104-8b310e16ffe0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2aa978c7-a92f-47be-9df2-c4acbe7f88b8"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("36de2dd1-8013-418b-bb93-aed2279b4f83"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("375ce69b-6780-4c98-8072-23d9137e1802"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3b720de8-84cd-4533-91eb-67cce3583ade"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3cf8e11a-c23d-400a-ba32-bf62a7b35f8d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3f6e59ca-2a0b-4ad1-8ad3-a67aa81f188b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4620d11d-4583-42d7-b579-41767c6b5923"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("48bc2207-ec50-455d-99e4-990995f809e0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49b35fdc-f2be-4286-97f3-fc7e14e2082d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49c2b516-b12e-4dd8-ae2b-9027446f4b77"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4dbc897b-1395-4263-a0be-e590434c67c2"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("5712562b-e4f7-4279-ab8c-f4a5c8c3002d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("59339cda-7d6d-4cbf-833c-367d7db965e1"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5a1c0199-f674-408d-84fe-37e2a890d93b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("60c17fcb-178e-4181-ad50-3690524f5190"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6b360b9c-bb2d-4783-9d49-ca224f7ac790"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6d961aa5-8577-420d-9313-203567e1602b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7750cb4f-a326-4961-8a51-563d809cb92d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7b6b2681-ee20-4d4b-9f27-ab0a7d4d61c7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7b9b9e92-9d83-4b1f-ae46-c9b73b9ac6b3"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("7d92b859-fe2a-4830-9a82-b40ffce97c71"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8254443a-3481-4ba1-86a6-f86a1b9e440b"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8627fb23-8914-494c-85fa-e9b9fca43282"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("880958e1-7efa-4d7f-87b7-eae08b5c516d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8e19aca1-35ef-45b8-bab3-d65b04b179d0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("97bb2876-1bc4-4d19-9bc4-3c7f36de568a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a0722e9f-e18b-4f65-a7d5-a1fb6ba6046e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6eff315-6326-413b-bfe1-aa150eed7dd7"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a7453b95-f710-46f4-97a2-100fb351e5f5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a9f9da9f-f00f-443a-8e80-6986e3f2ac2c"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("aa7303c0-2d7b-4a5e-b467-41a7234f53ad"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bc4fbf1c-968d-4e50-b33f-d8478a38671d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c5e786e1-16f4-4b08-83f3-f1e89a03cbf5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc10e718-343b-404f-b622-a6b7f3637e06"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc8b35de-03b1-4943-83bb-2ab7d3247d9a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d3b042b9-d1f4-4dc0-8e04-89ecda62669f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d4f64bd3-51ac-4341-ab16-06bcda5abb1d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e0a25437-ad54-427f-9223-35bf48a5459a"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e227d00e-e34b-4836-ba97-6f8263d221ff"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e4022914-f3f9-4a69-a135-b1a62c10e908"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ebb1d292-a91c-41be-84e0-e32569db74c4"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ec506cde-e043-46a9-b542-7dd5d5c0973e"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ede0c1cd-5d7e-422c-a787-8f473c45123b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f4551061-e49e-4e45-97ae-581801221bff"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f55a22b5-f3f2-4620-a2ed-d798a8c808d5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f65c3016-ee9f-4f9f-8241-bfd79738bf7d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f6670fb1-7053-4fc8-93fb-ff279c3ddde9"), "UserRole" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("029db996-262c-4e07-8a19-644c09e0214a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("03185a20-27c3-4e3a-88ae-1527d5cf70a1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("151e3a0f-5cd2-48ad-ae50-783614f5d4ff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("15a89e0f-ddbd-4ffe-acb4-087db1dc7e21") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("16eb8729-b05d-41c0-bf0c-d45ee4b3d38e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("182ae763-6957-46a5-aa6e-88054b4bf786") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("18e23987-101a-45f8-b9bf-28577234acf5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("1973d93f-8fd4-4d7f-b7db-fa8c921db220") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("19752558-bf20-48b1-a86a-c5918b15e33f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1ad51d88-1bdc-4956-8343-adaac1d5cc22") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23ec06cc-ba03-42b0-a8e4-99e6912a8e72") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2450bc08-8b39-41cf-90e9-7b10510c557e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("256a9cef-7479-4563-a104-8b310e16ffe0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2aa978c7-a92f-47be-9df2-c4acbe7f88b8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("36de2dd1-8013-418b-bb93-aed2279b4f83") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("375ce69b-6780-4c98-8072-23d9137e1802") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3b720de8-84cd-4533-91eb-67cce3583ade") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3cf8e11a-c23d-400a-ba32-bf62a7b35f8d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3f6e59ca-2a0b-4ad1-8ad3-a67aa81f188b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4620d11d-4583-42d7-b579-41767c6b5923") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("48bc2207-ec50-455d-99e4-990995f809e0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49b35fdc-f2be-4286-97f3-fc7e14e2082d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49c2b516-b12e-4dd8-ae2b-9027446f4b77") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("4dbc897b-1395-4263-a0be-e590434c67c2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("5712562b-e4f7-4279-ab8c-f4a5c8c3002d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("59339cda-7d6d-4cbf-833c-367d7db965e1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("5a1c0199-f674-408d-84fe-37e2a890d93b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("60c17fcb-178e-4181-ad50-3690524f5190") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("6b360b9c-bb2d-4783-9d49-ca224f7ac790") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6d961aa5-8577-420d-9313-203567e1602b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7750cb4f-a326-4961-8a51-563d809cb92d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7b6b2681-ee20-4d4b-9f27-ab0a7d4d61c7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("7b9b9e92-9d83-4b1f-ae46-c9b73b9ac6b3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("7d92b859-fe2a-4830-9a82-b40ffce97c71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8254443a-3481-4ba1-86a6-f86a1b9e440b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("8627fb23-8914-494c-85fa-e9b9fca43282") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("880958e1-7efa-4d7f-87b7-eae08b5c516d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8e19aca1-35ef-45b8-bab3-d65b04b179d0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("97bb2876-1bc4-4d19-9bc4-3c7f36de568a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("a0722e9f-e18b-4f65-a7d5-a1fb6ba6046e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a6eff315-6326-413b-bfe1-aa150eed7dd7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a7453b95-f710-46f4-97a2-100fb351e5f5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a9f9da9f-f00f-443a-8e80-6986e3f2ac2c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("aa7303c0-2d7b-4a5e-b467-41a7234f53ad") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bc4fbf1c-968d-4e50-b33f-d8478a38671d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c5e786e1-16f4-4b08-83f3-f1e89a03cbf5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc10e718-343b-404f-b622-a6b7f3637e06") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc8b35de-03b1-4943-83bb-2ab7d3247d9a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d3b042b9-d1f4-4dc0-8e04-89ecda62669f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d4f64bd3-51ac-4341-ab16-06bcda5abb1d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e0a25437-ad54-427f-9223-35bf48a5459a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e227d00e-e34b-4836-ba97-6f8263d221ff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e4022914-f3f9-4a69-a135-b1a62c10e908") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ebb1d292-a91c-41be-84e0-e32569db74c4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ec506cde-e043-46a9-b542-7dd5d5c0973e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("ede0c1cd-5d7e-422c-a787-8f473c45123b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f4551061-e49e-4e45-97ae-581801221bff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f55a22b5-f3f2-4620-a2ed-d798a8c808d5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f65c3016-ee9f-4f9f-8241-bfd79738bf7d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("f6670fb1-7053-4fc8-93fb-ff279c3ddde9") });

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("07ed57d0-9745-43e0-a40e-39a29c957c1b"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("0eab77a8-ed89-4483-9d98-6ccafa74d450"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("28793bed-3c13-487d-b9ec-7e3c8181b16f"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("2fefef1a-cb08-4c2d-bdef-99751bbf7a5c"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("34adbd02-c110-4d27-86d6-fc009183c254"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("3644951d-c46e-4efd-959c-dfdd22dd0908"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("39897458-d30d-4e31-8f23-69ae6a6b32c5"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("40f0345d-8205-4e90-a6e0-0888dc019ae5"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("4619a936-baf7-4e47-9300-9d261c6f7e88"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("48e50b2e-2b0a-44cb-a054-1dc044ef0677"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("4cb354b6-d548-425c-828b-ecd2987d8ae1"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("503c3eb7-3a05-4123-8c69-3011bee3d553"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("52a4a0a0-86cb-4bf2-84df-c791df97159a"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("5a3c187e-1b16-4594-854d-d472df45cfcb"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("5f1b622c-bda9-4a4e-920c-7790eb950ffc"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6065254a-2a0d-4500-8934-c633ce166e1e"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("63595347-4e5a-4bc6-b419-96b17b615c46"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6b04de6a-c45f-466d-b196-da6503c25752"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("6fd6d297-5cf4-4a6e-9a6d-6dae42e721fb"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("75b8711b-bbec-401e-9017-6a3ac43e234b"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("797d40d3-217a-4ad9-962b-076a98ebcacb"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("7b6c911a-d317-4b8e-84fe-8c8aaaf94ebc"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("81436c8d-4090-4abf-a926-14d061f1f9c9"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("8f0063d0-4d0b-4fdc-87e6-f53e3f98d75d"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("9520f38b-34f9-47f4-8f4b-9b414263e21a"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("9a7e2a23-23b6-4172-946a-28470034253b"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("9b21cf8c-dc79-4398-87ed-e6142b5b1731"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("9c309599-cbe5-4bb6-9040-6fc0cb272804"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a36af1ae-ffc0-4690-8d9f-b2e41b0b905a"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a5533648-2a7f-4ba7-9474-561c60b88ee5"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a579c96b-700e-47c2-8636-632137f9aa07"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a91d8139-49ff-43f2-a9c1-379142b3c056"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("a99aca9c-3500-4119-a115-a886c67214a6"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b1b70469-f9a5-44e0-8f82-b0e7c6f189b5"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b26b66bf-db14-423c-b016-b7f154f54152"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("b8372a82-f598-4410-81ce-6d12565fa707"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("befb823a-a77f-4507-9ff0-bb0d60396104"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("bf03a575-fb79-4544-840c-f7fe240ec685"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("c08c5c70-2344-4b7e-8d6f-50cf5cd7ab0e"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("d1e6a66c-3e83-4157-89a8-d6e849a0f333"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("f0dff85d-6cc7-496b-8437-40b50298e62c"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("f673f337-c449-4ff1-97cd-366b79cf3a63"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("f99aea34-6887-49f9-a606-55afc0be1874"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("029db996-262c-4e07-8a19-644c09e0214a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("03185a20-27c3-4e3a-88ae-1527d5cf70a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06f00eb0-b413-4096-ac54-8a501d96d3da"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("151e3a0f-5cd2-48ad-ae50-783614f5d4ff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15a89e0f-ddbd-4ffe-acb4-087db1dc7e21"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("16eb8729-b05d-41c0-bf0c-d45ee4b3d38e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("182ae763-6957-46a5-aa6e-88054b4bf786"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("18e23987-101a-45f8-b9bf-28577234acf5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1973d93f-8fd4-4d7f-b7db-fa8c921db220"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19752558-bf20-48b1-a86a-c5918b15e33f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ad51d88-1bdc-4956-8343-adaac1d5cc22"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23ec06cc-ba03-42b0-a8e4-99e6912a8e72"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2450bc08-8b39-41cf-90e9-7b10510c557e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("256a9cef-7479-4563-a104-8b310e16ffe0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2aa978c7-a92f-47be-9df2-c4acbe7f88b8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c484448-b14e-46f3-957e-a8719f14bbd6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("36de2dd1-8013-418b-bb93-aed2279b4f83"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("375ce69b-6780-4c98-8072-23d9137e1802"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b720de8-84cd-4533-91eb-67cce3583ade"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cf8e11a-c23d-400a-ba32-bf62a7b35f8d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f6e59ca-2a0b-4ad1-8ad3-a67aa81f188b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4620d11d-4583-42d7-b579-41767c6b5923"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("48bc2207-ec50-455d-99e4-990995f809e0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("49b35fdc-f2be-4286-97f3-fc7e14e2082d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("49c2b516-b12e-4dd8-ae2b-9027446f4b77"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c196276-54f0-48ae-acc9-abeb0cb598f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4dbc897b-1395-4263-a0be-e590434c67c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5712562b-e4f7-4279-ab8c-f4a5c8c3002d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("59339cda-7d6d-4cbf-833c-367d7db965e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a1c0199-f674-408d-84fe-37e2a890d93b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60c17fcb-178e-4181-ad50-3690524f5190"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b360b9c-bb2d-4783-9d49-ca224f7ac790"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d961aa5-8577-420d-9313-203567e1602b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7750cb4f-a326-4961-8a51-563d809cb92d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b6b2681-ee20-4d4b-9f27-ab0a7d4d61c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b9b9e92-9d83-4b1f-ae46-c9b73b9ac6b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7d92b859-fe2a-4830-9a82-b40ffce97c71"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8254443a-3481-4ba1-86a6-f86a1b9e440b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8627fb23-8914-494c-85fa-e9b9fca43282"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("880958e1-7efa-4d7f-87b7-eae08b5c516d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8e19aca1-35ef-45b8-bab3-d65b04b179d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97bb2876-1bc4-4d19-9bc4-3c7f36de568a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0722e9f-e18b-4f65-a7d5-a1fb6ba6046e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a6eff315-6326-413b-bfe1-aa150eed7dd7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a7453b95-f710-46f4-97a2-100fb351e5f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9f9da9f-f00f-443a-8e80-6986e3f2ac2c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa7303c0-2d7b-4a5e-b467-41a7234f53ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("afa27f12-ee0b-4a82-b30b-507a680cb9cf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4fbf1c-968d-4e50-b33f-d8478a38671d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5e786e1-16f4-4b08-83f3-f1e89a03cbf5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc10e718-343b-404f-b622-a6b7f3637e06"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc8b35de-03b1-4943-83bb-2ab7d3247d9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d3b042b9-d1f4-4dc0-8e04-89ecda62669f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4f64bd3-51ac-4341-ab16-06bcda5abb1d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0a25437-ad54-427f-9223-35bf48a5459a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e227d00e-e34b-4836-ba97-6f8263d221ff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4022914-f3f9-4a69-a135-b1a62c10e908"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebb1d292-a91c-41be-84e0-e32569db74c4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ec506cde-e043-46a9-b542-7dd5d5c0973e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ede0c1cd-5d7e-422c-a787-8f473c45123b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4551061-e49e-4e45-97ae-581801221bff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f55a22b5-f3f2-4620-a2ed-d798a8c808d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f65c3016-ee9f-4f9f-8241-bfd79738bf7d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f6670fb1-7053-4fc8-93fb-ff279c3ddde9"));

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Asset",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
        }
    }
}
