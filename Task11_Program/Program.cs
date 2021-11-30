using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructEquation;

namespace Task11_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения вида 0 = kx+b");
            Console.Write("Введите коэффициент k: ");
            InputNumber(out double k);
            Console.Write("Введите коэффициент b: ");
            InputNumber(out double b);
            LinEq linear = new LinEq(k, b);
            linear.Root();
            Console.ReadKey();
        }
        static void InputNumber(out double number)
        {
            number = 0;
            bool x;
            do
            {
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    x = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}\nПопробуйте еще раз\n", ex.Message);
                    Console.Write("Введите число: ");
                    x = true;
                }
            } while (x);
        }
    }
}
