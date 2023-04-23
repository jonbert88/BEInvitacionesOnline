﻿// <auto-generated />
using BEInvitacionesOnline.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BEInvitacionesOnline.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230210211153_Template")]
    partial class Template
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BEInvitacionesOnline.Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cvv")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("expireDate")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("nameCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("perfil")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.Template", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("divContentCero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentEight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentFive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentFooter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentFour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentOne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentSeven")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentSix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentThree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divContentTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("divHeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idTypeTemplate")
                        .HasColumnType("int");

                    b.Property<string>("nombrePlantilla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("idTypeTemplate");

                    b.ToTable("Plantillass");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.TypeTemplate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("typeTemplate")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.ToTable("TiposPlantilla");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("idProfile")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("id");

                    b.HasIndex("idProfile");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.Template", b =>
                {
                    b.HasOne("BEInvitacionesOnline.Models.TypeTemplate", "TypeTemplate")
                        .WithMany()
                        .HasForeignKey("idTypeTemplate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeTemplate");
                });

            modelBuilder.Entity("BEInvitacionesOnline.Models.User", b =>
                {
                    b.HasOne("BEInvitacionesOnline.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("idProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
