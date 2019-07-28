namespace W4_MVCClubs.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using W4_MVCClubs.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<W4_MVCClubs.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(W4_MVCClubs.Models.ApplicationDbContext context)
        {
            var manager =
                new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "ClubAdmin" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "member" }
                );

            PasswordHasher ps = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "powell.paul@itsligo.ie",
                    EmailConfirmed = true,
                    JoinDate = DateTime.Now,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Paul",
                    SurName = "Powell",
                    PasswordHash = ps.HashPassword("Ppowell$1")
                });

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "ITS FC Admin",
                    Email = "radp2016@outlook.com",
                    EmailConfirmed = true,
                    JoinDate = DateTime.Now,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Rad",
                    SurName = "Paulner",
                    PasswordHash = ps.HashPassword("radP2016$1")
                });
            context.SaveChanges();

            ApplicationUser admin = manager.FindByEmail("powell.paul@itsligo.ie");
            if (admin != null)
            {
                manager.AddToRoles(admin.Id, new string[] { "Admin", "member", "ClubAdmin" });
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
