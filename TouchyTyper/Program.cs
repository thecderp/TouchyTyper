using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;

namespace TouchyTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = 0;
            int maxNum = 26;
            int[] matchyText = new int[10]; //10 elements
            Random randNum = new Random();
            for (int i = 0; i < matchyText.Length; i++) {
                matchyText[i] = randNum.Next(minNum, maxNum);
                Console.WriteLine(matchyText[i]);
            }
            


           /*
           * int Min = 0;
           * int Max = 20;
           * 
           * // this declares an integer array with 5 elements
           * // and initializes all of them to their default value
           * // which is zero
           * int[] test2 = new int[5];
           * 
           * Random randNum = new Random();
           * for (int i = 0; i < test2.Length; i++)
           * {
           *     test2[i] = randNum.Next(Min, Max);
           * }
           */
        }
    }
}
