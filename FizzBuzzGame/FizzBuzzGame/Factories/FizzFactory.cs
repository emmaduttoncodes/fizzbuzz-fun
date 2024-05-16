namespace FizzBuzzGame;

public class FizzFactory : INumberFactory
{
    public int DivisableBy => 3;

    public string GetFizzBuzzValue(int input)
    {
        return (input % 5 == 0)? "Buzz": $"{input}";
    }
}
