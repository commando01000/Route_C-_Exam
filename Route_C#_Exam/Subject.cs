using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_C__Exam
{
    public class Subject
    {
        // subject has subject id and name and exam of subject

        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public string _name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.Name = value;
            }
        }

        public Subject(int _id, string _name)
        {
            this.Id = _id;
            this.Name = _name;
        }

        public void CreateExam()
        {
            // ask the user if he wants the exam to be practical or final
            Console.WriteLine("Do you want the exam to be final or practical ? (1 for final and 2 for practical)");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {
                    // ask the user for the time and number of questions
                    Console.WriteLine("Enter the time of the exam : ");
                    if (double.TryParse(Console.ReadLine(), out double time))
                    {
                        Console.WriteLine("Enter the number of questions : ");
                        if (int.TryParse(Console.ReadLine(), out int number_of_questions))
                        {
                            this.Exam = new Exam(time, number_of_questions, this, new List<Question>());
                            this.Exam.AddQuestions(choice);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (choice == 2)
                {
                    // ask the user for the time and number of questions
                    Console.WriteLine("Enter the time of the exam : ");
                      if (double.TryParse(Console.ReadLine(), out double time))
                    {
                        Console.WriteLine("Enter the number of questions : ");
                        if (int.TryParse(Console.ReadLine(), out int number_of_questions))
                        {
                            this.Exam = new Exam(time, number_of_questions, this, new List<Question>());
                            this.Exam.AddQuestions(choice);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
        public void AttemptExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            for (int i = 0; i < this.Exam.Questions.Count; i++)
            {
                if (this.Exam.Questions[i] is MCQ)
                {
                    Console.WriteLine(this.Exam.Questions[i]);
                    Console.WriteLine("Please type the answer of the question : \n");
                    string answer = Console.ReadLine();
                    if (answer == this.Exam.Questions[i].Answers[0].Text)
                    {
                        this.Exam.Total_Marks += this.Exam.Questions[i].Mark;
                    }
                }
                else if (this.Exam.Questions[i] is True_or_False)
                {
                    Console.WriteLine(this.Exam.Questions[i]);
                    Console.WriteLine("Please type the answer of the question : \n");
                    string answer = Console.ReadLine();
                    if (answer == this.Exam.Questions[i].Answers[0].Text)
                    {
                        this.Exam.Total_Marks += this.Exam.Questions[i].Mark;
                    }
                }
            }
            Console.WriteLine($"Your total marks are : {this.Exam.Total_Marks}");
            Console.WriteLine($"Your time is : {stopwatch.Elapsed.TotalMinutes} minutes");
        }
    }
}
