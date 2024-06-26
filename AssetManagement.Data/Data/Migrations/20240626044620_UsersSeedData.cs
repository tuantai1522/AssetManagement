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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
