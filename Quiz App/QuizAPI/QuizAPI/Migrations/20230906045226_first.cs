using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "quiz");

            migrationBuilder.CreateTable(
                name: "participants",
                schema: "quiz",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    TimeTaken = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participants", x => x.ParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                schema: "quiz",
                columns: table => new
                {
                    QnId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QnInWords = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    ImageName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Option1 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Option2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Option3 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Option4 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Answer = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.QnId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "participants",
                schema: "quiz");

            migrationBuilder.DropTable(
                name: "questions",
                schema: "quiz");
        }
    }
}
