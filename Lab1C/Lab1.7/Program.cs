using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Кортежи 1

            (int, string, char, string, ulong) cortej = (93, "Start", '#', "End", 158);
            Console.WriteLine($"{cortej.Item1}\t{cortej.Item2}\t{cortej.Item3}\t{cortej.Item4}\t{cortej.Item5}");
            Console.WriteLine($"Item1: {cortej.Item1}\nItem3: {cortej.Item3}\nItem4: {cortej.Item4}");
            var first = cortej.Item1;
            var second = cortej.Item2;
            var third = cortej.Item3;
            var fourth = cortej.Item4;
            var fifth = cortej.Item5;

            (int, string, char, string, ulong) cortej2 = (39, "Star", '%', "And", 372);

            if (cortej == cortej2)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }



        }
    }
}
