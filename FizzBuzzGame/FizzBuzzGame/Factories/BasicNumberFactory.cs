using Microsoft.VisualBasic;

namespace FizzBuzzGame;

public class BasicNumberFactory: INumberFactory
{
    public int DivisableBy => 1;

    public string GetFizzBuzzValue(int input)
    {
        return $"{input}";
    }
}
