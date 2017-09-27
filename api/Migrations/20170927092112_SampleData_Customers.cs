using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace api.Migrations
{
    public partial class SampleData_Customers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations\sampledata\sampledata_up.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations\sampledata\sampledata_down.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }
    }
}
