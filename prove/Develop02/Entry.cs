class Entry {
    //we have parts of the entry that we are putting in.
    public string _date;
    public string _prompt;
    public string _response;

    //We are going to display the entry
    public void showEntry()
    {
        string result = "";
        result += "Date: " + _date + " - ";
        result += "Prompt: " + _prompt;
        result += "\nResponse: " + _response;
        Console.WriteLine(result);
    }

    //we need a way to save to the entry so we need to save entry to a string
    // we are also formatting it so it can be fit into a csv
    public string getEntryToCsv(){
        //So we are making it so that if the user put quotes into their response then we make it so it doesn't bug out the csv file.
        return $"{_date},\"{_prompt}\",\"{_response}\",";
    }

}