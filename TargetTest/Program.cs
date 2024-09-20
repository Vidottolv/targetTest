using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TargetTest.exercicio1;
using TargetTest.exercicio2;
using TargetTest.exercicio3;

namespace TargetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "exe1")
            {
                Exercicio1.Executar();
            }
            else if (args.Length > 0 && args[0] == "exe2")
            {
                Exercicio2.Executar();
            }
            else if(args.Length > 0 && args[0] == "exe3")
            {
                Exercicio3.Executar();
            }
        }
    }
}
