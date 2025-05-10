using System;
class ChatBot
{
    // Greeting Response
    public string Respond(string message)
    {
        return "Hi ! You said: " + message;
    }

    // Question to response with formality
    public string Respond(string Question, bool isFormal)
    {
        return isFormal ? "Formal reply to: " + question : "Casual reply to: " + question;
    }

    // Number response
    public string Respond(int number)
    {
        return "You gave the number: " + number;
    }
}

class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();

        Console.WriteLine(bot.Respond("Hello"));
        Console.WriteLine(bot.Respond("What is your name?", false));
        Console.WriteLine(bot.Respond("Could ypu assit me?", true));
        Console.WriteLine(bot.Respond(100));
    }
}