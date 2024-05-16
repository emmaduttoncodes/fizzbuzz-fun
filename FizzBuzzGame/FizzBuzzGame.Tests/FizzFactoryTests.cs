namespace FizzBuzzGame.Tests;

public class FizzFactoryTests
{
    private FizzFactory _fizzFactory;

    [SetUp]
    public void Setup()
    {
        _fizzFactory = new FizzFactory();
    }

    [Test]
    public void FizzFactory_ReturnsFizzValueWhenInputDivisibleBy3()
    {
        //Arrange 
        var input = 3;

        //Act
        var result = _fizzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [Test]
    public void FizzFactory_ReturnsInputValueWhenInputNotDivisibleBy3()
    {
        //Arrange 
        var input = 2;

        //Act
        var result = _fizzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("2"));
    }
}
