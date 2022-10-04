using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы а

            int[,] Arr = new int[10, 6];

            Random rand = new Random();

            for (int i = 0; i < Arr.GetLength(0); i++) 
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = rand.Next(10, 100);
                }
            }

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "  ");
                }
                Console.WriteLine("    |");
            }

        }
    }
}
