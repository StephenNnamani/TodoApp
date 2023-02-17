using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAppDAL
{
    public class ToDoContextDbFactory : IDesignTimeDbContextFactory<ToDoDbContext>
    {
        public ToDoContextDbFactory()
        {

        }

        public ToDoDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<ToDoDbContext>();
            var connectionString = @"Data Source=DESKTOP-BJR8R95\SQLEXPRESS;Initial Catalog=TodoDB Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionBuilder.UseSqlServer(connectionString);
            return new ToDoDbContext(optionBuilder.Options);
        }
    }
}
