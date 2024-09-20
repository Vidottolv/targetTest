using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TargetTest.exercicio4.Exercicio4DTO;

namespace TargetTest.exercicio4
{
    internal class MyDbContext : DbContext
    {
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Telefone> Telefones { get; set; }
            public DbSet<Estado> Estados { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=LOCALHOST;Database=DB_TARGET;Trusted_Connection=True");
            }
    }
}
