﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using travelingoapi;

namespace travelingoapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190624160832_AddedMoreColumns")]
    partial class AddedMoreColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("travelingoapi.models.model", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Language");

                    b.Property<string>("LastName");

                    b.Property<double>("Latitude");

                    b.Property<string>("LocationName");

                    b.Property<double>("Longitude");

                    b.Property<string>("UserName");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("id");

                    b.ToTable("Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
