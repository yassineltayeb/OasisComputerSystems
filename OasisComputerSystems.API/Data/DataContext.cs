using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OasisComputerSystems.API.Models;

namespace OasisComputerSystems.API.Data
{
    public class DataContext : IdentityDbContext<StaffProfile, Role, int,
        IdentityUserClaim<int>, StaffProfileRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientContact> ClientsContacts { get; set; }
        public DbSet<ClientContactSupport> ClientsContactsSupport { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<SystemModule> SystemsModules { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketNote> TicketNotes { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(builder);

            //Many to Many Relationship
            builder.Entity<StaffProfileRole>(staffProfileRole =>
            {
                staffProfileRole.HasKey(sr => new { sr.UserId, sr.RoleId });

                staffProfileRole.HasOne(sr => sr.Role)
                    .WithMany(sr => sr.StaffProfileRoles)
                    .HasForeignKey(sr => sr.RoleId)
                    .IsRequired();

                staffProfileRole.HasOne(sr => sr.StaffProfile)
                    .WithMany(sr => sr.StaffProfileRoles)
                    .HasForeignKey(sr => sr.UserId)
                    .IsRequired();
            });

            builder.Entity<ClientsModules>(clientsModules =>
            {
                clientsModules.HasKey(cm => new { cm.ClientId, cm.SystemModuleId });

                clientsModules.HasOne(cm => cm.Client)
                    .WithMany(cm => cm.ClientsModules)
                    .HasForeignKey(cm => cm.ClientId)
                    .IsRequired();

                clientsModules.HasOne(cm => cm.SystemModule)
                    .WithMany(cm => cm.ClientsModules)
                    .HasForeignKey(cm => cm.SystemModuleId)
                    .IsRequired();
            });

            //Seed Database

            //Clients
            builder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    NameEn = "City Brokers",
                    NameAr = "وسيط المدينة",
                    Address = "Mauritius - Port Louis",
                    VATNo = "1",
                    TelephoneNumber = "11",
                    CountryId = 6,
                    TechnicalDetails = "Details 1",
                    CreatedById = 1,
                    CreatedOn = DateTime.Now
                },
                new Client
                {
                    Id = 2,
                    NameEn = "Masarat",
                    NameAr = "مسارات",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "2",
                    TelephoneNumber = "22",
                    CountryId = 2,
                    TechnicalDetails = "Details 2",
                    CreatedById = 1,
                    CreatedOn = DateTime.Now
                },
                new Client
                {
                    Id = 3,
                    NameEn = "Platinum",
                    NameAr = "بلاتينيوم",
                    Address = "Lebanon - Beirut",
                    VATNo = "3",
                    TelephoneNumber = "33",
                    CountryId = 3,
                    TechnicalDetails = "Details 3",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 4,
                    NameEn = "GMRB",
                    NameAr = "قروب ميد",
                    Address = "Lebanon - Beirut",
                    VATNo = "4",
                    TelephoneNumber = "44",
                    CountryId = 3,
                    TechnicalDetails = "Details 4",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 5,
                    NameEn = "GMIB",
                    NameAr = "قروب ميد",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "5",
                    TelephoneNumber = "55",
                    CountryId = 2,
                    TechnicalDetails = "Details 5",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 6,
                    NameEn = "Alhimaya",
                    NameAr = "الحماية",
                    Address = "UAE - Dubai",
                    VATNo = "6",
                    TelephoneNumber = "66",
                    CountryId = 4,
                    TechnicalDetails = "Details 6",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 7,
                    NameEn = "Al Manarah",
                    NameAr = "المنارة",
                    Address = "UAE - Dubai",
                    VATNo = "7",
                    TelephoneNumber = "77",
                    CountryId = 4,
                    TechnicalDetails = "Details 7",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 8,
                    NameEn = "APPlus",
                    NameAr = "اب بلس",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "8",
                    TelephoneNumber = "88",
                    CountryId = 2,
                    TechnicalDetails = "Details 8",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 9,
                    NameEn = "Ofooq",
                    NameAr = "افق",
                    Address = "Saudi Arabia - Riyadh",
                    VATNo = "9",
                    TelephoneNumber = "99",
                    CountryId = 2,
                    TechnicalDetails = "Details 99",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 10,
                    NameEn = "Concord",
                    NameAr = "كونكورد",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "10",
                    TelephoneNumber = "1010",
                    CountryId = 2,
                    TechnicalDetails = "Details 10",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 11,
                    NameEn = "Broker Care",
                    NameAr = "بروكر كير",
                    Address = "Saudi Arabia - Riyadh",
                    VATNo = "11",
                    TelephoneNumber = "1111",
                    CountryId = 2,
                    TechnicalDetails = "Details 11",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 12,
                    NameEn = "Broker Vision",
                    NameAr = "رؤية الوسيط",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "12",
                    TelephoneNumber = "1212",
                    CountryId = 2,
                    TechnicalDetails = "Details 12",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 13,
                    NameEn = "Hazim",
                    NameAr = "حازم",
                    Address = "Saudi Arabia - Jeddah",
                    VATNo = "13",
                    TelephoneNumber = "1313",
                    CountryId = 2,
                    TechnicalDetails = "Details 13",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 14,
                    NameEn = "Elnilein Insurance Company",
                    NameAr = "النيلين للتأمين",
                    Address = "Sudan - Khartoum",
                    VATNo = "14",
                    TelephoneNumber = "1414",
                    CountryId = 1,
                    TechnicalDetails = "Details 14",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                },
                new Client
                {
                    Id = 15,
                    NameEn = "Swiss",
                    NameAr = "سويسس",
                    Address = "Sudan - Khartoum",
                    VATNo = "15",
                    TelephoneNumber = "1515",
                    CountryId = 1,
                    TechnicalDetails = "Details 15",
                    CreatedById = 1,
                    CreatedOn =
                    DateTime.Now
                }
            );

            //Countries
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Sudan" },
                new Country { Id = 2, Name = "Saudi Arabia" },
                new Country { Id = 3, Name = "Lebanon" },
                new Country { Id = 4, Name = "United Arab Emirate" },
                new Country { Id = 5, Name = "Qatar" },
                new Country { Id = 6, Name = "Mauritius" }
            );

