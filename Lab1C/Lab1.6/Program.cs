using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы d

            int[] Arr = { 8, 4, 7, 8, 2, 6, 4, 8 };
            var massiv = Arr;
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
            Console.Write("\n" + massiv + "\n");

            var stroka = "Neyavno tipizirovannaya peremennaya dlya stroki";
            Console.WriteLine(stroka);





        }
    }
}
