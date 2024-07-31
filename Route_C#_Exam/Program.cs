namespace Route_C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Math = new Subject(1, "Math");

            Math.CreateExam();

            Math.AttemptExam();
        }
    }
}
