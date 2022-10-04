using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы c

            double[][] Arr= new double[3][];
            Arr[0] = new double[2];
            Arr[1] = new double[3];
            Arr[2] = new double[4];

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write($"Введите элемент {i} {j}: ");
                    Arr[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
