// See https://aka.ms/new-console-template for more information
using FizzBuzzGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var lower = 1; 
        var upper = 10;
        var fizzBuzzCalculator = new FizzBuzzCalculator();
        var outputList = fizzBuzzCalculator.GetFizzBuzzList(lower, upper);
        outputList.ForEach(output => Console.WriteLine(output));
    }
    
}