namespace Develop04;
class ReflectingActivity : Activity {

    private List<string> _questions = new() {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    private List<string> _availableQuestions;

    public ReflectingActivity() : base("Reflecting\n", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it it other aspects of your life.\n")
    { }
    public void RefelctingExercise() {
        Console.Clear();
        int durationTime = DisplayStart();
        
        
        SetTimer(durationTime);
        int elapsed = 0;

        List<string> availableQuestions = new(GetQuestions());

        SetAvaliableQuestions(availableQuestions);

        int pauseTime = 4;
        

        Console.WriteLine("Consider the following prompt: \n");
        SettingPromptList();
        List<string> prompt = GetPromptString();
        string randomPrompt = GetRandomPrompt(prompt);

        Console.WriteLine($"--- {randomPrompt} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");

        ConsoleKeyInfo key = Console.ReadKey();
        if(key.Key == ConsoleKey.Enter) {
            Console.WriteLine("\nNow ponder on each of the following questions as they are related to this experince.");
            Console.Write("You may begin in: ");
            CountDown(5);

            Console.Clear();
            DateTime startTime = DateTime.Now;
            while(elapsed < GetTimer()){

                string question = GetRandomQuestion();
                Console.Write($"{question} ");

                elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
                
                if (elapsed >= GetTimer()) break;
                
                DateTime questionStartTime = DateTime.Now;
                while ((DateTime.Now - questionStartTime).TotalSeconds < pauseTime){
                    loaderPart(0.001);

                    elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
                    if (elapsed >= GetTimer()){ 
                        break;
                    }
                }
                Console.WriteLine();

                
                elapsed = (int)(DateTime.Now - startTime).TotalSeconds;

                if (elapsed >= GetTimer()) break;
            }
            displayEnd();


        }



        
        



    }

    public void SettingPromptList() {
        List<string> prompts = new()
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        SetPromptString(prompts);
    }
    


    public List<string> GetQuestions(){
        return _questions;
    }


    public void SetAvaliableQuestions(List<string> question){
        _availableQuestions = question;
    }
    public List<string> GetAvailableQuestions(){
        return _availableQuestions;

    }
    public string GetRandomQuestion(){

        Random random = new();

        if(GetAvailableQuestions().Count == 0){
            SetAvaliableQuestions(GetQuestions());
        }
        int index = random.Next(GetAvailableQuestions().Count);
        string selectedQuestion = GetAvailableQuestions()[index];

        GetAvailableQuestions().RemoveAt(index);

        return selectedQuestion;       

    }


}