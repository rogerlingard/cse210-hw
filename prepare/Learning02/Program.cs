using System;

class Program
{
    static void Main(string[] args)
    {
        Job Microsoft = new();
        Job Apple = new();

        Microsoft._jobTitle = "Software Engineer";
        Microsoft._company = "Microsoft";
        Microsoft.startYear = 2022;
        Microsoft.endYear = 2024;
        
        Apple._jobTitle = "Software Engineer";
        Apple._company = "Apple";
        Apple.startYear = 2024;
        Apple.endYear = 2026;

        Apple.DisplayJobDetails();

        Resume NickRes = new();

        NickRes._name = "lingist";
        NickRes._jobs.Add(Microsoft);
        NickRes._jobs.Add(Apple);

        NickRes.DisplayRes();
    }
}