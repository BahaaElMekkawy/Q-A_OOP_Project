using System;
using System.Security.Cryptography.X509Certificates;


namespace Route_Project
{
    internal abstract class Exam
    {
        private protected Subject ExamSubject { set; get; }

        private int TimeOfExam { get; set; }
        private int NoOfQuestions { get; set; }


        public Exam() { }

        public Exam(int _timeofexam, int _noofquestions)
        {
            TimeOfExam = _timeofexam;
            NoOfQuestions = _noofquestions;
        }

        public int GetNumberOfQuestions(){
            return NoOfQuestions;
        }

        //public abstract void Display();



    }
}
