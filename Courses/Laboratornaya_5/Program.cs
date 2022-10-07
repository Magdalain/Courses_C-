using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            List<string> names = new List<string>();
            do
            {
                Console.WriteLine("Введите имя");
                inputName = Console.ReadLine();
                names.Add(inputName);
            }
            while (!string.IsNullOrEmpty(inputName));
            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
