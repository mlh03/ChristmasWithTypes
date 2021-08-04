using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
        var k = new Christmas();
        var xmasDay = Christmas.Day.Thursday;
        k.Santa = "Kris Kringle";
        k.Presents =  new string[3]{"xbox", "bike", "shoes"};
        k.TreeHeight = 10;
        Console.WriteLine($"This year christmas falls on {xmasDay} \n");
        Console.WriteLine($"Our tree will be {k.TreeHeight} feet high \n");
        Console.WriteLine("Here are the presents we would like:");
        foreach (var present in k.Presents)
        {
          Console.WriteLine($"    {present}");
        }
         Console.WriteLine($"\n We like to call Santa, {k.Santa}");
        }
    }
}
