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
        var result = _fizzBuzzCalculator.GetFizzBuzzList(1, 10);

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.TypeOf<List<string>>());
    }

    [Test]
    public void FizzBuzzCalculator_ReturnsFizzWhenInputIsDivisibleBy3()
    {
        //Arrange
        var startsAt = 3;
        var increasesBy = 1;

        //Act
        var result = _fizzBuzzCalculator.GetFizzBuzzList(startsAt, increasesBy);

        //Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.SingleOrDefault, Is.EqualTo("Fizz"));
    }

    [Test]
    public void FizzBuzzCalculator_ReturnsBuzzWhenInputIsDivisibleBy5()
    {
        //Arrange
        var startsAt = 5;
        var increasesBy = 1;

        //Act
        var result = _fizzBuzzCalculator.GetFizzBuzzList(startsAt, increasesBy);

        //Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.SingleOrDefault, Is.EqualTo("Buzz"));
    }

        [Test]
    public void FizzBuzzCalculator_ReturnsFizzBuzzWhenInputIsDivisibleBy15()
    {
        //Arrange
        var startsAt = 15;
        var increasesBy = 1;

        //Act
        var result = _fizzBuzzCalculator.GetFizzBuzzList(startsAt, increasesBy);

        //Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.SingleOrDefault, Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void FizzBuzzCalculator_ReturnsIntegerIfNotDivisible()
    {
        //Arrange
        var startsAt = 1;
        var increasesBy = 1;

        //Act
        var result = _fizzBuzzCalculator.GetFizzBuzzList(startsAt, increasesBy);

        //Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.SingleOrDefault, Is.EqualTo("1"));
    }
}