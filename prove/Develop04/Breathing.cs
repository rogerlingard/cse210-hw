class BreathingActivity : Activity {
    private int _breathingIn;
    private int _breathingOut;

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }
    public void SetBreathingTimer(int inTimer, int outTimer){
        _breathingIn = inTimer;
        _breathingOut = outTimer;   

    }
    public int GetBreathingIn() {
        return _breathingIn;
    }

    public int GetBreathingOut(){
        return _breathingOut;

    }
    public override int DisplayStart(){
        string name = GetName();
        string description = GetDescription();
        Console.WriteLine($"Welcome to the {name} Activity\n");
        Console.WriteLine(description);

        Console.WriteLine("\nHow long, in seconds, would you like to do this for? ");

        int durationTime = int.Parse(Console.ReadLine()); 

        // extra credit of adding user control over how long they want to breath in or out.
        SetTimer(durationTime);
        Console.WriteLine("\nHow long would you like to breath in for?(recommended 4 seconds) ");
        int breathingIn = int.Parse(Console.ReadLine());

        Console.WriteLine("\nHow long would you like to breath in for?(recommended 8 seconds) ");
        int breathingOut = int.Parse(Console.ReadLine());

        SetBreathingTimer(breathingIn, breathingOut);

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoaderPart(5);

        return durationTime;
    }
    public void BreathingExersise() {
        Console.Clear();
        int durationTime = DisplayStart();



        int elapsed = 0;
        
        while (elapsed < GetTimer())
        {
            Console.Write("Breathe in... ");
            CountDown(GetBreathingIn());
            elapsed += GetBreathingIn();
            Console.WriteLine();


            if (elapsed >= durationTime) break;
        
            Console.Write("Breath out... ");
            CountDown(GetBreathingOut());
            elapsed += GetBreathingOut();
            Console.WriteLine("\n");
        }
        Console.WriteLine();
        DisplayEnd();


    }



}