            //Genders
            builder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Male" },
                new Gender { Id = 2, Name = "Female" }
            );

            //Marital Statuses
            builder.Entity<MaritalStatus>().HasData(
                new MaritalStatus { Id = 1, Name = "Single" },
                new MaritalStatus { Id = 2, Name = "Married" },
                new MaritalStatus { Id = 3, Name = "Widowed" },
                new MaritalStatus { Id = 4, Name = "Divorced" },
                new MaritalStatus { Id = 5, Name = "Separated" }
            );

            //Nationalities
            builder.Entity<Nationality>().HasData(
                new Nationality { Id = 1, Name = "Sudanese" },
                new Nationality { Id = 2, Name = "Saudi" }
            );

            //Genders
            builder.Entity<Religion>().HasData(
                new Religion { Id = 1, Name = "Muslim" },
                new Religion { Id = 2, Name = "Non-Muslim" }
            );

            //Priorities
            builder.Entity<Priority>().HasData(
                new Priority { Id = 1, Name = "Low" },
                new Priority { Id = 2, Name = "Normal" },
                new Priority { Id = 3, Name = "High" }
            );

            //Roles
            builder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new Role { Id = 2, Name = "Member", NormalizedName = "MEMBER" },
                new Role { Id = 3, Name = "Client", NormalizedName = "CLIENT" }
            );

            //Systems Modules
            builder.Entity<SystemModule>().HasData(
                new SystemModule { Id = 1, Name = "Master Tables" },
                new SystemModule { Id = 2, Name = "Clients Management" },
                new SystemModule { Id = 3, Name = "Business Development" },
                new SystemModule { Id = 4, Name = "Production (Insurance)" },
                new SystemModule { Id = 5, Name = "Production (Reinsurance - Facultative)" },
                new SystemModule { Id = 6, Name = "Production (Reinsurance - Facultative Claims)" },
                new SystemModule { Id = 7, Name = "Production (Reinsurance - Treaties)" },
                new SystemModule { Id = 8, Name = "Production (Reinsurance - Treaties Claims)" },
                new SystemModule { Id = 9, Name = "Customer Service Management" },
                new SystemModule { Id = 10, Name = "Claims Management" },
                new SystemModule { Id = 11, Name = "Human Resources" },
                new SystemModule { Id = 12, Name = "Finance Management" },
                new SystemModule { Id = 13, Name = "System Administrator" }
            );

            //Ticket Types
            builder.Entity<TicketType>().HasData(
                new TicketType { Id = 1, Name = "Technical Support" },
                new TicketType { Id = 2, Name = "System Bug" },
                new TicketType { Id = 3, Name = "Change Request" }
            );

        }

    }
}