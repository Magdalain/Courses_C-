using System;


namespace Laboratornaya_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ворон");
            int inputRavens = Convert.ToInt32(Console.ReadLine());

            int ravens = inputRavens % 100;
            if (ravens >= 11 && ravens <= 14)
            {
                Console.WriteLine($"На дереве {inputRavens} ворон"); 
            }
            else

            switch (inputRavens % 10)
            {
                case 1:
                    Console.WriteLine($"На дереве {inputRavens} ворона");
                    break;
                    case 2:
                    Console.WriteLine($"На дереве {inputRavens} вороны");
                    break;
                case 3:
                    goto case 2;
                    case 4:
                    goto case 2;
                case 5:
                Console.WriteLine($"На дереве {inputRavens} ворон");
                    break;
                case 6:
                    goto case 5;
                    case 7:
                    goto case 5;
                case 8:
                    goto case 5;
                case 9:
                    goto case 5;
                default:
                    Console.WriteLine($"На дереве  {inputRavens}  ворон ");
                    break;
            }
            Console.ReadLine();


        }
    }
}
