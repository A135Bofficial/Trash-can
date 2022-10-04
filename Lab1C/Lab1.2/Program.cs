using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Строки

            string lit1 = "Это строка.";
            string lit2 = "Это тоже строка.";
            if(lit1 == lit2)
            {
                Console.WriteLine("The same");
            }
            else 
            {
                Console.WriteLine("Not the same");
            }

            string s1 = "First", s2 = "Second", s3 = "Third", s4 = "";
            s4 = s1 + " " + s2 + " ";
            s4 = string.Concat(s4, "Concat");
            Console.WriteLine("конкатенация: " + s4);

            s4 = "";
            s4 = string.Copy(s1);
            Console.WriteLine("Копирование: " + s4);

            s4 = "Never mind";
            s4 = s4.Substring(0, 5);
            Console.WriteLine("Подстрока: " + s4);

            s4 = "Smells like teen spirits";
            string[] StringArray = s4.Split(' ');
            foreach (var item in StringArray) 
            {
                Console.WriteLine("Одно слово из предложения: " + item);
            }

            s4 = "I'm the only one";
            s4 = s4.Insert(3, " not");
            Console.WriteLine("Результат вставки: " + s4);

            s4 = s4.Remove(4,4);
            Console.WriteLine("Удаление подстроки: " + s4);

            Console.WriteLine($"Интерполирование строки: {s4}");

            string s5 = "";
            string s6 = null;
            string s7 = "qwer";

            if (string.IsNullOrEmpty(s5))
            {
                Console.WriteLine("s5 - пустая");
            }
            else
            {
                Console.WriteLine("s5 - не пустая");
            }

            if(string.IsNullOrEmpty(s6))
            {
                Console.WriteLine("s6 - пустая");
            }
            else
            {
                Console.WriteLine("s6 - не пустая");
            }

            if(string.IsNullOrEmpty(s7))
            {
                Console.WriteLine("s7 - пустая");
            }
            else
            {
                Console.WriteLine("s7 - не пустая");
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Smells ");
            sb.Append("Like ");
            sb.Append("Teen ");

            string ssb = sb.ToString();
            Console.WriteLine(ssb);

            sb.Append("Spirit ");

            ssb = sb.ToString();
            Console.WriteLine(ssb);

            sb.Insert(0, "Kurt ");

            ssb = sb.ToString();
            Console.WriteLine(ssb);

            sb.Remove(0, 5);

            ssb = sb.ToString();
            Console.WriteLine(ssb);

        }
    }
}
