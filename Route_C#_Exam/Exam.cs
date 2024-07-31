using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class Exam
    {
        // has Time of exam and Number of questions

        public double Time { get; set; }
        public int Number_of_questions { get; set; }
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; }
        public double Total_Marks = 0;
        public double _time
        {
            get
            {
                return this.Time;
            }
            set
            {
                if (double.TryParse(value.ToString(), out double time))
                {
                    this.Time = time;
                }
                else
                {
                    throw new ArgumentException("Time must be a number");
                }
            }
        }

        public Exam(double _time, int _number_of_questions, Subject _subject, List<Question> _questions)
        {
            this.Time = _time;
            this.Number_of_questions = _number_of_questions;
            this.Subject = _subject;
            this.Questions = _questions;
        }
        public void Create_True_or_False_Questions(int i)
        {
            Console.WriteLine("True or False Question : ");
            // please enter the body of the question 
            Console.WriteLine("Enter the body of the question : \n");
            string body = Console.ReadLine();
            // please enter the mark of the question 
            Console.WriteLine("Enter the mark of the question : \n");
            if (double.TryParse(Console.ReadLine(), out double mark))
            {
                // please enter the answer of the question
                Console.WriteLine("Enter the answer of the question : \n");
                string answer = Console.ReadLine();
                Answers correct = new Answers(i + 1, answer);

                True_or_False tf = new True_or_False("", body, mark, new List<Answers> { correct });

                this.Questions.Add(tf);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void Create_MCQ(int i)
        {
            Console.WriteLine("MCQ Question : ");
            // please enter the body of the question 
            Console.WriteLine("Enter the body of the question : \n");
            string body = Console.ReadLine();
            // please enter the mark of the question 
            Console.WriteLine("Enter the mark of the question : \n");
            if (double.TryParse(Console.ReadLine(), out double mark))
            {
                MCQ mcq = new MCQ();
                Console.WriteLine("Enter the choices of the question : \n");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($" Enter the choice {j + 1} : \n");
                    string choice_body = Console.ReadLine();
                    mcq.Choices.Add(choice_body);
                }
                mcq.Body = body;
                mcq.Mark = mark;
                Console.WriteLine("Enter the answer of the question : \n");
                string answer = Console.ReadLine();
                Answers correct = new Answers(i + 1, answer);
                mcq.Answers = new List<Answers> { correct };
                this.Questions.Add(mcq);
            }
        }
        public void AddQuestions(int type)
        {
            for (int i = 0; i < this.Number_of_questions; i++)
            {
                if(type == 1)
                {
                    // please choose the type of question
                    Console.WriteLine("Please choose the type of question : \n 1. True or False \n 2. MCQ \n");
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice == 1)
                        {
                            Create_True_or_False_Questions(i);
                        }
                        else if (choice == 2)
                        {
                            Create_MCQ(i);
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (type == 2)
                {
                    Create_MCQ(i);
                }
            }
            Console.Clear();
        }
    }
}
