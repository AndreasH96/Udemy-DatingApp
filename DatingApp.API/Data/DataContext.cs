using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext    //Inheriting from DbContext, a session with the application Database
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }

        public DbSet<Value> Values{get;set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}