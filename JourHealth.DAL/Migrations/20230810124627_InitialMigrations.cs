using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JourHealth.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DoctorSpeciality = table.Column<string>(type: "text", nullable: false),
                    DoctorFullName = table.Column<string>(type: "text", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    Diagnosis = table.Column<string>(type: "text", nullable: false),
                    TypeOfCure = table.Column<string>(type: "text", nullable: false),
                    Recipe = table.Column<string>(type: "text", nullable: false),
                    InspectionTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PatienId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalHistories_Patients_PatienId",
                        column: x => x.PatienId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1L, "2668 Garrison Court", new DateTime(1956, 6, 2, 19, 0, 0, 0, DateTimeKind.Utc), "fpargiter0@addtoany.com", "Frasco", "Male", "Pargiter", "+7 722 471 0555" },
                    { 2L, "154 Lake View Hill", new DateTime(1978, 8, 22, 19, 0, 0, 0, DateTimeKind.Utc), "ulunney1@mapy.cz", "Urbanus", "Male", "Lunney", "+7 948 513 0995" },
                    { 3L, "8 Kennedy Parkway", new DateTime(1988, 1, 11, 19, 0, 0, 0, DateTimeKind.Utc), "wluckett2@zdnet.com", "Wyndham", "Male", "Luckett", "+86 716 519 6428" },
                    { 4L, "191 Del Sol Trail", new DateTime(1928, 10, 31, 19, 0, 0, 0, DateTimeKind.Utc), "zferreiro3@plala.or.jp", "Zacharia", "Male", "Ferreiro", "+62 556 355 0529" },
                    { 5L, "62 Delladonna Crossing", new DateTime(2013, 4, 2, 19, 0, 0, 0, DateTimeKind.Utc), "vguare4@blogspot.com", "Vannie", "Female", "Guare", "+62 433 615 2364" },
                    { 6L, "90301 Jana Circle", new DateTime(2017, 9, 2, 19, 0, 0, 0, DateTimeKind.Utc), "ddrydale5@psu.edu", "Dawn", "Female", "Drydale", "+63 433 896 1062" },
                    { 7L, "9244 6th Street", new DateTime(2021, 2, 3, 19, 0, 0, 0, DateTimeKind.Utc), "cselwyn6@wufoo.com", "Charil", "Female", "Selwyn", "+385 632 311 1550" },
                    { 8L, "78552 Mandrake Trail", new DateTime(1928, 6, 6, 19, 0, 0, 0, DateTimeKind.Utc), "ecordrey7@adobe.com", "Elijah", "Male", "Cordrey", "+380 203 655 7729" },
                    { 9L, "3 Esch Terrace", new DateTime(2006, 6, 17, 19, 0, 0, 0, DateTimeKind.Utc), "mdrinkhill8@telegraph.co.uk", "Margo", "Female", "Drinkhill", "+20 625 506 6824" },
                    { 10L, "47 Buhler Pass", new DateTime(2009, 10, 8, 19, 0, 0, 0, DateTimeKind.Utc), "fsaddleton9@wunderground.com", "Fair", "Male", "Saddleton", "+7 998 571 3542" },
                    { 11L, "52813 Jenifer Plaza", new DateTime(2013, 11, 17, 19, 0, 0, 0, DateTimeKind.Utc), "ogirodiasa@163.com", "Osbourn", "Male", "Girodias", "+7 509 569 5039" },
                    { 12L, "00220 Golf View Center", new DateTime(2001, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), "fwillattb@epa.gov", "Freda", "Female", "Willatt", "+62 617 638 3707" },
                    { 13L, "30 Waubesa Way", new DateTime(2001, 5, 17, 19, 0, 0, 0, DateTimeKind.Utc), "skingzettc@gmpg.org", "Simone", "Male", "Kingzett", "+62 366 244 3294" },
                    { 14L, "02 Hansons Center", new DateTime(2003, 9, 16, 19, 0, 0, 0, DateTimeKind.Utc), "tkennellyd@mail.ru", "Timmy", "Female", "Kennelly", "+595 118 401 2243" },
                    { 15L, "8 Jackson Pass", new DateTime(2007, 7, 11, 19, 0, 0, 0, DateTimeKind.Utc), "svanoorde@posterous.com", "Saxe", "Male", "Van Oord", "+380 700 958 2544" }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "Id", "Diagnosis", "DoctorFullName", "DoctorSpeciality", "InspectionTime", "PatienId", "Recipe", "Symptoms", "TypeOfCure" },
                values: new object[,]
                {
                    { 1L, "Asperger syndrome", "Cordrey Zacharia", "Dermatolog", new DateTime(2013, 2, 9, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Aspiren,Izofluran", "Measles", "Diabetes Treatments" },
                    { 2L, " Rett syndrome", "Drinkhill Elijah", "Neurolog", new DateTime(2018, 5, 14, 19, 0, 0, 0, DateTimeKind.Utc), 2L, "Morfin", "conjunctivitis", "Stem Cell Therapy" },
                    { 3L, " Scrotum", "Kennelly", "Orthoped", new DateTime(2013, 9, 17, 19, 0, 0, 0, DateTimeKind.Utc), 6L, " Garlic clove, Minced", "Cough", "Islet Cell Transplantation" },
                    { 4L, " Strabismus", "Lunney Freda", "Pediatr", new DateTime(2007, 2, 19, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Galotan", "Pathognomonic", "Immunotherapies" },
                    { 5L, "Reproductive system", "Ferreiro Timmy", "Cardiolog", new DateTime(2017, 5, 22, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Droperidol", "Dehydration", "Inhaled Insulin" },
                    { 6L, " Pervasive developmental disorders ", "Kennelly Dawn", "Psychiatr", new DateTime(2001, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), 3L, "Diazepam", "Allergy", "Preserve Function of Beta Cells" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatienId",
                table: "MedicalHistories",
                column: "PatienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalHistories");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
