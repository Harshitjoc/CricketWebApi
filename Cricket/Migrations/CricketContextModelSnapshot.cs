// <auto-generated />
using System;
using Cricket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cricket.Migrations
{
    [DbContext(typeof(CricketContext))]
    partial class CricketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cricket.Data.Models.BatsmanScoreBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Balls")
                        .HasColumnType("int");

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

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Runs")
                        .HasColumnType("int");

                    b.Property<int>("Sixes")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("BatsmanScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.BowlerScoreBoard", b =>
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

                    b.Property<int>("NoBalls")
                        .HasColumnType("int");

                    b.Property<int>("Overs")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Runs")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Wickets")
                        .HasColumnType("int");

                    b.Property<int>("WideBalls")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("BowlerScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.Country", b =>
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Cricket.Data.Models.MatchDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BatsmanScoreBoardId")
                        .HasColumnType("int");

                    b.Property<int>("BowlerScoreBoardId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("MatchNo")
                        .HasColumnType("int");

                    b.Property<string>("MatchReferee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<int>("TeamAId")
                        .HasColumnType("int");

                    b.Property<int>("TeamBId")
                        .HasColumnType("int");

                    b.Property<string>("Toss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UmpireRoleMapId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BatsmanScoreBoardId");

                    b.HasIndex("BowlerScoreBoardId");

                    b.HasIndex("SeriesId");

                    b.HasIndex("StadiumId");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.HasIndex("UmpireRoleMapId");

                    b.ToTable("MatchDetail");
                });

            modelBuilder.Entity("Cricket.Data.Models.Player", b =>
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

            modelBuilder.Entity("Cricket.Data.Models.PlayerRole", b =>
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

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleMap", b =>
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

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PlayerRoleId");

                    b.ToTable("PlayerRoleMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.ScoreBoard", b =>
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

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("ScoreBoard");
                });

            modelBuilder.Entity("Cricket.Data.Models.Series", b =>
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

            modelBuilder.Entity("Cricket.Data.Models.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex("CountryId");

                    b.ToTable("Stadium");
                });

            modelBuilder.Entity("Cricket.Data.Models.Team", b =>
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

            modelBuilder.Entity("Cricket.Data.Models.TeamPlayerMap", b =>
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

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamPlayerMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.Umpire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasIndex("CountryId");

                    b.ToTable("Umpire");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRole", b =>
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

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMap", b =>
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

                    b.Property<int>("UmpireId")
                        .HasColumnType("int");

                    b.Property<int>("UmpireRoleId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UmpireId");

                    b.HasIndex("UmpireRoleId");

                    b.ToTable("UmpireRoleMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.BatsmanScoreBoard", b =>
                {
                    b.HasOne("Cricket.Data.Models.Player", null)
                        .WithMany("BatsmanScoreBoards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.BowlerScoreBoard", b =>
                {
                    b.HasOne("Cricket.Data.Models.Player", null)
                        .WithMany("BowlerScoreBoards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.MatchDetail", b =>
                {
                    b.HasOne("Cricket.Data.Models.BatsmanScoreBoard", "BatsmanScoreBoard")
                        .WithMany("MatchDetails")
                        .HasForeignKey("BatsmanScoreBoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.BowlerScoreBoard", "BowlerScoreBoard")
                        .WithMany("MatchDetails")
                        .HasForeignKey("BowlerScoreBoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.Series", "Series")
                        .WithMany("MatchDetails")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.Stadium", "Stadium")
                        .WithMany("MatchDetails")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.Team", "TeamA")
                        .WithMany()
                        .HasForeignKey("TeamAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.Team", "TeamB")
                        .WithMany()
                        .HasForeignKey("TeamBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.UmpireRoleMap", "UmpireRoleMap")
                        .WithMany("MatchDetails")
                        .HasForeignKey("UmpireRoleMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BatsmanScoreBoard");

                    b.Navigation("BowlerScoreBoard");

                    b.Navigation("Series");

                    b.Navigation("Stadium");

                    b.Navigation("TeamA");

                    b.Navigation("TeamB");

                    b.Navigation("UmpireRoleMap");
                });

            modelBuilder.Entity("Cricket.Data.Models.Player", b =>
                {
                    b.HasOne("Cricket.Data.Models.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRoleMap", b =>
                {
                    b.HasOne("Cricket.Data.Models.Player", null)
                        .WithMany("PlayerRoleMaps")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.PlayerRole", null)
                        .WithMany("PlayerRoleMaps")
                        .HasForeignKey("PlayerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.ScoreBoard", b =>
                {
                    b.HasOne("Cricket.Data.Models.Team", null)
                        .WithMany("ScoreBoards")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.Stadium", b =>
                {
                    b.HasOne("Cricket.Data.Models.Country", null)
                        .WithMany("Stadiums")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.TeamPlayerMap", b =>
                {
                    b.HasOne("Cricket.Data.Models.Player", null)
                        .WithMany("TeamPlayerMaps")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.Team", null)
                        .WithMany("TeamPlayerMaps")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.Umpire", b =>
                {
                    b.HasOne("Cricket.Data.Models.Country", null)
                        .WithMany("Umpires")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMap", b =>
                {
                    b.HasOne("Cricket.Data.Models.Umpire", null)
                        .WithMany("UmpireRoleMaps")
                        .HasForeignKey("UmpireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cricket.Data.Models.UmpireRole", null)
                        .WithMany("UmpireRoleMaps")
                        .HasForeignKey("UmpireRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cricket.Data.Models.BatsmanScoreBoard", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.BowlerScoreBoard", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.Country", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Stadiums");

                    b.Navigation("Umpires");
                });

            modelBuilder.Entity("Cricket.Data.Models.Player", b =>
                {
                    b.Navigation("BatsmanScoreBoards");

                    b.Navigation("BowlerScoreBoards");

                    b.Navigation("PlayerRoleMaps");

                    b.Navigation("TeamPlayerMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.PlayerRole", b =>
                {
                    b.Navigation("PlayerRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.Series", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.Stadium", b =>
                {
                    b.Navigation("MatchDetails");
                });

            modelBuilder.Entity("Cricket.Data.Models.Team", b =>
                {
                    b.Navigation("ScoreBoards");

                    b.Navigation("TeamPlayerMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.Umpire", b =>
                {
                    b.Navigation("UmpireRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRole", b =>
                {
                    b.Navigation("UmpireRoleMaps");
                });

            modelBuilder.Entity("Cricket.Data.Models.UmpireRoleMap", b =>
                {
                    b.Navigation("MatchDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
