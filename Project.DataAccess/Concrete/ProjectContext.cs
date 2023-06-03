
using Microsoft.EntityFrameworkCore;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete
{
    public class ProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(conn);
        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }

    }
}
