namespace HaianhShop.Data.Migrations
{
    using HaianhShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaianhShop.Data.HaiAnhShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HaianhShop.Data.HaiAnhShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new HaiAnhShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new HaiAnhShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "haianh",
                Email = "haianh.international@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Technology Education"

            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("haianh.international@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
