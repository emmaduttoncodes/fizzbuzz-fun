namespace FizzBuzzGame;

public class FizzPrinter : INumberFactory
{
    public int DivisableBy => 3;

    public string GetFizzBuzzValue(int input)
    {
        return "Fizz";
    }
}
