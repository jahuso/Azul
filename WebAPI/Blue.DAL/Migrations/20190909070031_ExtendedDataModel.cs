using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blue.DAL.Migrations
{
    public partial class ExtendedDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Hour = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Doctor = table.Column<int>(type: "int", nullable: false),
                    Patient = table.Column<int>(type: "int", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    ConsultingRoom = table.Column<string>(type: "nvarchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClinicHistory",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    PatientID = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    AnalisisPlan = table.Column<string>(type: "nvarchar(800)", nullable: false),
                    Diagnostic = table.Column<string>(type: "nvarchar(800)", nullable: false),
                    NeurologicalStatus = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HeadandShoulder = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CardioPulmonar = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Abdomen = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GenitoUrinary = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConsultingRoom",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultingRoom", x => x.ID);
                });

            //migrationBuilder.CreateTable(
            //    name: "Doctor",
            //    columns: table => new
            //    {
            //        Code = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        IDNumber = table.Column<string>(type: "nvarchar(15)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
            //        MobilePhone = table.Column<string>(type: "nvarchar(15)", nullable: true),
            //        Mail = table.Column<string>(type: "nvarchar(50)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Doctor", x => x.Code);
            //    });

            migrationBuilder.CreateTable(
                name: "Evolution",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    HistoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolution", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EvolutionDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EvolutionID = table.Column<int>(type: "int", nullable: false),
                    Subjetive = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Objetive = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Analisis = table.Column<string>(type: "nvarchar(800)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Justification = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Diagnose = table.Column<string>(type: "nvarchar(800)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "HistoryDetail",
                columns: table => new
                {
                    DetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HistoryID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CurrentDisease = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryDetail", x => x.DetailID);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Appointment = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    TypeID = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Insurance = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DOB = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AfiliationType = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalExam",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DetailID = table.Column<int>(type: "int", nullable: false),
                    HearthFrequency = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    BreathingFrequency = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    ArterialPresure = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    O2SAT = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    NeurologicalStatus = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HeadandShoulder = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PulmonaryCardio = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Abdomen = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GenitoUrinary = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Limbs = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Skin = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalExam", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "ClinicHistory");

            migrationBuilder.DropTable(
                name: "ConsultingRoom");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Evolution");

            migrationBuilder.DropTable(
                name: "EvolutionDetail");

            migrationBuilder.DropTable(
                name: "HistoryDetail");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "PhysicalExam");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
