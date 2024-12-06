using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new("8835 E Quill Street", "Mesa", "Arizona", "USA");
        Customer roger = new("Roger Lingard", addressOne);
        
        Product taterTots = new("P001", 5.3, 4, "Tater Tots");
        Product hairGel = new("G213", 4.2, 2, "Sticky Up Hair");
        Product slugBug = new("GB2003", 1432.68, 1, "Space-Warp Slug Bug");

        List<Product> productList = new();
        productList.Add(taterTots);
        productList.Add(hairGel);
        productList.Add(slugBug);

        Order orderOne = new(productList, roger);

        string orderOneShippingLable = orderOne.shippingLable();
        string orderOnePackingLable = orderOne.packingLable();
        double orderOneCost = orderOne.totalOrderCost();
        Console.WriteLine(orderOnePackingLable);
        Console.WriteLine();
        Console.WriteLine(orderOneShippingLable);
        Console.WriteLine();
        Console.WriteLine($"Order Total (including shipping): {orderOneCost}");

        Address addressTwo = new("6393 NW Marine Dr", "Vancouver", "British Columbia", "Canada");
        Customer ryan = new("Ryan North Lion", addressTwo);

        Product playingCards = new("P034", 1.2, 3, "Deluxe Playing Cards");
        Product computer = new("C002", 2830.34, 1, "Gaming PC");
        Product peloton = new("P123", 1232.29, 2, "Peloton Bike");

        List<Product> productListTwo = new();
        productListTwo.Add(playingCards);
        productListTwo.Add(computer);
        productListTwo.Add(peloton);

        Order orderTwo = new(productListTwo, ryan);

        string orderTwoPackingLable = orderTwo.packingLable();
        string orderTwoShippingLable = orderTwo.shippingLable();
        double totalOrderTwoCost = orderTwo.totalOrderCost();
        Console.WriteLine();
        Console.WriteLine(orderTwoPackingLable);
        Console.WriteLine();
        Console.WriteLine(orderTwoShippingLable);
        Console.WriteLine();
        Console.WriteLine($"Order Total (including shipping): {totalOrderTwoCost}");
    }
}