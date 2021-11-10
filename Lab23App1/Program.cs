using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab23App1
{
    class Program
    {
        //Разработать асинхронный метод для вычисления факториала числа.В методе Main выполнить проверку работы метода.
        static int n;
        static void Main(string[] args)
        {
            Console.Write("Введите целое значение для нахождения его факториала: ");
            n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync();
            Console.ReadKey();
        }
        static int Factorial()
        {
            int fac = 1;
            for (int i=1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine($"{n}! = {fac}");
            return fac;
        }
        static async void FactorialAsync()
        {
            await Task.Run(() => Factorial());
        }
    }
}
