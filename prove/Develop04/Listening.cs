class ListeningActivity : Activity {

    public ListeningActivity() : base("Listening\n", "This activity will help you reflect on the good things in your life by having you list as many things as you can  in a certain area\n")
    { }

    public void ListeningExercise(){
        Console.Clear();
        int durationTime = DisplayStart();
        
        SetTimer(durationTime);
        int elapsed = 0;



        Console.WriteLine("List as many responses as you can to the following prompt:");

        SettingPromptList();
        List<string> prompt = GetPromptString();
        string randomPrompt = GetRandomPrompt(prompt);

        Console.WriteLine($"\n--- {randomPrompt} ---\n");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        int counter = 0;
        while(elapsed < GetTimer()){

            Console.Write("> ");
            Console.ReadLine();
            counter ++;

            elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
            if (elapsed >= GetTimer()) break;
        }
        Console.WriteLine($"You listed {counter} items!");
        LoaderPart(5);
        Console.WriteLine();

        DisplayEnd();

    }


    public void SettingPromptList() {
        List<string> prompts = new()
        {
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        SetPromptString(prompts);
    }


}