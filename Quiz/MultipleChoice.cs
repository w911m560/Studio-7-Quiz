using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNS
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }
        public MultipleChoice(int point, string toAsk, int correctAnswer, List<string> possibleAnswers) : base(point, toAsk)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswer = correctAnswer;
            PointValue = 1;
        }

        public override void PromptPossibleAnswers()
        {
            foreach (string answer in PossibleAnswers)
            {
                Console.WriteLine(answer);
            }
        }

        public bool IsCorrect(int userAnswer)
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
            Console.WriteLine("Enter the number corresponding to your answer: ");
            {
                string userAnswer = Console.ReadLine();
                int result = int.Parse(userAnswer);
                if (IsCorrect(result))
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
