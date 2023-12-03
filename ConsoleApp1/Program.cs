using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        char[] separators = new char[] { ' ', ',', '.', '-', '­' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        Console.WriteLine("Слово\t\tКоличество");
        Console.WriteLine("------------------------");
        foreach (var pair in wordCounts.OrderBy(pair => pair.Key))
        {
            Console.WriteLine($"{pair.Key,-15}{pair.Value}");
        }
    }
}
