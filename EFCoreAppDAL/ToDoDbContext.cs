using System;
using EFCoreAppDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCoreAppDAL
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            :base(options)
        {

        }

       public DbSet<User> users { get; set; }
    }
}
