using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace fekon_repository_datamodel.Migrations
{
    public partial class FekonRepositoryDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IsAdvisor = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AuthorNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    CommunityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CommunityName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CommunityCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.CommunityId);
                });

            migrationBuilder.CreateTable(
                name: "FileMonitoringHist",
                columns: table => new
                {
                    FileMonitoringHistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TotalFile = table.Column<int>(type: "int", nullable: false),
                    TotalSize = table.Column<int>(type: "int", nullable: false),
                    RunningDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RunningDuration = table.Column<int>(type: "int", nullable: false),
                    TotalFileProblem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMonitoringHist", x => x.FileMonitoringHistId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PublisherName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "RefCategorySearch",
                columns: table => new
                {
                    RefCategorySearchId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Property = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropertyCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CategoryName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCategorySearch", x => x.RefCategorySearchId);
                });

            migrationBuilder.CreateTable(
                name: "RefCollection",
                columns: table => new
                {
                    RefCollectionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CollName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CollCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCollection", x => x.RefCollectionId);
                });

            migrationBuilder.CreateTable(
                name: "RefLanguage",
                columns: table => new
                {
                    LangCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    LangName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RefLangu__F43B705372DC863F", x => x.LangCode);
                });

            migrationBuilder.CreateTable(
                name: "RefType",
                columns: table => new
                {
                    RefTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TypeCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefType", x => x.RefTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RefUser",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: true),
                    FullName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RefUser__1788CC4C479AB583", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(767)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(767)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "varchar(767)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(767)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(767)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(767)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefEmployee",
                columns: table => new
                {
                    RefEmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true),
                    EmployeeName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ProfilePicLoc = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefEmployee", x => x.RefEmployeeId);
                    table.ForeignKey(
                        name: "FK__RefEmploy__UserI__4F47C5E3",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserActivityHist",
                columns: table => new
                {
                    UserActivityHistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: false),
                    ActivityTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ActivityDesc = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    ActivityAction = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityHist", x => x.UserActivityHistId);
                    table.ForeignKey(
                        name: "FK__UserActiv__UserI__5224328E",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollectionD",
                columns: table => new
                {
                    CollectionDId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CollectionDName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CommunityId = table.Column<long>(type: "bigint", nullable: false),
                    RefCollectionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionD", x => x.CollectionDId);
                    table.ForeignKey(
                        name: "FK__Collectio__Commu__02084FDA",
                        column: x => x.CommunityId,
                        principalTable: "Community",
                        principalColumn: "CommunityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Collectio__RefCo__71D1E811",
                        column: x => x.RefCollectionId,
                        principalTable: "RefCollection",
                        principalColumn: "RefCollectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollectionDList",
                columns: table => new
                {
                    CollectionDListId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CollectionDListName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CollectionDId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionDList", x => x.CollectionDListId);
                    table.ForeignKey(
                        name: "FK__Collectio__Colle__3F466844",
                        column: x => x.CollectionDId,
                        principalTable: "CollectionD",
                        principalColumn: "CollectionDId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repository",
                columns: table => new
                {
                    RepositoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "text", unicode: false, nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Publisher = table.Column<long>(type: "bigint", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefCollectionId = table.Column<long>(type: "bigint", nullable: true),
                    CollectionDId = table.Column<long>(type: "bigint", nullable: true),
                    CommunitiyId = table.Column<long>(type: "bigint", nullable: true),
                    UsrCreate = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repository", x => x.RepositoryId);
                    table.ForeignKey(
                        name: "FK__Repositor__Colle__70DDC3D8",
                        column: x => x.CollectionDId,
                        principalTable: "CollectionD",
                        principalColumn: "CollectionDId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Repositor__Commu__01142BA1",
                        column: x => x.CommunitiyId,
                        principalTable: "Community",
                        principalColumn: "CommunityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Repositor__Publi__29572725",
                        column: x => x.Publisher,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Repositor__RefCo__5AEE82B9",
                        column: x => x.RefCollectionId,
                        principalTable: "RefCollection",
                        principalColumn: "RefCollectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileDetail",
                columns: table => new
                {
                    FileDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    FileType = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FilePath = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    RepositoryId = table.Column<long>(type: "bigint", nullable: true),
                    FileSize = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FileExt = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    OriginFileName = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDetail", x => x.FileDetailId);
                    table.ForeignKey(
                        name: "FK__FileDetai__Repos__2C3393D0",
                        column: x => x.RepositoryId,
                        principalTable: "Repository",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepositoryD",
                columns: table => new
                {
                    RepositoryDid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RepositoryId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepositoryD", x => x.RepositoryDid);
                    table.ForeignKey(
                        name: "FK__Repositor__Autho__48CFD27E",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Repositor__Repos__47DBAE45",
                        column: x => x.RepositoryId,
                        principalTable: "Repository",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepoStatistic",
                columns: table => new
                {
                    RepoStatisticId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LinkHitCount = table.Column<long>(type: "bigint", nullable: false),
                    DownloadCount = table.Column<long>(type: "bigint", nullable: false),
                    RepositoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepoStatistic", x => x.RepoStatisticId);
                    table.ForeignKey(
                        name: "FK__RepoStati__Repos__4BAC3F29",
                        column: x => x.RepositoryId,
                        principalTable: "Repository",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DownloadStatistic",
                columns: table => new
                {
                    DownloadStatisticId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FileDetailId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: false),
                    DownloadDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadStatistic", x => x.DownloadStatisticId);
                    table.ForeignKey(
                        name: "FK__DownloadS__FileD__29221CFB",
                        column: x => x.FileDetailId,
                        principalTable: "FileDetail",
                        principalColumn: "FileDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DownloadS__UserI__2A164134",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileMonitoringResult",
                columns: table => new
                {
                    FileMonitoringResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FileMonitoringHistId = table.Column<long>(type: "bigint", nullable: true),
                    FileDetailId = table.Column<long>(type: "bigint", nullable: true),
                    StatusFile = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMonitoringResult", x => x.FileMonitoringResultId);
                    table.ForeignKey(
                        name: "FK__FileMonit__FileD__2FCF1A8A",
                        column: x => x.FileDetailId,
                        principalTable: "FileDetail",
                        principalColumn: "FileDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__FileMonit__FileM__2EDAF651",
                        column: x => x.FileMonitoringHistId,
                        principalTable: "FileMonitoringHist",
                        principalColumn: "FileMonitoringHistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionD_CommunityId",
                table: "CollectionD",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionD_RefCollectionId",
                table: "CollectionD",
                column: "RefCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionDList_CollectionDId",
                table: "CollectionDList",
                column: "CollectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_DownloadStatistic_FileDetailId",
                table: "DownloadStatistic",
                column: "FileDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DownloadStatistic_UserId",
                table: "DownloadStatistic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDetail_RepositoryId",
                table: "FileDetail",
                column: "RepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FileMonitoringResult_FileDetailId",
                table: "FileMonitoringResult",
                column: "FileDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_FileMonitoringResult_FileMonitoringHistId",
                table: "FileMonitoringResult",
                column: "FileMonitoringHistId");

            migrationBuilder.CreateIndex(
                name: "IX_RefEmployee_UserId",
                table: "RefEmployee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository_CollectionDId",
                table: "Repository",
                column: "CollectionDId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository_CommunitiyId",
                table: "Repository",
                column: "CommunitiyId");

            migrationBuilder.CreateIndex(
                name: "IX_Repository_Publisher",
                table: "Repository",
                column: "Publisher");

            migrationBuilder.CreateIndex(
                name: "IX_Repository_RefCollectionId",
                table: "Repository",
                column: "RefCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RepositoryD_AuthorId",
                table: "RepositoryD",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_RepositoryD_RepositoryId",
                table: "RepositoryD",
                column: "RepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RepoStatistic_RepositoryId",
                table: "RepoStatistic",
                column: "RepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityHist_UserId",
                table: "UserActivityHist",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CollectionDList");

            migrationBuilder.DropTable(
                name: "DownloadStatistic");

            migrationBuilder.DropTable(
                name: "FileMonitoringResult");

            migrationBuilder.DropTable(
                name: "RefCategorySearch");

            migrationBuilder.DropTable(
                name: "RefEmployee");

            migrationBuilder.DropTable(
                name: "RefLanguage");

            migrationBuilder.DropTable(
                name: "RefType");

            migrationBuilder.DropTable(
                name: "RefUser");

            migrationBuilder.DropTable(
                name: "RepositoryD");

            migrationBuilder.DropTable(
                name: "RepoStatistic");

            migrationBuilder.DropTable(
                name: "UserActivityHist");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FileDetail");

            migrationBuilder.DropTable(
                name: "FileMonitoringHist");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Repository");

            migrationBuilder.DropTable(
                name: "CollectionD");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "RefCollection");
        }
    }
}
