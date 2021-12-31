using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyASPNetCoreMVC.Models;

namespace MyASPNetCoreMVC.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }


        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
    }
}
