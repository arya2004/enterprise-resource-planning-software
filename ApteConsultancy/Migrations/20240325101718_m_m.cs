using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.Migrations
{
    /// <inheritdoc />
    public partial class m_m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Architects_ArchitectId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ArchitectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ArchitectId",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "ArchitectProject",
                columns: table => new
                {
                    ArchitectsArchitectId = table.Column<int>(type: "int", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchitectProject", x => new { x.ArchitectsArchitectId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_ArchitectProject_Architects_ArchitectsArchitectId",
                        column: x => x.ArchitectsArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchitectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArchitectProject_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchitectProject_ProjectsProjectId",
                table: "ArchitectProject",
                column: "ProjectsProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchitectProject");

            migrationBuilder.AddColumn<int>(
                name: "ArchitectId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ArchitectId",
                table: "Projects",
                column: "ArchitectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Architects_ArchitectId",
                table: "Projects",
                column: "ArchitectId",
                principalTable: "Architects",
                principalColumn: "ArchitectId");
        }
    }
}
