using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary.Migrations
{
    public partial class UpdateAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Dictionary",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionary", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Dictionary",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Dictionary",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Dictionary",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsRTL = table.Column<bool>(type: "bit", nullable: false),
                    Short_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Language",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Language",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Language",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Miscellaneous",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miscellaneous", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Miscellaneous",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Miscellaneous",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Miscellaneous",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionAssociation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BGImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionAssociation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Guild",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Guild",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Guild",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionAssociationCouncilWord",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionAssociationCouncilWord", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_SyndicateCouncilWord",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_SyndicateCouncilWord",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_SyndicateCouncilWord",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionAssociationFooter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoalsTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembersTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionAssociationFooter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_GuildFooter",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_GuildFooter",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_GuildFooter",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionAssociationMember",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionAssociationMember", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_GuildMember",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_GuildMember",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_GuildMember",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionCinemaLibraryFooter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorldCinemaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabCinemaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionCinemaLibraryFooter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_CinemaLibraryFooter",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_CinemaLibraryFooter",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_CinemaLibraryFooter",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionContact",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtnTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtnBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionContact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Contact",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Contact",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Contact",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionContactFooter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Morning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evening = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionContactFooter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_ContactFooter",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_ContactFooter",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_ContactFooter",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionCurrentlyShowing",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionCurrentlyShowing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_CurrentlyShowing",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_CurrentlyShowing",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_CurrentlyShowing",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionCurrentlyShowingList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionCurrentlyShowingList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_CurrentlyShowingList",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_CurrentlyShowingList",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_CurrentlyShowingList",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionDivision",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BtnTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtnColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberCounttitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionDivision", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Division",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Division",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Division",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionEvent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEvent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Event",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Event",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Event",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionEventList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEventList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_EventList",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_EventList",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_EventList",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionFooter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionFooter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Footer",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Footer",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Footer",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionIntro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Button_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionIntro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Intro",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Intro",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Intro",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionLatestNew",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionLatestNew", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_LatestNew",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_LatestNew",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_LatestNew",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionLatestNewList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionLatestNewList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_LatestNewsList",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_LatestNewsList",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_LatestNewsList",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionLatestService",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionLatestService", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_LatestService",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_LatestService",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_LatestService",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionLatestServiceList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionLatestServiceList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_LatestServiceList",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_LatestServiceList",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_LatestServiceList",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionService",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionService", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_Service",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_Service",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_Service",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SectionVisiblity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    CreationUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyUserID = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteUserID = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionVisiblity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserCreation_SectionVisiblity",
                        column: x => x.CreationUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserDelete_SectionVisiblity",
                        column: x => x.DeleteUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserModify_SectionVisiblity",
                        column: x => x.ModifyUserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dictionary_CreationUserID",
                table: "Dictionary",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionary_DeleteUserID",
                table: "Dictionary",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Dictionary_ModifyUserID",
                table: "Dictionary",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_CreationUserID",
                table: "Language",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_DeleteUserID",
                table: "Language",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_ModifyUserID",
                table: "Language",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Miscellaneous_CreationUserID",
                table: "Miscellaneous",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Miscellaneous_DeleteUserID",
                table: "Miscellaneous",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Miscellaneous_ModifyUserID",
                table: "Miscellaneous",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociation_CreationUserID",
                table: "SectionAssociation",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociation_DeleteUserID",
                table: "SectionAssociation",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociation_ModifyUserID",
                table: "SectionAssociation",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationCouncilWord_CreationUserID",
                table: "SectionAssociationCouncilWord",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationCouncilWord_DeleteUserID",
                table: "SectionAssociationCouncilWord",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationCouncilWord_ModifyUserID",
                table: "SectionAssociationCouncilWord",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationFooter_CreationUserID",
                table: "SectionAssociationFooter",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationFooter_DeleteUserID",
                table: "SectionAssociationFooter",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationFooter_ModifyUserID",
                table: "SectionAssociationFooter",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationMember_CreationUserID",
                table: "SectionAssociationMember",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationMember_DeleteUserID",
                table: "SectionAssociationMember",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionAssociationMember_ModifyUserID",
                table: "SectionAssociationMember",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCinemaLibraryFooter_CreationUserID",
                table: "SectionCinemaLibraryFooter",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCinemaLibraryFooter_DeleteUserID",
                table: "SectionCinemaLibraryFooter",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCinemaLibraryFooter_ModifyUserID",
                table: "SectionCinemaLibraryFooter",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContact_CreationUserID",
                table: "SectionContact",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContact_DeleteUserID",
                table: "SectionContact",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContact_ModifyUserID",
                table: "SectionContact",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContactFooter_CreationUserID",
                table: "SectionContactFooter",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContactFooter_DeleteUserID",
                table: "SectionContactFooter",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionContactFooter_ModifyUserID",
                table: "SectionContactFooter",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowing_CreationUserID",
                table: "SectionCurrentlyShowing",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowing_DeleteUserID",
                table: "SectionCurrentlyShowing",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowing_ModifyUserID",
                table: "SectionCurrentlyShowing",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowingList_CreationUserID",
                table: "SectionCurrentlyShowingList",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowingList_DeleteUserID",
                table: "SectionCurrentlyShowingList",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionCurrentlyShowingList_ModifyUserID",
                table: "SectionCurrentlyShowingList",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionDivision_CreationUserID",
                table: "SectionDivision",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionDivision_DeleteUserID",
                table: "SectionDivision",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionDivision_ModifyUserID",
                table: "SectionDivision",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEvent_CreationUserID",
                table: "SectionEvent",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEvent_DeleteUserID",
                table: "SectionEvent",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEvent_ModifyUserID",
                table: "SectionEvent",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEventList_CreationUserID",
                table: "SectionEventList",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEventList_DeleteUserID",
                table: "SectionEventList",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEventList_ModifyUserID",
                table: "SectionEventList",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionFooter_CreationUserID",
                table: "SectionFooter",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionFooter_DeleteUserID",
                table: "SectionFooter",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionFooter_ModifyUserID",
                table: "SectionFooter",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionIntro_CreationUserID",
                table: "SectionIntro",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionIntro_DeleteUserID",
                table: "SectionIntro",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionIntro_ModifyUserID",
                table: "SectionIntro",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNew_CreationUserID",
                table: "SectionLatestNew",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNew_DeleteUserID",
                table: "SectionLatestNew",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNew_ModifyUserID",
                table: "SectionLatestNew",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNewList_CreationUserID",
                table: "SectionLatestNewList",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNewList_DeleteUserID",
                table: "SectionLatestNewList",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestNewList_ModifyUserID",
                table: "SectionLatestNewList",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestService_CreationUserID",
                table: "SectionLatestService",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestService_DeleteUserID",
                table: "SectionLatestService",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestService_ModifyUserID",
                table: "SectionLatestService",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestServiceList_CreationUserID",
                table: "SectionLatestServiceList",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestServiceList_DeleteUserID",
                table: "SectionLatestServiceList",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionLatestServiceList_ModifyUserID",
                table: "SectionLatestServiceList",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionService_CreationUserID",
                table: "SectionService",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionService_DeleteUserID",
                table: "SectionService",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionService_ModifyUserID",
                table: "SectionService",
                column: "ModifyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionVisiblity_CreationUserID",
                table: "SectionVisiblity",
                column: "CreationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionVisiblity_DeleteUserID",
                table: "SectionVisiblity",
                column: "DeleteUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SectionVisiblity_ModifyUserID",
                table: "SectionVisiblity",
                column: "ModifyUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dictionary");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Miscellaneous");

            migrationBuilder.DropTable(
                name: "SectionAssociation");

            migrationBuilder.DropTable(
                name: "SectionAssociationCouncilWord");

            migrationBuilder.DropTable(
                name: "SectionAssociationFooter");

            migrationBuilder.DropTable(
                name: "SectionAssociationMember");

            migrationBuilder.DropTable(
                name: "SectionCinemaLibraryFooter");

            migrationBuilder.DropTable(
                name: "SectionContact");

            migrationBuilder.DropTable(
                name: "SectionContactFooter");

            migrationBuilder.DropTable(
                name: "SectionCurrentlyShowing");

            migrationBuilder.DropTable(
                name: "SectionCurrentlyShowingList");

            migrationBuilder.DropTable(
                name: "SectionDivision");

            migrationBuilder.DropTable(
                name: "SectionEvent");

            migrationBuilder.DropTable(
                name: "SectionEventList");

            migrationBuilder.DropTable(
                name: "SectionFooter");

            migrationBuilder.DropTable(
                name: "SectionIntro");

            migrationBuilder.DropTable(
                name: "SectionLatestNew");

            migrationBuilder.DropTable(
                name: "SectionLatestNewList");

            migrationBuilder.DropTable(
                name: "SectionLatestService");

            migrationBuilder.DropTable(
                name: "SectionLatestServiceList");

            migrationBuilder.DropTable(
                name: "SectionService");

            migrationBuilder.DropTable(
                name: "SectionVisiblity");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
