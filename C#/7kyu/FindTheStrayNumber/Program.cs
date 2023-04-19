// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Stray Number MEMEMEMEME xD");

void ShowValues(Dictionary<int,int> dictionary)
{
    foreach(var kvp in dictionary)
    {
        Console.WriteLine($"Key: {kvp.Key} | Value: {kvp.Value}");
    }
}

int Stray(int[] numbers)
{
    int strayInt=0;
    Dictionary<int, int> numberCount = new Dictionary<int,int>();
    for(int i=0; i<numbers.Length; i++)
    {
        if(!numberCount.ContainsKey(numbers[i]))
        {
            numberCount.Add(numbers[i], 1);
        }
        else
        {
            numberCount[numbers[i]]+=1;
        }
    }
    foreach(var kvp in numberCount)
    {
        if(kvp.Value==1)
        {
            strayInt = kvp.Key;
        }
    }
    ShowValues(numberCount);
    Console.WriteLine($"Stray int was: {strayInt}");
    return strayInt;
}

Stray(new int[]{1,1,3});