using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Route_Project
{
    internal class FinalExam : Exam
    {
        private int Grade { get; set; }
        private MCQ_Question[] McqQuestion { get; set; }
        private TrueFalseQuestion[] TrueFalseQuestion { get; set; }

        public FinalExam() { }

        public FinalExam(int _timeofexam, int _noofquestions, Subject _subject)
            : base(_timeofexam, _noofquestions)
        {
            Grade = 0;
            ExamSubject = _subject;
        }

        public FinalExam MakeFinalExam(Subject _subject)
        {
            Console.Write("Please Enter The time of The Exam.");
            int _time = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The No of Question in The Exam.");
            int _numberofquestions = int.Parse(Console.ReadLine());
            FinalExam exam = new FinalExam(_time, _numberofquestions, _subject);
            return exam;
        }

        public void TakeQuestionFromAdmin()
        {
            Console.Write("How Many MCQ Questions..?");
            int _mcq = int.Parse(Console.ReadLine());
            Console.Write("How Many True or False Questions..?");
            int _trueorfalase = int.Parse(Console.ReadLine());
            McqQuestion = new MCQ_Question[_mcq];
            TrueFalseQuestion = new TrueFalseQuestion[_trueorfalase];
            for (int i = 0; i < _mcq; i++)
            {
                McqQuestion[i] = new MCQ_Question();
                McqQuestion[i] = McqQuestion[i].MakeMcqQuestion();
            }
            for (int i = 0; i < _trueorfalase; i++)
            {
                TrueFalseQuestion[i] = new TrueFalseQuestion();
                TrueFalseQuestion[i] = TrueFalseQuestion[i].MakeTrueFalseQuestion();
            }
        }

        public void TakeAnswersFromUser()
        {
            if (McqQuestion is null || TrueFalseQuestion is null)
            {
                Console.WriteLine("No questions have been added yet!");
                return;
            }
            for (int i = 0; i < McqQuestion.Length; i++)
            {
                McqQuestion[i].Display();
                int ans = McqQuestion[i].GetAnswerFromUser();
                bool answer = McqQuestion[i].CheckAnswer(ans);
                if (answer)
                    Grade += McqQuestion[i].GetMark();

            }
            for (int i = 0; i < TrueFalseQuestion.Length; i++)
            {
                TrueFalseQuestion[i].Display();
                int ans = TrueFalseQuestion[i].GetAnswerFromUser();
                bool answer = TrueFalseQuestion[i].CheckAnswer(ans);
                if (answer)
                    Grade += TrueFalseQuestion[i].GetMark();
            }
        }

        public int GetUserGrade (){ 
            return Grade;
        }
        public void Display()
        {
            for (int i = 0; i < McqQuestion.Length; i++)
            {
                McqQuestion[i].Display();
            }
            for (int i = 0; i < TrueFalseQuestion.Length; i++)
            {
                TrueFalseQuestion[i].Display();
            }
        }




    }
}
