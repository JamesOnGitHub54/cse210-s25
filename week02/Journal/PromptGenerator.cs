using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        // Manual added prompts.
        _prompts.Add("What did you do today?");
        _prompts.Add("Who did you meet with today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");

        // Count how many prompts are present in the _prompts list.
        int promptSize = _prompts.Count;

        // Generate a random index number to pull the prompt from the list.
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, promptSize);

        // Return the string prompt from the random index.
        return _prompts[number];

    }
}