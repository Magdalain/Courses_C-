using System;

namespace Laboratornaya_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, введите температуру в градусах Цельсия");
            double celsTemp = Convert.ToDouble (Console.ReadLine());
            double farTemp = celsTemp * 9 / 5 + 32;
            Console.WriteLine("Температура в Фаренгейтах : {0:F6}", farTemp);
            Console.ReadLine();
        }
    }
}
