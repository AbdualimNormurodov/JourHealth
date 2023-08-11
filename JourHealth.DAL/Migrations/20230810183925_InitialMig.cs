using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JourHealth.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMig : Migration
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
                    Address = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    PatienId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                columns: new[] { "Id", "Address", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "2668 Garrison Court", null, new DateTime(1956, 6, 2, 19, 0, 0, 0, DateTimeKind.Utc), "fpargiter0@addtoany.com", "Frasco", "Male", "Pargiter", "+7 722 471 0555", null },
                    { 2L, "154 Lake View Hill", null, new DateTime(1978, 8, 22, 19, 0, 0, 0, DateTimeKind.Utc), "ulunney1@mapy.cz", "Urbanus", "Male", "Lunney", "+7 948 513 0995", null },
                    { 3L, "8 Kennedy Parkway", null, new DateTime(1988, 1, 11, 19, 0, 0, 0, DateTimeKind.Utc), "wluckett2@zdnet.com", "Wyndham", "Male", "Luckett", "+86 716 519 6428", null },
                    { 4L, "191 Del Sol Trail", null, new DateTime(1928, 10, 31, 19, 0, 0, 0, DateTimeKind.Utc), "zferreiro3@plala.or.jp", "Zacharia", "Male", "Ferreiro", "+62 556 355 0529", null },
                    { 5L, "62 Delladonna Crossing", null, new DateTime(2013, 4, 2, 19, 0, 0, 0, DateTimeKind.Utc), "vguare4@blogspot.com", "Vannie", "Female", "Guare", "+62 433 615 2364", null },
                    { 6L, "90301 Jana Circle", null, new DateTime(2017, 9, 2, 19, 0, 0, 0, DateTimeKind.Utc), "ddrydale5@psu.edu", "Dawn", "Female", "Drydale", "+63 433 896 1062", null },
                    { 7L, "9244 6th Street", null, new DateTime(2021, 2, 3, 19, 0, 0, 0, DateTimeKind.Utc), "cselwyn6@wufoo.com", "Charil", "Female", "Selwyn", "+385 632 311 1550", null },
                    { 8L, "78552 Mandrake Trail", null, new DateTime(1928, 6, 6, 19, 0, 0, 0, DateTimeKind.Utc), "ecordrey7@adobe.com", "Elijah", "Male", "Cordrey", "+380 203 655 7729", null },
                    { 9L, "3 Esch Terrace", null, new DateTime(2006, 6, 17, 19, 0, 0, 0, DateTimeKind.Utc), "mdrinkhill8@telegraph.co.uk", "Margo", "Female", "Drinkhill", "+20 625 506 6824", null },
                    { 10L, "47 Buhler Pass", null, new DateTime(2009, 10, 8, 19, 0, 0, 0, DateTimeKind.Utc), "fsaddleton9@wunderground.com", "Fair", "Male", "Saddleton", "+7 998 571 3542", null },
                    { 11L, "52813 Jenifer Plaza", null, new DateTime(2013, 11, 17, 19, 0, 0, 0, DateTimeKind.Utc), "ogirodiasa@163.com", "Osbourn", "Male", "Girodias", "+7 509 569 5039", null },
                    { 12L, "00220 Golf View Center", null, new DateTime(2001, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), "fwillattb@epa.gov", "Freda", "Female", "Willatt", "+62 617 638 3707", null },
                    { 13L, "30 Waubesa Way", null, new DateTime(2001, 5, 17, 19, 0, 0, 0, DateTimeKind.Utc), "skingzettc@gmpg.org", "Simone", "Male", "Kingzett", "+62 366 244 3294", null },
                    { 14L, "02 Hansons Center", null, new DateTime(2003, 9, 16, 19, 0, 0, 0, DateTimeKind.Utc), "tkennellyd@mail.ru", "Timmy", "Female", "Kennelly", "+595 118 401 2243", null },
                    { 15L, "8 Jackson Pass", null, new DateTime(2007, 7, 11, 19, 0, 0, 0, DateTimeKind.Utc), "svanoorde@posterous.com", "Saxe", "Male", "Van Oord", "+380 700 958 2544", null }
                });

            migrationBuilder.InsertData(
                table: "MedicalHistories",
                columns: new[] { "Id", "CreatedAt", "Diagnosis", "DoctorFullName", "DoctorSpeciality", "InspectionTime", "PatienId", "Recipe", "Symptoms", "TypeOfCure", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, null, "Asperger syndrome", "Cordrey Zacharia", "Dermatolog", new DateTime(2013, 2, 9, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Aspiren,Izofluran", "Measles", "Diabetes Treatments", null },
                    { 2L, null, " Rett syndrome", "Drinkhill Elijah", "Neurolog", new DateTime(2018, 5, 14, 19, 0, 0, 0, DateTimeKind.Utc), 2L, "Morfin", "conjunctivitis", "Stem Cell Therapy", null },
                    { 3L, null, " Scrotum", "Kennelly", "Orthoped", new DateTime(2013, 9, 17, 19, 0, 0, 0, DateTimeKind.Utc), 6L, " Garlic clove, Minced", "Cough", "Islet Cell Transplantation", null },
                    { 4L, null, " Strabismus", "Lunney Freda", "Pediatr", new DateTime(2007, 2, 19, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Galotan", "Pathognomonic", "Immunotherapies", null },
                    { 5L, null, "Reproductive system", "Ferreiro Timmy", "Cardiolog", new DateTime(2017, 5, 22, 19, 0, 0, 0, DateTimeKind.Utc), 1L, "Droperidol", "Dehydration", "Inhaled Insulin", null },
                    { 6L, null, " Pervasive developmental disorders ", "Kennelly Dawn", "Psychiatr", new DateTime(2001, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), 3L, "Diazepam", "Allergy", "Preserve Function of Beta Cells", null }
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
