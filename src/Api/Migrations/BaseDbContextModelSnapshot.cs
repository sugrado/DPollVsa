﻿// <auto-generated />
using System;
using Api.Shared.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Api.Features.Presentations.Domain.Entities.Presentation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("presentations", (string)null);
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.MultipleChoice", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("multiple_choices", (string)null);
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.MultipleChoiceOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<Guid>("MultipleChoiceId")
                        .HasColumnType("uuid")
                        .HasColumnName("multiple_choice_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("MultipleChoiceId");

                    b.ToTable("multiple_choice_options", (string)null);
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.Slide", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<short>("Order")
                        .HasColumnType("smallint")
                        .HasColumnName("order");

                    b.Property<Guid>("PresentationId")
                        .HasColumnType("uuid")
                        .HasColumnName("presentation_id");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("PresentationId");

                    b.ToTable("slides", (string)null);
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Url")
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("videos", (string)null);
                });

            modelBuilder.Entity("Api.Features.Users.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("last_name");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f89cff9-8c7f-493f-af8c-a2fd68980ca9"),
                            CreatedAt = new DateTime(2021, 8, 30, 20, 30, 0, 0, DateTimeKind.Utc),
                            Email = "admin@admin.com",
                            FirstName = "Görkem Rıdvan",
                            LastName = "ARIK",
                            Status = true
                        });
                });

            modelBuilder.Entity("Api.Features.Presentations.Domain.Entities.Presentation", b =>
                {
                    b.HasOne("Api.Features.Users.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.MultipleChoice", b =>
                {
                    b.HasOne("Api.Features.Slides.Domain.Entities.Slide", "Slide")
                        .WithOne("MultipleChoice")
                        .HasForeignKey("Api.Features.Slides.Domain.Entities.MultipleChoice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slide");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.MultipleChoiceOption", b =>
                {
                    b.HasOne("Api.Features.Slides.Domain.Entities.MultipleChoice", "MultipleChoice")
                        .WithMany("Options")
                        .HasForeignKey("MultipleChoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MultipleChoice");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.Slide", b =>
                {
                    b.HasOne("Api.Features.Presentations.Domain.Entities.Presentation", "Presentation")
                        .WithMany("Slides")
                        .HasForeignKey("PresentationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentation");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.Video", b =>
                {
                    b.HasOne("Api.Features.Slides.Domain.Entities.Slide", "Slide")
                        .WithOne("Video")
                        .HasForeignKey("Api.Features.Slides.Domain.Entities.Video", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Slide");
                });

            modelBuilder.Entity("Api.Features.Presentations.Domain.Entities.Presentation", b =>
                {
                    b.Navigation("Slides");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.MultipleChoice", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Api.Features.Slides.Domain.Entities.Slide", b =>
                {
                    b.Navigation("MultipleChoice");

                    b.Navigation("Video");
                });
#pragma warning restore 612, 618
        }
    }
}
