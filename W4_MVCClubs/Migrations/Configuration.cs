namespace W4_MVCClubs.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
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
            System.Globalization.CultureInfo cultureinfo = CultureInfo.CreateSpecificCulture("en-IE");

            var manager =
                new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin", Id = "1" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "ClubAdmin", Id = "2" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Members", Id = "3" }
                );

            PasswordHasher ps = new PasswordHasher();

            //context.Users.AddOrUpdate(u => u.UserName,
            //    new ApplicationUser
            //    {
            //        UserName = "Admin",
            //        Email = "powell.paul@itsligo.ie",
            //        EmailConfirmed = true,
            //        JoinDate = DateTime.ParseExact("09/10/2018 23:45:42","dd/MM/yyyy H:mm:ss", cultureinfo),
            //        SecurityStamp = Guid.NewGuid().ToString(),
            //        FirstName = "Paul",
            //        SurName = "Powell",
            //        PasswordHash = ps.HashPassword("Ppowell$1")
            //    });

            //context.Users.AddOrUpdate(u => u.UserName,
            //    new ApplicationUser
            //    {
            //        UserName = "ClubAdmin",
            //        Email = "powell.paul@itsligo.ie",
            //        EmailConfirmed = true,
            //        JoinDate = DateTime.ParseExact("09/10/2018 23:45:42", "dd/MM/yyyy H:mm:ss", cultureinfo),
            //        SecurityStamp = Guid.NewGuid().ToString(),
            //        FirstName = "Paul",
            //        SurName = "Powell",
            //        PasswordHash = ps.HashPassword("radP2016$1")
            //    });
            //context.Users.AddOrUpdate(u => u.UserName,
            //   new ApplicationUser
            //   {
            //       UserName = "Members",
            //       Email = "powell.paul@itsligo.ie",
            //       EmailConfirmed = true,
            //       JoinDate = DateTime.ParseExact("09/10/2018 23:45:42", "dd/MM/yyyy H:mm:ss", cultureinfo),
            //       SecurityStamp = Guid.NewGuid().ToString(),
            //       FirstName = "Paul",
            //       SurName = "Powell",
            //       PasswordHash = ps.HashPassword("radP2016$1")
            //   });
            context.Users.AddOrUpdate(u => u.UserName,
               new ApplicationUser
               {
                   UserName = "Members",
                   Email = "powell.paul@outlook.com",
                   EmailConfirmed = true,
                   JoinDate = DateTime.ParseExact("09/10/2018 23:45:42", "dd/MM/yyyy H:mm:ss", cultureinfo),
                   SecurityStamp = Guid.NewGuid().ToString(),
                   FirstName = "Rad",
                   SurName = "Paulner",
                   PasswordHash = ps.HashPassword("radP2016$1")
               });
            context.SaveChanges();

            ApplicationUser admin = manager.FindByEmail("s00083446@mail.itsligo.ie");
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
