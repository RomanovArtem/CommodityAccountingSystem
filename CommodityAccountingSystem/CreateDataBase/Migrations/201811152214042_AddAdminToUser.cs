namespace CreateDataBase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public partial class AddAdminToUser : DbMigration
    {
        CASContext context = new CASContext();

        public override void Up()
        {

            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Password = "admin"
            };

            context.Users.Add(user);
            context.SaveChanges();
        }

        public override void Down()
        {
            var user = context.Users.FirstOrDefault(u => u.Login == "admin");
            if (user!= null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
