using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answers
    {
        internal int _id { get; set; }
        internal string _a { get; set; }
        internal string _b { get; set; }
        internal string _c { get; set; }
        internal int _mark { get; set; }// to calculate grade
        internal int _head { get; set; }
        internal Answers(int id, string a, string b, string c, int mark, int head)
        {
            _id = id;
            _a = a;
            _b = b;
            _c = c;
            _mark = mark;
            _head = head;
        }
    }
}
