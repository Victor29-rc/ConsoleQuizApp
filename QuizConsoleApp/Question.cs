using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsoleApp
{
    public class Question
    {
        private string _question;
        private string[] _answers;
        private int _correctAnswerIndex;

        public string[] Answers { get => _answers; }
        public int CorrectAnswerIndex { get => _correctAnswerIndex; }

        public Question(string question, string[] answers, int correctAnswerIndex)
        {
            _question = question;
            _answers = answers;
            _correctAnswerIndex = correctAnswerIndex;
        }

        public void DisplayQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================================");
            Console.WriteLine("                     Question                        ");
            Console.WriteLine("=====================================================");

            Console.ResetColor();

            Console.WriteLine($" {_question}?");

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < _answers.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_answers[i]}.");
            }
            Console.ResetColor();
        }

        public bool IsAnswerCorrect(int answerIndex)
        {
            return answerIndex == _correctAnswerIndex;
        }
    }
}
