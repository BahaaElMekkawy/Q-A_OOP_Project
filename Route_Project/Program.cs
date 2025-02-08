using System;
using System.ComponentModel;
using System.IO;

namespace Route_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject(1, "Math");
            Exam exam =math.MakeExam();
            math.TakeExam(exam);
        }
    }
}
