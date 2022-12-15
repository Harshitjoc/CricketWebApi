﻿// <auto-generated />
using System;
using Cricket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cricket.Migrations
{
    [DbContext(typeof(CricketContext))]
    [Migration("20221213211656_dataupdate")]
    partial class dataupdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cricket.Data.Models.BatsmanScoreBoardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fours")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("PlayerEntityId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Scored")
                        .HasColumnType("int");

                    b.Property<int>("Sixes")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerEntityId");

                    b.ToTable("BatsmanScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.BowlerScoreBoardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("Overs")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerEntityId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Wickets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerEntityId");

                    b.ToTable("BowlerScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.CountryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Cricket.Data.Models.MatchDetailEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("SeriesEntityId")
                        .HasColumnType("int");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.Property<int?>("StadiumEntityId")
                        .HasColumnType("int");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int?>("TossEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TossId")
                        .HasColumnType("int");

                    b.Property<int?>("UmpireRoleMapEntityId")
                        .HasColumnType("int");

                    b.Property<int>("UmpireRoleMapId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeriesEntityId");

                    b.HasIndex("StadiumEntityId");

                    b.HasIndex("TossEntityId");

                    b.HasIndex("UmpireRoleMapEntityId");

                    b.ToTable("MatchDetail");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PlayerRole");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleMapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("PlayerEntityId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerRoleEntityId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerEntityId");

                    b.HasIndex("PlayerRoleEntityId");

                    b.ToTable("PlayerRoleMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.ScoreBoardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("Scored")
                        .HasColumnType("int");

                    b.Property<int?>("TeamEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TeamEntityId");

                    b.ToTable("ScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.SeriesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Cricket.Data.Models.StadiumEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CountryEntityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryEntityId");

                    b.ToTable("Stadium");
                });

            modelBuilder.Entity("Cricket.Data.Models.TeamEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Cricket.Data.Models.TeamPlayerMapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("PlayerEntityId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("TeamEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerEntityId");

                    b.HasIndex("TeamEntityId");

                    b.ToTable("TeamPlayerMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.TossEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Winner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Toss");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CountryEntityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryEntityId");

                    b.ToTable("Umpire");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UmpireRole");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("UmpireEntityId")
                        .HasColumnType("int");

                    b.Property<int>("UmpireId")
                        .HasColumnType("int");

                    b.Property<int?>("UmpireRoleEntityId")
                        .HasColumnType("int");

                    b.Property<int>("UmpireRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UmpireEntityId");

                    b.HasIndex("UmpireRoleEntityId");

                    b.ToTable("UmpireRoleMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.BatsmanScoreBoardEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.PlayerEntity", null)
                        .WithMany("BatsmanScoreBoards")
                        .HasForeignKey("PlayerEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.BowlerScoreBoardEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.PlayerEntity", null)
                        .WithMany("BowlerScoreBoards")
                        .HasForeignKey("PlayerEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.MatchDetailEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.SeriesEntity", null)
                        .WithMany("MatchDetails")
                        .HasForeignKey("SeriesEntityId");

                    b.HasOne("Cricket.Data.Models.StadiumEntity", null)
                        .WithMany("MatchDetails")
                        .HasForeignKey("StadiumEntityId");

                    b.HasOne("Cricket.Data.Models.TossEntity", null)
                        .WithMany("MatchDetails")
                        .HasForeignKey("TossEntityId");

                    b.HasOne("Cricket.Data.Models.UmpireRoleMapEntity", null)
                        .WithMany("MatchDetails")
                        .HasForeignKey("UmpireRoleMapEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.CountryEntity", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleMapEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.PlayerEntity", null)
                        .WithMany("PlayerRoleMaps")
                        .HasForeignKey("PlayerEntityId");

                    b.HasOne("Cricket.Data.Models.PlayerRoleEntity", null)
                        .WithMany("PlayerRoleMaps")
                        .HasForeignKey("PlayerRoleEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.ScoreBoardEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.TeamEntity", null)
                        .WithMany("ScoreBoards")
                        .HasForeignKey("TeamEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.StadiumEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.CountryEntity", null)
                        .WithMany("Stadiums")
                        .HasForeignKey("CountryEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.TeamPlayerMapEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.PlayerEntity", null)
                        .WithMany("TeamPlayerMapEntities")
                        .HasForeignKey("PlayerEntityId");

                    b.HasOne("Cricket.Data.Models.TeamEntity", null)
                        .WithMany("TeamPlayerMapEntities")
                        .HasForeignKey("TeamEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.CountryEntity", null)
                        .WithMany("Umpires")
                        .HasForeignKey("CountryEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMapEntity", b =>
                {
                    b.HasOne("Cricket.Data.Models.UmpireEntity", null)
                        .WithMany("UmpireRoleMaps")
                        .HasForeignKey("UmpireEntityId");

                    b.HasOne("Cricket.Data.Models.UmpireRoleEntity", null)
                        .WithMany("UmpireRoleMaps")
                        .HasForeignKey("UmpireRoleEntityId");
                });

            modelBuilder.Entity("Cricket.Data.Models.CountryEntity", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Stadiums");

                    b.Navigation("Umpires");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerEntity", b =>
                {
                    b.Navigation("BatsmanScoreBoards");

                    b.Navigation("BowlerScoreBoards");

                    b.Navigation("PlayerRoleMaps");

                    b.Navigation("TeamPlayerMapEntities");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleEntity", b =>
                {
                    b.Navigation("PlayerRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.SeriesEntity", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.StadiumEntity", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.TeamEntity", b =>
                {
                    b.Navigation("ScoreBoards");

                    b.Navigation("TeamPlayerMapEntities");
                });

            modelBuilder.Entity("Cricket.Data.Models.TossEntity", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireEntity", b =>
                {
                    b.Navigation("UmpireRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleEntity", b =>
                {
                    b.Navigation("UmpireRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMapEntity", b =>
                {
                    b.Navigation("MatchDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
