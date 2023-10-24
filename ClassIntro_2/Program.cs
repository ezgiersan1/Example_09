using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            for (int i = 0; i < students.Length; i++) 
            {
                Console.Write("Number:");
                students[i].number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name:");
                students[i].name = Console.ReadLine();

                Console.Write("Surname:");
                students[i].surname = Console.ReadLine();

                Console.Write("Point:");
                students[i].point = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < students.Length; i++) 
            {
                Console.WriteLine($"{students[i].number}-{students[i].name} {students[i].surname.ToUpper()} ({students[i].point})");
            }
            Console.ReadKey();
        }
    }
}
