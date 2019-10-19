using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasteryBlog2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Reviewer = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagBlogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagBlogs", x => new { x.BlogId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TagBlogs_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagBlogs_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Genre" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Erotica" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Content" },
                values: new object[,]
                {
                    { 1, "Enjoyable Reading" },
                    { 2, "Innapropriate Reading" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Body", "CategoryId", "DateTime", "Image", "Reviewer", "Title" },
                values: new object[,]
                {
                    { 1, "Seriously it is the best freaking book I've ever read .and I'm not the type of a person who always reads books, I like movies more, still the movie is absolutely breathtaking so as the book, and if I have to compare the movie to the book I would definitely choose the book. I highly recommended.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/LordOfTheRings.jpg", "LEGOLAS_IS_NOT_DED", "The Lord of the Rings" },
                    { 2, "There are few worlds more richly imagined than Tolkien's Middle Earth. Readers would get caught up just in his exquisitely imaginative details if it weren't for the nonstop adventure; it's a perfect balance. Add to that a wonderful main character -- the hairy-footed little hobbit who truly triumphs -- and you have the perfect fantasy-adventure. This is how it's done.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/TheHobbit.jpg", "Aragorn-4ever-XSlayerX", "The Hobbit" },
                    { 3, "Given what I'd heard about this book I expected it to be poorly written and salacious. I had never intended to read it for those reasons. But with the movie out this weekend, I can't walk two feet without having this book in my face. I decided I needed to read it, so I would truly know what all the fuss was about. What surprised me was how boring it was. There was no plot and the dialogue was silly. Also, with all the talk about this book, I expected it to be sexy to the point of scandalous. I didn't find it sexy at all and certainly not romantic. When all is said and done, it's not the subject matter that I find offensive. It's the bad writing.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/FiftyShadesGrey.jpg", "Not Justin Brown", "Fifty Shades of Grey" },
                    { 4, "This trilogy is a guilty pleasure, no doubt about it. It is not a literary work of art. It is not a challenging read. Much of the story is predictable. Some parts are cheesy. That being said, it's an addicting story one step above a $5 romance novel and I'm not ashamed to say I enjoyed it.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/FiftyShadesDarker.jpg", "Maybe Justin Brown", "Fifty Shades Darker" },
                    { 5, "I have become enticed by these characters and their story. The kinky stuff was interesting to read but I really enjoyed the characters. Their conflict, different personalities, sharing and becoming one in marriage. There is more to the story then the sex and that I enjoyed greatly. I love how Anna loves and helps Christian to become a better himself. Then again the way Christian pushes Anna to be bolder and more attentive is really inspiring. Their love story, yes kinky and out of the normal, is what I wish to accomplish. The partnership, trust, and growth I want in my relationship. I will see about getting my love to read this and maybe I will.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/Images/FiftyShadesFreed.jpg", "Definitely Justin Brown", "Fifty Shades Freed" }
                });

            migrationBuilder.InsertData(
                table: "TagBlogs",
                columns: new[] { "BlogId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagBlogs_TagId",
                table: "TagBlogs",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagBlogs");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
