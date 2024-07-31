using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class True_or_False : Question
    {
        public True_or_False(string _header, string _body, double _mark, List<Answers> _answers) : base(_header, _body, _mark, _answers)
        {
        }
        override public string ToString()
        {
            if (this is True_or_False)
            {
                string body = this.Body;
                return $"{body}";
            }
            return "";
        }
    }
}
