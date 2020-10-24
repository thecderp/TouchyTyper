using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace TouchyTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = 1;
            int maxNum = 26;
            int[] matchyText = new int[10]; //10 elements
            
            Random randNum = new Random();
            for (int i = 0; i < matchyText.Length; i++) {
                matchyText[i] = randNum.Next(minNum, maxNum);
                Console.WriteLine(matchyText[i]); //This will be temporary
            }
        }
    }
}

