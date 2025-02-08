using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Route_Project
{
    public class TrueFalseQuestion : Question
    {
        private Answer Answer;
        private int CorrectAnswerId { get; set; }

        public TrueFalseQuestion(string Header, string Body, int Mark) : base(Header, Body, Mark)
        {
            this.Answer = new Answer();
        }

        public TrueFalseQuestion() : base()
        {
           
        }

        private void SetAnswer(string _Answer, int _ID)
        {
            Answer.AnswerText = _Answer;   
            Answer.AnswerId = _ID;
        }
        public void TakeAnswerFromAdmin() {
            Console.WriteLine("Please Enter The Right Answer.(1.True\t2.False)");
            int _asnwer  = int.Parse(Console.ReadLine());
            if (_asnwer == 1)
            {
                SetAnswer("True", 1);
                Console.WriteLine("Answer Saved..");

            }
            else if (_asnwer == 2){
                    SetAnswer("False", 2);
                Console.WriteLine("Answer Saved..");
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }
        }

        public int GetAnswerFromUser() {
            Console.WriteLine("Please Enter Your Answer. 1.True === 2.False");
            int _answer = int.Parse(Console.ReadLine());
            return _answer;
        }

        public override bool CheckAnswer(int _id)
        {
            if (_id == this.Answer.AnswerId)
                return true;
            return false;
        }

        public virtual TrueFalseQuestion TakeQuestionFromAdmin()
        {
            Console.WriteLine("Please Enter The Question Header.");
            string _header = Console.ReadLine();
            Console.WriteLine("Please Enter The Question Body.");
            string _body = Console.ReadLine();
            Console.WriteLine("Please Enter The Question Mark.");
            int _mark = int.Parse(Console.ReadLine());
            TrueFalseQuestion question = new TrueFalseQuestion(_header, _body, _mark);
            return question;
        }

        public TrueFalseQuestion MakeTrueFalseQuestion() {
            TrueFalseQuestion q1 = new TrueFalseQuestion();
            q1 = q1.TakeQuestionFromAdmin();
            q1.TakeAnswerFromAdmin();
            Console.WriteLine("Question Saved");
            //Console.Clear();
            return q1;
        }

        public override void Display()
        {
            Console.WriteLine($"{ToString()} Grade = {this.GetMark()}");
            Console.WriteLine($"1.True\t 2. False"); 
        }
    }
}

