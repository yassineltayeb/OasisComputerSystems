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
        public DbSet<Religion> Religions { get; set; }
        public DbSet<SystemModule> SystemsModules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
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

            //Models Delete Behavior
            // builder.Entity<StaffProfile>()
            //     .HasOne<Client>(u => u.Client)
            //     .WithMany()
            //     .HasForeignKey(u => u.Id);

            //Seed Database
            //Countries
            builder.Entity<Country>().HasData(
                new Role { Id = 1, Name = "Sudan" },
                new Role { Id = 2, Name = "Saudi Arabia" },
                new Role { Id = 3, Name = "Lebanon" },
                new Role { Id = 4, Name = "United Arab Emirate" },
                new Role { Id = 5, Name = "Qatar" },
                new Role { Id = 6, Name = "Mauritius" }
            );

            //Genders
            builder.Entity<Gender>().HasData(
                new Role { Id = 1, Name = "Male" },
                new Role { Id = 2, Name = "Female" }
            );

            //Marital Statuses
            builder.Entity<MaritalStatus>().HasData(
                new Role { Id = 1, Name = "Single" },
                new Role { Id = 2, Name = "Married" },
                new Role { Id = 3, Name = "Widowed" },
                new Role { Id = 4, Name = "Divorced" },
                new Role { Id = 5, Name = "Separated" }
            );

            //Nationalities
            builder.Entity<Nationality>().HasData(
                new Role { Id = 1, Name = "Sudanese" },
                new Role { Id = 2, Name = "Saudi" }
            );

            //Genders
            builder.Entity<Religion>().HasData(
                new Role { Id = 1, Name = "Muslim" },
                new Role { Id = 2, Name = "Non-Muslim" }
            );

            //Roles
            builder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new Role { Id = 2, Name = "Member", NormalizedName = "MEMBER" },
                new Role { Id = 3, Name = "Client", NormalizedName = "CLIENT" }
            );

            //Systems Modules
            builder.Entity<SystemModule>().HasData(
                new Role { Id = 1, Name = "Master Tables" },
                new Role { Id = 2, Name = "Clients Management" },
                new Role { Id = 3, Name = "Business Development" },
                new Role { Id = 4, Name = "Production (Insurance)" },
                new Role { Id = 5, Name = "Production (Reinsurance - Facultative)" },
                new Role { Id = 6, Name = "Production (Reinsurance - Facultative Claims)" },
                new Role { Id = 7, Name = "Production (Reinsurance - Treaties)" },
                new Role { Id = 8, Name = "Production (Reinsurance - Treaties Claims)" },
                new Role { Id = 9, Name = "Customer Service Management" },
                new Role { Id = 10, Name = "Claims Management" },
                new Role { Id = 11, Name = "Human Resources" },
                new Role { Id = 12, Name = "Finance Management" },
                new Role { Id = 13, Name = "System Administrator" }
            );

        }

    }
}