﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace exam.Migrations
{
    [DbContext(typeof(QuestionsContext))]
    partial class QuestionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exam.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionID"));

                    b.Property<string>("Answer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorrectAnswer")
                        .HasColumnType("int");

                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.ToTable("Question");
                });
#pragma warning restore 612, 618
        }
    }
}
