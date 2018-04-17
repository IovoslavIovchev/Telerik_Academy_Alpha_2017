using Social_Network.Data;
using System;
using System.Data.Entity;
using System.Linq;
using Social_Network.Data.Migrations;

namespace Social_Network.Client
{
    class StartUp
    {
        static void Main()
        {
            SetUp();

            SocialNetworkContext ctx = new SocialNetworkContext();

            Console.WriteLine(ctx.UserProfiles.Count());

            var userprofiles = ctx.UserProfiles;

            foreach (var user in userprofiles)
            {
                Console.WriteLine(user.Username);
            }
        }

        private static void SetUp()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SocialNetworkContext, Configuration>());
        }
    }
}
