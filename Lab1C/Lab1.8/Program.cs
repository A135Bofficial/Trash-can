using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Функции
namespace Lab1._8
{
    class Program
    {
        static void Retorl(int[] numbers, string str)
        {
            (int MaxE, int MinE, int Sum, string Let) cortej;
            cortej.MaxE = numbers.Max();
            cortej.MinE = numbers.Min();
            int summa = 0;
            foreach (var item in numbers)
            {
                summa += item;
            }
            cortej.Sum = summa;
            cortej.Let = str.Substring(0, 1);
            Console.WriteLine($"Максимальный: {cortej.MaxE}  Минимальный:{cortej.MinE}  Сумма:{cortej.Sum}  Первая буква:{cortej.Let}");
        }

        static int CheckedFun()
        {
            int num1 = checked(2147483647);
            return num1;
        }

        static int UnCheckedFun()
        {
            int num2 = unchecked(2147483647+1);
            return num2;
        }

        static void Main(string[] args)
        {
            int[] Arr = new int[4] { 7, 3, 6, 4 };
            string lok = "Home";
            Retorl(Arr, lok);
            Console.WriteLine($"Checked: {CheckedFun()}\tUnchecked: {UnCheckedFun()}");
        }
    }
}
