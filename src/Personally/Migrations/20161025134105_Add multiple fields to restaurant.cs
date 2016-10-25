using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Personally.Migrations
{
    public partial class Addmultiplefieldstorestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AveragePrice",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postal",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Restaurants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AveragePrice",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Postal",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Restaurants");
        }
    }
}
