using System;
using System.Collections.Generic;
using System.Configuration;
using System.Numerics;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Languago.Models.DataStructures;
using Languago.Models.Protector;

namespace Languago.Models.orm
{
    public class LanguagoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Word> Words { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ToDo Safety
            var connectionStringClass = new DB_LOGINS();
            optionsBuilder.UseNpgsql(connectionStringClass.ConnectorString);
        }
    }

}


