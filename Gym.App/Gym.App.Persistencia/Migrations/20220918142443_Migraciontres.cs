using Microsoft.EntityFrameworkCore.Migrations;

namespace Gym.App.Persistencia.Migrations
{
    public partial class Migraciontres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriesConsumed",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "Series",
                table: "Exercises",
                newName: "UrlExercise");

            migrationBuilder.RenameColumn(
                name: "Repetitions",
                table: "Exercises",
                newName: "ExerciseConditions");

            migrationBuilder.AddColumn<int>(
                name: "BodyPart",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsecutivoIntensidad",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConsumedCalories",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intensity",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TiempoDedidado",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoutineExerciseId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoutineExerciseId",
                table: "Customers",
                column: "RoutineExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Routines_RoutineExerciseId",
                table: "Customers",
                column: "RoutineExerciseId",
                principalTable: "Routines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Routines_RoutineExerciseId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoutineExerciseId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BodyPart",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ConsecutivoIntensidad",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ConsumedCalories",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Intensity",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TiempoDedidado",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "RoutineExerciseId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "UrlExercise",
                table: "Exercises",
                newName: "Series");

            migrationBuilder.RenameColumn(
                name: "ExerciseConditions",
                table: "Exercises",
                newName: "Repetitions");

            migrationBuilder.AddColumn<string>(
                name: "CaloriesConsumed",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
