using System.Collections.Generic;
using System.Data.Entity;
using Models;

namespace Data
{
    internal class RoleContextInitializer : DropCreateDatabaseAlways<RoleContext>
    {
        protected override void Seed(RoleContext context)
        {

            context.Users.Add(new User
            {
                //Change this to whatever you're logged in as on the machine that's running
                Name = "WIN-I503DI913IN\\Developer",
                Roles = new List<Role>
                {
                    new Role
                    {
                        Name = "Admin"
                    }
                }
            });

            context.Roles.Add(new Role
            {
                Name = "Manager"
            });

            context.SaveChanges();

        }
    }
}