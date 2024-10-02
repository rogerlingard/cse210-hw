class Job{
    public string _company;

    public string _jobTitle;

    public int startYear;

    public int endYear;

    public void DisplayJobDetails()
    {
        string result = "";
        result += _jobTitle +" "+ _company + " "+ startYear + '-' + endYear;

        
        Console.WriteLine(result + "\n");


    }

}