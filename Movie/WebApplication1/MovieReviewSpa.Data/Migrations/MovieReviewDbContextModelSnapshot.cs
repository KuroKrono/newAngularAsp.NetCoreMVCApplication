﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReviewSpa.Data;

namespace MovieReviewSpa.Data.Migrations
{
    [DbContext(typeof(MovieReviewDbContext))]
    partial class MovieReviewDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieReviewSpa.Model.Movie", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieReviewSpa.Model.MovieReview", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MovieId");

                    b.Property<string>("ReviewComments")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("ReviewName")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("ReviewerRating");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieReviews");
                });

            modelBuilder.Entity("MovieReviewSpa.Model.MovieReview", b =>
                {
                    b.HasOne("MovieReviewSpa.Model.Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
