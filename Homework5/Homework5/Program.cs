using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Homework5
    {
        static void Main()
        {
            Console.WriteLine("1 Задание:");
            BinarFile();
        }

        static void BinarFile(int N = 20, double a = -50, double b = 50, string fileName = "task1.txt")
        {
            if (N <= 0 || a > b || string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Неправильные значения.");
                return;
            }
        }
    }
}