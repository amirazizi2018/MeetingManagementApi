using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetingManagementInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7923c8a7-ede6-4831-a735-98ebd700fc35"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("769b400f-aeec-4669-9784-e7a3ebf7fccb"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "hassan@gmail.com", "حسن", "احسانی", "$2a$11$K9/BW2vLSJzDhIxpbLvkreFEipNpKSy4GLlkD1fvuR8J7jltaduV2", "Member", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7b9684f9-51d1-423f-8666-b51c55d95918"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "ali@gmail.com", "علی", "منصوری", "$2a$11$L4mbMrzlIbCGfoDxS3Q.H.vBlMXf4zipRi7axon5SXVbNEuqXvIlW", "Member", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd3252f7-f18c-4b21-9a50-c54b58688e58"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "admin@gmail.com", "امیر", "عزیزی", "$2a$11$PApAaAqms9uDUO5iRKiNce8sYcVSg4wxBSho1AUbNtiiQjl/9R67.", "Admin", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d3a3b7fb-b599-4647-b059-306625200570"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "mohammad@gmail.com", "محمد", "مقدسی", "$2a$11$57s53U4BtYwe6SrCZraP7u1JWycYZToWC9M5NNkBw9G58qhXl7hUO", "Member", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("769b400f-aeec-4669-9784-e7a3ebf7fccb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b9684f9-51d1-423f-8666-b51c55d95918"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd3252f7-f18c-4b21-9a50-c54b58688e58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3a3b7fb-b599-4647-b059-306625200570"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role", "UpdatedAt" },
                values: new object[] { new Guid("7923c8a7-ede6-4831-a735-98ebd700fc35"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "amirazizi67@gmail.com", "امیر", "عزیزی", "$2a$11$mYriolok.RbfktG00wvrMOtw9dqMr5RVURQ8HJw2tkUkQYhd.ylou", "Admin", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
