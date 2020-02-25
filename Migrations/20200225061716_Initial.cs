using Microsoft.EntityFrameworkCore.Migrations;

namespace IParse.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientCarousels",
                columns: table => new
                {
                    ClientCarouselId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCarousels", x => x.ClientCarouselId);
                });

            migrationBuilder.CreateTable(
                name: "RequestQuestions",
                columns: table => new
                {
                    RequestQuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestQuestions", x => x.RequestQuestionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCarousels");

            migrationBuilder.DropTable(
                name: "RequestQuestions");
        }
    }
}
