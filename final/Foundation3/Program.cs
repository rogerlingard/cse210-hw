using System;

class Program
{


    static void Main(string[] args)
    {
        Address address1 = new("S 2nd W & 3rd W", "Rexburg", "Idaho", "USA");
        Address address2 = new("E Main St", "Rexburg", "Idaho", "USA");
        Address address3 = new("47 Mill Race Rd", "Rexburg", "Idaho", "USA");
        Lecture lecture = new("Love in the Family","Teaching the Orphans About Family Love", "6/23/2025", "7:30pm", address1, "Zed Alfair", 50);
    }
}