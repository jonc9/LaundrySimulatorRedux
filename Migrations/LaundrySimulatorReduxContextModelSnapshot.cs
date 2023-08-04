﻿// <auto-generated />
using LaundrySimulator2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaundrySimulator2.Migrations
{
    [DbContext(typeof(LaundrySimulatorReduxContext))]
    partial class LaundrySimulatorReduxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LaundrySimulator2.Classes.PlayerName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlayerNames", (string)null);
                });

            modelBuilder.Entity("LaundrySimulator2.LaundrySimulatorReduxContext+DefaultInventory", b =>
                {
                    b.Property<int>("InvId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvId"));

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvId")
                        .HasName("PrimaryKey_InvId");

                    b.ToTable("DefaultInventories", (string)null);

                    b.HasData(
                        new
                        {
                            InvId = 1,
                            ItemDescription = "Test description",
                            ItemName = "Mallet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
