﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotesApp.Data;

namespace NotesApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220216130312_AddNotesTypeFKToNotesToDatabase")]
    partial class AddNotesTypeFKToNotesToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotesApp.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Important")
                        .HasColumnType("bit");

                    b.Property<int>("NoteTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ReadCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NoteTypeId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("NotesApp.Models.NoteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoteTypes");
                });

            modelBuilder.Entity("NotesApp.Models.Note", b =>
                {
                    b.HasOne("NotesApp.Models.NoteType", "NoteType")
                        .WithMany()
                        .HasForeignKey("NoteTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NoteType");
                });
#pragma warning restore 612, 618
        }
    }
}
