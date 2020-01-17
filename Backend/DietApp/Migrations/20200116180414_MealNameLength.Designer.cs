﻿// <auto-generated />
using System;
using DietApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DietApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200116180414_MealNameLength")]
    partial class MealNameLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DietApp.Domain.Models.Friendship", b =>
                {
                    b.Property<int>("SrcUserID")
                        .HasColumnType("int");

                    b.Property<int>("DestUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("SrcUserID", "DestUserID");

                    b.HasIndex("DestUserID");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("DietApp.Domain.Models.Goal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxCaloriesKcal")
                        .HasColumnType("int");

                    b.Property<int>("MinCaloriesKcal")
                        .HasColumnType("int");

                    b.Property<int>("Reward")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("DietApp.Domain.Models.GoalInvitation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoalID")
                        .HasColumnType("int");

                    b.Property<int>("InvitedUserID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("ID");

                    b.HasIndex("GoalID");

                    b.HasIndex("InvitedUserID");

                    b.ToTable("GoalInvitations");
                });

            modelBuilder.Entity("DietApp.Domain.Models.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("DietApp.Domain.Models.MealEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WeightGram")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("MealEntries");
                });

            modelBuilder.Entity("DietApp.Domain.Models.PublicMeal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("ID");

                    b.ToTable("PublicMeals");
                });

            modelBuilder.Entity("DietApp.Domain.Models.RefreshToken", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("Expiration")
                        .HasColumnType("bigint");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("DietApp.Domain.Models.ScoreLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScoredPointsCarbs")
                        .HasColumnType("int");

                    b.Property<int>("ScoredPointsFat")
                        .HasColumnType("int");

                    b.Property<int>("ScoredPointsKcal")
                        .HasColumnType("int");

                    b.Property<int>("ScoredPointsProtein")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("ScoreLogs");
                });

            modelBuilder.Entity("DietApp.Domain.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CalorieLimit")
                        .HasColumnType("int");

                    b.Property<int>("CalorieLimitLower")
                        .HasColumnType("int");

                    b.Property<int>("CalorieLimitUpper")
                        .HasColumnType("int");

                    b.Property<int>("CarbsLimit")
                        .HasColumnType("int");

                    b.Property<int>("CarbsLimitLower")
                        .HasColumnType("int");

                    b.Property<int>("CarbsLimitUpper")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatLimit")
                        .HasColumnType("int");

                    b.Property<int>("FatLimitLower")
                        .HasColumnType("int");

                    b.Property<int>("FatLimitUpper")
                        .HasColumnType("int");

                    b.Property<bool>("IsEmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsPrivate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProteinLimit")
                        .HasColumnType("int");

                    b.Property<int>("ProteinLimitLower")
                        .HasColumnType("int");

                    b.Property<int>("ProteinLimitUpper")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DietApp.Domain.Models.Friendship", b =>
                {
                    b.HasOne("DietApp.Domain.Models.User", "DestUser")
                        .WithMany("ReceivedFriendships")
                        .HasForeignKey("DestUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Domain.Models.User", "SrcUser")
                        .WithMany("RequestedFriendships")
                        .HasForeignKey("SrcUserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Domain.Models.GoalInvitation", b =>
                {
                    b.HasOne("DietApp.Domain.Models.Goal", "Goal")
                        .WithMany("GoalInvitations")
                        .HasForeignKey("GoalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DietApp.Domain.Models.User", "InvitedUser")
                        .WithMany("GoalInvitations")
                        .HasForeignKey("InvitedUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Domain.Models.Meal", b =>
                {
                    b.HasOne("DietApp.Domain.Models.User", "User")
                        .WithMany("SavedMeals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DietApp.Domain.Models.Nutrients", "Nutrients", b1 =>
                        {
                            b1.Property<int>("MealID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<float>("Carbs")
                                .HasColumnType("real");

                            b1.Property<float>("Fat")
                                .HasColumnType("real");

                            b1.Property<float>("Fiber")
                                .HasColumnType("real");

                            b1.Property<float>("Kcal")
                                .HasColumnType("real");

                            b1.Property<float>("Protein")
                                .HasColumnType("real");

                            b1.HasKey("MealID");

                            b1.ToTable("Meals");

                            b1.WithOwner()
                                .HasForeignKey("MealID");
                        });
                });

            modelBuilder.Entity("DietApp.Domain.Models.MealEntry", b =>
                {
                    b.HasOne("DietApp.Domain.Models.User", "User")
                        .WithMany("MealsHistory")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DietApp.Domain.Models.Nutrients", "Nutrients", b1 =>
                        {
                            b1.Property<int>("MealEntryID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<float>("Carbs")
                                .HasColumnType("real");

                            b1.Property<float>("Fat")
                                .HasColumnType("real");

                            b1.Property<float>("Fiber")
                                .HasColumnType("real");

                            b1.Property<float>("Kcal")
                                .HasColumnType("real");

                            b1.Property<float>("Protein")
                                .HasColumnType("real");

                            b1.HasKey("MealEntryID");

                            b1.ToTable("MealEntries");

                            b1.WithOwner()
                                .HasForeignKey("MealEntryID");
                        });
                });

            modelBuilder.Entity("DietApp.Domain.Models.PublicMeal", b =>
                {
                    b.OwnsOne("DietApp.Domain.Models.Nutrients", "Nutrients", b1 =>
                        {
                            b1.Property<int>("PublicMealID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<float>("Carbs")
                                .HasColumnType("real");

                            b1.Property<float>("Fat")
                                .HasColumnType("real");

                            b1.Property<float>("Fiber")
                                .HasColumnType("real");

                            b1.Property<float>("Kcal")
                                .HasColumnType("real");

                            b1.Property<float>("Protein")
                                .HasColumnType("real");

                            b1.HasKey("PublicMealID");

                            b1.ToTable("PublicMeals");

                            b1.WithOwner()
                                .HasForeignKey("PublicMealID");
                        });
                });

            modelBuilder.Entity("DietApp.Domain.Models.RefreshToken", b =>
                {
                    b.HasOne("DietApp.Domain.Models.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DietApp.Domain.Models.ScoreLog", b =>
                {
                    b.HasOne("DietApp.Domain.Models.User", "User")
                        .WithMany("ScoreLogs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}