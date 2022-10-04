using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1C
{
    class Program
    {
        static void Main(string[] args)
        {

            //Типы

            Console.WriteLine("bool: ");
            bool a = bool.Parse(Console.ReadLine());
            Console.WriteLine("bool: " + a);

            Console.WriteLine("byte: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte: " + b);

            Console.WriteLine("sbyte: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte: " + c);

            Console.WriteLine("char: ");
            char d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("char: " + d);

            Console.WriteLine("decimal: ");
            decimal e = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("decimal: " + e);

            Console.WriteLine("double: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("double: " + f);

            Console.WriteLine("float: ");
            float g = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("float: " + g);

            Console.WriteLine("int: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int: " + h);

            Console.WriteLine("uint: ");
            uint i = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("uint: " + i);

            Console.WriteLine("long: ");
            long l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long: " + l);

            Console.WriteLine("ulong: ");
            ulong m = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulong: " + m);

            Console.WriteLine("short: ");
            short n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("short: " + n);

            Console.WriteLine("ushort: ");
            ushort o = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("ushort: " + o);

            //неявное приведение

            byte prv = 255;
            int prv2 = prv;
            Console.WriteLine(prv2);

            int prv3 = 1236543;
            long prv4 = prv3;
            Console.WriteLine(prv4);

            byte prv5 = 255;
            short prv6 = prv5;
            Console.WriteLine(prv6);

            short prv7 = -204;
            int prv8 = prv7;
            Console.WriteLine(prv8);

            sbyte prv9 = -128;
            int prv10 = prv9;
            Console.WriteLine(prv10);

            //явное приведение

            double pr1 = 25.5;
            int pr2;
            pr2 = (int)pr1;
            Console.WriteLine(pr2);

            double pr3 = 10.5;
            short pr4;
            pr4 = (short)pr3;
            Console.WriteLine(pr4);

            double pr5 = 25555.5;
            long pr6;
            pr6 = (long)pr5;
            Console.WriteLine(pr6);

            short pr7 = 32767;
            byte pr8;
            pr8 = (byte)pr7;
            Console.WriteLine(pr8);

            double pr9 = 2147483649.2;
            ulong pr10;
            pr10 = (ulong)pr9;
            Console.WriteLine(pr10);

            //упаковка

            int pack1 = 159;
            object Twopack = pack1;
            Console.WriteLine(Twopack);
            int unpack = (int)Twopack;
            Console.WriteLine(unpack);

            var ney = 214;
            int sum = ney + 10;
            Console.WriteLine(sum);

            int? mint = null;
            Console.WriteLine(mint == null ? "empty" : "not empty");






        }
    }
}
