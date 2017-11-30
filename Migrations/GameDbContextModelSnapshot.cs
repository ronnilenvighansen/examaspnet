﻿// <auto-generated />
using ExamAspDotNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ExamAspDotNet.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ExamAspDotNet.Models.Entities.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Developer");

                    b.Property<string>("Genre");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("Publisher");

                    b.Property<string>("Score");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}