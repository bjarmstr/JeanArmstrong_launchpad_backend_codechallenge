using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaunchpadCodeChallenge.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0"), "5th floor", "Engineering" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("32765d3e-4e43-41a3-8177-4409cb508b7a"), "7th floor", "Administration" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { new Guid("c5845a58-f668-4459-9d4b-70ddc5197fec"), "123 My Street", new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0"), "Vivi", "Software Developer", "Jones" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { new Guid("dc7814a6-5d0c-45f7-8096-ff8bb90d69e3"), "345 23rd St, NE", new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0"), "Jack", "Software Developer", "Brown" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { new Guid("848866eb-c5b9-4a72-97f3-0af770123355"), "4532 Briar Hill Way, SW", new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0"), "Millie", "Software Architect", "Peterson" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { new Guid("42374644-1216-4411-8645-a7732270f165"), "19934 15 Ave, NE", new Guid("32765d3e-4e43-41a3-8177-4409cb508b7a"), "John", "Receptionist", "Smith" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
