﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetComputerSekho.Migrations
{
    /// <inheritdoc />
    public partial class firstcommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_duration = table.Column<int>(type: "int", nullable: false),
                    course_syllabus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_grp_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_is_active = table.Column<bool>(type: "bit", nullable: false),
                    cover_photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.course_id);
                });

            migrationBuilder.CreateTable(
                name: "Enquiry",
                columns: table => new
                {
                    enquiry_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enquirer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enquirer_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enquirer_email_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enquiry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Follow_up_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closure_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    followup_msg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enquirer_query = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enquiry_processed_flag = table.Column<bool>(type: "bit", nullable: true),
                    staff_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquiry", x => x.enquiry_id);
                });

            migrationBuilder.CreateTable(
                name: "Followup",
                columns: table => new
                {
                    followup_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enquiry_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    followup_msg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followup", x => x.followup_id);
                });

            migrationBuilder.CreateTable(
                name: "Placement",
                columns: table => new
                {
                    placemetid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coursename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batchid = table.Column<int>(type: "int", nullable: false),
                    total_student = table.Column<int>(type: "int", nullable: false),
                    placedstudents = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placement", x => x.placemetid);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staff_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staff_id);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    batch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    batch_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batch_start_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    batch_end_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    final_presentation_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    batch_fees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    course_id = table.Column<int>(type: "int", nullable: false),
                    course_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.batch_id);
                    table.ForeignKey(
                        name: "FK_Batch_Course_course_id1",
                        column: x => x.course_id1,
                        principalTable: "Course",
                        principalColumn: "course_id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_dob = table.Column<DateTime>(type: "date", nullable: false),
                    student_qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    batch_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.student_id);
                    table.ForeignKey(
                        name: "FK_Student_Batch_batch_id",
                        column: x => x.batch_id,
                        principalTable: "Batch",
                        principalColumn: "batch_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batch_course_id1",
                table: "Batch",
                column: "course_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Student_batch_id",
                table: "Student",
                column: "batch_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquiry");

            migrationBuilder.DropTable(
                name: "Followup");

            migrationBuilder.DropTable(
                name: "Placement");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
