using System;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think about a person you are grateful for.",
        "Think about a place that brings you joy.",
        "Think about a recent positive experience you had.",
        "Think about a skill or talent you are thankful to have.",
        "Think about something in nature you appreciate."
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public GratitudeActivity() : base("Gratitude Activity",
        "This activity will help you cultivate a sense of gratitude by having you list things you are thankful for in a specific area of your life.")
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

    protected override void ExecuteActivity()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine($"\nReflect on the following prompt and list things you are grateful for:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.Write($"\nYou have {_duration} seconds to list items. Press enter when you are ready to begin.");
        Console.ReadLine();

        Console.WriteLine("\nStart listing items now (press Enter after each item):");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (DateTime.Now < endTime)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    itemCount++;
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"\nYou listed {itemCount} things you are grateful for! Cultivating gratitude is a powerful practice.");
    }
}