using System;


namespace Route_Project
{
    internal class Subject
    {
        private int ID { set; get; }
        private string Name { set; get; }
        //private FinalExam finalexam { set; get; }
        //private FinalExam finalexam { set; get; }
        public Subject()
        {
        }
        public Subject(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
        public FinalExam MakeFinalExam()
        {
            FinalExam _finalexam = new FinalExam();
            _finalexam = _finalexam.MakeFinalExam(this);
            _finalexam.TakeQuestionFromAdmin();
            Console.WriteLine("Final Exam Has Been Saved.");
            return _finalexam;
        }
        public void TakeFinalExam(FinalExam _finalExam)
        {
            Console.Clear();
            Console.WriteLine($"You Are Now Taking Final Exam For {Name}");
            _finalExam.TakeAnswersFromUser();
            GetUserGrade(_finalExam);
        }
        public PracticalExam MakePracticalExam()
        {
            PracticalExam _practicalexam = new PracticalExam();
            _practicalexam = _practicalexam.MakePracticalExam(this);
            _practicalexam.TakeQuestionFromAdmin();
            Console.WriteLine("Practical Exam Has Been Saved.");
            return _practicalexam;
        }
        public void TakePracticalExam(PracticalExam _prcaticalexam)
        {
            Console.Clear();
            Console.WriteLine($"You Are Now Taking Practical Exam For {Name}");
            _prcaticalexam.TakeAnswersFromUser();
        }

        public void TakeExam(Exam exam)
        {
            Console.Clear();
            Console.WriteLine("Please Choose Which Exam U Want To Start With [1..Final , 2..Practical]");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 && exam is FinalExam _finalexam)
            {
                this.TakeFinalExam(_finalexam);
                GetUserGrade(_finalexam);

            }
            else if (choice == 2 && exam is PracticalExam _practicalexam)
            {
                this.TakePracticalExam(_practicalexam);
                Console.WriteLine("Exam Finished");
                _practicalexam.Display();
                _practicalexam.DisplayQuestionWithAnswer();
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public Exam MakeExam()
        {
            Console.Clear();
            Console.WriteLine("Please Choose Which Exam U Want To Make [1..Final , 2..Practical]");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"You Are Now Making Final Exam for {Name}");
                FinalExam _finalExam = new FinalExam();
                _finalExam = this.MakeFinalExam();
                Console.WriteLine($"Final Exam For {Name}Has Benn Saved Sucessfuly.");
                return _finalExam;
            }
            else if (choice == 2)
            {
                Console.WriteLine($"You Are Now Taking Prcatical Exam for {Name}");
                PracticalExam _practicalExam = new PracticalExam();
                _practicalExam = this.MakePracticalExam();
                Console.WriteLine($"Practical Exam For {Name}Has Benn Saved Sucessfuly.");
                return _practicalExam;
            }
            else
            {
                Console.WriteLine("Invalid Input.");
                return null;
            }
        }
        public void GetUserGrade(FinalExam exam)
        {
            Console.WriteLine($"Your Grade is = {exam.GetUserGrade()}");
        }
    }
}
