using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(){ }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           // optionsBuilder.UseSqlite("Data Source=SmartNote&ToDoDB.SQLite;");
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(Application.StartupPath, "SmartNote&ToDoDB.SQLite")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(e=>e.UserName).IsUnique();
            modelBuilder.Entity<Note>().Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            // seed data for Guest
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                UserName = "guest",
                Password = "guest"
            });


        }


        public DbSet<User> Users { get; set; }  
        public DbSet<Category> Categories { get; set; }     
        public DbSet<Note> Notes { get; set; }       

    }
}
