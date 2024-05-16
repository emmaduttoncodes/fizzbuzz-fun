namespace FizzBuzzGame.Tests;

public class BuzzFactoryTests
{
    private BuzzFactory _buzzFactory;

    [SetUp]
    public void Setup()
    {
        _buzzFactory = new BuzzFactory();
    }

    [Test]
    public void BuzzFactory_ReturnsBuzzValueWhenInputDivisibleBy5()
    {
        //Arrange 
        var input = 5;

        //Act
        var result = _buzzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void BuzzFactory_ReturnsInputValueWhenInputNotDivisibleBy5()
    {
        //Arrange 
        var input = 2;

        //Act
        var result = _buzzFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("2"));
    }
}
