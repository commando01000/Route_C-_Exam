using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class Answers
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string _text
        {
            get => this.Text;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Question's answer cannot be null or empty");
                }
                Text = value;
            }
        }

        public Answers(int _id, string _text)
        {
            this.Id = _id;
            this.Text = _text;
        }
    }
}
