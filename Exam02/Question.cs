using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam02
{

    internal abstract class Question
    {
        protected string _header { get; set; }
        protected string _body { get; set; }
        protected int _mark { get; set; }

        protected int _num { get; set; }// question's number
        protected string _a { get; set; }
        protected string _b { get; set; }
        internal Question(string header, string body, int mark, int num)
        {
            _header = header;
            _body = body;
            _mark = mark;
            _num = num;
            // I'm not set data for answers becasue type of questions are deferent
        }
    }
}
