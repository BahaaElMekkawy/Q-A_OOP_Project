using System;

namespace Route_Project
{
    //The main Question Class Which is an Abstract Class That The Question Types Will Later Inherited From it.
    //It Will Contain The Properties and The Methods Decleration That The Child Classes Will Implement After Inhertiance.
    public abstract class Question
    {
        private string Header { get; set; }
        private string QuestionBody { get; set; }
        private int Mark { get; set; }

        // Constructor to Take The Question and No Default Constructor Will Be Created As There is No Need For it As There is No Empty Question
        public Question(string Header, string Body, int Mark)
        {
            this.Header = Header;
            this.QuestionBody = Body;
            this.Mark = Mark;
        }

        public Question()
        {

        }
        public int GetMark()
        {
            return Mark;
        }

        public override string ToString()
        {
            return $"{QuestionBody}";
        }
        public virtual void Display()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract bool CheckAnswer(int _id);

    }

}
