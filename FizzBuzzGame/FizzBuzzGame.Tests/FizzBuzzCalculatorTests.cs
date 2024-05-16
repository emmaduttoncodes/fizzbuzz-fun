namespace FizzBuzzGame.Tests;

public class FizzBuzzCalculatorTests
{
     private FizzBuzzCalculator _fizzBuzzCalculator = null!;

    [SetUp]
    public void Setup()
    {
        _fizzBuzzCalculator = new FizzBuzzCalculator();
    }

    [Test]
    public void FizzBuzzCalculator_ReturnsListOfStrings()
    {
        var result = _fizzBuzzCalculator.GetFizzBuzzList();

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.TypeOf<List<string>>());
    }
}