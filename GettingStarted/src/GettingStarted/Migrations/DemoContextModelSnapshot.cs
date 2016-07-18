using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GettingStarted;

namespace GettingStarted.Migrations
{
    [DbContext(typeof(DemoContext))]
    partial class DemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GettingStarted.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("Parent_Id");

                    b.HasKey("Id");

                    b.HasIndex("Parent_Id");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("GettingStarted.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("GettingStarted.Models.Child", b =>
                {
                    b.HasOne("GettingStarted.Models.Parent", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("Parent_Id");
                });
        }
    }
}
