using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class First
    {

        public int a = 3;
        public int b = 2;

        public void MyInfo()
        {
            Console.WriteLine($"Переменная 1: {a}, Переменная 2: {b}");
            Console.Write("Введите два числа, чтобы изменить значения переменных ");
        }

    }
    public class Second
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        public void Change()
        {
            Console.WriteLine($"Переменная 1: {num1},Переменная 2: {num2}");
        }
        public void Sum()
        {
            Console.WriteLine($"Сумма: {num1 + num2}");
        }
        public void More()
        {
          
            if (num1 > num2)
            {
                Console.WriteLine($"Наибольшее значение: {num1}");
            }
            else
            {
                Console.WriteLine($"Наибольшее значение: {num2}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            First one = new First();
            one.MyInfo();

            Second two = new Second();
            two.Change();
            two.Sum();
            two.More();

            Console.ReadKey();
        }
    }
}
