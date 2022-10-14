using System;

namespace Laboratornaya_3
{
    internal class Program
    // fibonacci (0) 1 1 2 3 5 8
    {
        static void Main(string[] args)
        {



            int fibTec = 1;
            int fibPred = 0;
            int fibonacci;


            do
            {

                Console.WriteLine(fibTec);
                fibonacci = fibTec + fibPred;
                
                fibPred = fibTec;
                fibTec = fibonacci;
             


            }
            while (fibTec < 1000);




        }
    }
}

