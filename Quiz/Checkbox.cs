using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNS
{
    public class Checkbox : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private List<int> CorrectAnswers { get; set; }
        public Checkbox(int point, string toAsk, List<int> correctAnswers, List<string> possibleAnswers) : base(point, toAsk)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
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
            if (CorrectAnswers.Contains(userAnswer))
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
            Console.WriteLine("Type the number corresponding to each correct answer, (ex: 1,2,4 or 1 2 4): ");
            {
                string userAnswer = Console.ReadLine();
                int points = 0;
                foreach (char i in userAnswer)
                {
                    int result = (int)Char.GetNumericValue(i);
                    if (IsCorrect(result))
                    {
                        points++;
                        userAnswer.Replace(i, ' ');
                    }

                }
                return points;
            }
        }

    }
}
