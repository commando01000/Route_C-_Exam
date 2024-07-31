using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class MCQ : Question
    {
        // list of choices
        public List<string> Choices { get; set; } = new List<string>();

        // has header and body and mark

        public MCQ(string _header, string _body, double _mark) : base(_header, _body, _mark)
        {
        }
        public MCQ() : base()
        {
            Choices = new List<string>();
        }
        override public string ToString()
        {
            if (this is MCQ)
            {
                string body = this.Body;
                string choices = "";
                for (int i = 0; i < this.Choices.Count; i++)
                {
                    choices += $"{i + 1}. {this.Choices[i]}\n";
                }
                return $"{body}\n{choices}";
            }
            return "";
        }
    }
}
