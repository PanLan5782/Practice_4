using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n=InputData("n=");

            for (int i = 1; i <= n; i++)
                if (IsFullSquare(i) == true)
                {
                    Console.WriteLine(i);
                    count++;
                }
            Console.WriteLine($"В указанном диапазоне {count} чисел.");


        }
        public static bool IsFullSquare(int n)
        { 
            int sn = (int)Math.Sqrt(n);
            for (int i = 2; i < sn; i++)
                if (Math.Sqrt(n-i*i) % 1 == 0)
                    return true;

            return false;
        }
        public static int InputData(String prompt)
        {
            bool ok = true;
            int  v = 0;
            do
            {
                Console.Write(prompt);
                ok = int.TryParse(Console.ReadLine(), out v);
                if (!ok)
                    Console.WriteLine("Введенный символ не является числом. Повторите ввод.");
            }
            while (!ok);
            return v;
        }
    }
}
