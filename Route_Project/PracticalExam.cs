using System;
using System.Diagnostics;

namespace Route_Project
{
    internal class PracticalExam : Exam
    {

        private MCQ_Question[] McqQuestion { get; set; }

        public PracticalExam() { }

        public PracticalExam(int _timeofexam, int _noofquestions, Subject _subject)
            : base(_timeofexam, _noofquestions)
        {
            ExamSubject = _subject;
        }

        public PracticalExam MakePracticalExam(Subject _subject)
        {
            Console.Write("Please Enter The time of The Exam.");
            int _time = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter The No of Question in The Exam.");
            int _numberofquestions = int.Parse(Console.ReadLine());
            PracticalExam exam = new PracticalExam(_time, _numberofquestions, _subject);
            return exam;
        }

        public void TakeQuestionFromAdmin()
        {
            McqQuestion = new MCQ_Question[GetNumberOfQuestions()];
            for (int i = 0; i < GetNumberOfQuestions(); i++)
            {
                McqQuestion[i] = new MCQ_Question();
                McqQuestion[i] = McqQuestion[i].MakeMcqQuestion();
            }
        }
        public void TakeAnswersFromUser()
        {
            if (McqQuestion is null)
            {
                Console.WriteLine("No questions have been added yet!");
                return;
            }
            for (int i = 0; i < McqQuestion.Length; i++)
            {
                McqQuestion[i].DisplayQuestion();
                int ans = McqQuestion[i].GetAnswerFromUser();
                bool answer = McqQuestion[i].CheckAnswer(ans);
            }
        }
        public void Display()
        {
            for (int i = 0; i < McqQuestion.Length; i++)
            {
                McqQuestion[i].DisplayQuestion();
            }
        }
        public void DisplayQuestionWithAnswer()
        {
            for (int i = 0; i < McqQuestion.Length; i++)
            {
                McqQuestion[i].ToString();
                McqQuestion[i].DisplayQuestionWithAnswer();
            }

        }


    }
}
