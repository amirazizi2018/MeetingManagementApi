using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingManagementInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Role", "UpdatedAt" },
                values: new object[] { new Guid("7923c8a7-ede6-4831-a735-98ebd700fc35"), new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "amirazizi67@gmail.com", "امیر", "عزیزی", "$2a$11$mYriolok.RbfktG00wvrMOtw9dqMr5RVURQ8HJw2tkUkQYhd.ylou", "Admin", new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7923c8a7-ede6-4831-a735-98ebd700fc35"));
        }
    }
}
