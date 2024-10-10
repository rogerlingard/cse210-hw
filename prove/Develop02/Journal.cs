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
        //now we are writing to the file the content of the entries
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //so we know what the data below it represnets
            outputFile.WriteLine("Date,Prompt,Respone");
           foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry.getEntryToCsv());
        }


        }

    }
    public void Journal_read() {
         Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        //skipping the first line since we are saving it as a csv
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");

            if(parts.Length == 3){
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry new_entry = new();
                new_entry._date = date;
                new_entry._prompt = prompt;
                new_entry._response = response;

                _entries.Add(new_entry);
            }

        }

    }
    public void Journal_display(){
        for (int i = 0; i < _entries.Count; i++){
            _entries[i].showEntry();
            Console.WriteLine();

        }

    }
}