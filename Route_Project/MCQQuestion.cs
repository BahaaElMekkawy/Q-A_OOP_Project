using System;

namespace Route_Project
{
    public class MCQ_Question : Question
    {
        private Answer[] Answer { get; set; }

        private protected int CorrectAnswerId { get; set; }

        public MCQ_Question() : base()
        {
            Answer = new Answer[3];
            for (int i = 0; i < 3; i++)
            {
                Answer[i] = new Answer();  // Initialize each element of the array with an Answer object
            }
        }

        public MCQ_Question(string _Header, string _Body, int _Mark) : base(_Header, _Body, _Mark)
        {
            Answer = new Answer[3];
            for (int i = 0; i < 3; i++)
            {
                Answer[i] = new Answer();  // Initialize each element of the array with an Answer object
            }
        }

        public override bool CheckAnswer(int _id)
        {
            if (_id == CorrectAnswerId)
                return true;
            return false;
        }

        public void SetAnswer()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please Enter An Answer{i + 1}:  ");
                string _answer = Console.ReadLine();
                Answer[i].AnswerText = _answer;
            }
        }

        public void SetCorrectAnswer()
        {
            Console.Write("Please Enter The ID of The Correct Answer: ");
            if (int.TryParse(Console.ReadLine(), out int _correctId))
            {
                CorrectAnswerId = _correctId;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void TakeAnswerFromAdmin()
        {
            SetAnswer();
        }

        public virtual MCQ_Question TakeQuestionFromAdmin()
        {
            Console.Write("Please Enter The Question Header.  ");
            string _header = Console.ReadLine();
            Console.Write("Please Enter The Question Body.  ");
            string _body = Console.ReadLine();
            Console.Write("Please Enter The Question Mark.  ");
            int _mark = int.Parse(Console.ReadLine());
            MCQ_Question question = new MCQ_Question(_header, _body, _mark);
            return question;
        }

        public MCQ_Question MakeMcqQuestion()
        {
            MCQ_Question q1 = new MCQ_Question();
            q1 = q1.TakeQuestionFromAdmin();
            q1.TakeAnswerFromAdmin();
            q1.SetCorrectAnswer();
            Console.WriteLine("Question Saved");
            //Console.Clear();
            return q1;
        }

        public int GetAnswerFromUser()
        {
            Console.WriteLine("Please Enter Your Answer.");
            int _answer = int.Parse(Console.ReadLine());
            return _answer;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine($"{ToString()} Grade = {this.GetMark()}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Answer {i + 1} = {Answer[i].AnswerText}");
            }
        }

        public void DisplayQuestionWithAnswer()
        {
            Console.WriteLine($"The Right Answer is {Answer[CorrectAnswerId - 1]}");
        }
    }
}
