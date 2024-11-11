class Activity {
    private List<String> _promptString; 
    private int _durationTime; 

    private string _name;

    private string _description;


    public void SetTimer(int timer) {
        _durationTime = timer;
    }

    public int GetTimer(){
        return _durationTime;
    }

    public Activity(string ActivityName, string DescriptionName){
        _name = ActivityName;
        _description = DescriptionName;
    }

    public string GetName(){
        return _name;
    }

    public List<string> GetPromptString(){
        return _promptString;
    }   

    public void SetPromptString(List<string> listOfString){
        _promptString = listOfString;
    }

    public string GetRandomPrompt(List<string> prompt){
        Random random = new Random();
        int index = random.Next(GetPromptString().Count);
        return GetPromptString()[index];

    }
    public string GetDescription(){
        return _description;
    }

    public virtual int DisplayStart(){
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine(_description);

        Console.WriteLine("\nHow long, in seconds, would you like to do this for? ");

        int durationTime = int.Parse(Console.ReadLine()); 

        Console.Clear();
        Console.WriteLine("Get ready...");
        LoaderPart(5);

        return durationTime;

    }


    public void DisplayEnd(){
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_durationTime} seconds of the {_name} Activity");
        LoaderPart(5);
        Console.Clear();

    }

    public void LoaderPart(double seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("°");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write(".");
            Console.Write("\b \b");
        }

    }

    public void CountDown(int seconds) {
    for (int i = seconds; i > 0; i--){
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }

}