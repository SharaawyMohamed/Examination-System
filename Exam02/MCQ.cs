using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {
        private string _c { get; set; }
        internal MCQ(string header, string body, int mark, int num, string a, string b, string c):base(header,body,mark,num)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override string ToString()
        {
            return $"{_header}  Mark({_mark})\n {_num}) {_body}\n" +
                $" a) {_a}              b) {_b}             c) {_c}\n";
        }
    }
}
