using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Scripture
{
    public string Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public static List<Scripture> LoadFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
            return scriptures;
        }

        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                scriptures.Add(new Scripture(parts[0], parts[1]));
            }
        }

        return scriptures;
    }

    public string GetDisplayText()
    {
        return $"{Reference}: {string.Join(" ", Words.Select(w => w.GetDisplayText()))}";
    }

    public int HiddenPercentage()
    {
        int hiddenCount = Words.Count(w => w.IsHidden);
        return (hiddenCount * 100) / Words.Count;
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
