﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TangjinJam.Infrastructure.Ef;

namespace TangjinJam.Infrastructure.Migrations
{
    [DbContext(typeof(TangjinJamDbContext))]
    [Migration("20190830034455_Initail")]
    partial class Initail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("TangjinJam.Infrastructure.Model.Item", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TangjinJam.Infrastructure.Model.Item", b =>
                {
                    b.OwnsOne("TangjinJam.Infrastructure.Model.ItemDetail", "ItemDetail", b1 =>
                        {
                            b1.Property<string>("ItemId");

                            b1.Property<string>("Brand");

                            b1.Property<string>("DetailId");

                            b1.Property<bool>("IsBuy");

                            b1.Property<string>("Price");

                            b1.ToTable("Items");

                            b1.HasOne("TangjinJam.Infrastructure.Model.Item")
                                .WithOne("ItemDetail")
                                .HasForeignKey("TangjinJam.Infrastructure.Model.ItemDetail", "ItemId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
