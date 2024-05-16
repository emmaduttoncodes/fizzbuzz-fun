namespace FizzBuzzGame;

public class FizzBuzzCalculator : IFizzBuzzCalculator
{

    public List<string> GetFizzBuzzList(int startsAt, int increasesBy)
    {
        List<string> outputList = [];
        var inputRange = Enumerable.Range(startsAt, increasesBy).ToList<int>();

        var factories = GetAllFactories();
        
        foreach(int input in inputRange)
        {
            var matchingFactory = factories.FirstOrDefault(factory => input % factory.DivisableBy == 0);
            
            // TODO: Remove null supression when we handle it
            outputList.Add(matchingFactory!.GetFizzBuzzValue());
        }

        return outputList;
  
    }


    //Use reflection to get all factories with interface of INumberFactory 
    private static List<INumberFactory> GetAllFactories()
    {
        var numberFactoryInterface = typeof(INumberFactory);

        var factories = AppDomain.CurrentDomain.GetAssemblies()
                         .SelectMany(x => x.GetTypes())
                         .Where(x => numberFactoryInterface.IsAssignableFrom(x) && !x.IsInterface)
                         .Select(Activator.CreateInstance)
                         .Cast<INumberFactory>()
                         .ToList();

        return factories;
    }
}