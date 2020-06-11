using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNS
{
    public abstract class Question
    {
        private string ToAsk { get; set; }
        public int PointValue { get; set; } 
    
        public Question(int point, string toAsk)
        {
            PointValue = point;
            ToAsk = toAsk;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(ToAsk);
        }

        public abstract void PromptPossibleAnswers();

        public abstract int GetAnswer();
    }
}
