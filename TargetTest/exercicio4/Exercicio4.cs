using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static TargetTest.exercicio4.Exercicio4DTO;

namespace TargetTest.exercicio4
{
    internal class Exercicio4
    {
        internal static void Executar()
        {
            using (var context = new MyDbContext())
            {
                // Criando um novo cliente
                var cliente = new Cliente
                {
                    RazaoSocial = "Minha Empresa",
                    EstadoCodigo = "SP",
                    Telefones = new List<Telefone>
                    {
                        new Telefone { Numero = "(11) 1234-5678", Tipo = "Comercial" }
                    }
                };
                context.Clientes.Add(cliente);
                context.SaveChanges();

                // Consultando clientes de SP
                var clientesSp = context.Clientes
                    .Include(c => c.Telefones)
                    .Where(c => c.Estado.EstadoCodigo == "SP")
                    .ToList();
            }
        }
    }
}

