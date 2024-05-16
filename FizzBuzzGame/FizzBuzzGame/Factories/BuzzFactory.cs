namespace FizzBuzzGame;

public class BuzzFactory : INumberFactory
{
    public int DivisableBy => 5;

    public string GetFizzBuzzValue(int input)
    {
        return (input % 5 == 0)? "Buzz": $"{input}";
    }
}