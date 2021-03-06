// <auto-generated />
using System;
using LabManager.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LabManager.DataAccess.Migrations
{
    [DbContext(typeof(DbSeedContext))]
    [Migration("20211208105622_initial-db-seed")]
    partial class initialdbseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientClientCategory", b =>
                {
                    b.Property<int>("ClientCategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.HasKey("ClientCategoriesId", "ClientsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("ClientClientCategory");

                    b.HasData(
                        new
                        {
                            ClientCategoriesId = 2,
                            ClientsId = 3
                        },
                        new
                        {
                            ClientCategoriesId = 1,
                            ClientsId = 2
                        });
                });

            modelBuilder.Entity("LabManager.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Line_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressType = "Main",
                            ClientId = 1,
                            Line_1 = "Admirality Park",
                            Line_2 = "Admirality Road",
                            Line_3 = "Rosyth",
                            PostCode = "KY11 2YW"
                        },
                        new
                        {
                            Id = 3,
                            AddressType = "Main",
                            ClientId = 3,
                            Line_1 = "Meg Bank",
                            Line_2 = "Stainton,Penrith",
                            Line_3 = "Cumbria",
                            PostCode = "CA11 0EE"
                        });
                });

            modelBuilder.Entity("LabManager.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "MHVAP",
                            Name = "Mowi Consumer Products UK Limited"
                        },
                        new
                        {
                            Id = 2,
                            Code = "GDC",
                            Name = "Grahams Dairy"
                        },
                        new
                        {
                            Id = 3,
                            Code = "LAKE01",
                            Name = "The Lakes Free Range Egg  Company"
                        });
                });

            modelBuilder.Entity("LabManager.Model.ClientCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClientCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "RSA"
                        },
                        new
                        {
                            Id = 2,
                            Description = "CSPO"
                        });
                });

            modelBuilder.Entity("LabManager.Model.ContactNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactPersonId")
                        .HasColumnType("int");

                    b.Property<int>("ContactTypeId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactPersonId");

                    b.HasIndex("ContactTypeId");

                    b.ToTable("ContactNumber");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactPersonId = 1,
                            ContactTypeId = 1,
                            PhoneNumber = "07788925371"
                        },
                        new
                        {
                            Id = 2,
                            ContactPersonId = 2,
                            ContactTypeId = 1,
                            PhoneNumber = "07929181960"
                        },
                        new
                        {
                            Id = 3,
                            ContactPersonId = 2,
                            ContactTypeId = 2,
                            PhoneNumber = "01383221194"
                        },
                        new
                        {
                            Id = 4,
                            ContactPersonId = 3,
                            ContactTypeId = 1,
                            PhoneNumber = "07984590402"
                        },
                        new
                        {
                            Id = 5,
                            ContactPersonId = 3,
                            ContactTypeId = 2,
                            PhoneNumber = "01768890460"
                        });
                });

            modelBuilder.Entity("LabManager.Model.ContactPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("EmailId");

                    b.ToTable("ContactPerson");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            EmailId = 1,
                            FirstName = "Sandy",
                            JobTitle = "Micro and Taste Panel Technician",
                            LastName = "Fong"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 1,
                            EmailId = 2,
                            FirstName = "Bryan",
                            JobTitle = "Food Safety Manager",
                            LastName = "Donald"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            EmailId = 3,
                            FirstName = "Lucy",
                            JobTitle = "N/A",
                            LastName = "Templeton"
                        });
                });

            modelBuilder.Entity("LabManager.Model.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mobile"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Telephone"
                        });
                });

            modelBuilder.Entity("LabManager.Model.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdateTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UpdateTypeId");

                    b.ToTable("Email");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactEmail = "Sandy.fong@mowi.com"
                        },
                        new
                        {
                            Id = 2,
                            ContactEmail = "bryan.donald@mowi.com"
                        },
                        new
                        {
                            Id = 3,
                            ContactEmail = "lucyt@lakesfreerange.co.uk"
                        });
                });

            modelBuilder.Entity("LabManager.Model.UpdateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UpdateType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Test Reports"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Flagged Reports"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Excel Updates"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Gateway Updates"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Invoices"
                        });
                });

            modelBuilder.Entity("ClientClientCategory", b =>
                {
                    b.HasOne("LabManager.Model.ClientCategory", null)
                        .WithMany()
                        .HasForeignKey("ClientCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabManager.Model.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LabManager.Model.Address", b =>
                {
                    b.HasOne("LabManager.Model.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("LabManager.Model.ContactNumber", b =>
                {
                    b.HasOne("LabManager.Model.ContactPerson", "ContactPerson")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabManager.Model.ContactType", "ContactType")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactPerson");

                    b.Navigation("ContactType");
                });

            modelBuilder.Entity("LabManager.Model.ContactPerson", b =>
                {
                    b.HasOne("LabManager.Model.Address", "Address")
                        .WithMany("ContactPeople")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabManager.Model.Email", "Email")
                        .WithMany("ContactPeople")
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Email");
                });

            modelBuilder.Entity("LabManager.Model.Email", b =>
                {
                    b.HasOne("LabManager.Model.UpdateType", null)
                        .WithMany("Emails")
                        .HasForeignKey("UpdateTypeId");
                });

            modelBuilder.Entity("LabManager.Model.Address", b =>
                {
                    b.Navigation("ContactPeople");
                });

            modelBuilder.Entity("LabManager.Model.Client", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("LabManager.Model.ContactPerson", b =>
                {
                    b.Navigation("PhoneNumbers");
                });

            modelBuilder.Entity("LabManager.Model.ContactType", b =>
                {
                    b.Navigation("PhoneNumbers");
                });

            modelBuilder.Entity("LabManager.Model.Email", b =>
                {
                    b.Navigation("ContactPeople");
                });

            modelBuilder.Entity("LabManager.Model.UpdateType", b =>
                {
                    b.Navigation("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
