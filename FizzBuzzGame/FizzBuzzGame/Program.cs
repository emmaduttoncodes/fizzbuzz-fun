using FizzBuzzGame;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~~~~Welcome to FIZZBUZZ~~~~~~~~~");

        var startsAt = 1; 
        var increasesBy = 100;
        var fizzBuzzCalculator = new FizzBuzzCalculator();
        var outputList = fizzBuzzCalculator.GetFizzBuzzList(startsAt, increasesBy);
        outputList.ForEach(output => Console.WriteLine(output));
    }
}