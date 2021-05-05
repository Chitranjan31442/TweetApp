using Microsoft.EntityFrameworkCore;
using TweetApp.Dal.Models;

namespace TweetApp.Repository
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<TweetData> Tweet { get; set; }
        public DbSet<UserData> Users { get; set; }


    }
}
