class BreathingActivity : Activity {
    private int _breathingTimer;

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }
    public void SetBreathingTimer(int timer){
        _breathingTimer = timer;       

    }
    public int GetBreathingTimer() {
        return _breathingTimer;
    }
    public void BreathingExersise() {
        Console.Clear();
        DisplayStart();
        Console.WriteLine("How long, in seconds, would you like to do this for? ");
        
        int durationTime = int.Parse(Console.ReadLine());

        SetTimer(durationTime);

        int elapsed = 0;
        int breathingIn = 4;
        int breathingOut = 4;

        Console.Clear();
        Console.WriteLine("Get ready...");
        loaderPart();
        
        while (elapsed < GetTimer())
        {
            Console.Write("Breathe in... ");
            CountDown(breathingIn);
            elapsed += breathingIn;
            Console.WriteLine();


            if (elapsed >= durationTime) break;
        
            Console.Write("Breath out... ");
            CountDown(breathingOut);
            elapsed += breathingOut;
            Console.WriteLine();
        }

        displayEnd();

    }

    public void CountDown(int seconds) {
        for (int i = seconds; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }

}