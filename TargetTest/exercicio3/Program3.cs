using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest.exercicio3
{
    internal class Program3
    {
        internal static void Executar()
        {
            int diasNoAno = 365;
            double minFaturamento = 0;
            double maxFaturamento = 20000; // setei 20000 pra evitar números absurdamente fora da realidade
            Random random = new Random();

            double[] faturamentoDiario = new double[diasNoAno];
            for(int i = 0; i < diasNoAno; i++)
            {
                faturamentoDiario[i] = random.NextDouble() * (maxFaturamento - minFaturamento) + minFaturamento;
            }
            //foreach (double valor in faturamentoDiario)
            //{
            //    Console.WriteLine(valor);
            //}

            double menorFaturamento = faturamentoDiario.Where(f => f > 0).Min();
            double maiorFaturamento = faturamentoDiario.Max();
            double mediaAnual = faturamentoDiario.Where(f => f > 0).Average();
            int diasAcimaDaMedia = faturamentoDiario.Count(f => f > mediaAnual);

            Console.WriteLine($"Menor faturamento: R$ {menorFaturamento.ToString("F3")}");
            Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento.ToString("F3")}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
    }
}