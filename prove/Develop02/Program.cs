using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int user_input = 0;
        Journal personal_journal = new();
        while (user_input != 6)
        {
            //menu things
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Write Author");
            Console.WriteLine("6. Quit ");
            Console.Write("What would you like to do? ");
            user_input = int.Parse(Console.ReadLine());


            if (user_input == 1){
                //Creating the new classes so we can use them
                Entry journal_entry = new();


                Prompt prompt_generated = new();
                prompt_generated.GeneratePrompt();
                prompt_generated.ShowPrompt();

                Console.Write("> ");

                //getting the input and seeing it if had " so that we don't save it and don't have to deal with it causing issues in csv
                string userString = Console.ReadLine();
                if (userString.Contains("\"") || userString.Contains(",")){
                    Console.WriteLine("Your input contains invalid characters (quotation marks and commas), which might cause issues.");
                }
                else {
                    //This is for the date getting the current date
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    journal_entry._date = dateText;

                    journal_entry._response = userString;
                    
                    journal_entry._prompt = prompt_generated.GeneratePrompt();

                    personal_journal._entries.Add(journal_entry);
                }
                

            }
            else if (user_input == 2){
                personal_journal.JournalDisplay();


            }
            else if (user_input == 3){
                personal_journal.JournalRead();

            }
            else if (user_input == 4){
                // delete instace of journal
                // create new instance
                personal_journal.JournalWrite();

            }
            else if (user_input == 5){
                //We are doing this for the extra credit and just makingi it a way to know who owns the journal. Might be fun to make a password system.
                personal_journal.AuthorWrite(personal_journal);

            }
        }
    }
}