namespace FizzBuzzGame;

public interface INumberFactory
{
    public int DivisableBy { get; }
    string GetFizzBuzzValue(int input);
}
