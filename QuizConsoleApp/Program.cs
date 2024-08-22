using System.Collections.Generic;
using System.Numerics;

namespace QuizConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question[] questions = {
                new Question("What's capital of DR", new string[]{"San Juan", "San pedro", "Santo Domingo", "Santiago"}, 2),
                new Question("Who painted the \"Mona Lisa\"", new string[]{"Leonardo da Vinci", "Michelangelo", "Raphael", "Caravaggio"}, 0),
                new Question("Which planet is known as the \"Red Planet\"", new string[]{"Venus", "Mars", "Jupiter", "Saturn"}, 1),
                new Question("Who discovered electricity", new string[]{ "Isaac Newton", "Nikola Tesla", "Michael Faraday", "Benjamin Franklin"}, 3),
                new Question("What is the world's largest ocean", new string[]{ "Atlantic Ocean", "Indian Ocean", "Pacific Ocean", "Southern Ocean"}, 2),
                new Question("Who came up with the theory of relativity", new string[]{ "Edgar Allan Poe", "Albert Einstein", "Galileo Galilei", "Louis Pasteur"}, 1)
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
        }
    }
}
