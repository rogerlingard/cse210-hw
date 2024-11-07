using System.ComponentModel.DataAnnotations;
using System.Dynamic;
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

    public List<String> GetPromptString(){
        return _promptString;
    }   

    public void setPromptString(List<String> listOfString){
        _promptString = listOfString;
    }


    public string GetDescription(){
        return _description;
    }

    public void DisplayStart(){
        loaderPart();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);

    }


    public void displayEnd(){
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name}");

    }

    public void loaderPart(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(2);
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


}