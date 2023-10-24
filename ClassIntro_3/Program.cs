using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro_3
{
    internal class Program
    {
        private static object students;

        static void Main(string[] args)
        {
            Student[] student = new Student();

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Number:");
                students[i].Setnumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name:");
                students[i].Setname = Console.ReadLine();

                Console.Write("Surname:");
                students[i].Setsurname = Console.ReadLine();

                Console.Write("Point:");
                students[i].Setpoint = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i].Getnumber()}-{students[i].Getname()} {students[i].Getsurname().ToUpper()} ({students[i].Getpoint()})");
            }
            Console.ReadKey();
        }
    }
}
