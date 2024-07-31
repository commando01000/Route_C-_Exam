using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public List<Answers> Answers;
        
        public string _header
        {
            get => this.Header;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Header cannot be null or empty");
                }
                _header = value;
            }
        }

        public string _body
        {
            get => this.Body;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Body cannot be null or empty");
                }
                _body = value;
            }
        }

        public double _mark
        {
            get => this.Mark;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Mark cannot be negative");
                }
               _mark = value;
            }
        }
        public Question(string _header, string _body, double _mark, List<Answers> _answers)
        {
            this.Header = _header;
            this.Body = _body;
            this.Mark = _mark;
            this.Answers = new List<Answers>();
            this.Answers = _answers;
        }
        public Question(string _header, string _body, double _mark)
        {
            this.Header = _header;
            this.Body = _body;
            this.Mark = _mark;
        }
        public Question()
        {
            
        }
    }
}
