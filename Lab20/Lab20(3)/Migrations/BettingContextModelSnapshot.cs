﻿// <auto-generated />
using System;
using Lab20_3_.P03_FootballBetting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab20_3_.Migrations
{
    [DbContext(typeof(BettingContext))]
    partial class BettingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Bet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BetId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Prediciton")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GameId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AwayTeamBetRate")
                        .HasColumnType("real");

                    b.Property<int>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<float>("DrawBetRate")
                        .HasColumnType("real");

                    b.Property<float>("HomeTeamBetRate")
                        .HasColumnType("real");

                    b.Property<int>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsInjured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("SquadNumber")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.PlayerStatistics", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("MinutesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("ScoredGoals")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerStatistics");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PositionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Budget")
                        .HasColumnType("real");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrimaryKitColorId")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryKitColorId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryKitColorId");

                    b.HasIndex("SecondaryKitColorId");

                    b.HasIndex("TownId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Balance")
                        .HasColumnType("real");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Bet", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Game", "Game")
                        .WithMany("Bets")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.User", "User")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Game", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Team", "AwayTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Team", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Player", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Position", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.PlayerStatistics", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Game", "Game")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Player", "Player")
                        .WithMany("PlayerStatistics")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Team", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Color", "PrimaryKitColor")
                        .WithMany("PrimaryColorKitTeams")
                        .HasForeignKey("PrimaryKitColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Color", "SecondaryKitColor")
                        .WithMany("SecondaryColorKitTeams")
                        .HasForeignKey("SecondaryKitColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Town", "Town")
                        .WithMany("Teams")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PrimaryKitColor");

                    b.Navigation("SecondaryKitColor");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Town", b =>
                {
                    b.HasOne("Lab20_3_.P03_FootballBetting.Data.Models.Country", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Color", b =>
                {
                    b.Navigation("PrimaryColorKitTeams");

                    b.Navigation("SecondaryColorKitTeams");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Country", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Game", b =>
                {
                    b.Navigation("Bets");

                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Player", b =>
                {
                    b.Navigation("PlayerStatistics");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Position", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Team", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.Town", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Lab20_3_.P03_FootballBetting.Data.Models.User", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
