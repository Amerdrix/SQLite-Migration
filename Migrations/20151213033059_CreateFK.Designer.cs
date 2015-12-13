using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using EFTest;

namespace EFTest.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20151213033059_CreateFK")]
    partial class CreateFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("EFTest.Model1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EFTest.Model2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Model1Id");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EFTest.Model2", b =>
                {
                    b.HasOne("EFTest.Model1")
                        .WithMany()
                        .HasForeignKey("Model1Id");
                });
        }
    }
}
