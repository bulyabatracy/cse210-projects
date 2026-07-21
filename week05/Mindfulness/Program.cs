/*  
 * SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS:
 * 
 * 1. Added a Gratitude Activity:
 *    - This new activity guides the user to think about and list things they are grateful for.
 *    - It helps shift focus to positive aspects of life, promoting a sense of well-being.
 *    - The activity provides a prompt (e.g., "Think about a person you are grateful for") and then asks
 *      the user to list as many things as they can related to that prompt within the specified duration.
 * 
 * 2. Persistent Activity Log:
 *    - The program now keeps a log of how many times each activity has been performed during the session.
 *    - This log is displayed in the main menu, giving the user feedback on their mindfulness practice.
 *    - This encourages users to try different activities and track their engagement.
 * 
 * 3. No duplicate prompts/questions in Reflection and Listing activities:
 *    - The program tracks which prompts and questions have been used in the current session
 *      and ensures all are used before repeating any.
 */

using System;

class Program
{
    // Session log to track activity counts
    private static int s_breathingCount = 0;
    private static int s_reflectionCount = 0;
    private static int s_listingCount = 0;
    private static int s_gratitudeCount = 0;

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Gratitude Activity (NEW!)");
            Console.WriteLine("  5. Quit");
            Console.WriteLine("\n--- Session Log ---");
            Console.WriteLine($"Breathing: {s_breathingCount} times");
            Console.WriteLine($"Reflection: {s_reflectionCount} times");
            Console.WriteLine($"Listing: {s_listingCount} times");
            Console.WriteLine($"Gratitude: {s_gratitudeCount} times");
            Console.WriteLine("-------------------");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity currentActivity = null;

            switch (choice)
            {
                case "1":
                    currentActivity = new BreathingActivity();
                    s_breathingCount++;
                    break;
                case "2":
                    currentActivity = new ReflectionActivity();
                    s_reflectionCount++;
                    break;
                case "3":
                    currentActivity = new ListingActivity();
                    s_listingCount++;
                    break;
                case "4":
                    currentActivity = new GratitudeActivity();
                    s_gratitudeCount++;
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Thank you for practicing mindfulness. Goodbye!");
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    Thread.Sleep(1500);
                    continue;
            }

            if (currentActivity != null)
            {
                currentActivity.StartActivity();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}