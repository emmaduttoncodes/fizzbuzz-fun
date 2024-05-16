namespace FizzBuzzGame;

public class FizzBuzzFactory : INumberFactory
{
    public int DivisableBy => 15;

    public string GetFizzBuzzValue(int input)
    {
        return (input % 15 == 0)? "FizzBuzz": $"{input}";
    }
}
