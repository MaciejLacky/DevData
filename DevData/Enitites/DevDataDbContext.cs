using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevData.Enitites
{
    public class DevDataDbContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=DevData;Trusted_Connection=True;";
       // private string _connectionString = "Server=DESKTOP-F3NJMD4\\SQLEXPRESS;Database=DevData;User //Id=user1;password=pass1;Trusted_Connection=True; Integrated Security=False";

        public DbSet<Table_A> Table_A { get; set; }
        public DbSet<Table_B> Table_B { get; set; }
        public DbSet<Table_C> Table_C { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);            
        }
    }
}
