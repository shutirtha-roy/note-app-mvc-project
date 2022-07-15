using Microsoft.EntityFrameworkCore.Migrations;

namespace NotesApp.Migrations
{
    public partial class AddNotesTypeFKToNotesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoteTypeId",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_NoteTypeId",
                table: "Notes",
                column: "NoteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_NoteTypes_NoteTypeId",
                table: "Notes",
                column: "NoteTypeId",
                principalTable: "NoteTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_NoteTypes_NoteTypeId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_NoteTypeId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "NoteTypeId",
                table: "Notes");
        }
    }
}
