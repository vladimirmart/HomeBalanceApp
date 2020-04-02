using HomeBalance.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBalance.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {

        }

        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<User> Users { get; set; }
    } 
}
