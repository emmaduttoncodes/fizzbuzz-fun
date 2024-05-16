namespace FizzBuzzGame.Tests;

public class FizzBuzzFactoryTests
{
     private FizzBuzzFactory _fizzBuzzFactory;

    [SetUp]
    public void Setup()
    {
        _fizzBuzzFactory = new FizzBuzzFactory();
    }

    [Test]
    public void FizzBuzzFactory_ReturnsFizzBuzzValueWhenInputDivisibleBy15()
    {
        //Arrange 
        var input = 30;

        //Act
        var result = _fizzBuzzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void FizzBuzzFactory_ReturnsInputValueWhenInputNotDivisibleBy15()
    {
        //Arrange 
        var input = 2;

        //Act
        var result = _fizzBuzzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("2"));
    }

}
