using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNS
{
    public class Quiz
    {
        public List<Question> GeneratedQuiz { get; set; }
        public int Score { get; set; }
        public int Total { get; set; }

        public Quiz(List<Question> questions)
        {
            GeneratedQuiz = questions;
            Score = 0;
            Total = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Total += questions[i].PointValue;
            }
        }

        public void AddQuestion(Question newQuestion)
        {
            GeneratedQuiz.Add(newQuestion);
            Total += newQuestion.PointValue;
        }

        public void TakeQuiz()
        {
            foreach (Question question in GeneratedQuiz)
            {
                question.DisplayQuestion();
                question.PromptPossibleAnswers();
                int point = question.GetAnswer();
                UpdateScore(point);
            }
        }

        public void UpdateScore(int point)
        {
            Score += point;
        }
        
        public void GradeQuiz()
        {
            Console.WriteLine("Score: " + Score + "/" + Total);
        }
    }
}
