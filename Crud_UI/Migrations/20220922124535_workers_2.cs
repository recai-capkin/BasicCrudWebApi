using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud_UI.Migrations
{
    public partial class workers_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorkerPositionId",
                table: "Workers",
                column: "WorkerPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Positions_WorkerPositionId",
                table: "Workers",
                column: "WorkerPositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Positions_WorkerPositionId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorkerPositionId",
                table: "Workers");
        }
    }
}
