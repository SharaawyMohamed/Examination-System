using System.Diagnostics;
using System.Transactions;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|| ======================================================================= ||");
            Console.WriteLine("||                                                                         ||");
            Console.WriteLine("||    :)                                                             :)    ||");
            Console.WriteLine("||                Welcome Welcome in our Examination System                ||");
            Console.WriteLine("||    :)                                                             :)    ||");
            Console.WriteLine("||                                                                         ||");
            Console.WriteLine("|| ======================================================================= ||\n\n");

            char pass;
            Console.Write(" Welcome are you need begin in our Examination System [Y or N] : ");
            while (char.TryParse(Console.ReadLine(), out pass) && (pass == 'Y' || pass == 'y'))
            {
                int id;
                do
                {
                    Console.Write(" Enter Subject Id : ");
                } while (!int.TryParse(Console.ReadLine(), out id));

                string name;
                do
                {
                    Console.Write(" Enter Subject Name: ");
                    name = Console.ReadLine();
                } while (string.IsNullOrEmpty(name));

                Subject subject = new Subject(id, name);
                subject.CreateExam();
                Console.Clear();

                char C;
                do
                {
                    Console.Write(" Do you want begin exam [ Y | N ] : ");
                } while (!char.TryParse(Console.ReadLine(), out C));
                Console.WriteLine();

                if (C == 'Y')
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    subject.BeginExam();
                    Console.WriteLine($" Time Taken in this Exam : {sw.Elapsed}");
                }
                Console.WriteLine(" \nAre you need Create Exam Again [Y | N ]");
            }
        }
    }
}