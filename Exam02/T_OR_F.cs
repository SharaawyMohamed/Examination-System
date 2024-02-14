using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class T_OR_F : Question
    {
        internal T_OR_F(string header, string body, int mark, int num):base(header,body,mark,num)
        {
           
        }

        public override string ToString()
        {
            return $"{_header}  Mark({_mark})\n {_num}) {_body}\n" +
                $" a) True                     b) False\n";
        }
    }
}