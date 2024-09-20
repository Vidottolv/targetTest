using System;

namespace TargetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K++;
                SOMA = Aggregate(SOMA,K);
                //K = K + 1;
                //SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
        }

        internal static int Aggregate(int FirstValue, int SecondValue)
        {
            return FirstValue += SecondValue;
        }
    }
}
