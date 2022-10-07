using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рахмер массива");
            int inputSize = Convert.ToInt32(Console.ReadLine());
            int [] newArray = new int[inputSize];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Введите число в массив");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                newArray[i] = inputNum;
            }   
            int min = newArray[0];
            int max = newArray[0];
            int sum = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] < min )
                    min = newArray[i];
                if (newArray[i] > max)
                    max = newArray[i];
                sum = sum + newArray[i];

            }
            double avg = (double)sum/inputSize;
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avg}");
            Console.ReadLine();
        }
    }
}
// 7 6 8 655 7 4 3 78 9 99
 