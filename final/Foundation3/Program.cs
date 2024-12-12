using System;

class Program
{


    static void Main(string[] args)
    {
        Address address1 = new("S 2nd W & 3rd W", "Rexburg", "Idaho", "USA");
        Address address2 = new("E Main St", "Rexburg", "Idaho", "USA");
        Address address3 = new("47 Mill Race Rd", "Rexburg", "Idaho", "USA");
        Lecture lecture = new("Love in the Family","Teaching the Orphans About Family Love", "6/23/2025", "7:30pm", address1, "Zed Alfair", 50);

        Outdoor outdoor = new("Baby Race", "We are going to race the newborns, see who wins.", "2/10/2025", "7:00 am", address2, "Partially Cloudy");

        Reception reception = new("Marrige of Noel and Leon", "We are going to be giving these two lovely people so many gifts", "4/1/2025", "12:00 pm", address3, "Leon123@gmail.com");

        string receptionFullDetails = reception.fullDetails();
        string receptionShortDetails = reception.shortDecription();
        string receptionGetDetails = reception.standardDetails();

        string lectureFull = lecture.fullDetails();
        string lectureShort = lecture.shortDecription();
        string lectureStandard = lecture.standardDetails();

        string outdoorFull = outdoor.fullDetails();
        string outdoorShort = outdoor.shortDecription();
        string outdoorStandard = outdoor.standardDetails();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionFullDetails);
        Console.WriteLine();
        Console.WriteLine(receptionGetDetails);
        Console.WriteLine();
        Console.WriteLine(receptionShortDetails);

        Console.WriteLine();
        Console.WriteLine("Lecutre Event");
        Console.WriteLine(lectureFull);
        Console.WriteLine();
        Console.WriteLine(lectureStandard);
        Console.WriteLine();
        Console.WriteLine(lectureShort);
        
        Console.WriteLine();
        Console.WriteLine("Outdoor Event");
        Console.WriteLine(outdoorFull);
        Console.WriteLine();
        Console.WriteLine(outdoorStandard);
        Console.WriteLine();
        Console.WriteLine(outdoorShort);

    }
}