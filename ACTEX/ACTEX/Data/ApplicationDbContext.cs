using ACTEX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using System.Reflection.Emit;

namespace ACTEX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(SeedUserTypeData());
            modelBuilder.Entity<User>().HasData(SeedUserData());
        }
        public List<User> SeedUserData()
        {
            var users = new List<User>();
            using (StreamReader r = new StreamReader(@"Data/InitData/Users.json"))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }
        public List<UserType> SeedUserTypeData()
        {
            var userTypes = new List<UserType>();
            using (StreamReader r = new StreamReader(@"Data/InitData/UserTypes.json"))
            {
                string json = r.ReadToEnd();
                userTypes = JsonConvert.DeserializeObject<List<UserType>>(json);
            }
            return userTypes;
        }
    }
}
