namespace FizzBuzzGame;

public class BuzzFactory : INumberFactory
{
    public int DivisableBy => 5;

    public string GetFizzBuzzValue()
    {
        return "Buzz";
    }
}