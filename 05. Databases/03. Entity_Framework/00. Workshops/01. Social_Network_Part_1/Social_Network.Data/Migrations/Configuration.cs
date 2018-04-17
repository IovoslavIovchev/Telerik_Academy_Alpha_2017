namespace Social_Network.Data.Migrations
{
    using Social_Network.Models;
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SocialNetworkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SocialNetworkContext context)
        {
            context.UserProfiles.Add(new UserProfile() { Username = "Petranko421", FirstName = "Petranko", LastName = "Petrankov" });
            context.UserProfiles.Add(new UserProfile() { Username = "Go6o125", FirstName = "Go6o", LastName = "Go6ov" });
            context.UserProfiles.Add(new UserProfile() { Username = "Min4oKilara420", FirstName = "Min4o", LastName = "Kilarov" });
            context.UserProfiles.Add(new UserProfile() { Username = "bushdid911", FirstName = "Conspiracy", LastName = "Theorist" });
            context.SaveChanges();

            context.Friendships.Add(new Friendship() { FirstUserID = 2, SecondUserID = 3, Approved = true, FriendsSince = DateTime.Now });
            context.Friendships.Add(new Friendship() { FirstUserID = 2, SecondUserID = 1, Approved = true, FriendsSince = DateTime.Now });
            context.Friendships.Add(new Friendship() { FirstUserID = 1, SecondUserID = 3, Approved = false });
            context.SaveChanges();

            context.Images.Add(new Image() { ImageURL = @"http://vege.com.pl/wp-content/uploads/2013/10/smierc.jpg", FileExtension = "jpg", UserID = 1 });
            context.Images.Add(new Image() { ImageURL = @"http://www.lanuevarutadelempleo.com/sites/default/files/imagenes_noticias/la_luz_que_no_puedes_alcanzar_al_final_del_tunel.jpg", FileExtension = "jpg", UserID = 2 });

            context.Messages.Add(new Message() { AuthorID = 3, Content = "Ko staa brat?", SentOn = DateTime.Now });

            context.SaveChanges();
        }
    }
}
