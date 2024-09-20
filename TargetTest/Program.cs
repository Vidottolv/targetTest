using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TargetTest.exercicio1;
using TargetTest.exercicio2;

namespace TargetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "exe1")
            {
                Program1.Executar();
            }
            else if (args.Length > 0 && args[0] == "exe2")
            {
                Program2.Executar();
            }
        }
    }
}
