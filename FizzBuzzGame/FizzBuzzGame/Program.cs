// See https://aka.ms/new-console-template for more information
using FizzBuzzGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var fizzBuzzCalculator = new FizzBuzzCalculator();
        var outputList = fizzBuzzCalculator.GetFizzBuzzList();
        outputList.ForEach(output => Console.WriteLine(output));
    }
    
}