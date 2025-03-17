
using System;

public class PromptGenerator {
public List<string> Prompts {get; set;}

    public PromptGenerator() {
        Prompts = new List<string> {
            "What was the best part of your day?",
            "Who was the most interesting person you interacted with today?",
            "Write about something that happened for which you are grateful today:",
            "If you had one thing you could do over today, what would it be?"
        };
    }

    //Generates random prompt from the list
    public string GenerateRandomPrompt() {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }

}