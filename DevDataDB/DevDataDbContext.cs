using DevData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDataDB
{
    public class DevDataDbContext : DbContext
    {
       
        private string _connectionString = "Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=DevData;User Id=user;password=pass;Trusted_Connection=True; Integrated Security=False";

        public DevDataDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
           // base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Table_A> table_a { get; set; }
        public DbSet<Table_B> table_b { get; set; }
        public DbSet<Table_C> table_c { get; set; }

    }
}
