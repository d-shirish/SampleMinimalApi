using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookapiMinimal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bookapi");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "bookapi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "bookapi",
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "Description", "Language", "Title", "TotalPages" },
                values: new object[,]
                {
                    { new Guid("30554fd5-7186-4f52-a271-9eabc88594bb"), "Paulo Coelho", "Fiction", "The Alchemist follows the journey of an Andalusian shepherd", "English", "The Alchemist", 208 },
                    { new Guid("43017ca4-6f0e-4039-9e26-9a1f95ba76d3"), "George Orwell", "Fiction", "A dystopian social science fiction novel and cautionary tale about the dangers of totalitarianism. ", "English", "1984", 328 },
                    { new Guid("b1d0b271-0c9d-4c23-b42c-dbff63aa8c45"), "Harper Lee", "Fiction", "A novel about the serious issues of rape and racial inequality.", "English", "To Kill a Mockingbird", 281 },
                    { new Guid("bbf2c501-8156-424c-80f4-b09e1e3dd445"), "Paulo Coelho", "Fiction", "The Alchemist follows the journey of an Andalusian shepherd", "English", "The Alchemist", 208 },
                    { new Guid("bcd324dd-c3ea-4f98-9e80-5766113255f1"), "Harper Lee", "Fiction", "A novel about the serious issues of rape and racial inequality.", "English", "To Kill a Mockingbird", 281 },
                    { new Guid("c7851419-7437-45fd-ac8f-657574aa5a31"), "George Orwell", "Fiction", "A dystopian social science fiction novel and cautionary tale about the dangers of totalitarianism. ", "English", "1984", 328 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books",
                schema: "bookapi");
        }
    }
}
