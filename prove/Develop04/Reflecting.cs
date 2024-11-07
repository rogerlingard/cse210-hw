namespace Develop04;
class ReflectingActivity : Activity {

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it it other aspects of your life.")
    { }

    

    public void RefelctingExercise() {
        Console.Clear();
        DisplayStart();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int durationTime = int.Parse(Console.ReadLine()); 
        SetTimer(durationTime);
        
        Console.Clear();
        loaderPart();

        Console.WriteLine("Consider the following prompt:");
        
        



    }

    public void SettingPromptList() {
        
    }



}