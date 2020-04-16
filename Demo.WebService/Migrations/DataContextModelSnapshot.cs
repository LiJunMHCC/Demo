﻿// <auto-generated />
using System;
using Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.WebService.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Data.models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content");

                    b.Property<int>("fatherId");

                    b.Property<string>("router");

                    b.HasKey("Id");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("Demo.Data.models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Demo.Data.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<int?>("rolesId");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.HasIndex("rolesId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Demo.Data.models.User", b =>
                {
                    b.HasOne("Demo.Data.models.Roles", "roles")
                        .WithMany()
                        .HasForeignKey("rolesId");
                });
#pragma warning restore 612, 618
        }
    }
}