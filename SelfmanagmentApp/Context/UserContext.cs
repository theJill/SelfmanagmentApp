using System.Data.Entity;

namespace SelfmanagmentApp.Context
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }

        public DbSet<ListDeal> ListDeals { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<PlaningUser> Planings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
