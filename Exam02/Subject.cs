using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exam02
{
    public class Subject
    {
        private int _id;
        private string _name;
        internal string[] _questions;
        internal Answers[] _answers;
        internal string[] _questbody;
        private int head = 1;// store type header for question
        private int mark;
        private int TR;// store id for correct answer to every question
        private int type;// type exam practical of final
        private int time;// time for exam
        private int NOQ;// number of question in exam
        private string body, a, b, c;// body question and three answers a,b and c

        internal Subject(int id, string name)
        {
            _id = id;
            _name = name;
        }
        internal void CreateExam()
        {
            // reade type of question practical or final
            do
            {
                Console.Write(" Welcome MR. enter Type your exam [ 1 for Practical ,2 for Final] : ");
            } while (!int.TryParse(Console.ReadLine(), out type) || !(type == 1 || type == 2));

            // read time for exam
            do
            {
                Console.Write(" Enter time of your exam in Minutes : ");

            } while (!int.TryParse(Console.ReadLine(), out time) || time <= 0);

            // read number of question for this exam
            do
            {
                Console.Write(" Enter number of Question : ");
            } while (!int.TryParse(Console.ReadLine(), out NOQ) || NOQ <= 0);


            // set size for arrays question and answers
            _questions = new string[NOQ + 1];// one base
            _answers = new Answers[NOQ + 1]; //indx[i,0]this for correct answer,others for question answers
            _questbody = new string[NOQ + 1];

            for (int i = 1; i <= NOQ; i++)
            {
                Console.Clear();

                string header = "MCQ Question";//defualt header mcq type 1
                if (type == 2)
                {
                    do
                    {
                        Console.Write(" Enter Header of your Question [ 1 for MCQ , 2 for (T | F) ]: ");
                    } while (!int.TryParse(Console.ReadLine(), out head) || (head < 1 || head > 2));
                    header = (head == 2 ? "(T | F) Question" : header);
                }
                Console.WriteLine(" " + header);

                do
                {
                    Console.Write(" Enter body of your question : ");
                    body = Console.ReadLine();
                } while (string.IsNullOrEmpty(body));

                do
                {
                    Console.Write(" Enter mark for this question : ");
                } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0);
                if (head == 1)
                {
                    do
                    {
                        Console.Write(" Enter first choice: ");
                        a = Console.ReadLine();
                    } while (string.IsNullOrEmpty(a));

                    do
                    {
                        Console.Write(" Enter second choice : ");
                        b = Console.ReadLine();
                    } while (string.IsNullOrEmpty(b));


                    do
                    {
                        Console.Write(" Enter therd choice : ");
                        c = Console.ReadLine();
                    } while (string.IsNullOrEmpty(c));
                }

                if (head == 1)
                {
                    do
                    {
                        Console.Write($" Enter Correct answer [ 1 for a, 2 for b and 3 for c ] : ");

                    } while (!int.TryParse(Console.ReadLine(), out TR) || (TR < 1 || TR > 3));
                }
                else
                {
                    do
                    {
                        Console.Write(" Enter [ 1 for True , 2 for False ] : ");
                    } while (!int.TryParse(Console.ReadLine(), out TR) || (TR > 2 || TR < 1));
                }

                Question obj;// using dynamic binding
                if (head == 1)
                {
                    obj = new MCQ(head == 1 ? " MCQ Question" : "(T | F ) Question", body, mark, i, a, b, c);
                }
                else
                {
                    obj = new T_OR_F(head == 1 ? " MCQ Question" : " (T | F ) Question", body, mark, i);
                }
                // set data which stored
                _questions[i] = obj.ToString();
                _questbody[i] = body;
                Answers answers = new Answers(TR, a, b, c, mark, head);
                _answers[i] = answers;
            }

        }
        internal void BeginExam()
        {

            //Console.WriteLine("Select Type");
            Exam exam;
            if (type == 1)
                exam = new Practical(_answers, _questions, _questbody, time, NOQ);
            else
                exam = new Final(_answers, _questions, _questbody, time, NOQ);

            exam.DoExam();
            exam.ShowExam();
        }
    }

}
