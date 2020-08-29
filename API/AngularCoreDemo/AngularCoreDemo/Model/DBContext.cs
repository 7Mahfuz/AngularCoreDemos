using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DemoModels.Areas.Auth.Entity;

namespace Demo.Gateway
{
   public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext>option):base(option)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
