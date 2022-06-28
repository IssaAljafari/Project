using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class DBInitial_28062022_154600 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionVisiblity",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionService",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionLatestServiceList",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionLatestService",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionLatestNewList",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionLatestNew",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionIntro",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionFooter",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionEventList",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionEvent",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionDivision",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionCurrentlyShowingList",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionCurrentlyShowing",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionContactFooter",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionContact",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionCinemaLibraryFooter",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionAssociationMember",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionAssociationFooter",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionAssociationCouncilWord",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "SectionAssociation",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "Miscellaneous",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "Language",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Is_Deleted",
                table: "Dictionary",
                newName: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionVisiblity",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionService",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionLatestServiceList",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionLatestService",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionLatestNewList",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionLatestNew",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionIntro",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionFooter",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionEventList",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionEvent",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionDivision",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionCurrentlyShowingList",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionCurrentlyShowing",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionContactFooter",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionContact",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionCinemaLibraryFooter",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionAssociationMember",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionAssociationFooter",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionAssociationCouncilWord",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "SectionAssociation",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Miscellaneous",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Language",
                newName: "Is_Deleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Dictionary",
                newName: "Is_Deleted");
        }
    }
}
