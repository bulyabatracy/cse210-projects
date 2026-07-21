using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
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
        
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
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

        Console.WriteLine($"\nYou listed {itemCount} items!");
    }
}