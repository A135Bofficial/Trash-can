using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массивы b

            string[] Arr = { "Cup", "Phone", "Table" };
            foreach(var item in Arr)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine("\nДлинна: " + Arr.GetLength(0));
            Console.WriteLine("Номер изменяемого элемента: ");

            int Num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Элемент: ");

            string Num2 = Console.ReadLine();

            Arr[Num1] = Num2;

            foreach (var item in Arr)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine("\n");

        }
    }
}
