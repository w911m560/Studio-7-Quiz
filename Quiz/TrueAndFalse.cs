using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNS
{
    public class TrueAndFalse : Question
    {
        private bool CorrectAnswer { get; set; }

        public TrueAndFalse(int pointValue, string toAsk, bool correctAnswer) : base(pointValue, toAsk)
        {
            pointValue = 1;
            CorrectAnswer = correctAnswer;
        }

        public override void PromptPossibleAnswers()
        {
            Console.WriteLine("True or False");
        }

        public bool IsCorrect(bool userAnswer)
        {
            if (userAnswer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetAnswer()
        {
            Console.WriteLine("Type \"t\" for true and \"f\" for false");
            string userAnswer = Console.ReadLine();
            if (userAnswer.IndexOf('t') >= 0)
            {
                if (IsCorrect(true))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (IsCorrect(false))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            
        }
    }
}
