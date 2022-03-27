﻿// <auto-generated />
using MemorabiliaManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MemorabiliaManager.Data.Migrations
{
    [DbContext(typeof(MemorabiliaManagerContext))]
    partial class MemorabiliaManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MemorabiliaManager.Domain.Entertainment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntertainmentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntertainmentCategoryId");

                    b.ToTable("Entertainment");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.EntertainmentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EntertainmentCategories");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ByteArray")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntertainmentId")
                        .HasColumnType("int");

                    b.Property<int>("ItemCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ItemCollectionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntertainmentId");

                    b.HasIndex("ItemCategoryId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemCategories");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemImage");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemSignature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("SignatureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SignatureId");

                    b.ToTable("ItemSignatures");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemSubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ItemSubjects");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.JerseyNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<short>("Number")
                        .HasColumnType("smallint");

                    b.Property<int>("SignatureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SignatureId")
                        .IsUnique();

                    b.ToTable("JerseyNumbers");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Signature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntertainmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntertainmentId");

                    b.ToTable("Signatures");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntertainmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntertainmentId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Entertainment", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.EntertainmentCategory", "EntertainmentCategory")
                        .WithMany("Entertainment")
                        .HasForeignKey("EntertainmentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntertainmentCategory");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Item", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Entertainment", "Entertainment")
                        .WithMany("Items")
                        .HasForeignKey("EntertainmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemorabiliaManager.Domain.ItemCategory", "ItemCategory")
                        .WithMany("Items")
                        .HasForeignKey("ItemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entertainment");

                    b.Navigation("ItemCategory");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemImage", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Image", "Image")
                        .WithMany("Items")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemorabiliaManager.Domain.Item", "Item")
                        .WithMany("Images")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemSignature", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Item", "Item")
                        .WithMany("Signatures")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemorabiliaManager.Domain.Signature", "Signature")
                        .WithMany("Items")
                        .HasForeignKey("SignatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Signature");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemSubject", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Item", "Item")
                        .WithMany("Subjects")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemorabiliaManager.Domain.Subject", "Subject")
                        .WithMany("Items")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.JerseyNumber", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Signature", "Signature")
                        .WithOne("JerseyNumber")
                        .HasForeignKey("MemorabiliaManager.Domain.JerseyNumber", "SignatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Signature");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Signature", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Entertainment", "Entertainment")
                        .WithMany("Signatures")
                        .HasForeignKey("EntertainmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entertainment");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Subject", b =>
                {
                    b.HasOne("MemorabiliaManager.Domain.Entertainment", "Entertainment")
                        .WithMany("Subjects")
                        .HasForeignKey("EntertainmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entertainment");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Entertainment", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Signatures");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.EntertainmentCategory", b =>
                {
                    b.Navigation("Entertainment");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Image", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Item", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Signatures");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.ItemCategory", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Signature", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("JerseyNumber");
                });

            modelBuilder.Entity("MemorabiliaManager.Domain.Subject", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
