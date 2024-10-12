//Doing this so we can edit the file.
using System.IO;
using System.IO.Enumeration;
class Journal {
    //Getting the data types we want in the journal.    
    // public Entry entry = new();
    public List<Entry> _entries = new();
        public string _username;



    //Now making the writing and saving part of the Journal

    public void Journal_write(){
        //we have to get the file name from the user
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        if (Path.GetExtension(fileName).ToLower() != ".csv"){

            Console.WriteLine("You need to enter the file in as a csv in order to recordy our journal entry");

        } 
        else { 
            string username = _username;
            //now we are writing to the file the content of the entries
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                //so we know what the data below it represnets
                outputFile.WriteLine("Date,Prompt,Respone,Author");
            foreach (Entry entry in _entries)
            {
                outputFile.Write(entry.getEntryToCsv());
                if(String.IsNullOrEmpty(username)) {
                    outputFile.WriteLine("N/A");
                }
                else {
                    outputFile.WriteLine(_username);
                }
            }
        }


        }

    }
    //fun cvs reading so we can load the journal back for the user.
    public void Journal_read() {
         Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        //skipping the first line since we are saving it as a csv
        for (int i = 1; i < lines.Length; i++)
        {
            //we know it is seperated by commams so it's easy to know what parts we are needing to get
            string[] parts = lines[i].Split(",");

            //just in case someone edited the file, we just don't want to record the data wrong
            if(parts.Length == 4){
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                string username = parts[3];

                Entry new_entry = new();
                new_entry._date = date;
                new_entry._prompt = prompt;
                new_entry._response = response;

                _entries.Add(new_entry);
                _username = username;
            }

        }

    }

    //We are adding a way for the user to put in the author name of the journal so they know it is their journal. Creative part
    public void Author_write(Journal journal_name){
        Console.WriteLine("Who is the author? ");
        string username = Console.ReadLine();
        journal_name._username = username;


    }
    public void Journal_display(){
        for (int i = 0; i < _entries.Count; i++){
            _entries[i].showEntry();
            Console.WriteLine();

        }
        Console.WriteLine($"Author: {_username}\n");

    }
}