using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Sandbox World!");
        Costume nurse = new();
        nurse.headWare = "Face mask";
        nurse.gloves = "nitrile gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "Scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWare = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "Slacks";
        detective.accessory = "magnifying glass";

        Costume cowboy = new();
        cowboy.headWare = "cowboy hat";
        cowboy.gloves = "work";
        cowboy.shoes = "cowboy boots";
        cowboy.upperGarment = "fancy vest";
        cowboy.lowerGarment = "jeans";
        cowboy.accessory = "lasso";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        cowboy.ShowWardrobe();

    }
}