namespace FizzBuzzGame.Tests;

public class BasicNumberFactoryTests
{
    private BasicNumberFactory _basicNumberFactory;

    [SetUp]
    public void Setup()
    {
        _basicNumberFactory = new BasicNumberFactory();
    }

    [Test]
    public void BasicNumberFactory_ReturnsStringValueForInput()
    {
        //Arrange 
        var input = 6;

        //Act
        var result = _basicNumberFactory.GetFizzBuzzValue(input);

        //Assert
        Assert.That(result, Is.EqualTo("6"));
    }
}
