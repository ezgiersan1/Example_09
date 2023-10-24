using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            string[] name = new string[3];
            string[] surname = new string[3];
            int[] point = new int[3];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Number:");
                number[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name:");
                name[i] = Console.ReadLine();

                Console.Write("Surname:");
                surname[i] = Console.ReadLine();

                Console.Write("Point:");
                point[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            for (int i = 0;i < number.Length;i++)
            {
                Console.WriteLine($"{number[i]}-{name[i]} {surname[i].ToUpper()} ({point[i]})");
            }
            Console.ReadKey();
        }
    }
}
