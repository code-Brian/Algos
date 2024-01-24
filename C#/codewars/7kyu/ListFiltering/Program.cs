// See https://aka.ms/new-console-template for more information

void ShowValues(List<int> filteredInts)
{
    foreach(var val in filteredInts)
    {
        Console.WriteLine(val);
    }
}

IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
{
    List<int> filteredInts = new List<int>();
    foreach(var val in listOfItems)
    {
        Console.WriteLine($"val is: {val}");
        Console.WriteLine(val.GetType());
        if(val is string)
        {
            Console.WriteLine("It's a string!");
        }
        if(val is int)
        {
            Console.WriteLine("It's an int!");
            filteredInts.Add((int)val);
        }
    }
    ShowValues(filteredInts);
    return filteredInts;
}

List<object> testVals = new List<object>(){1,"Hello", 2, "World"};

GetIntegersFromList(testVals);