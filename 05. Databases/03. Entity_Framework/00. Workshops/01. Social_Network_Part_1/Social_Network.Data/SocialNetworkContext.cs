using Social_Network.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Social_Network.Data
{
    public class SocialNetworkContext : DbContext
    {
        public SocialNetworkContext()
            : base("SocialNetwork")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Friendship> Friendships { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Post> Posts { get; set; }
            
        public DbSet<Message> Messages { get; set; }
    }
}
