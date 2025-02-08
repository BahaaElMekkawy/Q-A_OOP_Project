using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Project
{
    public class Answer
    {
        
            public int AnswerId { get; set; }

            public string AnswerText { get; set; }

            public Answer()
            {
                //Default Constructor
            }
            public Answer(int _id, string _Answer)
            {
                this.AnswerId = _id;
                this.AnswerText = _Answer;
            }
            public string GetAnswerText()
            {
                return AnswerText;
            }
            public int GetAnswerID()
            {
                return AnswerId;
            }
            public override string ToString()
            {
                return AnswerText;
            }

        }
    }

