using System;
using System.Collections.Generic;

namespace MyMonkeyApp;

/// <summary>
/// Entry point for the Monkey Console Application.
/// </summary>
public class Program
{
    private static readonly Dictionary<string, int> accessCounts = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Main method to run the application.
    /// </summary>
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Monkey Console Application!\n");
        bool exitRequested = false;
        while (!exitRequested)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) List all monkeys");
            Console.WriteLine("2) Get details for a specific monkey by name");
            Console.WriteLine("3) Get a random monkey");
            Console.WriteLine("4) Exit");
            Console.Write("Select an option (1-4): ");
            var userInput = Console.ReadLine();
            Console.WriteLine();
            switch (userInput)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    exitRequested = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }

    private static void ListAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("Available Monkeys:");
        foreach (var monkey in monkeys)
        {
            var count = accessCounts.TryGetValue(monkey.Name, out var c) ? c : 0;
            Console.WriteLine($"- {monkey.Name} (Accessed {count} times)");
        }
        Console.WriteLine();
    }

    private static void GetMonkeyByName()
    {
        Console.Write("Enter monkey name: ");
        var name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.\n");
            return;
        }
        var monkey = MonkeyHelper.GetMonkeyByName(name);
        if (monkey == null)
        {
            Console.WriteLine($"Monkey '{name}' not found.\n");
            return;
        }
        IncrementAccessCount(monkey.Name);
        DisplayMonkeyDetails(monkey);
    }

    private static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        IncrementAccessCount(monkey.Name);
        DisplayMonkeyDetails(monkey);
    }

    private static void IncrementAccessCount(string name)
    {
        if (accessCounts.ContainsKey(name))
            accessCounts[name]++;
        else
            accessCounts[name] = 1;
    }

    private static void DisplayMonkeyDetails(Monkey monkey)
    {
        Console.WriteLine(MonkeyAsciiArt());
        Console.WriteLine($"Name: {monkey.Name}");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population}");
        if (!string.IsNullOrWhiteSpace(monkey.Details))
            Console.WriteLine($"Details: {monkey.Details}");
        Console.WriteLine($"Accessed: {accessCounts[monkey.Name]} times\n");
    }

    private static string MonkeyAsciiArt() =>
        "  .--.  " + Environment.NewLine +
        " (o  o) " + Environment.NewLine +
        " | :: | " + Environment.NewLine +
        "  '--'  ";
}
