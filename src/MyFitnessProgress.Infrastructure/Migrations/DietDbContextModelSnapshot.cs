﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFitnessProgress.Infrastructure.Mappings;

namespace MyFitnessProgress.Infrastructure.Migrations
{
    [DbContext(typeof(DietDbContext))]
    partial class DietDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("diet")
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.Macro", b =>
                {
                    b.Property<int>("MacroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Calories")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Protein")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MacroId");

                    b.ToTable("Macros");
                });

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PictureId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<int>("MacroId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("PictureId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("MacroId");

                    b.HasIndex("PictureId");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ProductCategoryId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductCategoryId = 1,
                            IsDeleted = false,
                            Name = "Nabiał"
                        },
                        new
                        {
                            ProductCategoryId = 2,
                            IsDeleted = false,
                            Name = "Mięso i wyroby mięsne"
                        },
                        new
                        {
                            ProductCategoryId = 3,
                            IsDeleted = false,
                            Name = "Ryby i owoce morza"
                        },
                        new
                        {
                            ProductCategoryId = 4,
                            IsDeleted = false,
                            Name = "Pieczywo"
                        },
                        new
                        {
                            ProductCategoryId = 5,
                            IsDeleted = false,
                            Name = "Zbożowe"
                        },
                        new
                        {
                            ProductCategoryId = 6,
                            IsDeleted = false,
                            Name = "Orzechy i ziarna"
                        },
                        new
                        {
                            ProductCategoryId = 7,
                            IsDeleted = false,
                            Name = "Napoje"
                        },
                        new
                        {
                            ProductCategoryId = 8,
                            IsDeleted = false,
                            Name = "Tłuszcze"
                        },
                        new
                        {
                            ProductCategoryId = 9,
                            IsDeleted = false,
                            Name = "Inne"
                        },
                        new
                        {
                            ProductCategoryId = 10,
                            IsDeleted = false,
                            Name = "Owoce i Warzywa"
                        },
                        new
                        {
                            ProductCategoryId = 11,
                            IsDeleted = false,
                            Name = "Przyprawy i zioła"
                        });
                });

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UnitId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            UnitId = 1,
                            IsDeleted = false,
                            Name = "Garść"
                        },
                        new
                        {
                            UnitId = 2,
                            IsDeleted = false,
                            Name = "Łyżka"
                        },
                        new
                        {
                            UnitId = 3,
                            IsDeleted = false,
                            Name = "Sztuka"
                        },
                        new
                        {
                            UnitId = 4,
                            IsDeleted = false,
                            Name = "Litr"
                        },
                        new
                        {
                            UnitId = 5,
                            IsDeleted = false,
                            Name = "Plaster"
                        },
                        new
                        {
                            UnitId = 6,
                            IsDeleted = false,
                            Name = "Porcja"
                        },
                        new
                        {
                            UnitId = 7,
                            IsDeleted = false,
                            Name = "Plasterek"
                        },
                        new
                        {
                            UnitId = 8,
                            IsDeleted = false,
                            Name = "Opakowanie"
                        },
                        new
                        {
                            UnitId = 9,
                            IsDeleted = false,
                            Name = "Łyżeczka"
                        },
                        new
                        {
                            UnitId = 10,
                            IsDeleted = false,
                            Name = "Listek"
                        },
                        new
                        {
                            UnitId = 11,
                            IsDeleted = false,
                            Name = "Kromka"
                        },
                        new
                        {
                            UnitId = 12,
                            IsDeleted = false,
                            Name = "Szklanka"
                        },
                        new
                        {
                            UnitId = 13,
                            IsDeleted = false,
                            Name = "Kostka"
                        },
                        new
                        {
                            UnitId = 14,
                            IsDeleted = false,
                            Name = "Ząbek"
                        },
                        new
                        {
                            UnitId = 15,
                            IsDeleted = false,
                            Name = "Liść"
                        },
                        new
                        {
                            UnitId = 16,
                            IsDeleted = false,
                            Name = "Łodyga"
                        },
                        new
                        {
                            UnitId = 17,
                            IsDeleted = false,
                            Name = "Kieliszek"
                        },
                        new
                        {
                            UnitId = 18,
                            IsDeleted = false,
                            Name = "Kropla"
                        },
                        new
                        {
                            UnitId = 19,
                            IsDeleted = false,
                            Name = "Szczypta"
                        },
                        new
                        {
                            UnitId = 20,
                            IsDeleted = false,
                            Name = "Płat"
                        },
                        new
                        {
                            UnitId = 21,
                            IsDeleted = false,
                            Name = "Rurka"
                        },
                        new
                        {
                            UnitId = 22,
                            IsDeleted = false,
                            Name = "Kapsułka"
                        },
                        new
                        {
                            UnitId = 23,
                            IsDeleted = false,
                            Name = "Miarka"
                        },
                        new
                        {
                            UnitId = 24,
                            IsDeleted = false,
                            Name = "Pęczek"
                        },
                        new
                        {
                            UnitId = 25,
                            IsDeleted = false,
                            Name = "Gałka"
                        });
                });

            modelBuilder.Entity("MyFitnessProgress.Core.Domain.Diet.Product", b =>
                {
                    b.HasOne("MyFitnessProgress.Core.Domain.Diet.Macro", "Macro")
                        .WithMany()
                        .HasForeignKey("MacroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyFitnessProgress.Core.Domain.Diet.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("MyFitnessProgress.Core.Domain.Diet.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.HasOne("MyFitnessProgress.Core.Domain.Diet.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
