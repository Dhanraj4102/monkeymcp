using System;
using System.Collections.Generic;

namespace MyMonkeyApp;

/// <summary>
/// Provides helper methods for managing monkey data.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Baboon", Location = "Africa & Asia", Population = 10000 },
        new Monkey { Name = "Capuchin Monkey", Location = "Central & South America", Population = 23000 },
        new Monkey { Name = "Blue Monkey", Location = "Central and East Africa", Population = 12000 },
        new Monkey { Name = "Squirrel Monkey", Location = "Central & South America", Population = 11000 },
        new Monkey { Name = "Golden Lion Tamarin", Location = "Brazil", Population = 19000 },
        new Monkey { Name = "Howler Monkey", Location = "South America", Population = 8000 },
        new Monkey { Name = "Japanese Macaque", Location = "Japan", Population = 1000 },
        new Monkey { Name = "Mandrill", Location = "Southern Cameroon, Gabon, and Congo", Population = 17000 },
        new Monkey { Name = "Proboscis Monkey", Location = "Borneo", Population = 15000 },
        new Monkey { Name = "Sebastian", Location = "Seattle", Population = 1 },
        new Monkey { Name = "Henry", Location = "Phoenix", Population = 1 },
        new Monkey { Name = "Red-shanked douc", Location = "Vietnam", Population = 1300 },
        new Monkey { Name = "Mooch", Location = "Seattle", Population = 1 }
    };

    /// <summary>
    /// Gets the list of all monkeys.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys()
        => monkeys.AsReadOnly();

    /// <summary>
    /// Gets a random monkey from the collection.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var random = new Random();
        return monkeys[random.Next(monkeys.Count)];
    }

    /// <summary>
    /// Gets a monkey by its name.
    /// </summary>
    /// <param name="name">The name of the monkey.</param>
    /// <returns>The monkey with the specified name, or null if not found.</returns>
    public static Monkey? GetMonkeyByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        foreach (var monkey in monkeys)
        {
            if (string.Equals(monkey.Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return monkey;
            }
        }

        return null;
    }
}
