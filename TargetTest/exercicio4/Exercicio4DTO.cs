using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest.exercicio4
{
    internal class Exercicio4DTO
    {
        public class Cliente
        {
            public int Codigo { get; set; }
            public int ClienteId { get; set; }
            public string RazaoSocial { get; set; }
            public int EstadoId { get; set; }
            public string EstadoCodigo { get; set; }
            public Estado Estado { get; set; }
            public ICollection<Telefone> Telefones { get; set; }
        }

        public class Telefone
        {
            public int Id { get; set; }
            public string Numero { get; set; }
            public string Tipo { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
        }

        public class Estado
        {
            public string EstadoCodigo { get; set; }
            public int EstadoId { get; set; }
            public string Nome { get; set; }
            public ICollection<Cliente> Clientes { get; set; }
        }
    }
}
