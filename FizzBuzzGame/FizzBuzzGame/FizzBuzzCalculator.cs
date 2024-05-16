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
            
            if (matchingFactory == null)
            {
                Console.WriteLine("Error occured: No matching factory");
                outputList.Add($"{input}"); // Making an assumption of some sensible error handling
            }

            outputList.Add(matchingFactory!.GetFizzBuzzValue(input));
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
                        .OrderByDescending(f => f.DivisableBy) // Want to make sure we order by largest divisor first as 15 can go into 3, 5, and 15, but we want it to print FizzBuzz
                        .ToList();

        return factories;
    }
}