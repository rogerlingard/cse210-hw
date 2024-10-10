using System.CodeDom.Compiler;

class Prompt {
    //a list of prompts, making the prompts
    public List<string> promptList = new List<string>
    {
    "What made you smile today?",
    "What challenge did you face today?",
    "What are you grateful for today?",
    "What is one thing you learned today?",
    "How did you help someone today?",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };


    public string GeneratePrompt()
    {   
        //we want to get a random number that is within the index. We want it to write it so it matches the size of the list no matter how big it may become
        //next returns a non-negative random integer.
        Random random = new();
        int index = random.Next(promptList.Count);
        return promptList[index];
        

    }
    public void ShowPrompt()
    {

        string prompt = GeneratePrompt();
        
        Console.WriteLine(prompt);
    }
} 