using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest.exercicio2
{
    internal class Exercicio2
    {
        public static int PredictNextNumber(int[] seqNums)
        {
            int sizeArray = seqNums.Length;
            int lastNum = seqNums[sizeArray - 1];
            int penultimateNum = seqNums[sizeArray - 2];
            int thirdToLastNum = seqNums[sizeArray - 3];
            
            if (lastNum - penultimateNum == penultimateNum - thirdToLastNum)
            {
                //aritmetica
                return lastNum + (lastNum - penultimateNum);
            }
            else if ((lastNum - penultimateNum) / 2 == thirdToLastNum)
            {
                //dobrando
                return lastNum * 2;
            }
            else if (seqNums[0] == seqNums[1])
            {
                //Fibonacci
                return lastNum + penultimateNum;
            }
            else
            {
                //acrescendo
                int diffThirdToSec = (penultimateNum - thirdToLastNum);
                int diffSecToLast = (lastNum - penultimateNum);
                int difference = (diffSecToLast - diffThirdToSec);

                return lastNum + (diffSecToLast + difference);
            }

        }
        internal static void Executar()
        {
            int[] sequenceA = { 1, 3, 5, 7 };
            int[] sequenceB = { 2, 4, 8, 16, 32, 64 };
            int[] sequenceC = { 0, 1, 4, 9, 16, 25, 36 };
            int[] sequenceD = { 4, 16, 36, 64 };
            int[] sequenceE = { 1, 1, 2, 3, 5, 8 };
            int[] sequenceF = { 2, 10, 12, 16, 17, 18, 19 };
            int nextA = PredictNextNumber(sequenceA);
            int nextB = PredictNextNumber(sequenceB);
            int nextC = PredictNextNumber(sequenceC);
            int nextD = PredictNextNumber(sequenceD);
            int nextE = PredictNextNumber(sequenceE);
            int nextF = PredictNextNumber(sequenceF);

            Console.WriteLine("Próximo número da sequência 1: " + nextA);
            Console.WriteLine("Próximo número da sequência 2: " + nextB);
            Console.WriteLine("Próximo número da sequência 3: " + nextC);
            Console.WriteLine("Próximo número da sequência 4: " + nextD);
            Console.WriteLine("Próximo número da sequência 5: " + nextE);
            Console.WriteLine("Próximo número da sequência 6: " + nextF);
        }
    }
}
