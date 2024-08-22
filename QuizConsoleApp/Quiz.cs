using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApp
{
    internal class Quiz
    {
        private int _score = 0;
        private Question[] _questions;

        public Quiz(Question[] questions)
        {
            _questions = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("                                                            ");
            Console.WriteLine("                           Quiz APP                         ");
            Console.WriteLine("                                                            ");
            Console.WriteLine("============================================================\n\n");

            foreach (Question question in _questions)
            {
                int userAnswer;

                question.DisplayQuestion();
                userAnswer = GetUserAnswer(question.Answers.Length);

                if (question.IsAnswerCorrect(userAnswer))
                {
                    ++_score;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t Answer correct");
                    Console.ResetColor();
                }
                else
                {
                    string correctAnswer = question.Answers[question.CorrectAnswerIndex];

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"\t Answer incorrect: the correct answer is: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{question.CorrectAnswerIndex + 1}. {correctAnswer}");
                    Console.ResetColor();

                }
            }

            ShowQuizScore(_questions.Length);
        }

        private int GetUserAnswer(int maxOption)
        {
            Console.Write("Choose your answer: ");
            string input = Console.ReadLine();
            int userAnswer;

            while (!int.TryParse(input, out userAnswer) || userAnswer < 1 || userAnswer > maxOption)
            {
                Console.Write($"The answer must be an integer number between 1 and {maxOption}: ");
                input = Console.ReadLine();
            }

            return --userAnswer;
        }

        private void ShowQuizScore(int maxScore)
        {
            Console.WriteLine("\n");
            Console.WriteLine("============================================================");
            Console.WriteLine("                                                            ");
            Console.WriteLine($" Quiz completed: your score is {_score} out of {maxScore}. ");
            Console.WriteLine("                                                            ");
            Console.WriteLine("============================================================");
        }
    }
}
