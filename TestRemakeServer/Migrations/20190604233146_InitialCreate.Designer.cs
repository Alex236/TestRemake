﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestRemakeServer;

namespace TestRemakeServer.Migrations
{
    [DbContext(typeof(ClockProilesContext))]
    [Migration("20190604233146_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("TestRemakeServer.DbModels.ClockProfile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FaceColor");

                    b.Property<string>("HandsColor");

                    b.Property<string>("Name");

                    b.Property<string>("Timezone");

                    b.HasKey("ID");

                    b.ToTable("ClockProiles");
                });
#pragma warning restore 612, 618
        }
    }
}
