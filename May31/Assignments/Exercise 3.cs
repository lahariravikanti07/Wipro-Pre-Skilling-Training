using System;
using System.Collections.Generic;

namespace QuizApp
{
    // Question class definition
    public class Question
    {
        public string Text { get; set; }
        public Dictionary<char, string> Options { get; set; }
        public char CorrectAnswer { get; set; }

        public Question(string text, Dictionary<char, string> options, char correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = char.ToUpper(correctAnswer);
        }

        public bool CheckAnswer(char userAnswer)
        {
            return char.ToUpper(userAnswer) == CorrectAnswer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>
            {
                new Question("What is the capital of France?",
                    new Dictionary<char, string>
                    {
                        {'A', "Paris"},
                        {'B', "Berlin"},
                        {'C', "Madrid"},
                        {'D', "Rome"}
                    }, 'A'),

                new Question("Which planet is known as the Red Planet?",
                    new Dictionary<char, string>
                    {
                        {'A', "Earth"},
                        {'B', "Mars"},
                        {'C', "Jupiter"},
                        {'D', "Saturn"}
                    }, 'B'),

                new Question("Who wrote 'Romeo and Juliet'?",
                    new Dictionary<char, string>
                    {
                        {'A', "Charles Dickens"},
                        {'B', "William Shakespeare"},
                        {'C', "Jane Austen"},
                        {'D', "Mark Twain"}
                    }, 'B'),

                new Question("Which language is primarily used for Android development?",
                    new Dictionary<char, string>
                    {
                        {'A', "C#"},
                        {'B', "Swift"},
                        {'C', "Java"},
                        {'D', "Python"}
                    }, 'C')
            };

            int score = 0;
            int questionCount = 0;

            // Shuffle the questions randomly
            Random random = new Random();
            List<Question> shuffledQuestions = new List<Question>(questions);
            for (int i = 0; i < shuffledQuestions.Count; i++)
            {
                int swapIndex = random.Next(shuffledQuestions.Count);
                var temp = shuffledQuestions[i];
                shuffledQuestions[i] = shuffledQuestions[swapIndex];
                shuffledQuestions[swapIndex] = temp;
            }

            foreach (var question in shuffledQuestions)
            {
                questionCount++;
                Console.WriteLine($"\nQuestion {questionCount}: {question.Text}");
                foreach (var option in question.Options)
                {
                    Console.WriteLine($"{option.Key}. {option.Value}");
                }

                Console.Write("Your answer (A/B/C/D): ");
                char userAnswer;
                while (!char.TryParse(Console.ReadLine().ToUpper(), out userAnswer) || !question.Options.ContainsKey(userAnswer))
                {
                    Console.Write("Invalid input. Please enter A, B, C, or D: ");
                }

                if (question.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct answer is {question.CorrectAnswer}.");
                }
            }

            Console.WriteLine($"\nYour final score is: {score}/{questions.Count}");
        }
    }
}
