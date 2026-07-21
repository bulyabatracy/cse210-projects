using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Track used prompts and questions to avoid repetition
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    private string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        List<string> available = _prompts.Except(_usedPrompts).ToList();
        string prompt = available[_random.Next(available.Count)];
        _usedPrompts.Add(prompt);
        return prompt;
    }

    private string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        List<string> available = _questions.Except(_usedQuestions).ToList();
        string question = available[_random.Next(available.Count)];
        _usedQuestions.Add(question);
        return question;
    }

    protected override void ExecuteActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} ");
            ShowSpinner(10);
        }
    }
}