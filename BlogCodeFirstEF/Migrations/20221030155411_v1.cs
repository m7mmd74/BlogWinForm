using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogCodeFirstEF.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    auth_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    auth_isBlocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.auth_id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    o_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.o_id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    b_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    o_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.b_id);
                    table.ForeignKey(
                        name: "FK_Blogs_Owners_o_Id",
                        column: x => x.o_Id,
                        principalTable: "Owners",
                        principalColumn: "o_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    p_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brief = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    p_media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    author_id = table.Column<int>(type: "int", nullable: true),
                    authorauth_id = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.p_id);
                    table.ForeignKey(
                        name: "FK_Posts_Authors_authorauth_id",
                        column: x => x.authorauth_id,
                        principalTable: "Authors",
                        principalColumn: "auth_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "b_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_o_Id",
                table: "Blogs",
                column: "o_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_authorauth_id",
                table: "Posts",
                column: "authorauth_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
