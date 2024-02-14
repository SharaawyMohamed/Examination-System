using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Final : Exam
    {
        public int _fullMark = 0;
        public int _studentMark = 0;
        public Final(Answers[] answers, string[] questions, string[] questbody, int time, int numberofqustions) : base(answers, questions, questbody, time, numberofqustions)
        {
            //_answers = answers;
            //_questbody = questbody;
            //_questions = questions;
            //_time = time;
            //_numberOfQuestions = numberofqustions;
            //_studanswer = new string[numberofqustions];
        }
        public override void DoExam()
        {
            for (int i = 1; i <= _numberOfQuestions; i++)
            {
                Console.WriteLine(_questions[i]);//have header and body and answers for exam
                int id;
                if (_answers[i]._head == 1)
                {
                    do
                    {
                        Console.Write($" Enter Correct answer [ 1 for a, 2 for b and 3 for c ] : ");

                    } while (!int.TryParse(Console.ReadLine(), out id) || (id < 1 || id > 3));
                }
                else
                {
                    do
                    {
                        Console.Write(" Enter [ 1 for True , 2 for False ] : ");
                    } while (!int.TryParse(Console.ReadLine(), out id) || (id > 2 || id < 1));
                }

                Console.WriteLine("\n=======================================================\n");

                _studanswer[i] = id;

                if (id == _answers[i]._id)
                {
                    _studentMark += _answers[i]._mark;
                }
                _fullMark += _answers[i]._mark;
                Console.Clear();
            }
        }
        public override void ShowExam()
        {
            Console.WriteLine(" Correct answers and your answers\n");

            for (int i = 1; i <= _numberOfQuestions; i++)
            {
                Console.Write($" {i}) {_questbody[i]} : correct answer  [ ");
                // if statement for print correct answer
                if (_answers[i]._head == 2)
                {
                    Console.Write(_answers[i]._id == 1 ? "True ]" : "False ], ");
                    string studans = (_studanswer[i] == 1) ? "True" : "False";//student anser
                    Console.WriteLine($"and your answer[{studans}]");
                }
                else
                {
                    Console.Write(_answers[i]._id == 1 ? _answers[i]._a : (_answers[i]._id == 2 ? _answers[i]._b : _answers[i]._c) + " ], ");//print correct anser
                    string studans = (_studanswer[i] == 1) ? _answers[i]._a : _studanswer[i] == 2 ? _answers[i]._b : _answers[i]._c;//store student anser
                    Console.WriteLine($"and your answer [{studans}]");

                }
                Console.WriteLine();
            }
            Console.WriteLine($" Your grade is {_studentMark} from {_fullMark}");
        }


    }
}
