using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Exam
    {
        public int _time { get; set; }
        protected int _numberOfQuestions { get; set; }

        protected Answers[] _answers;
        protected string[] _questions;
        protected string[] _questbody;
        protected int[] _studanswer;
        public Exam(Answers[] answers, string[] questions, string[] questbody, int time, int numberofqustions)
        {
            _answers = answers;
            _questbody = questbody;
            _questions = questions;
            _time = time;
            _numberOfQuestions = numberofqustions;
            _studanswer = new int[numberofqustions+1];
        }
        public abstract void DoExam();// { }
        public abstract void ShowExam();//{ }

    }
}
