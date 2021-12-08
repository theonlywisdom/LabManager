using LabManager.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.DataAccess
{
    public class DbSeedContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactPerson> ContactPeople { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<ContactNumber> ContactNumbers { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                @"Server=DESKTOP-O73GN70\LOCALDB;Database=LabManager;Trusted_Connection=True;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientCategory>().HasData(
                new ClientCategory
                {
                    Id = 1,
                    Description = "RSA"
                },
                new ClientCategory
                {
                    Id = 2,
                    Description = "CSPO"
                });

            modelBuilder.Entity<UpdateType>().HasData(
                new UpdateType
                {
                    Id = 1,
                    Description = "Test Reports"
                },
                new UpdateType
                {
                    Id = 2,
                    Description = "Flagged Reports"
                },
                new UpdateType
                {
                    Id = 3,
                    Description = "Excel Updates"
                },
                new UpdateType
                {
                    Id = 4,
                    Description = "Gateway Updates"
                },
                new UpdateType
                {
                    Id = 5,
                    Description = "Invoices"
                });

            modelBuilder.Entity<Client>(
                entity =>
                {
                    entity.HasMany(c => c.Addresses)
                    .WithOne(a => a.Client)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);
                }
                );
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    Name = "Mowi Consumer Products UK Limited",
                    Code = "MHVAP"
                },
                new Client
                {
                    Id = 2,
                    Name = "Grahams Dairy",
                    Code = "GDC"
                },
                new Client
                {
                    Id = 3,
                    Name = "The Lakes Free Range Egg  Company",
                    Code = "LAKE01"
                });

            modelBuilder.Entity<Client>()
                .HasMany(c => c.ClientCategories)
                .WithMany(c => c.Clients)
                .UsingEntity(j => j.HasData(
                    new
                    {
                        ClientCategoriesId = 2,
                        ClientsId = 3
                    }));

            modelBuilder.Entity<Client>()
                .HasMany(c => c.ClientCategories)
                .WithMany(c => c.Clients)
                .UsingEntity(j => j.HasData(
                    new
                    {
                        ClientCategoriesId = 1,
                        ClientsId = 2
                    }));

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    Line_1 = "Admirality Park",
                    Line_2 = "Admirality Road",
                    Line_3 = "Rosyth",
                    ClientId = 1,
                    PostCode = "KY11 2YW",
                    AddressType = "Main"
                },
                new Address
                {
                    Id = 3,
                    Line_1 = "Meg Bank",
                    Line_2 = "Stainton,Penrith",
                    Line_3 = "Cumbria",
                    ClientId = 3,
                    PostCode = "CA11 0EE",
                    AddressType = "Main"
                });

            modelBuilder.Entity<Email>().HasData(
            new Email
            {
                Id = 1,
                ContactEmail = "Sandy.fong@mowi.com",
            },
            new Email
            {
                Id = 2,
                ContactEmail = "bryan.donald@mowi.com",
            },
            new Email
            {
                Id = 3,
                ContactEmail = "lucyt@lakesfreerange.co.uk",
            });

            modelBuilder.Entity<ContactPerson>().HasData(
                new ContactPerson
                {
                    Id = 1,
                    FirstName = "Sandy",
                    LastName = "Fong",
                    JobTitle = "Micro and Taste Panel Technician",
                    AddressId = 1,
                    EmailId = 1
                },
                new ContactPerson
                {
                    Id = 2,
                    FirstName = "Bryan",
                    LastName = "Donald",
                    JobTitle = "Food Safety Manager",
                    AddressId = 1,
                    EmailId = 2
                },
                new ContactPerson
                {
                    Id = 3,
                    FirstName = "Lucy",
                    LastName = "Templeton",
                    JobTitle = "N/A",
                    AddressId = 3,
                    EmailId = 3
                });

            modelBuilder.Entity<ContactNumber>().HasData(
                new ContactNumber
                {
                    Id = 1,
                    PhoneNumber = "07788925371",
                    ContactPersonId = 1,
                    ContactTypeId = 1
                },
                new ContactNumber
                {
                    Id = 2,
                    PhoneNumber = "07929181960",
                    ContactPersonId = 2,
                    ContactTypeId = 1
                },
                new ContactNumber
                {
                    Id = 3,
                    PhoneNumber = "01383221194",
                    ContactPersonId = 2,
                    ContactTypeId = 2
                },
                new ContactNumber
                {
                    Id = 4,
                    PhoneNumber = "07984590402",
                    ContactPersonId = 3,
                    ContactTypeId = 1
                },
                new ContactNumber
                {
                    Id = 5,
                    PhoneNumber = "01768890460",
                    ContactPersonId = 3,
                    ContactTypeId = 2
                });

            modelBuilder.Entity<ContactType>().HasData(
                new ContactType
                {
                    Id = 1,
                    Description = "Mobile"
                },
                new ContactType
                {
                    Id = 2,
                    Description = "Telephone"
                });
        }
    }
}
